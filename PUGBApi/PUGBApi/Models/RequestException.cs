using System;
using System.Collections.Generic;

namespace PUBGApi.Models
{
    class RequestException : Exception
    {

        public RequestException()
        : base() { }
            public RequestException(string name)
                : base(String.Format("API Exception thrown: {0}", name))
            {

            }
    }
}