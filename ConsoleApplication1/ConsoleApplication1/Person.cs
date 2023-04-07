using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Person
    {
        private string _firstname { get; set; }
        private string _lastname { get; set; }
        private DateTime _bdate { get; set; }

        public Person(string FirstName, string LastName, DateTime BDate)
        {
            _firstname = FirstName;
            _lastname = LastName;
            _bdate = BDate;
        }
        
        public Person()
        {
            _firstname = "Joye";
            _lastname = "Drew";
            _bdate = new DateTime(1930, 01, 01);
        }
        
        //public int year
        //{
        //    get { return BDate.Year; }
        //    set { year = value; }
        //}
        public string ToFullString()
        {
            return $"Имя: {_firstname}, фамилия: {_lastname}, дата рождения: {_bdate}";
        }

        public string ToShortString()
        {
            return $"Имя: {_firstname}, фамилия: {_lastname}";
        }
    }   

}