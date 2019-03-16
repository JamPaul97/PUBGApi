using System;
using System.Collections.Generic;

namespace PUBGApi.Models
{
    public class Seasons
    {
        public List<Season> data = new List<Season>();
        public Links links = null;

        public class Links
        {
            public string self = string.Empty;
        }

        public class Season
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public Attributes attribues= null;
        }
        public class Attributes
        {
            public bool isCurrentSeason = false;
            public bool isOffseason = false;
        }
    }
}
