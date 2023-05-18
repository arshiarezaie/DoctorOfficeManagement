using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DataLayer;
using UnitOfWork;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DataLayer.Models;


namespace DoctorOfficeManagement.Classes
{
    public class PDFgenerator
    {

        private UnitOfWorkDB db;


        public string GeneratePDfFile(Person person, DataLayer.Models.File file, Visit visit, IEnumerable<DataLayer.Models.Task> tasks, string[] fileImages, City city = null)
        {
            using (db = new UnitOfWorkDB())
            {
                city = person.City == null ? db.CityRepository.GetByPrimaryKey(person.CityID) : person.City;
            }

            Document pdfDoc = new Document(PageSize.A6, 10, 10, 10, 10);

            string _randomName = Guid.NewGuid().ToString();

            //Create our file stream and bind the writer to the document and the stream
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(Application.StartupPath + "/PDFFiles/" + _randomName + ".pdf", FileMode.Create));

            //Open the document for writing
            pdfDoc.Open();

            //Add a new page
            pdfDoc.NewPage();

            //Reference a Unicode font to be sure that the symbols are present.

            BaseFont bfArialUniCode = BaseFont.CreateFont(Application.StartupPath + "/fonts/tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //Create a font from the base font
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfArialUniCode, 8, 1, BaseColor.BLACK);

            //Use a table so that we can set the text direction
            PdfPTable table = new PdfPTable(1);
            //Ensure that wrapping is on, otherwise Right to Left text will not display
            table.DefaultCell.NoWrap = false;

            //Create a regex expression to detect hebrew or arabic code points
            const string regex_match_arabic_hebrew = @"[\u0600-\u06FF,\u0590-\u05FF]+";
            if (Regex.IsMatch("م الموافق", regex_match_arabic_hebrew, RegexOptions.IgnoreCase))
            {
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            }


            if (person.ProfilePicture == null)
            {
                iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance(Application.StartupPath + "/Images/doctor.jpg");

                PdfPCell cellImg = new PdfPCell(Logo);
                cellImg.Border = 0;
                cellImg.FixedHeight = 80;
                cellImg.VerticalAlignment = Element.ALIGN_CENTER;
                cellImg.HorizontalAlignment = Element.ALIGN_CENTER;
                cellImg.PaddingBottom = 5;
                table.AddCell(cellImg);
            }


            PdfPCell PersonImage = new PdfPCell(new Phrase("تصویر بیمار ", font));
            PersonImage.Border = 0;
            PersonImage.PaddingBottom = 10;
            PersonImage.PaddingTop = 5;
            PersonImage.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            PersonImage.NoWrap = false;
            PersonImage.HorizontalAlignment = Element.ALIGN_CENTER;
            PersonImage.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(PersonImage);


            if (person.ProfilePicture != null)
            {
                iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(person.ProfilePicture);

                PdfPCell Img = new PdfPCell(Image);
                Img.Border = 0;
                Img.FixedHeight = 80;
                Img.VerticalAlignment = Element.ALIGN_CENTER;
                Img.HorizontalAlignment = Element.ALIGN_CENTER;
                Img.PaddingBottom = 5;
                table.AddCell(Img);
            }



            PdfPCell PersonName = new PdfPCell(new Phrase("نام و نام خانوادگی بیمار :" + person.FullName, font));
            PersonName.Border = 1;
            PersonName.PaddingBottom = 5;
            PersonName.PaddingTop = 5;
            PersonName.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            PersonName.NoWrap = false;
            PersonName.HorizontalAlignment = Element.ALIGN_CENTER;
            PersonName.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(PersonName);


            PdfPCell Phonenumber = new PdfPCell(new Phrase("شماره تلفن :" + person.PhoneNumber, font));
            Phonenumber.Border = 1;
            Phonenumber.PaddingBottom = 5;
            Phonenumber.PaddingTop = 5;
            Phonenumber.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            Phonenumber.NoWrap = false;
            Phonenumber.HorizontalAlignment = Element.ALIGN_CENTER;
            Phonenumber.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Phonenumber);


            PdfPCell Age = new PdfPCell(new Phrase("سن :" + person.Age, font));
            Age.Border = 1;
            Age.PaddingBottom = 5;
            Age.PaddingTop = 5;
            Age.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            Age.NoWrap = false;
            Age.HorizontalAlignment = Element.ALIGN_CENTER;
            Age.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Age);

            PdfPCell City = new PdfPCell(new Phrase("شهر - وستا - شهرستان  :" + city.City1, font));
            City.Border = 1;
            City.PaddingBottom = 5;
            City.PaddingTop = 5;
            City.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            City.NoWrap = false;
            City.HorizontalAlignment = Element.ALIGN_CENTER;
            City.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(City);



            PdfPCell VisitDate = new PdfPCell(new Phrase("تاریخ  مراجعه " + visit.Date, font));
            VisitDate.Border = 1;
            VisitDate.PaddingBottom = 5;
            VisitDate.PaddingTop = 5;
            VisitDate.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            VisitDate.NoWrap = false;
            VisitDate.HorizontalAlignment = Element.ALIGN_CENTER;
            VisitDate.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(VisitDate);


            PdfPCell Title = new PdfPCell(new Phrase("عنوان مشکل بیمار " + file.Title, font));
            Title.Border = 1;
            Title.PaddingBottom = 5;
            Title.PaddingTop = 5;
            Title.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            Title.NoWrap = false;
            Title.HorizontalAlignment = Element.ALIGN_CENTER;
            Title.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Title);

            PdfPCell Description = new PdfPCell(new Phrase("توضیحات " + file.Title, font));
            Description.Border = 1;
            Description.PaddingBottom = 5;
            Description.PaddingTop = 5;
            Description.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            Description.NoWrap = false;
            Description.HorizontalAlignment = Element.ALIGN_CENTER;
            Description.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Description);

            PdfPCell TaskCaption = new PdfPCell(new Phrase("شرح وظایف پزشک : ", font));
            TaskCaption.Border = 1;
            TaskCaption.PaddingBottom = 5;
            TaskCaption.PaddingTop = 5;
            TaskCaption.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            TaskCaption.NoWrap = false;
            TaskCaption.HorizontalAlignment = Element.ALIGN_CENTER;
            TaskCaption.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(TaskCaption);


            foreach (DataLayer.Models.Task task in tasks)
            {


                PdfPCell TaskLine = new PdfPCell(new Phrase(task.Task1, font));
                TaskLine.Border = 1;
                TaskLine.PaddingBottom = 5;
                TaskLine.PaddingTop = 5;
                TaskLine.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                TaskLine.NoWrap = false;
                TaskLine.HorizontalAlignment = Element.ALIGN_CENTER;
                TaskLine.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(TaskLine);



            }


            PdfPCell ImagesFilesTitle = new PdfPCell(new Phrase("تصاویر مربوط به پرونده", font));
            ImagesFilesTitle.Border = 1;
            ImagesFilesTitle.PaddingBottom = 10;
            ImagesFilesTitle.PaddingTop = 5;
            ImagesFilesTitle.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
            ImagesFilesTitle.NoWrap = false;
            ImagesFilesTitle.HorizontalAlignment = Element.ALIGN_CENTER;
            ImagesFilesTitle.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(ImagesFilesTitle);


            if (fileImages != null)
            {
                foreach (string images in fileImages)
                {

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(images);
                    PdfPCell Imgcell = new PdfPCell(img);
                    Imgcell.Border = 0;
                    Imgcell.FixedHeight = 100;
                    Imgcell.VerticalAlignment = Element.ALIGN_CENTER;
                    Imgcell.HorizontalAlignment = Element.ALIGN_CENTER;
                    Imgcell.PaddingBottom = 5;
                    table.AddCell(Imgcell);

                }
            }






            PdfPCell Footer = new PdfPCell(new Phrase("نرم افزار مدیریت مطب پزشک ", font));
            Footer.Border = 0;
            Footer.PaddingBottom = 5;
            Footer.PaddingTop = 20;
            Footer.NoWrap = false;
            Footer.HorizontalAlignment = Element.ALIGN_CENTER;
            Footer.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Footer);


            //Add the table to the document
            pdfDoc.Add(table);
            //Close the document
            pdfDoc.Close();


            return "/PDFFiles/" + _randomName + ".pdf";
        }







        public void GeneratePDfPerons(string SavePath)
        {


            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

     

            //Create our file stream and bind the writer to the document and the stream
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(SavePath, FileMode.Create));

            //Open the document for writing
            pdfDoc.Open();

            //Add a new page
            pdfDoc.NewPage();

            //Reference a Unicode font to be sure that the symbols are present.

            BaseFont bfArialUniCode = BaseFont.CreateFont(Application.StartupPath + "/fonts/tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //Create a font from the base font
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfArialUniCode, 8, 1, BaseColor.BLACK);

            //Use a table so that we can set the text direction
            PdfPTable table = new PdfPTable(1);
            //Ensure that wrapping is on, otherwise Right to Left text will not display
            table.DefaultCell.NoWrap = false;

            //Create a regex expression to detect hebrew or arabic code points
            const string regex_match_arabic_hebrew = @"[\u0600-\u06FF,\u0590-\u05FF]+";
            if (Regex.IsMatch("م الموافق", regex_match_arabic_hebrew, RegexOptions.IgnoreCase))
            {
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            }


            using (db = new UnitOfWorkDB())
            {


                foreach (Person person in db.PersonRepository.Get())
                {

                    
                        iTextSharp.text.Image Profile = iTextSharp.text.Image.GetInstance(person.ProfilePicture!=null? person.ProfilePicture : Application.StartupPath+ "/Images/Patent.jpg");

                        PdfPCell cellImg = new PdfPCell(Profile);
                        cellImg.Border = 0;
                        cellImg.FixedHeight = 80;
                        cellImg.VerticalAlignment = Element.ALIGN_CENTER;
                        cellImg.HorizontalAlignment = Element.ALIGN_CENTER;
                        cellImg.PaddingBottom = 5;
                        table.AddCell(cellImg);
                    


                    PdfPCell personFullName = new PdfPCell(new Phrase("نام و نام خانوادگی : " + person.FullName, font));
                    personFullName.Border = 1;
                    personFullName.PaddingBottom = 5;
                    personFullName.PaddingTop = 5;
                    personFullName.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    personFullName.NoWrap = false;
                    personFullName.HorizontalAlignment = Element.ALIGN_CENTER;
                    personFullName.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(personFullName);

                    PdfPCell personAge = new PdfPCell(new Phrase("سن: " + person.Age, font));
                    personAge.Border = 1;
                    personAge.PaddingBottom = 5;
                    personAge.PaddingTop = 5;
                    personAge.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    personAge.NoWrap = false;
                    personAge.HorizontalAlignment = Element.ALIGN_CENTER;
                    personAge.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(personAge);

                    PdfPCell personCity = new PdfPCell(new Phrase("شهر: " + person.City.City1, font));
                    personCity.Border = 1;
                    personCity.PaddingBottom = 5;
                    personCity.PaddingTop = 5;
                    personCity.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    personCity.NoWrap = false;
                    personCity.HorizontalAlignment = Element.ALIGN_CENTER;
                    personCity.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(personCity);

                    PdfPCell personProvince = new PdfPCell(new Phrase("استان: " + person.City.Province.Province1, font));
                    personProvince.Border = 1;
                    personProvince.PaddingBottom = 5;
                    personProvince.PaddingTop = 5;
                    personProvince.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    personProvince.NoWrap = false;
                    personProvince.HorizontalAlignment = Element.ALIGN_CENTER;
                    personProvince.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(personProvince);

                    PdfPCell personAddress = new PdfPCell(new Phrase("آدرس: " + person.Address, font));
                    personAddress.Border = 1;
                    personAddress.PaddingBottom = 5;
                    personAddress.PaddingTop = 5;
                    personAddress.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    personAddress.NoWrap = false;
                    personAddress.HorizontalAlignment = Element.ALIGN_CENTER;
                    personAddress.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(personAddress);




                }

            }













            PdfPCell Footer = new PdfPCell(new Phrase("نرم افزار مدیریت مطب پزشک ", font));
            Footer.Border = 0;
            Footer.PaddingBottom = 5;
            Footer.PaddingTop = 20;
            Footer.NoWrap = false;
            Footer.HorizontalAlignment = Element.ALIGN_CENTER;
            Footer.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Footer);


            //Add the table to the document
            pdfDoc.Add(table);
            //Close the document
            pdfDoc.Close();

        }



        public void GeneratePDFtasks(string SavePath)
        {


            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);



            //Create our file stream and bind the writer to the document and the stream
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(SavePath, FileMode.Create));

            //Open the document for writing
            pdfDoc.Open();

            //Add a new page
            pdfDoc.NewPage();

            //Reference a Unicode font to be sure that the symbols are present.

            BaseFont bfArialUniCode = BaseFont.CreateFont(Application.StartupPath + "/fonts/tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //Create a font from the base font
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfArialUniCode, 8, 1, BaseColor.BLACK);

            //Use a table so that we can set the text direction
            PdfPTable table = new PdfPTable(1);
            //Ensure that wrapping is on, otherwise Right to Left text will not display
            table.DefaultCell.NoWrap = false;

            //Create a regex expression to detect hebrew or arabic code points
            const string regex_match_arabic_hebrew = @"[\u0600-\u06FF,\u0590-\u05FF]+";
            if (Regex.IsMatch("م الموافق", regex_match_arabic_hebrew, RegexOptions.IgnoreCase))
            {
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            }


            using (db = new UnitOfWorkDB())
            {


                foreach (DataLayer.Models.Task task in db.TaskRepository.Get())
                {


                    PdfPCell Title = new PdfPCell(new Phrase("عنوان وظیفه :  " + task.Task1, font));
                    Title.Border = 1;
                    Title.PaddingBottom = 5;
                    Title.PaddingTop = 5;
                    Title.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Title.NoWrap = false;
                    Title.HorizontalAlignment = Element.ALIGN_CENTER;
                    Title.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Title);




                    PdfPCell Price = new PdfPCell(new Phrase("قیمت وظیفه :  " + task.Price, font));
                    Price.Border = 1;
                    Price.PaddingBottom = 5;
                    Price.PaddingTop = 5;
                    Price.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Price.NoWrap = false;
                    Price.HorizontalAlignment = Element.ALIGN_CENTER;
                    Price.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Price);




                    PdfPCell Description = new PdfPCell(new Phrase("توضیحات  :  " + task.Description, font));
                    Description.Border = 1;
                    Description.PaddingBottom = 5;
                    Description.PaddingTop = 5;
                    Description.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Description.NoWrap = false;
                    Description.HorizontalAlignment = Element.ALIGN_CENTER;
                    Description.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Description);




                }

            }













            PdfPCell Footer = new PdfPCell(new Phrase("نرم افزار مدیریت مطب پزشک ", font));
            Footer.Border = 0;
            Footer.PaddingBottom = 5;
            Footer.PaddingTop = 20;
            Footer.NoWrap = false;
            Footer.HorizontalAlignment = Element.ALIGN_CENTER;
            Footer.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Footer);


            //Add the table to the document
            pdfDoc.Add(table);
            //Close the document
            pdfDoc.Close();

        }



        public void GeneratePDFVisits(string SavePath)
        {


            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);



            //Create our file stream and bind the writer to the document and the stream
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(SavePath, FileMode.Create));

            //Open the document for writing
            pdfDoc.Open();

            //Add a new page
            pdfDoc.NewPage();

            //Reference a Unicode font to be sure that the symbols are present.

            BaseFont bfArialUniCode = BaseFont.CreateFont(Application.StartupPath + "/fonts/tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //Create a font from the base font
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfArialUniCode, 8, 1, BaseColor.BLACK);

            //Use a table so that we can set the text direction
            PdfPTable table = new PdfPTable(1);
            //Ensure that wrapping is on, otherwise Right to Left text will not display
            table.DefaultCell.NoWrap = false;

            //Create a regex expression to detect hebrew or arabic code points
            const string regex_match_arabic_hebrew = @"[\u0600-\u06FF,\u0590-\u05FF]+";
            if (Regex.IsMatch("م الموافق", regex_match_arabic_hebrew, RegexOptions.IgnoreCase))
            {
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            }


            using (db = new UnitOfWorkDB())
            {


                foreach (DataLayer.Models.Visit visit in db.VisitRepository.Get())
                {


                    PdfPCell Name = new PdfPCell(new Phrase("نام کامل  :  " + visit.Person.FullName, font));
                    Name.Border = 1;
                    Name.PaddingBottom = 5;
                    Name.PaddingTop = 5;
                    Name.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Name.NoWrap = false;
                    Name.HorizontalAlignment = Element.ALIGN_CENTER;
                    Name.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Name);




                    PdfPCell Date = new PdfPCell(new Phrase("تاریخ :  " + visit.Date, font));
                    Date.Border = 1;
                    Date.PaddingBottom = 5;
                    Date.PaddingTop = 5;
                    Date.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Date.NoWrap = false;
                    Date.HorizontalAlignment = Element.ALIGN_CENTER;
                    Date.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Date);




                    PdfPCell Time = new PdfPCell(new Phrase(" ساعت :  " + visit.Time , font));
                    Time.Border = 1;
                    Time.PaddingBottom = 5;
                    Time.PaddingTop = 5;
                    Time.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Time.NoWrap = false;
                    Time.HorizontalAlignment = Element.ALIGN_CENTER;
                    Time.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Time);




                }

            }













            PdfPCell Footer = new PdfPCell(new Phrase("نرم افزار مدیریت مطب پزشک ", font));
            Footer.Border = 0;
            Footer.PaddingBottom = 5;
            Footer.PaddingTop = 20;
            Footer.NoWrap = false;
            Footer.HorizontalAlignment = Element.ALIGN_CENTER;
            Footer.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Footer);


            //Add the table to the document
            pdfDoc.Add(table);
            //Close the document
            pdfDoc.Close();

        }




        public void GeneratePDFuserActions(string SavePath)
        {


            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);



            //Create our file stream and bind the writer to the document and the stream
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(SavePath, FileMode.Create));

            //Open the document for writing
            pdfDoc.Open();

            //Add a new page
            pdfDoc.NewPage();

            //Reference a Unicode font to be sure that the symbols are present.

            BaseFont bfArialUniCode = BaseFont.CreateFont(Application.StartupPath + "/fonts/tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //Create a font from the base font
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfArialUniCode, 8, 1, BaseColor.BLACK);

            //Use a table so that we can set the text direction
            PdfPTable table = new PdfPTable(1);
            //Ensure that wrapping is on, otherwise Right to Left text will not display
            table.DefaultCell.NoWrap = false;

            //Create a regex expression to detect hebrew or arabic code points
            const string regex_match_arabic_hebrew = @"[\u0600-\u06FF,\u0590-\u05FF]+";
            if (Regex.IsMatch("م الموافق", regex_match_arabic_hebrew, RegexOptions.IgnoreCase))
            {
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            }


            using (db = new UnitOfWorkDB())
            {


                foreach (DataLayer.Models.UserAction action in db.UserActionRepository.Get())
                {


                    PdfPCell UserName = new PdfPCell(new Phrase("کاربر   :  " + action.UserName, font));
                    UserName.Border = 1;
                    UserName.PaddingBottom = 5;
                    UserName.PaddingTop = 5;
                    UserName.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    UserName.NoWrap = false;
                    UserName.HorizontalAlignment = Element.ALIGN_CENTER;
                    UserName.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(UserName);




                    PdfPCell Date = new PdfPCell(new Phrase("تاریخ :  " + action.Date, font));
                    Date.Border = 1;
                    Date.PaddingBottom = 5;
                    Date.PaddingTop = 5;
                    Date.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Date.NoWrap = false;
                    Date.HorizontalAlignment = Element.ALIGN_CENTER;
                    Date.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Date);




                    PdfPCell Time = new PdfPCell(new Phrase(" ساعت :  " + action.Time, font));
                    Time.Border = 1;
                    Time.PaddingBottom = 5;
                    Time.PaddingTop = 5;
                    Time.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Time.NoWrap = false;
                    Time.HorizontalAlignment = Element.ALIGN_CENTER;
                    Time.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Time);





                    PdfPCell Action = new PdfPCell(new Phrase(" عملیات :  " + action.Action, font));
                    Action.Border = 1;
                    Action.PaddingBottom = 5;
                    Action.PaddingTop = 5;
                    Action.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.Color.White);
                    Action.NoWrap = false;
                    Action.HorizontalAlignment = Element.ALIGN_CENTER;
                    Action.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(Action);




                }

            }













            PdfPCell Footer = new PdfPCell(new Phrase("نرم افزار مدیریت مطب پزشک ", font));
            Footer.Border = 0;
            Footer.PaddingBottom = 5;
            Footer.PaddingTop = 20;
            Footer.NoWrap = false;
            Footer.HorizontalAlignment = Element.ALIGN_CENTER;
            Footer.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(Footer);


            //Add the table to the document
            pdfDoc.Add(table);
            //Close the document
            pdfDoc.Close();

        }





    }
}