using System;
namespace Abstraction;
class Program
{
    public static void Main(string[] args)
    {
        List<CSEDepartment> cseBookList=new List<CSEDepartment>();
        List<EEEDepartment> eeeBookList=new List<EEEDepartment>();
        CSEDepartment cse=new CSEDepartment("Arul","Programming in c",new DateTime(2002,09,08));
        cseBookList.Add(cse);
        CSEDepartment cse1=new CSEDepartment("Jeniht","Pyhton",new DateTime(2001,01,23));
        cseBookList.Add(cse1);

        foreach(CSEDepartment details in cseBookList)
        {
            details.DisplayInfo();
        }


        System.Console.WriteLine("****************************");
        System.Console.WriteLine("****************************");

        EEEDepartment book1=new EEEDepartment("Author1","Micro Processor",new DateTime (1992,09,23));
        eeeBookList.Add(book1);
        EEEDepartment book2=new EEEDepartment("Author2","Micro Control System",new DateTime (2001,12,01));
        eeeBookList.Add(book2);

        foreach(EEEDepartment books in eeeBookList)
        {
            books.DisplayInfo();
        }

        //Library lib=new Library(); we cannot create the instance of Abstract class
        
    }
}