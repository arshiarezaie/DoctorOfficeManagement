using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Data.Entity;
using DataLayer.Repository;
namespace UnitOfWork
{
    public class UnitOfWorkDB : IDisposable
    {

        private DoctorOfficeManagementEntities db;

        private Exception _exception;


        public UnitOfWorkDB()
        {
            db = new DoctorOfficeManagementEntities();

        }


        public Repository<City> CityRepository
        {
            get
            {
                return new Repository<City>(db);
            }
        }


        public Repository<Province> ProvinceRepository
        {
            get
            {
                return new Repository<Province>(db);
            }
        }


        public Repository<DigitalFile> DigitalFileRepository
        {
            get
            {
                return new Repository<DigitalFile>(db);
            }
        }

        public Repository<DoctorTask> DoctorTaskRepository
        {
            get
            {
                return new Repository<DoctorTask>(db);
            }
        }

        public Repository<DataLayer.Models.Task> TaskRepository
        {
            get
            {
                return new Repository<DataLayer.Models.Task>(db);
            }
        }

        public Repository<File> FileRepository
        {
            get
            {
                return new Repository<File>(db);
            }
        }

        public Repository<ImagesOfFile> ImagesOfFileRepository
        {
            get
            {
                return new Repository<ImagesOfFile>(db);
            }
        }

        public Repository<Person> PersonRepository
        {
            get
            {
                return new Repository<Person>(db);
            }
        }
        public Repository<Visit> VisitRepository
        {
            get
            {
                return new Repository<Visit>(db);
            }
        }

        public Repository<VisitPrice> VisitPriceRepository
        {
            get
            {
                return new Repository<VisitPrice>(db);
            }
        }


        public Repository<User> UserRepository
        {
            get
            {
                return new Repository<User>(db);
            }
        }

        public Repository<UserAction> UserActionRepository
        {
            get
            {
                return new Repository<UserAction>(db);
            }
        }

        public Repository<Payment> PaymentRepository
        {
            get
            {
                return new Repository<Payment>(db);
            }
        }

        public Repository<Revenues> RevenuesRepository
        {
            get
            {
                return new Repository<Revenues>(db);
            }
        }


        public Exception Exception
        {
            get
            {
                return _exception;
            }
        }




        public void Dispose()
        {
            db.Dispose();
        }

        public bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _exception = ex;
                return false;
            }


        }



    }
}



