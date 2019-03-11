using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUGBApi.Tempates
{
    public class Players
    {
        public List<Player> data;
        public Links link;
        public Meta meta;
        public class Player
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public attribute attributes;
            public relationship relationships;
            public Links links;

        }
        public class SimpleMatch
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public attribute attributes;
            public relationship relationships;
            public Links links;
        }
        public class SimpleAsset
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public attribute attributes;
            public relationship relationships;
            public Links links;

        }
        public class attribute
        {
            public string createdAt = string.Empty;
            public string updatedAt = string.Empty;
            public string patchVersion = string.Empty;
            public string name = string.Empty;
            public string stats = string.Empty;
            public string titleId = string.Empty;
            public string shardId = string.Empty;
        }
        public class relationship
        {
            public match matches;
            public asset assets;
            public class match
            {
                public List<SimpleMatch> data;
            }
        }
        public class asset
        {
            public List<SimpleAsset> data;
        }
        public class Links
        {
            public string self = string.Empty;
            public string schema = string.Empty;
        }
        public class Meta
        {

        }
    }
}
