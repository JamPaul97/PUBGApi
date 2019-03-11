using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGApi.Tempates
{
    [Serializable]
    public class DateStamp
    {
        public int Year = 0;
        public int Month = 0;
        public int Day = 0;
        public int Hour = 0;
        public int Minute = 0;
        public int Second = 0;
        public int Miliseconds = 0;
        public string TimeStamp = string.Empty;
    }
}
