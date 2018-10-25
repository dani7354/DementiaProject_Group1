using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication.DataAccess
{
    public class RepliesTableDataContext : DbContext
    {
        public RepliesTableDataContext()
        {

        }

        public string GetReply(string message)
        {
            string reply = "";
            Database.EnsureCreated();
            Database.ExecuteSqlCommand("spSelectTheRightResponse");

            


            return reply;
        }

    }
}
