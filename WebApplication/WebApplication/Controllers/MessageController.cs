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
using WebApplication.Models;
using WebApplication.DataAccess;

namespace WebApplication.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {
        public MessageController(IChatbotAPIService chatbotAPIService, IMessageDbContext messageDataContext)
        {
            _chatbotAPIService = chatbotAPIService;
            _messageDataContext = messageDataContext;
        }
        private readonly IChatbotAPIService _chatbotAPIService;
        private readonly IMessageDbContext _messageDataContext;

        [HttpPost, Route("reply")]
        public IActionResult GetReply(string message)
        {
            var newMessage = new Message()
            {
                User = "Chatuser", 
                Text = message,
                Sent = DateTime.Now
            };
             _messageDataContext.SaveMessage(newMessage);
            var reply = _chatbotAPIService.GetReplyAsync(newMessage.Text).Result;
            return Json(new { Reply = reply });
        }

        [HttpGet, Route("user/{user}")]
        public IActionResult GetMessagesByUser(string user)
        {
            var messages = _messageDataContext.GetMessageByUser(user);
            return Ok(messages);
        }
        [HttpGet, Route("")]
        public IActionResult GetAllMessages()
        {
            var messages = _messageDataContext.GetAllMessages();
            return Ok(messages);
        }
    }
}