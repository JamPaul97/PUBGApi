using System;
using PUBGApi;
using PUBGApi.Enumrations;
using PUBGApi.Tempates;

namespace PUBGApi.Tempates
{
    public static class URLs
    {
        public const string domain = "https://api.pubg.com";

        public static string GenerateSearchPlayersByNameUrl(string[] players, Shards shard)
        {
            if (players.Length == 0)
            {
                return(string.Format("{0}/shards/{1}/players?filter[playerNames]=errorplayersnotdified", domain, shard.ToString()));
            }
            else
            {
                Func<string[], string> makePlayers = pr => { string result = string.Empty; foreach (string x in pr) { result += x + ","; } result = result.Remove(result.Length - 1, 1); return result; };
                return(string.Format("{0}/shards/{1}/players?filter[playerNames]={2}", domain, shard.ToString(), makePlayers(players)));
            }
        }
        public static string GenerateSearchPlayersByAccountID(string[] accounts, Shards shard)
        {
            if (accounts.Length == 0)
            {
                return (string.Format("{0}/shards/{1}/players?filter[playerIds]=errorplayersnotdified", domain, shard.ToString()));
            }
            else
            {
                Func<string[], string> makeIDs = pr => { string result = string.Empty; foreach (string x in pr) { result += x + ","; } result = result.Remove(result.Length - 1, 1); return result; };
                return (string.Format("{0}/shards/{1}/players?filter[playerIds]={2}", domain, shard.ToString(), makeIDs(accounts)));
            }
        }
        public static string[] GenerateMatch(Players.Player player, Shards shard)
        {
            string[] urls = new string[player.relationships.matches.data.Count];
            for (int i = 0; i <= player.relationships.matches.data.Count -1; i++)
            {
                urls[i] = string.Format("{0}/shards/{1}/matches/{2}",domain, shard, player.relationships.matches.data[i].id);
            }
            return (urls);
        }
        public static string GenerateMatchByID(string MatchID,Shards shard)
        {
            return ((string.Format("{0}/shards/{1}/matches/{2}",domain, shard, MatchID)));
        }
        public static string GenerateTelemetryUrlFromMatch(Match match)
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
        public static string GenerateSeasons(Shards shard)
        {
            return (string.Format("{0}/shards/{1}/seasons", domain, shard));
        }
        public static string GeneratePlayerSeasonStats(Players.Player player,Seasons.Season season,Shards shard)
        {
            return(string.Format("{0}/shards/{1}/players/{2}/seasons/{3}",domain, shard, player.id, season.id));
        }
        public static string GeneratePlayerLifetimeStats(Players.Player player,Shards shard)
        {
            return (string.Format("{0}/shards/{1}/players/{2}/seasons/lifetime",domain, shard, player.id));
        }
        public static string GenerateLifetimeStats(Gamemode Gamemode, Shards shard)
        {
            string gamemode = string.Empty;
            switch (Gamemode)
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
            return (string.Format("{0}/shards/{1}/leaderboards/{2}", domain, shard, gamemode));
        }
        public static string GenerateTournaments()
        {
            return (domain + "/tournaments");
        }
        public static string GenerateTournamentDetails(Tournaments.Tournament tournament)
        {
            return (string.Format("{0}/tournaments/{1}", domain, tournament.id));
        }
        public static string GenerateStatus()
        {
            return (string.Format("{0}/status", domain));
        }
        public static string GenerateDomain()
        {
            return (domain.Replace("http://", ""));
        }

    }
}
