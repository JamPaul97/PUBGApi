using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGApi.Tempates
{
    /// <summary>
    /// Progress class event
    /// </summary>
    public class Progress
    {
        /// <summary>
        /// Maximum progress
        /// </summary>
        public int Maximum = 0;
        /// <summary>
        /// Current progress value
        /// </summary>
        public int Value = 0;
        /// <summary>
        /// Progress message
        /// </summary>
        public string Message = string.Empty;
    }
}
