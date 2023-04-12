using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ResearchTeam
    {
        private string _theme { get; set; }
        private string _organization { get; set; }
        private int _number { get; set; }
        private TimeFrame _last { get; set; }
        private Paper[] _listPublication { get; set; }

        public ResearchTeam(string Theme, string Organization, int Number, TimeFrame Last, Paper[] ListPublication)
        {
            _theme = Theme;
            _organization = Organization;
            _number = Number;
            _last = Last;
            _listPublication = ListPublication;
        }
        public ResearchTeam()
        {
            _theme = "Dream come to life";
            _organization = "Joye Drew Studios";
            _number = 01;
            _last = TimeFrame.Давно;
            _listPublication = new [] {new Paper()};
           
        }
        //public string Theme
        //{
        //    get { return _theme; }
        //    set { _theme = value; }
        //}
        //public string Organization
        //{
        //    get { return _organization; }
        //    set { _organization = value; }
        //}
        //public int Number
        //{
        //    get { return _number; }
        //    set { _number = value; }
        //}
        //public TimeFrame ReseearchTimeFrame
        //{
        //    get { return _Last; }
        //    set { _Last = value; }
        //}
        //public Paper[] papers 
        //{
        //    get { return _listPublication; }
        //    set { _listPublication = value; }
        //}

        public void AddPapers(params Paper[] newPapers)
        {
            
            int names = _listPublication.Length;
            //Array.Resize<Paper>(ref _listPublication, names + newPapers.Length);
            //newPapers.CopyTo.names);
            _listPublication = _listPublication.Concat(newPapers).ToArray();
            
        }
     
        public string ToFullString()
        {
            string Papers = "";
            //foreach (var item in _listPublication)
            //    Papers += $"{item._publication} {item._person}"; //oshibka
            //Papers += $"{item.ToFullString()} \n";
            Papers += $"Тема: {_theme},\nНазвание: {_organization}, \nРег. номер: {_number}, \nПродолжительность исследований: {_last},\nСписок публикаций: ";
            return Papers;
        }
        public string ToShortString()
        {
            return $"Тема: {_theme}, \nОрганизация: {_organization}, \nРег. номер: {_number}, \nПродолжительность исследований: {_last} ";

        }


    }
}
