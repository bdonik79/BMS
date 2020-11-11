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
    public class DataController : ApiController
    {
        public ApiResponse Get(string Code, string ContentType)
        {
            DataAccess dal = new DataAccess();
            List<Data> userList = dal.getdata(Code, ContentType);
            ApiResponse aresponse = new ApiResponse();

            if (userList.Count > 0)
            {
                aresponse.status = "success";
                aresponse.message = "got data";
                aresponse.type = ContentType;
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
