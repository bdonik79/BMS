using Music_Streaming.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music_Streaming.Models
{
    public class Combine
    {
        
        public Search Artist { get; set; }
        
        public Search Album { get; set; }

        public Search Track { get; set; }

        public Search Video { get; set; }

    }
}