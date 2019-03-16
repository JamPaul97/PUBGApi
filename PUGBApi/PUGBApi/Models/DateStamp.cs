using System;

namespace PUBGApi.Models
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
