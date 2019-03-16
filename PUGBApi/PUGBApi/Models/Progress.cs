using System;
using System.Collections.Generic;

namespace PUBGApi.Models
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
