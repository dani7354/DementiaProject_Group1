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
    public class QnAMakerAPIService : IChatbotAPIService
    {
        public QnAMakerAPIService(IOptions<QnAAPIServiceOptions> options)
        {
            Options = options;
        }

        private class Metadata
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        private class Answer
        {
            public IList<string> questions { get; set; }
            public string answer { get; set; }
            public double score { get; set; }
            public int id { get; set; }
            public string source { get; set; }
            public IList<object> keywords { get; set; }
            public IList<Metadata> metadata { get; set; }
        }
        private class QnAAnswer
        {
            public IList<Answer> answers { get; set; }
        }

        public IOptions<QnAAPIServiceOptions> Options { get; }

        public async Task<string> GetReplyAsync(string message)
        {
            string uri = Options.Value.Hostname + "/qnamaker/knowledgebases/" + Options.Value.KnowledgeBaseId + "/generateAnswer";
            string questionJSON = @"{'question': '" + message + "'}";

            var response = await Post(uri, questionJSON);

            var answers = JsonConvert.DeserializeObject<QnAAnswer>(response);
            if (answers.answers.Count > 0)
            {
                Random rnd = new Random();
                var answerMessage= answers.answers.ElementAt(0).answer;
                if(answerMessage == null)
                {
                    return answers.answers[0].questions[0];
                }
                else
                {
                    return answerMessage;
                }
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
