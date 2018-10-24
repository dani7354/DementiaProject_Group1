using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DataAccess.Interfaces;

namespace WebApplication.DataAccess
{
    public class QnAAPIService : IChatbotAPIService
    {
        public QnAAPIService(IOptions<QnAAPIServiceOptions> options)
        {
            Options = options;
        }

        private class Metadata
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private class Answer
        {
            public IList<string> Questions { get; set; }
            public string AnswerMessage { get; set; }
            public double Score { get; set; }
            public int Id { get; set; }
            public string Source { get; set; }
            public IList<object> Keywords { get; set; }
            public IList<Metadata> Metadata { get; set; }
        }
        private class QnAAnswer
        {
            public IList<Answer> Answers { get; set; }
        }

        public IOptions<QnAAPIServiceOptions> Options { get; }

        public async Task<string> GetReplyAsync(string message)
        {
            string uri = Options.Value.Hostname + "/qnamaker/knowledgebases/" + Options.Value.KnowledgeBaseId + "/generateAnswer";
            string questionJSON = @"{'question': '" + message + "'}";

            var response = await Post(uri, questionJSON);

            var answers = JsonConvert.DeserializeObject<QnAAnswer>(response);
            if (answers.Answers.Count > 0)
            {
                Random rnd = new Random();
                return answers.Answers.ElementAt(rnd.Next(0, answers.Answers.Count - 1)).AnswerMessage;
            }
            else
            {
                return "Sorry, I did not understand";
            }

        }
        private async Task<string> Post(string uri, string body)
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(uri);
                request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                request.Headers.Add("Authorization", "EndpointKey " + Options.Value.EndpointKey);

                var response = await client.SendAsync(request);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
