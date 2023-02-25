using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Person
    {
        private string First_Name;
        private string Last_Name;
        private DateTime BDate;
        public Person(string _First_Name, string _Last_Name, DateTime _BDate)
        {
            First_Name = _First_Name;
            Last_Name = _Last_Name;
            BDate = _BDate;
        }

        public Person()
        {
            First_Name = "Joye";
            Last_Name = "Drew";
            BDate = new DateTime(1930, 01, 01);
        }
        public string Name
        {
            get { return First_Name; }
            set { First_Name = value; }
        }
        public string LName
        {
            get { return Last_Name; }
            set { Last_Name = value; }
        }
        public DateTime HappyBri
        {
            get { return BDate; }
            set { BDate = value; }
        }
        public int year
        {
            get { return BDate.Year; }
            set { year = value; }
        }
        public string ToFullString()
        {
            return $"Имя: {First_Name}, фамилия: {Last_Name}, дата рождения: {BDate}";
        }

        public string ToShortString()
        {
            return $"Имя: {First_Name}, фамилия: {Last_Name}";
        }
    }   

}