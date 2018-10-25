
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication.Models;

    namespace WebApplication.DataAccess.Interfaces
    {
        public interface IMessageDbContext
        {
            IList<Message> GetAllMessages();
            IList<Message> GetMessageByUser(string user);
            void SaveMessage(Message message);
        }
    }

