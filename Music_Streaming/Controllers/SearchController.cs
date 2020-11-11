using DAL;
using Music_Streaming.DataContext;
using Music_Streaming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Music_Streaming.Controllers
{
    public class SearchController : ApiController
    {

        public ApiResponse_search Get(string Keyword)
        {
            DataAccess dal = new DataAccess();

            List<Data> Album_search = dal.getsearch(Keyword, "R");
            List<Data> Artist_search = dal.getsearch(Keyword, "A");
            List<Data> Song_search = dal.getsearch(Keyword, "S");
            List<Data> Video_search = dal.getsearch(Keyword, "V");

            Combine combineresponse = new Combine();
            
            Search albumresponse = new Search();
            Search artistresponse = new Search();
            Search songstresponse = new Search();
            Search videoresponse = new Search();
            
            
            ApiResponse_search searchresponse = new ApiResponse_search();

            if (Album_search.Count > 0)
            {
                albumresponse.status = "success";
                albumresponse.message = "got data";
                albumresponse.type = "R";
                albumresponse.data = Album_search;
            }
            else
            {
                albumresponse.status = "failed";
                albumresponse.message = "no data";
                albumresponse.type = "R";
                albumresponse.data = Album_search;
            }

            if (Artist_search.Count > 0)
            {
                artistresponse.status = "success";
                artistresponse.message = "got data";
                artistresponse.type = "A";
                artistresponse.data = Artist_search;
            }
            else
            {
                artistresponse.status = "failed";
                artistresponse.message = "no data";
                artistresponse.type = "A";
                artistresponse.data = Artist_search;
            }

            if (Song_search.Count > 0)
            {
                songstresponse.status = "success";
                songstresponse.message = "got data";
                songstresponse.type = "S";
                songstresponse.data = Song_search;
            }
            else
            {
                songstresponse.status = "failed";
                songstresponse.message = "no data";
                songstresponse.type = "S";
                songstresponse.data = Song_search;
            }

            if (Video_search.Count > 0)
            {
                videoresponse.status = "success";
                videoresponse.message = "got data";
                videoresponse.type = "V";
                videoresponse.data = Video_search;
            }
            else
            {
                videoresponse.status = "failed";
                videoresponse.message = "no data";
                videoresponse.type = "V";
                videoresponse.data = Video_search;
            }

            {
                combineresponse.Artist = artistresponse;
                combineresponse.Album = albumresponse;
                combineresponse.Track = songstresponse;
                combineresponse.Video = videoresponse;
            }


            if (Artist_search.Count > 0 || Album_search.Count > 0 || Song_search.Count > 0 || Video_search.Count > 0)
            {
                searchresponse.status = "success";
                searchresponse.message = "got data";
                searchresponse.data = combineresponse;
            }

            else 
            {
                searchresponse.status = "failed";
                searchresponse.message = "no data";
                searchresponse.data = combineresponse;
            }
            
            {
                return searchresponse;

            }
        }
    }
    
}
