using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repository;
using UnitOfWork;
namespace DoctorOfficeManagement.Classes.ViewModels
{
   public class PersonViewModel
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public short Age { get; set; }
        public string City { get; set; }
        public string Province { get; set; }


        public PersonViewModel(Person person)
        {
            ID = person.ID;
            FullName = person.FullName;
            PhoneNumber = person.PhoneNumber;
            Email = person.Email;
            Address = person.Address;
            Age = person.Age;
            City = person.City.City1;
            Province = person.City.Province.Province1;
        }



    }

}
