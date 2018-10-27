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
using WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace WebApplication.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {

        private readonly IMessageDbContext _messageDataContext;
        private readonly IChatbotAPIService _chatbotAPIService;
        private readonly SignInManager<IdentityUser> _signInManager;
        public MessageController(IChatbotAPIService chatbotAPIService, IMessageDbContext messageDataContext, SignInManager<IdentityUser> signInManager)
        {
            _chatbotAPIService = chatbotAPIService;
            _messageDataContext = messageDataContext;
            _signInManager = signInManager;
        }
        [HttpPost, Route("reply")]
        public IActionResult GetReply(string message)
        {
            var newMessage = new Message()
            {
                User = _signInManager.Context.User?.Identity.Name,
                Text = message,
                Sent = DateTime.Now
            };
            _messageDataContext.SaveMessage(newMessage);
            var reply = _chatbotAPIService.GetReplyAsync(newMessage.Text).Result;
            return Json(new { Reply = reply });

        }
        [Authorize]
        [HttpGet, Route("user/{user}")]
        public IActionResult GetMessagesByUser(string user)
        {
            var messages = _messageDataContext.GetMessageByUser(user);
            return Ok(messages);
        }
        [Authorize]
        [HttpGet, Route("")]
        public IActionResult GetAllMessages()
        {
            var messages = _messageDataContext.GetAllMessages();
            return Ok(messages);
        }


    }
}