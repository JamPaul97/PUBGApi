using System;
using System.Collections.Generic;

namespace PUBGApi.Models
{
    public class Tournaments
    {
        public List<Tournament> data = new List<Tournament>();
        public Links links = null;
        public dynamic meta = null;
        public class Tournament
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public Attributes attributes;
        }
        public class Attributes
        {
            public string createdAt = string.Empty;
        }
        public class Links
        {
            public string self = string.Empty;
        }
    }
    
}
