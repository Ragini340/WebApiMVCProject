using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiMVCProject.Models;

namespace WebApiMVCProject.Controllers
{
    public class UserController : ApiController
    {
        List<User> userList = new List<User>();
        public UserController()
        {
            userList.Add(new User { UserId = 1, Name = "Ragini", Address = "Buxar" });
            userList.Add(new User { UserId = 2, Name = "Ragini Singh", Address = "Bangalore" });
        }

        //api/user
        public IHttpActionResult GetUsers()
        {
            return Ok(userList);
        }

        //api/user/1

        public IHttpActionResult GetUser(int id)
        {
            User user = userList.Find(u => u.UserId == id);
            return Ok(user);
        }
    }
}
