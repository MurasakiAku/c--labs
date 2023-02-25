using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Paper
    {
        public string _Publication;
        public Person _person;
        public DateTime _PublicationDate;

        public Paper(string Publication, Person person, DateTime PublicationDate)
        {
            _Publication = Publication;
            _person = person;
            _PublicationDate = PublicationDate;
        }
        public Paper()
        {
            _Publication = "Bendy";
            _person = new Person();
            _PublicationDate = new DateTime(1935, 06, 09);
        }
        public string publication
        {
            get { return _Publication; }
            set { _Publication = value; }
        }
        public Person persons
        {
            get { return _person; }
            set { _person = value; }
        }
        public DateTime publicationdate
        {
            get { return _PublicationDate; }
            set { _PublicationDate = value; }
        }
        public override string ToString()
        {
            return _Publication + ' ' + _person + ' ' + _PublicationDate.ToString("dd.mm.yyyy");
        }
        public string ToFullString()
        {
            return $"Наименоввание публикации: {_Publication}, Автор публикации: {_person}, Дата публикации: {_PublicationDate}";
        }
    }
}
