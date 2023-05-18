using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Globalization;
namespace DoctorOfficeManagement.Classes
{
    public class ActionMaker
    {
        public UserAction GetAction(string text)
        {
            PersianCalendar calendar = new PersianCalendar();

            UserAction action = new UserAction()
            {
                UserName = Identity.User.UserName,
                Action = text,
                Date = calendar.GetYear(DateTime.Now) + "/" + calendar.GetMonth(DateTime.Now) + "/" + calendar.GetDayOfMonth(DateTime.Now),
                Time = DateTime.Now.ToShortTimeString()

            };
            return action;
        }


    }
}
