using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace regexxx.v2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Number 1

            //Regex regex = new Regex(@"(^a$) | aaaaaa| (a aa a)");
            //string[] input = File.ReadAllLines(@"Regex1.txt");
            //for (int i = 0; i < input.Length; ++i)
            //{
            //    Console.Write(input[i]);
            //    if (regex.IsMatch(input[i]))

            //        Console.WriteLine("norm");
            //    Console.WriteLine(String.Empty);

            //}

            // -----------------------------------

            ////Number 2 

            ////Regex regex = new Regex(@"[a-zA-Z0-9]{5,}");
            ////Console.WriteLine("Номер2");
            ////Console.WriteLine("Введите 5 алфавитно-цифровых символов:");
            ////string s = Console.ReadLine();
            //////  Console.WriteLine(new Regex)
            ////if (regex.IsMatch(s))
            ////{
            ////    Console.WriteLine("Хорошо");
            ////}
            ////else { Console.WriteLine("Нет"); }

            //// -----------------------------------

            ////Number 3 

            //Console.WriteLine("Number3");
            //string email = File.ReadAllText(@"Regex3.txt");
            //Regex regex = new Regex(@"[.+@+]");

            //if (regex.IsMatch(email))
            //{
            //    Console.WriteLine("Хорошо");
            //}
            //else { Console.WriteLine("Нет"); }
            //Console.WriteLine(String.Empty);

            //string email = File.ReadAllText(@"Regex3.txt");
            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //Match match = regex.Match(email);
            //if (match.Success)

            //// -----------------------------------

            ////Number 4 

            Console.WriteLine("Number4");
            Console.WriteLine("vvtdite adress");
            Console.ReadLine();

            string adress = File.ReadAllText(@"Regex4.txt");
            Regex regex = new Regex(@"^[А-Яа-я]+[А-Яа-я]");
            if (regex.IsMatch(adress)) {
                Console.WriteLine("Хорошо");
            }
            else { Console.WriteLine("Нет"); }
            Console.WriteLine(String.Empty);
            Console.ReadKey();
        }
            //foreach (string line in adress)
            //{
            //    Match match = regex.Match(TextReader);
            //    if (match.Success)
            //    {
            //        Console.WriteLine($"{match.Groups["street"]} {match.Groups["house"]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }

            //}
            //MatchCollection matchCollection = regex.Matches(@"Regex4.txt");
            //for (int count = 0; count < matchCollection.Count; count++)
            //    Console.WriteLine(matchCollection[count].Value);
            //Console.ReadKey();
        
        
    }
}
