using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication.Models;

namespace WebApplication.DataAccess
{
    public partial class RemindersContext : DbContext
    {
        public RemindersContext()
        {
        }

        public RemindersContext(DbContextOptions<RemindersContext> options, ReminderManipulator reminderManipulator): base(options)
        {
            ReminderManipulator = reminderManipulator;
        }

        public ReminderManipulator ReminderManipulator { get; set; }
        public virtual DbSet<Reminders> Reminders { get; set; }
    
        //manipulate and send the message to the DB
        public string ReminderHandler(string message)
        {
            string reply = ReminderManipulator.SetReminder(message);

            Reminders reminder = new Reminders();

            reminder.ReminderMessage = ReminderManipulator.GetMessage();

            reminder.ReminderTime = ReminderManipulator.ConvertTimeToDateTime();

            Reminders.Add(reminder);

            SaveChanges();

            return reply;
        }

        public string GetReminderCount()
        {
            string tempResult = Reminders.Count().ToString();

            string result = "";
            if (tempResult == "0")
            {
                result = "You have no reminders";
            }
            else
            {
                result = "You currently have " + tempResult + " coming up";
            }

            return result;
        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reminders>(entity =>
            {
                entity.HasKey(e => e.ReminderId);

                entity.Property(e => e.ReminderId).HasColumnName("reminderID");

                entity.Property(e => e.ReminderMessage)
                    .IsRequired()
                    .HasColumnName("reminderMessage");

                entity.Property(e => e.ReminderTime)
                    .HasColumnName("reminderTime")
                    .HasColumnType("datetime");
            });
        }
    }
}
