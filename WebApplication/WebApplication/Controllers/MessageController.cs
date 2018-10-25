using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Web;
using Newtonsoft.Json;
using WebApplication.DataAccess.Interfaces;
using WebApplication.DataAccess;

namespace WebApplication.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {
        public MessageController(IChatbotAPIService chatbotAPIService, MessageDataContext logService)
        {
            _chatbotAPIService = chatbotAPIService;
            _logService = logService;
        }
        private IChatbotAPIService _chatbotAPIService;
        private MessageDataContext _logService;

        [HttpPost, Route("reply")]
        public IActionResult GetReply(string message)
        {
             _logService.SaveMessage(message);
            var reply = _chatbotAPIService.GetReplyAsync(message).Result;
            return Json(new { Reply = reply });
        }
    }
}