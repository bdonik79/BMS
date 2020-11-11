using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
//using Datacontext;
using Music_Streaming.DataContext;
using Music_Streaming.Models;
namespace Music_Streaming.Controllers
{
    public class VideoCategoryController : ApiController
    {
        public ApiResponse Get()
        {
            DataAccess dal = new DataAccess();
            List<Category> userList = dal.getvideocategory();
            ApiResponse aresponse = new ApiResponse();

            if (userList.Count > 0)
            {
                aresponse.status = "success";
                aresponse.message = "got data";
                aresponse.type = "C";
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
