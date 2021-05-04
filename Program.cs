using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proverocnaya
{
    class Program
    {

       

        static string Name ()
            {
            
                string a = Console.ReadLine();
                Console.WriteLine($"imya raboceqo:   { a}");
                while(a.Trim().Length==0)
                {

                    Console.WriteLine("vvedite imya  raboceqo");
                  a = Console.ReadLine();

                }
                 return a;
            }


        static int Sal(int a , int b)
        {
           

            int sal = int.Parse(Console.ReadLine());
            try
            {
                sal = int.Parse(Console.ReadLine());


            }
            catch (Exception)
            {
                Console.WriteLine("Dont enter symbol");
                sal = int.Parse(Console.ReadLine());
            }

            while (sal<=0)
            {

                Console.WriteLine("vvedite vernuyu summu");

                sal = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("vvedite naloq  raboceqo");
            int nal = int.Parse(Console.ReadLine());
            try
            {
                nal = int.Parse(Console.ReadLine());


            }
            catch (Exception)
            {
                Console.WriteLine("Dont enter symbol");
                nal = int.Parse(Console.ReadLine());
            }
            while (nal <= 0)
            {

                Console.WriteLine("vvedite verniy naloq");

                nal = int.Parse(Console.ReadLine());

            }

            int w = sal - (sal*nal/100);
            Console.WriteLine($"zarplata {sal} oplata {w} naloq {nal} ");
            
            return w;
           
        }




        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("vvedite  imya pervoqo raboceqo");
            string name1 = Name();
            
            Console.WriteLine("vvedite zarplatu pervoqo raboceqo");
            int sal1 = Sal(a,b);
            Console.WriteLine(sal1);
            Console.WriteLine("vvedite  imya vtoroqo raboceqo");
            string name2 = Name();
            Console.WriteLine("vvedite zarplatu vtoroqo raboceqo");
            int sal2 = Sal(a,b);
            Console.WriteLine(sal2);
            Console.WriteLine("u koqo naloq bolwe");
           
        





        }
    }
}
