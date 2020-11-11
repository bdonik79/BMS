using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datacontext
{
    public class category
    {
        public string Name { get; set; }

        public string Code { get; set; }
        
        public string ContentType { get; set; }

        public string Sort { get; set; }
    }

    public class data
    {
        public string ContentID { get; set; }

        public string image { get; set; }

        public string title { get; set; }

        public string ContentType { get; set; }

        public string PlayUrl { get; set; }
    }

    public class album
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

    public class artist
    {
        public string ContentID { get; set; }

        public string image { get; set; }

        public string title { get; set; }

        public string ContentType { get; set; }

        public string PlayUrl { get; set; }

        public string artistname { get; set; }

        public string duration { get; set; }

        public string copyright { get; set; }

        public string labelname { get; set; }

        public string releaseDate { get; set; }
    }

    public class playlist
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
