using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ResearchTeam
    {
        private string _theme;
        private string _organization;
        private int _number;
        private TimeFrame _Last;
        private Paper[] _listPublication;

        public ResearchTeam(string theme, string organization, int number, TimeFrame List, Paper[] listPublication)
        {
            _theme = theme;
            _organization = organization;
            _number = number;
            _Last = List;
            _listPublication = listPublication;
        }
        public ResearchTeam()
        {
            _theme = "Dream come to life";
            _organization = "Joye Drew Studios";
            _number = 01;
            _Last = TimeFrame.Давно;
            _listPublication = new [] {new Paper()};
           
        }
        public string Theme
        {
            get { return _theme; }
            set { _theme = value; }
        }
        public string Organization
        {
            get { return _organization; }
            set { _organization = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public TimeFrame ReseearchTimeFrame
        {
            get { return _Last; }
            set { _Last = value; }
        }
        public Paper[] papers 
        {
            get { return _listPublication; }
            set { _listPublication = value; }
        }

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
               // Papers += $"{item._Publication} {item._person}"; //oshibka
          // Papers += $"{item.ToFullString()} \n";
            Papers += $"Тема: {_theme},\nНазвание: {_organization}, \nРег. номер: {_number}, \nПродолжительность исследований: {_Last},\nСписок публикаций: ";
            return Papers;
        }
        //public string ToShortString()
        //{
        //    return $"Тема: {_theme}, Название: {_organization}, Рег. номер: {_number}, Продолжительность исследований: {_Last},Список публикаций: ";
 
        //}


    }
}
