using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.DataAccess.Interfaces;
using WebApplication.Models;

namespace WebApplication.DataAccess
{
    public class MessageDataContext : DbContext, IChatlogService
    {
        public DbSet<Message> Messages { get; set; }
        public MessageDataContext(DbContextOptions<MessageDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public async void SaveMessage(string message)
        {
            var newMessage = new Message()
            {
                Sent = DateTime.Now,
                Text = message,
                User = "Chat user" // for test purposes only
            };
            Messages.Add(newMessage);
            await SaveChangesAsync();
        }
    }
}
