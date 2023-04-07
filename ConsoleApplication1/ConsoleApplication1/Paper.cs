using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Paper
    {
        public string Publication { get; set; }
        public Person Person { get; set; }
        public DateTime PublicationDate { get; set; }

        public Paper(string Publication, Person person, DateTime PublicationDate)
        {
            Publication = Publication;
            Person = Person;
            PublicationDate = PublicationDate;
        }
        public Paper()
        {
            Publication = "Bendy";
            Person = new Person();
            PublicationDate = new DateTime(1935, 06, 09);
        }
        
        public override string ToString()
        {
            return Publication + ' ' + Person + ' ' + PublicationDate.ToString("dd.mm.yyyy");
        }
        public string ToFullString()
        {
            return $"Наименоввание публикации: {Publication}, Автор публикации: {Person}, Дата публикации: {PublicationDate}";
        }
    }
}
