using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music_Streaming.Models
{
    public class Playlist
    {
        public string ContentID { get; set; }

        public string image { get; set; }

        public string title { get; set; }

        public string ContentType { get; set; }

        public string PlayUrl { get; set; }

        public string artist { get; set; }

        public string duration { get; set; }

        public string copyright { get; set; }

        public string labelname { get; set; }

        public string releaseDate { get; set; }
    }
}