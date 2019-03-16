using System;
using Newtonsoft.Json;

namespace PUBGApi.Models
{
    public class Stats
    {
        public Data data;
        public Players.Links links;
        public dynamic meta = null;

        public class Data
        {
            public string type = string.Empty;
            public Attributes attributes = null;
            public Relationships relationships = null;
        }
        public class Attributes
        {
            public GameModeStats gameModeStats = null;
        }
        public class Relationships
        {
            public Players.SimpleMatch matchesDuoFPP = null;
            public Players.SimpleMatch matchesSquad = null;
            public Players.SimpleMatch matchesSquadFPP = null;
            public Players.SimpleMatch matchesSolo = null;
            public Players.SimpleMatch matchesSoloFPP = null;
            public Players.SimpleMatch matchesDuo = null;
            public localSeason season = null;
            public localPlayer player = null;

        }
        public class GameModeStats
        {
            public stat duo= null;
            [JsonProperty(PropertyName = "duo-fpp")]
            public stat duo_fpp = null;
            public stat solo = null;
            [JsonProperty(PropertyName = "solo-fpp")]
            public stat solo_fpp = null;
            public stat squad = null;
            [JsonProperty(PropertyName = "squad-fpp")]
            public stat squad_fpp = null;
        }
        public class stat
        {
            public int assists = 0;
            public float bestRankPoint = 0f;
            public int boosts = 0;
            public int dBNOs = 0;
            public int dailyKills = 0;
            public int dailyWins = 0;
            public float damageDealt = 0f;
            public int days = 0;
            public int headshotKills = 0;
            public int heals = 0;
            public int killPoints = 0;
            public int kills = 0;
            public float longestKill = 0f;
            public float longestTimeSurvived = 0f;
            public int losses = 0;
            public int maxkillStreaks = 0;
            public float mostSurvivalTime = 0f;
            public float rankPoints = 0f;
            public string rankPointsTitle = string.Empty;
            public int revives = 0;
            public float rideDistance = 0f;
            public int roadKills = 0;
            public int roundMostKills = 0;
            public int roundsPlayed = 0;
            public int suicides = 0;
            public float swimDistance = 0f;
            public int teamKills = 0;
            public float timeSurvived = 0f;
            public int top10s = 0;
            public int vehicleDestroys = 0;
            public float walkDistance = 0f;
            public int weaponsAcquired = 0;
            public int weeklyKills = 0;
            public int winPoints = 0;
            public int wins = 0;
        }
        public class localSeason
        {
            public Seasons.Season data = null;
        }
        public class localPlayer
        {
            public Players.Player player;
        }
    }
}
