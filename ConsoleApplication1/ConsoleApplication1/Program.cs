using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum TimeFrame
    {
        Год,
        Два_года,
        Давно
    }
    class Program
    {
        



        static void Main(string[] args)
        {
            ResearchTeam research = new ResearchTeam();
            Console.WriteLine(research.ToShortString());

            //  Person p1 = new Person();
            //  p1.Name = "Genry";


            //  Person avtorname = new Person();
            //  avtorname.Name = "Betti";
            //  ResearchTeam research = new ResearchTeam();
            //  //Console.WriteLine(value: research.AvarageRate);
            ////  Console.WriteLine(research.ToShortString());
            //  Console.WriteLine(research.ToFullString());
            //  research.AddPapers(new Paper());
            //  // Console.WriteLine(research.PaperLast.Title);
            Console.ReadKey();


            
                










        }
    }
}

