using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGApi.Tempates
{
    public class Match
    {
        public Data data;
        public List<Data> included;
        public dynamic links = null;
        public dynamic meta = null;
        public class Data {
            public string type = string.Empty;
            public string id = string.Empty;
            public Attributes attributes;
            public Relationships relationships;
            
            public Links links;
        }
        public class Relationships
        {
            public datum rosters = null;
            public datum assets = null;
        }
        public class datum
        {
            public List<Data> data;
        }
        public class Attributes
        {
            public string createdAt = string.Empty;
            public string shardId = string.Empty;
            public bool isCustomMatch = false;
            public int duration = 0;
            public dynamic stats = null;
            public string gameMode = string.Empty;
            public string titleId = string.Empty;
            public dynamic tags = null;
            public string mapName = string.Empty;
            public string seasonState = string.Empty;
            public string URL = string.Empty;
        }
        public class Links
        {
            public string self = string.Empty;
            public string schema = string.Empty;
        }
    }
}
