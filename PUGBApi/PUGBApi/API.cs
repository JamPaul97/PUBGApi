using System;
using System.IO;
using System.Net;
using PUBGApi.Tempates;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace PUBGApi
{
    public class Connector
    {
        public enum Shards
        {
            steam,psn,kakao,tournament,xbox
        }
        public enum Regions
        {
            @as,eu,jp,kakao,krjp,na,oc,ru,sa,sea,tournament
        }
        public enum Gamemode
        {
            solo, solo_fpp,duo, duo_fpp,squad, squad_fpp
        }
        private string apiKey = string.Empty;
        private Shards shard;
        private Regions region;
        private string Shard;
        private bool hasEvents = false;
        /// <summary>
        /// Connector Constructor
        /// </summary>
        /// <param name="apiKey">the api key used to make authorized calls</param>
        /// <param name="shard">the shard used to make calls</param>
        /// <param name="region">the region used to make calls</param>
        public Connector(string apiKey, Shards shard, Regions region)
        {
            this.apiKey = apiKey;
            this.shard = shard;
            this.region = region;
            this.Shard = this.shard + "-" + this.region;
        }
        /// <summary>
        /// Connector Constructor
        /// </summary>
        /// <param name="apiKey">the api key used to make authorized calls</param>
        /// <param name="shard">the shard used to make calls</param>
        /// <param name="region">the region used to make calls</param>
        /// <param name="withEvents">Have events raised</param>
        public Connector(string apiKey, Shards shard, Regions region, bool withEvents)
        {
            this.apiKey = apiKey;
            this.shard = shard;
            this.region = region;
            this.hasEvents = withEvents;
            this.Shard = this.shard + "-" + this.region;
        }

        /// <summary>
        /// Retun a list of players searced by their name
        /// </summary>
        /// <param name="name">Player name to search for</param>
        /// <returns>List Players</returns>
        public Players GetPlayersByName(string name)
        {
            changeProgress(0, 2, "Generating URL");
            string url = "https://api.pubg.com/shards/" + this.shard.ToString() + "/players?filter[playerNames]=" + name;
            changeProgress(1, 2, "Making Request to API");
            Players pr;
            try
            {
                pr = JsonConvert.DeserializeObject<Players>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                throw new Exception(ex.Message);
            }
            changeProgress(2, 2, "Done");
            return pr;
        }
        /// <summary>
        /// Retun a list of players searced by their accoutID
        /// </summary>
        /// <param name="name">Player accoutID to search for</param>
        /// <returns>List Players</returns>
        public Players GetPlayerByAccountID(string accountID)
        {
            changeProgress(0, 2, "Generating URL");
            string url = "https://api.pubg.com/shards/" + this.Shard + "/players?filter[playerIds]=" + accountID;
            changeProgress(1, 2, "Making request to API");
            Players pr = new Players();
            try
            {
                pr = JsonConvert.DeserializeObject<Players>(request(url));
            }
            catch (WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(2, 2, "Done");
            return pr;
        }
        /// <summary>
        /// Get a list of recent matches played by player provided
        /// </summary>
        /// <param id="string">Player object to get matches</param>
        /// <returns>List Matches</returns>
        public List<Match> GetMatchesByPlayer(Players.Player player)
        {
            changeProgress(0, player.relationships.matches.data.Count+1, "Making list");
            List<Match> matches = new List<Match>();
            for(int i =0; i <= player.relationships.matches.data.Count-1;i++)
            {
                try
                {
                    matches.Add(JsonConvert.DeserializeObject<Match>(request(string.Format("https://api.pubg.com/shards/{0}/matches/{1}", this.shard, player.relationships.matches.data[i].id))));
                }
                catch(WebException ex)
                {
                    changeProgress(player.relationships.matches.data.Count, player.relationships.matches.data.Count, "Error");
                    handleRequextException(ex);
                }
                
                changeProgress(i+1, player.relationships.matches.data.Count, "Player added");
            }
            changeProgress(player.relationships.matches.data.Count, player.relationships.matches.data.Count, "Done");
            return (matches);
        }
        /// <summary>
        /// Get a match from its id
        /// </summary>
        /// <param name="id">The match id</param>
        /// <returns>Match</returns>
        public Match GetMatchById(string id)
        {
            changeProgress(0, 2, "Generating URL");
            string url = (string.Format("https://api.pubg.com/shards/{0}/matches/{1}", this.shard, id));
            Match temp = new Match();
            try
            {
                changeProgress(2, 2, "Making request to API");
                temp = JsonConvert.DeserializeObject<Match>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(2, 2, "Done");
            return temp;
        }
        /// <summary>
        /// Get telemetry object from match
        /// </summary>
        /// <param name="match">Match to get telemetry from</param>
        /// <returns>Telemetry</returns>
        public Telemetry GetTelemetry(Match match)
        {
            changeProgress(0, 2, "Making URL");
            string url = GetTelemetryUrlFromMatch(match);
            dynamic WholeObject = null;
            try
            {
                changeProgress(1, 2, "Making request to API");
                WholeObject = JsonConvert.DeserializeObject<dynamic>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(0, WholeObject.Count+1, "Making telemetry object");
            Telemetry Object = new Telemetry();
            int counter = 1;
            foreach (dynamic temp in WholeObject)
            {
                changeProgress(counter, WholeObject.Count+1, "Error");
                string type = temp.@_T;
                try
                {
                    switch (type)
                    {
                        case "LogMatchDefinition":
                            Object.Definition = GetMatchDefinition(temp);
                            break;
                        case "LogMatchStart":
                            Object.Start = GetMatchStart(temp);
                            break;
                        case "LogItemEquip":
                            Object.ItemsEquiped.Add(GetItemEquiped(temp));
                            break;
                        case "LogPlayerCreate":
                            Object.PlayersCreated.Add(GetPlayerCreate(temp));
                            break;
                        case "LogPlayerPosition":
                            Object.PlayersPossitions.Add(GetPlayerPossition(temp));
                            break;
                        case "LogVaultStart":
                            Object.VaultsStart.Add(GetValueStart(temp));
                            break;
                        case "LogPlayerAttack":
                            Object.PlayersAttacks.Add(GetPlayerAttack(temp));
                            break;
                        case "LogItemUnequip":
                            Object.ItemsUnequiped.Add(GetItemUnequip(temp));
                            break;
                        case "LogPlayerLogout":
                            Object.PlayersLogouts.Add(GetPlayerLogout(temp));
                            break;
                        case "LogPlayerLogin":
                            Object.PlayerLogins.Add(GetPlayerLogin(temp));
                            break;
                        case "LogWeaponFireCount":
                            Object.WeaponFireCounts.Add(GetWeaponFireCount(temp));
                            break;
                        case "LogVehicleRide":
                            Object.VehicleRides.Add(GetVehicleRide(temp));
                            break;
                        case "LogItemPickup":
                            Object.ItemsPickups.Add(GetItemPickup(temp));
                            break;
                        case "LogGameStatePeriodic":
                            Object.GamestatePeriodic.Add(GetGameState(temp));
                            break;
                        case "LogVehicleLeave":
                            Object.VehicleLeaves.Add(GetVehicleLeave(temp));
                            break;
                        case "LogParachuteLanding":
                            Object.ParachuteLandings.Add(GetParachuteLanding(temp));
                            break;
                        case "LogItemAttach":
                            Object.ItemsAttach.Add(GetItemAttach(temp));
                            break;
                        case "LogItemDrop":
                            Object.ItemsDrop.Add(GetItemDrop(temp));
                            break;
                        case "LogObjectDestroy":
                            Object.ObjectsDestroy.Add(GetObjectDestroy(temp));
                            break;
                        case "LogItemDetach":
                            Object.ItemsDetach.Add(GetItemDetach(temp));
                            break;
                        case "LogPlayerTakeDamage":
                            Object.PlayersTakeDamage.Add(GetPlayerTakeDamage(temp));
                            break;
                        case "LogPlayerMakeGroggy":
                            Object.PlayersMakeGroggy.Add(GetPlayerMakeGroggy(temp));
                            break;
                        case "LogPlayerKill":
                            Object.PlayersKill.Add(GetPlayerKill(temp));
                            break;
                        case "LogItemPickupFromLootBox":
                            Object.ItemPickupFromLootbox.Add(GetItemPickupFromLootBox(temp));
                            break;
                        case "LogItemUse":
                            Object.ItemsUse.Add(GetItemUse(temp));
                            break;
                        case "LogHeal":
                            Object.Heals.Add(GetHeal(temp));
                            break;
                        case "LogArmorDestroy":
                            Object.ArmorsDestoy.Add(GetArmorDestroy(temp));
                            break;
                        case "LogPlayerRevive":
                            Object.PlayersRevives.Add(GetPlayerRevive(temp));
                            break;
                        case "LogCarePackageSpawn":
                            Object.CarePackageSpawns.Add(GetCarePackageSpawn(temp));
                            break;
                        case "LogSwimStart":
                            Object.SwimStarts.Add(GetSwimStart(temp));
                            break;
                        case "LogSwimEnd":
                            Object.SwimEnds.Add(GetSwimEnd(temp));
                            break;
                        case "LogCarePackageLand":
                            Object.CarePackageLands.Add(GetCarePackageLand(temp));
                            break;
                        case "LogRedZoneEnded":
                            Object.redZoneEndeds.Add(GetRedZoneEnded(temp));
                            break;
                        case "LogWheelDestroy":
                            Object.WheelsDestoy.Add(GetWheelDestroy(temp));
                            break;
                        case "LogMatchEnd":
                            Object.End = (GetEnd(temp));
                            break;
                    }
                }
                catch
                {
                    changeProgress(WholeObject.Count+1, WholeObject.Count+1, "Error");
                    throw new RequestException("There was an error desirializing the telemetry json");
                }
                counter++;
            }
            changeProgress(WholeObject.Count+1, WholeObject.Count+1, "Done");
            return (Object);
        }
        /// <summary>
        /// Get Season details
        /// </summary>
        /// <returns>Seasons</returns>
        public Seasons GetSeasons()
        {
            changeProgress(1, 2, "Genarating URL");
            string url = "https://api.pubg.com/shards/" + this.shard +"/seasons";
            Seasons result = new Seasons();
            try
            {
                changeProgress(1, 2, "Making request to API");
                result = JsonConvert.DeserializeObject<Seasons>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(2, 2, "Done");
            return (result);
        }
        /// <summary>
        /// Get the season stats of a player
        /// </summary>
        /// <param name="player">Player to get stats</param>
        /// <param name="season">Season to get stats</param>
        /// <returns>Stats</returns>
        public Stats GetPlayerSeasonStats(Players.Player player, Seasons.Season season)
        {
            changeProgress(0, 2, "Generating URL");
            string url = string.Format("https://api.pubg.com/shards/{0}/players/{1}/seasons/{2}", this.shard , player.id, season.id);
            Stats result = new Stats();
            try
            {
                changeProgress(1, 2, "Making request to API");
                result = JsonConvert.DeserializeObject<Stats>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(2, 2, "Done");
            return (result);
        }
        /// <summary>
        /// Get lifetime stats of a players
        /// </summary>
        /// <param name="player">Players to get lifetime stats</param>
        /// <returns>Stats</returns>
        public Stats GetPlayerLefetimeStats(Players.Player player)
        {
            changeProgress(0, 2, "Generating URL");
            string url = string.Format("https://api.pubg.com/shards/{0}/players/{1}/seasons/lifetime", this.shard, player.id);
            Stats result = new Stats();
            try
            {
                changeProgress(1, 2, "Making request to API");
                result = JsonConvert.DeserializeObject<Stats>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(2, 2, "Done");
            return (result);
        }
        /// <summary>
        /// Get leaderboard lifetime stats from a gamemode
        /// </summary>
        /// <param name="gm">Gamemode to get lifetime stats</param>
        /// <returns>Lifetime</returns>
        public Lifetime GetLifetimeStats(Gamemode gm)
        {

            string gamemode = string.Empty;
            changeProgress(0, 3, "Selecting gamemode");
            switch (gm)
            {
                case Gamemode.solo:
                    gamemode = "solo";
                    break;
                case Gamemode.duo:
                    gamemode = "duo";
                    break;
                case Gamemode.squad:
                    gamemode = "squad";
                    break;
                case Gamemode.solo_fpp:
                    gamemode = "solo-fpp";
                    break;
                case Gamemode.duo_fpp:
                    gamemode = "duo-fpp";
                    break;
                case Gamemode.squad_fpp:
                    gamemode = "squad-fpp";
                    break;
                default:
                    gamemode = "solo";
                    break;
            }
            changeProgress(1, 3, "Generating URL");
            string url = "https://api.pubg.com/shards/" + this.shard + "/leaderboards/" + gamemode;
            Lifetime result = new Lifetime();
            try
            {
                changeProgress(2, 3, "Making request to API");
                result = JsonConvert.DeserializeObject<Lifetime>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(3, 3, "Error");
                handleRequextException(ex);
            }
            changeProgress(3, 3, "Done");
            return (result);
        }
        /// <summary>
        /// Get all tournaments
        /// </summary>
        /// <returns>Tournamets</returns>
        public Tournaments GetTournaments()
        {
            changeProgress(0, 2, "Generating URL");
            string url = "https://api.pubg.com/tournaments";
            Tournaments result = new Tournaments();
            try
            {
                changeProgress(1, 2, "Making request to API");
                result = JsonConvert.DeserializeObject<Tournaments>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(2, 2, "Done");
            return (result);
        }
        /// <summary>
        /// Get details of a tournament
        /// </summary>
        /// <param name="tournament">Tournament to get details from</param>
        /// <returns>Tournament</returns>
        public Tournament GetTournamentDetails(Tournaments.Tournament tournament)
        {
            changeProgress(0, 2, "Generating URL");
            string url = "https://api.pubg.com/tournaments/" + tournament.id;
            Tournament result = new Tournament();
            try
            {
                changeProgress(1, 2, "Making request to API");
                result = JsonConvert.DeserializeObject<Tournament>(request(url));
            }
            catch(WebException ex)
            {
                changeProgress(2, 2, "Error");
                handleRequextException(ex);
            }
            changeProgress(2, 2, "Done");
            return (result);
        }
        /// <summary>
        /// Return a status object with the current api status
        /// </summary>
        /// <returns>Status</returns>
        public Status GetStatus()
        {
            changeProgress(0, 3, "Collecting information about the request");
            string Response = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.pubg.com/status");
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.Headers.Add("Authorization", "Bearer " + this.apiKey);
            request.Accept = "application/vnd.api+json";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Status result = new Status();
            try
            {
                changeProgress(1, 3, "Making request to API");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    changeProgress(2, 3, "Got response from API");
                    Response = reader.ReadToEnd();
                }
                sw.Stop();
                result.active = true;
            }
            catch
            {
                changeProgress(3, 3, "Error");
                result.active = false;
            }
            changeProgress(3, 3, "Response OK");
            result.responseTime = sw.ElapsedMilliseconds;
            return (result);
        }


        #region "Events"
        public delegate void ProgressChangeDLG(Progress progress);
        /// <summary>
        /// Event raised on progress change
        /// </summary>
        public event ProgressChangeDLG ProgressChange;
        public void OnProgressChange(Progress progress)
        {
            ProgressChangeDLG handler = ProgressChange;
            if (handler != null)
            {
                handler(progress);
            }
        }

        #endregion


        #region "Private Functions"
        private string GetTelemetryUrlFromMatch(Match match)
        {
            foreach (Match.Data data in match.data.relationships.assets.data)
            {
                foreach (dynamic obj in match.included)
                {
                    if (data.id == obj.id)
                    {

                        return (obj.attributes.URL);
                    }
                }
            }
            return (string.Empty);
        }
        private string request(string url)
        {
            string Response = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.Headers.Add("Authorization", "Bearer " + this.apiKey);
            request.Accept = "application/vnd.api+json";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                Response = reader.ReadToEnd();
            }

            return (Response);
        }
        private void changeProgress(int current, int max, string message)
        {
            if (hasEvents)
            {
                Progress pr = new Progress();
                pr.Maximum = max;
                pr.Value = current;
                pr.Message = message;
                OnProgressChange(pr);
            }
        }
        private void handleRequextException(WebException ex)
        {

        }
        #endregion



        #region "Telemetry Constructors"
        private TelemetryBases.MatchDefinition GetMatchDefinition(dynamic obj)
        {
            TelemetryBases.MatchDefinition temp = new TelemetryBases.MatchDefinition();
            temp.MatchId = obj.MatchId;
            temp.PingQuality = obj.PingQuality;
            temp.SeasonState = obj.SeasonState;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.MatchStart GetMatchStart(dynamic obj)
        {
            TelemetryBases.MatchStart temp = new TelemetryBases.MatchStart();
            temp.mapName = obj.mapName;
            temp.weatherId = obj.weatherId;
            foreach(dynamic x in obj.characters)
            {
                temp.characters.Add(GetCharacter(x));
            }
            temp.cameraViewBehaviour = obj.cameraViewBehaviour;
            temp.teamSize = obj.teamSize;
            temp.isCustomGame = obj.isCustomGame;
            temp.isEventMode = obj.isEventMode;
            temp.blueZoneCustomOptions = obj.blueZoneCustomOptions;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.ItemEquip GetItemEquiped(dynamic obj)
        {
            TelemetryBases.ItemEquip temp = new TelemetryBases.ItemEquip();
            temp.character = GetCharacter(obj.character);
            temp.item = GetItem(obj.item);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.PlayerCreate GetPlayerCreate(dynamic obj)
        {
            TelemetryBases.PlayerCreate temp = new TelemetryBases.PlayerCreate();
            temp.character = GetCharacter(obj.character);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.PlayerPosittion GetPlayerPossition(dynamic obj)
        {
            TelemetryBases.PlayerPosittion temp = new TelemetryBases.PlayerPosittion();
            temp.character = GetCharacter(obj.character);
            temp.numAlivePlayers = obj.numAlivePlayers;
            temp.vehicle = GetVehicle(obj.vehicle);
            temp.elapsedTime = obj.elapsedTime;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.VaultStart GetValueStart(dynamic obj)
        {
            TelemetryBases.VaultStart temp = new TelemetryBases.VaultStart();
            temp.character = GetCharacter(obj.character);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.PlayerAttack GetPlayerAttack(dynamic obj)
        {
            TelemetryBases.PlayerAttack temp = new TelemetryBases.PlayerAttack();
            temp.attacker = GetCharacter(obj.attacker);
            temp.attackId = obj.attackId;
            temp.attackType = obj.attackType;
            temp.fireWeaponStackCount = obj.fireWeaponStackCount;
            temp.TimeStack = MakeTimeStamp(obj.@_D);
            temp.vehicle = GetVehicle(obj.vehicle);
            temp.weapon = GetItem(obj.weapon);
            return (temp);
        }
        private TelemetryBases.ItemUnequip GetItemUnequip(dynamic obj)
        {
            TelemetryBases.ItemUnequip temp = new TelemetryBases.ItemUnequip();
            temp.character = GetCharacter(obj.character);
            temp.item = GetItem(obj.item);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.PlayerLogout GetPlayerLogout(dynamic obj)
        {
            TelemetryBases.PlayerLogout temp = new TelemetryBases.PlayerLogout();
            temp.accountId = obj.accountId;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.WeaponFireCount GetWeaponFireCount(dynamic obj)
        {
            TelemetryBases.WeaponFireCount temp = new TelemetryBases.WeaponFireCount();
            temp.character = GetCharacter(obj.character);
            temp.fireCount = obj.fireCount;
            temp.weaponId = obj.weaponId;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.VehicleRide GetVehicleRide(dynamic obj)
        {
            TelemetryBases.VehicleRide temp = new TelemetryBases.VehicleRide();
            temp.character = GetCharacter(obj.character);
            temp.seatIndex = obj.seatIndex;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            temp.vehicle = GetVehicle(obj.vehicle);
            return (temp);
        }
        private TelemetryBases.ItemPickup GetItemPickup(dynamic obj)
        {
            TelemetryBases.ItemPickup temp = new TelemetryBases.ItemPickup();
            temp.character = GetCharacter(obj.character);
            temp.item = GetItem(obj.item);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.GameStatePeriod GetGameState(dynamic obj)
        {
            TelemetryBases.GameStatePeriod temp = new TelemetryBases.GameStatePeriod();
            temp.gameState = GetGamestate(obj.gameState);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.Gamestate GetGamestate(dynamic obj)
        {
            TelemetryBases.Gamestate temp = new TelemetryBases.Gamestate();
            temp.elapsedTime = obj.elapsedTime;
            temp.numAlivePlayers = obj.numAlivePlayers;
            temp.numAliveTeams = obj.numAliveTeams;
            temp.numJoinPlayers = obj.numJoinPlayers;
            temp.numStartPlayers = obj.numStartPlayers;
            temp.poisonGasWarningPosition = GetLocation(obj.poisonGasWarningPostion);
            temp.poisonGasWarningRadius = obj.poisonGasWarningRadius;
            temp.redZonePosition = GetLocation(obj.redZonePosition);
            temp.redZoneRadius = obj.redZoneRadius;
            temp.safetyZonePosition = GetLocation(obj.safetyZonePosition);
            temp.safetyZoneRadius = obj.safetyZoneRadius;
            return (temp);
        }
        private TelemetryBases.VehicleLeave GetVehicleLeave(dynamic obj)
        {
            TelemetryBases.VehicleLeave temp = new TelemetryBases.VehicleLeave();
            temp.character = GetCharacter(obj.character);
            temp.maxSpeed = obj.maxSpeed;
            temp.rideDistance = obj.rideDistance;
            temp.seatIndex = obj.seatIndex;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            temp.vehicle = GetVehicle(obj.vehicle);
            return (temp);
        }
        private TelemetryBases.ParachuteLanding GetParachuteLanding(dynamic obj)
        {
            TelemetryBases.ParachuteLanding temp = new TelemetryBases.ParachuteLanding();
            temp.character = GetCharacter(obj.character);
            temp.distance = obj.distance;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.ItemAttach GetItemAttach(dynamic obj)
        {
            TelemetryBases.ItemAttach temp = new TelemetryBases.ItemAttach();
            temp.character = GetCharacter(obj.character);
            temp.childItem = GetItem(obj.childItem);
            temp.parrentItem = GetItem(obj.parrentItem);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.ItemDrop GetItemDrop(dynamic obj)
        {
            TelemetryBases.ItemDrop temp = new TelemetryBases.ItemDrop();
            temp.character = GetCharacter(obj.character);
            temp.item = GetItem(obj.item);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.ObjectDestroy GetObjectDestroy(dynamic obj)
        {
            TelemetryBases.ObjectDestroy temp = new TelemetryBases.ObjectDestroy();
            temp.character = GetCharacter(obj.character);
            temp.objectLocation = GetLocation(obj.objectLocation);
            temp.objectType = obj.objectType;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.ItemDetach GetItemDetach(dynamic obj)
        {
            TelemetryBases.ItemDetach temp = new TelemetryBases.ItemDetach();
            temp.character = GetCharacter(obj.character);
            temp.childItem = GetItem(obj.childItem);
            temp.parrentItem = GetItem(obj.parrentItem);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.PlayerTakeDamage GetPlayerTakeDamage(dynamic obj)
        {
            TelemetryBases.PlayerTakeDamage temp = new TelemetryBases.PlayerTakeDamage();
            temp.attacker = GetCharacter(obj.attacker);
            temp.victim = GetCharacter(obj.victim);
            temp.attackId = obj.attackId;
            temp.damage = obj.damage;
            temp.damageCauserName = obj.damagesCauserName;
            temp.damageReason = obj.damageReason;
            temp.damageTypeCategory = obj.damageTypeCategory;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.PlayerMakeGroggy GetPlayerMakeGroggy(dynamic obj)
        {
            TelemetryBases.PlayerMakeGroggy temp = new TelemetryBases.PlayerMakeGroggy();
            temp.attacker = GetCharacter(obj.attacker);
            temp.attackId = obj.attackId;
            foreach(dynamic x in obj.damageCauserAdditionalInfo)
            {
                temp.damageCauserAdditionalInfo.Add(Convert.ToString(x));
            }

            temp.damageCauserName = obj.damageCauserName;
            temp.damageReason = obj.damageReason;
            temp.damageTypeCategory = obj.damageTypeCategory;
            temp.dBNOId = obj.dBNOId;
            temp.distance = obj.distance;
            temp.isAttackerInVehicle = obj.isAttackerInVehicle;
            temp.victim = GetCharacter(obj.victim);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.PlayerKill GetPlayerKill(dynamic obj)
        {
            TelemetryBases.PlayerKill temp = new TelemetryBases.PlayerKill();
            temp.assistant = GetCharacter(obj.assistant);
            temp.attackId = obj.attackId;
            foreach(dynamic x in obj.damageCauserAdditionalInfo)
            {
                temp.damageCauserAdditionalInfo.Add(Convert.ToString(x));
            }
            temp.damageCauserName = obj.damageCauserName;
            temp.damageReason = obj.damageReason;
            temp.damageTypeCategory = obj.damageTypeCategory;
            temp.dBNOId = obj.dBNOId;
            temp.distance = obj.distance;
            temp.killer = GetCharacter(obj.killer);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            temp.victim = GetCharacter(obj.victim);
            temp.victimGameResult = GetVictimResult(obj.victimGameResult);
            return temp;
        }
        private TelemetryBases.ItemPickupFromLootBox GetItemPickupFromLootBox(dynamic obj)
        {
            TelemetryBases.ItemPickupFromLootBox temp = new TelemetryBases.ItemPickupFromLootBox();
            temp.character = GetCharacter(obj.character);
            temp.item = GetItem(obj.item);
            temp.ownerTeamId = obj.ownerTeamId;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return (temp);
        }
        private TelemetryBases.ItemUse GetItemUse(dynamic obj)
        {
            TelemetryBases.ItemUse temp = new TelemetryBases.ItemUse();
            temp.character = GetCharacter(obj.character);
            temp.item = GetItem(obj.item);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return temp;
        }
        private TelemetryBases.Heal GetHeal(dynamic obj)
        {
            TelemetryBases.Heal temp = new TelemetryBases.Heal();
            temp.character = GetCharacter(obj.character);
            temp.healAmount = obj.healAmount;
            temp.item = GetItem(obj.item);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return temp;
        }
        private TelemetryBases.ArmorDestroy GetArmorDestroy(dynamic obj)
        {
            TelemetryBases.ArmorDestroy temp = new TelemetryBases.ArmorDestroy();
            temp.attacker = GetCharacter(obj.attacker);
            temp.attackId = obj.attackId;
            temp.damageReason = obj.damageReason;
            temp.damageTypeCategory = obj.damageTypeCategoryl;
            temp.distance = obj.distance;
            temp.item = GetItem(obj.item);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            temp.victim = GetCharacter(obj.victim);
            return temp;
        }
        private TelemetryBases.PlayerRevive GetPlayerRevive(dynamic obj)
        {
            TelemetryBases.PlayerRevive temp = new TelemetryBases.PlayerRevive();
            temp.dBNOId = obj.dBNOId;
            temp.reviver = GetCharacter(obj.reviver);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            temp.victim = GetCharacter(obj.victim);
            return temp;
        }
        private TelemetryBases.CarePackageSpawn GetCarePackageSpawn(dynamic obj)
        {
            TelemetryBases.CarePackageSpawn temp = new TelemetryBases.CarePackageSpawn();
            temp.itemPackage = GetItemPackage(obj.itemPackage);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return temp;
        }
        private TelemetryBases.SwimStart GetSwimStart(dynamic obj)
        {
            TelemetryBases.SwimStart temp = new TelemetryBases.SwimStart();
            temp.character = GetCharacter(obj.character);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return temp;
        }
        private TelemetryBases.SwimEnd GetSwimEnd(dynamic obj)
        {
            TelemetryBases.SwimEnd temp = new TelemetryBases.SwimEnd();
            temp.character = GetCharacter(obj.character);
            temp.maxSwimDepthOfWater = obj.maxSwimDepthOfWater;
            temp.swimDistance = obj.swimDistance;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return temp;
        }
        private TelemetryBases.CarePackageLand GetCarePackageLand(dynamic obj)
        {
            TelemetryBases.CarePackageLand temp = new TelemetryBases.CarePackageLand();
            temp.itemPackage = GetItemPackage(obj.itemPackage);
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return temp;
        }
        private TelemetryBases.RedZoneEnded GetRedZoneEnded(dynamic obj)
        {
            TelemetryBases.RedZoneEnded temp = new TelemetryBases.RedZoneEnded();
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            foreach (dynamic x in obj.drivers)
            {
                temp.drivers.Add(GetCharacter(x));
            }
            return temp;
        }
        private TelemetryBases.WheelDestroy GetWheelDestroy(dynamic obj)
        {
            TelemetryBases.WheelDestroy temp = new TelemetryBases.WheelDestroy();
            temp.attacker = GetCharacter(obj.attacker);
            temp.attackId = obj.attackId;
            temp.damageCauserName = obj.damageCauserName;
            temp.damageTypeCategory = obj.damageTypeCategory;
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            temp.vehicle = GetVehicle(obj.vehicle);
            return temp;
        }
        private TelemetryBases.MatchEnd GetEnd(dynamic obj)
        {
            TelemetryBases.MatchEnd temp = new TelemetryBases.MatchEnd();
            foreach(dynamic x in obj.characters)
            {
                temp.characters.Add(GetCharacter(x));
            }
            temp.TimeStamp = MakeTimeStamp(obj.@_D);
            return temp;
        }
        private TelemetryBases.PlayerLogin GetPlayerLogin(dynamic obj)
        {
            TelemetryBases.PlayerLogin temp = new TelemetryBases.PlayerLogin();
            temp.accountId = obj.accountId;
            temp.TimeStamp = MakeTimeStamp(obj.@_D); 
            return temp;
        }
        private TelemetryBases.ItemPackage GetItemPackage(dynamic obj)
        {
            TelemetryBases.ItemPackage temp = new TelemetryBases.ItemPackage();
            temp.itemPackageId = obj.itemPackageId;
            foreach (dynamic x in obj.items)
            {
                temp.items.Add(GetItem(x));
            }
            temp.location = GetLocation(obj.location);
            return temp;
        }
        private DateStamp MakeTimeStamp(dynamic obj)
        {
            string str = JsonConvert.SerializeObject(obj);
            str = str.Replace("\"", "");
            str = str.Replace("T", " ");
            str = str.Replace("Z", "");
            str = str.Replace("-", "/");
            DateStamp temp = new DateStamp();
            temp.Year = Convert.ToInt32(DateTime.Parse(str).ToString("yyyy"));
            temp.Month = Convert.ToInt32(DateTime.Parse(str).ToString("MM"));
            temp.Day = Convert.ToInt32(DateTime.Parse(str).ToString("dd"));
            temp.Hour = Convert.ToInt32(DateTime.Parse(str).ToString("HH"));
            temp.Minute = Convert.ToInt32(DateTime.Parse(str).ToString("mm"));
            temp.Second = Convert.ToInt32(DateTime.Parse(str).ToString("ss"));
            temp.Miliseconds = Convert.ToInt32(DateTime.Parse(str).ToString("fffffff"));
            temp.TimeStamp = str;
            return (temp);
        }
        private TelemetryBases.Character GetCharacter(dynamic obj)
        {
            TelemetryBases.Character temp = new TelemetryBases.Character();
            if(obj!= null)
            {
                temp.name = obj.name;
                temp.teamId = obj.teamId;
                temp.health = obj.health;
                temp.location = GetLocation(obj.location);
                temp.ranking = obj.ranking;
                temp.accountId = obj.accountId;
                temp.isInBlueZone = obj.isInBlueZone;
                temp.isInRedZone = obj.isInRedZone;
                temp.zone = null;
            }
            
            return (temp);
        }
        private TelemetryBases.Location GetLocation(dynamic obj)
        {
            TelemetryBases.Location temp = new TelemetryBases.Location();
            if(obj != null) {
                temp.x = obj.x;
                temp.y = obj.y;
                temp.z = obj.z;
            }
            
            return (temp);
        }
        private TelemetryBases.Item GetItem(dynamic obj)
        {
            
            TelemetryBases.Item temp = new TelemetryBases.Item();
            if(obj != null)
            {
                try
                {
                    temp.ItemId = obj.itemId;
                    temp.stackCount = obj.stackCount;
                    temp.category = obj.category;
                    temp.subCategory = obj.subCategory;
                    foreach (dynamic x in obj.attachedItems)
                    {
                        temp.attachedItems.Add(Convert.ToString(x));
                    }
                }
                catch
                {
                    return (temp);
                }
                
            }
            return (temp);
        }
        private TelemetryBases.Vehicle GetVehicle(dynamic obj)
        {
            TelemetryBases.Vehicle temp = new TelemetryBases.Vehicle();
            string a = Convert.ToString(obj);
            if (a != "{}" && a != "" && a != " ")
            {
                try
                {
                    temp.feulPercent = obj.feulPercent;
                    temp.vehicleId = obj.vehicleId;
                    temp.vehicleType = obj.vehicleType;
                    temp.healthPercent = obj.healthPercent;
                }
                catch
                {

                }
            }
            
            return (temp);

        }
        private TelemetryBases.VictimGameResult GetVictimResult(dynamic obj)
        {
            TelemetryBases.VictimGameResult temp = new TelemetryBases.VictimGameResult();
            temp.rank = obj.rank;
            temp.stats = GetStat(obj.stats);
            temp.teamId = obj.teamId;
            temp.accountId = obj.accountId;
            return (temp);
    }
        private TelemetryBases.Stat GetStat(dynamic obj)
        {
            TelemetryBases.Stat temp = new TelemetryBases.Stat();
            temp.distanceOnFoot = obj.distanceOnFoot;
            temp.distanceOnFreefall = obj.distanceOnFreefall;
            temp.distanceOnParachute = obj.distanceOnParachute;
            temp.distanceOnSwim = obj.distanceOnSwim;
            temp.distanceOnVehicle = obj.distanceOnVehicle;
            temp.killCount = obj.killCount;
            return (temp);
        }
        #endregion




    }

}
