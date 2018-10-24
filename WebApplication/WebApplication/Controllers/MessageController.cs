using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Google.Apis.Dialogflow.v2;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {
        public MessageController()
        {
           
        }
        public class Metadata
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Answer
        {
            public IList<string> questions { get; set; }
            public string answer { get; set; }
            public double score { get; set; }
            public int id { get; set; }
            public string source { get; set; }
            public IList<object> keywords { get; set; }
            public IList<Metadata> metadata { get; set; }
        }
        public class QnAAnswer
        {   
            public IList<Answer> answers { get; set; }
        }

        [HttpPost, Route("reply")]
        public async Task<IActionResult> GetReplyAsync(string message)
        {

            string uri = "https://chatbotgroup1qna.azurewebsites.net/" + "/qnamaker/knowledgebases/" + "5b0943a9-3c83-4c7b-8826-408bf91b6c26" + "/generateAnswer";
            string questionJSON = @"{'question': '" + message + "'}";

            var response = await Post(uri, questionJSON);

            var answers = JsonConvert.DeserializeObject<QnAAnswer>(response);
            if (answers.answers.Count > 0)
            {
                Random rnd = new Random();
                
                return Json(new { Reply = answers.answers.ElementAt(rnd.Next(0, answers.answers.Count-1)).answer });
            }
            else
            {
                return Json(new { Reply = "Sorry, I did not understand" }); ;
            }
        }
        async Task<string> Post(string uri, string body)
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(uri);
                request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                request.Headers.Add("Authorization", "EndpointKey " + "d994b54e-cd11-4472-884b-088f34e59d4e");

                var response = await client.SendAsync(request);
                return await response.Content.ReadAsStringAsync();
            }
        }

    }
}