﻿using DAL;
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
    public class PlaylistController : ApiController
    {
        public ApiResponse Get(string id)
        {
            DataAccess dal = new DataAccess();
            List<Playlist> userList = dal.getplaylist(id);
            ApiResponse aresponse = new ApiResponse();

            if (userList.Count > 0)
            {
                aresponse.status = "success";
                aresponse.message = "got data";
                aresponse.type = "P";
                aresponse.data = userList;

            }

            else
            {
                aresponse.status = "failed";
                aresponse.message = "no data";
                aresponse.type = "";
                aresponse.data = userList;
            }

            {
                return aresponse;
            }

        }
    }
}
