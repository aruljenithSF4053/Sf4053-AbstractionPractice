using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Library //abstract class can inherit from another Interface or abstract class //cannot use sealed
    {
        private static int _serialNumber=100;
        public string SerialNumber{get;set;}

        public Library()
        {
            _serialNumber++;
            SerialNumber="LIB"+_serialNumber;
        }

        //public virtual int RockNumber{get;set;} //virtual keywords
     

        public abstract string  AuthorName{get;set;}
        public abstract string BookName{get;set;}
        public abstract DateTime PublishingYear{get;set;}
        public abstract void DisplayInfo();// cannot declare the body because mark as a abstract
       
    }
}