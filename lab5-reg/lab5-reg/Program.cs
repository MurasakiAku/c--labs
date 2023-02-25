using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace lab5_reg
{
    internal class Program
    {
        static void Main()
        {

            //string[] input = File.ReadAllLines(@"Regex1.txt");
            //for (int i = 0; i < input.Length; ++i)
            //{
            //    Console.Write(input[i]);
            //    if(new Regex(@"(^a$)|(aaaaa)|(a aa a)")).IsMatch(input[i]))
            //Consol
            //    //проверка i-го элемента массива на соответствие регулярному выражению
            //}

            //Console.WriteLine(String.Empty);


            Console.ReadKey();
            Console.WriteLine("number2");
            Console.WriteLine("Vvedite ne menie 5 bukv i cifr");
            Regex regex = new Regex(@"[0-9a-zA-Z]{5,}");
            //string[] s = { @"[0-9a-zA-Z]{5,}" };
            string str = Console.ReadLine();
            if (Regex.IsMatch( str))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("no");
            }

        }

    }
}
