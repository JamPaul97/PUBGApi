using System;
using System.Collections.Generic;

namespace PUBGApi.Models
{
    public class Tournament
    {
        public Data data = null;
        public List<localMatch> included = new List<localMatch>();
        public Links links = null;
        public dynamic meta = null;
        public class Data
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public Relationships relationships = null;
        }
        public class Relationships
        {
            public Matches matches = null;
        }
        public class Matches
        {
            public List<localMatch> data = new List<localMatch>();
        }
        public class localMatch
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public Attributes attributes = null;
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
