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
            if(message?.ToLower() == "hi")
            {
                return Json(new { Reply = "Hello" });
            }
            else
            {
                return Json(new { Reply = $"Controller received: {message}" });
            }
            // Here we should have some calls to an API that can reply the message

            // for testing purposes only
            
        }
    }
}