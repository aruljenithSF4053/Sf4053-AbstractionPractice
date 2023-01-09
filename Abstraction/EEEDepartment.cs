using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    public class EEEDepartment : Library
    {
        public override string AuthorName {get;set;}
        public override string BookName {get;set;}
        public override DateTime PublishingYear { get;set;}

        public EEEDepartment(string authorName,string bookName,DateTime publishingYear)
        {
           
            AuthorName=authorName;
            BookName=bookName;
            PublishingYear=publishingYear;
        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine(SerialNumber+"||"+AuthorName+"||"+BookName+"||"+PublishingYear.ToString("dd/MM/yyyy"));
        }
    }
}