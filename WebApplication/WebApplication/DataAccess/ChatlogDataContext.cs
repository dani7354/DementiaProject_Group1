using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.DataAccess.Interfaces;
using WebApplication.Models;

namespace WebApplication.DataAccess
{
    public class MessageDataContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public MessageDataContext(DbContextOptions<MessageDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public async void SaveMessage(Message message)
        {
            Messages.Add(message);
            await SaveChangesAsync();
        }
    }
}
