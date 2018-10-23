using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.DataAccess
{
    public class ReminderDataContext : DbContext
    {
        public DbSet<Reminder> Reminders { get; set; }
        public ReminderDataContext(DbContextOptions<ReminderDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
    }
}
