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
        public MessageController(IChatbotAPIService chatbotAPIService, RemindersContext remindersContext)
        {
            ChatbotAPIService = chatbotAPIService;
            RemindersContext = remindersContext;
        }

        string tempReply;

        public IChatbotAPIService ChatbotAPIService { get; }
        public RemindersContext RemindersContext { get; }

        [HttpPost, Route("reply")]
        public IActionResult GetReply(string message)
        {
            
            var reply = ChatbotAPIService.GetReplyAsync(message).Result;


            if (reply == "RemindMessage")
            {
                try
                {
                    tempReply = RemindersContext.ReminderHandler(message);

                    reply = $"I will remind you to {tempReply}";
                }
                catch (Exception e)
                {
                    reply = "Sorry, I could not save the reminder";
                }
            }else if (reply == "RemindCount")
            {
                try
                {
                    reply = RemindersContext.GetReminderCount();
                }
                catch (Exception e)
                {
                    reply = "Sorry, I could not find any reminders";
                }
            }
            return Json(new { Reply = reply });
         
            
        }
       

    }
}