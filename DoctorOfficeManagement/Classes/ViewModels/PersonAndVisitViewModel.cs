using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repository;
using UnitOfWork;
using System.Globalization;

namespace DoctorOfficeManagement.Classes.ViewModels
{
    public class PersonAndVisitViewModel
    {

        public bool isFailed;
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string IsFailedMessage { get; set; }


        public PersonAndVisitViewModel(Visit visit)
        {

            ID = visit.ID;
            FullName = visit.Person.FullName;
            Time = visit.Time;
            Date = visit.Date;
            IsFailedMessage = visit.IsFailed ? "نوبت سوخته" : "نسوخته";
            isFailed = visit.IsFailed;


        }



    }
}
