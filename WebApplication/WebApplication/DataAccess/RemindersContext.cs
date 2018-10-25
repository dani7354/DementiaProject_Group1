using System;
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

        public RemindersContext(DbContextOptions<RemindersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Reminders> Reminders { get; set; }

      

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
