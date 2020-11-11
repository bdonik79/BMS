using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music_Streaming.Models
{
    public class Data
    {
        public string ContentID { get; set; }

        public string image { get; set; }

        public string title { get; set; }

        public string ContentType { get; set; }

        public string PlayUrl { get; set; }

        public string Artist { get; set; }

        public string Duration { get; set; }
    }
}