﻿using System;
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

namespace WebApplication.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {

        private readonly IMessageDbContext _messageDataContext;
        private readonly IChatbotAPIService _chatbotAPIService;
        public MessageController(IChatbotAPIService chatbotAPIService, MessageDataContext messageDataContext)
        {
            _chatbotAPIService = chatbotAPIService;
            _messageDataContext = messageDataContext;
        }
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