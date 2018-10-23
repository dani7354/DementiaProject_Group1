using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Reminder
    {
        [Key]
        public long Id { get; set; }
        public string Description { get; set; }
        public IdentityUser User { get; set; }
        public DateTime Time { get; set; }
        public bool ShouldRepeat { get; set; }
    }
}
