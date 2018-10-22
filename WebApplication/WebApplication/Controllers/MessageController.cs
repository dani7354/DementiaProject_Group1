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
           if(message == null) return Json(new { Reply = $"Sorry, I didn't understand." });
            if (message?.ToLower() == "hi")
            {
                return Json(new { Reply = "Hello" });
            }
            if (message.ToLower().Contains("how are you"))
            {
                return Json(new { Reply = "I'm good, thanks!" });
            }
            else
            {
                return Json(new { Reply = $"Sorry, I didn't understand." });
            }
        }
    }
}