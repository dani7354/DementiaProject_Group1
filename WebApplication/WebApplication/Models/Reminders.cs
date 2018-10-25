using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Reminders
    {
        public int ReminderId { get; set; }
        public string ReminderMessage { get; set; }
        public DateTime ReminderTime { get; set; }
    }
}
