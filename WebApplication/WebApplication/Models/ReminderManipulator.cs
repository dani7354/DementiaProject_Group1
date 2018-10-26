using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ReminderManipulator
    {
        Regex regex = new Regex(@"\d+");
        Regex regex2 = new Regex(@"\d");

        string[] meridianArray = { "p.m.", "a.m.", "tonight", "tomorrow", "later" };
        //At currently gets removed, it would be nice if it did not.
        string[] remindArray = { "remind", "me", "to", "at", "can", "beemo", "beemo,"};
        string[] pronounArray = { "I", "me", "my" };

        //This property saves the time
        private string timeSaved { get; set; }
        //This property saves the meridian
        private string meridianSaved { get; set; }
        private string messageSaved { get; set; }

        public ReminderManipulator()
        {


        }
        //Remind function
        public string SetReminder(string message)
        {
            string[] tempResult = message.Split(' ');
            bool remind = true;
            timeSaved = "";
            meridianSaved = "";
            messageSaved = "";
            List<string> meridianList = new List<string>(meridianArray);
            List<string> remindList = new List<string>(remindArray);
            List<string> pronounList = new List<string>(pronounArray);

            foreach (string s in tempResult)
            {

                //Finds the remind part of the message and cuts it out.
                foreach (string r in remindList)
                {
                    if (s.ToLower() == r)
                    {
                        remind = false;
                        break;
                    }
                }


                //Tests to see if it containts numbers, this is used for datetime
                Match match = regex.Match(s);

                if (match.Success)
                {
                    remind = false;
                    timeSaved = s + " ";
                }

                //This tries to find the meridian used for the time.
                foreach (string m in meridianList)
                {
                    if (s.ToLower() == m)
                    {
                        meridianSaved += m + " ";
                        remind = false;
                        break;
                    }
                }
                //If nothing was cut out it will add the word
                if (remind)
                {
                    //Finds the pronouns and changes them to your/you
                    foreach (string p in pronounList)
                    {
                        if (s.ToLower() == p)
                        {
                            messageSaved += "your ";
                            remind = false;
                            break;
                        }
                    }

                    //It will not enter the statement if it found a pronoun
                    if (remind)
                    {
                        messageSaved += s + " ";
                    }
                }
                remind = true;
            }

            
            return messageSaved + timeSaved + meridianSaved;
        }

        //public string GetReminder(int reminderID)
        //{

        //}

        public DateTime ConvertTimeToDateTime()
        {
            string time = timeSaved;
            string meridian = meridianSaved;
            DateTime date;

            if (time + meridian == "")
            {
                date = DateTime.Now;
               date = date.AddHours(2);
            }
            else
            {

                Match match = regex2.Match(time);

                if (match.Success)
                {
                    time = "0" + time;
                }

                if (meridian == "p.m. ")
                {
                    meridian = " PM";
                }
                else if (meridian == "a.m. ")
                {
                    meridian = " AM";
                }
                else
                {
                    //This is bad and you should split meridian and time- like tonight.
                    meridian = "PM";
                }

                //Again, if time is zero the meridian split should give a default time.
                if (time == "")
                {
                    date = DateTime.Now;
                   date = date.AddHours(2);
                }
                else
                {
                    date = DateTime.Parse(time + meridian);

                }
            }

            return date;
        }

        public string GetMessage()
        {
            return messageSaved;
        }


    }
}
