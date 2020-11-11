using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music_Streaming.DataContext
{
    public class ApiResponse_search
    {
        public string status { get; set; }

        public string message { get; set; }

        //public string type { get; set; }

        public object data { get; set; }

    }
}