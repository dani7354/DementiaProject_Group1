using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {
        [HttpPost, Route("reply")]
        public IActionResult GetReply(string message)
        {

            return Json(new {Reply = $"Controller received: {message}" });
        }
    }
}