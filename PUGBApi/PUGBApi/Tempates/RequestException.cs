using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGApi.Tempates
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