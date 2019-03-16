using System;
using System.Collections.Generic;

namespace PUBGApi.Models
{
    public class Lifetime
    {
        public Data data;
        public List<localPlayerData> included;
        public Links links;
        public dynamic meta;
        public class Data
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public Attributes attributes = null;
            public Relationships relationships = null;
        }
        public class Attributes
        {
            public string shardId = string.Empty;
            public string gameMode = string.Empty;
        }
        public class pr
        {
            public List<localPlayerData> data = new List<localPlayerData>();
        }
        public class Relationships
        {
            public pr players = null;
        }
        public class localPlayerData
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public playerAttributes attributes = null;
        }
        public class playerAttributes
        {
            public string name = string.Empty;
            public int rank = 0;
            public stat stats = null;
        }
        public class stat
        {
            public int rankPoints = 0;
            public int wins = 0;
            public int games = 0;
            public float winRatio = 0f;
            public int averageDamage = 0;
            public int kills = 0;
            public float killDeathRation = 0f;
            public float averageRank = 0f;
        }
        public class Links
        {
            public string self = string.Empty;
        }
    }

}
