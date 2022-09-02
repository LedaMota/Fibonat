using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonat
{
    class Program
    {
        static void Main(string[] args)
        {

            //0 1 1 2 3 5 8 
            int a = 0, b = 1, c = 0;

            Console.Write("Quntos valores");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de Fibonancci com" + valores + "valores");

            for(int i = 0; i < valores; i ++)
            {

                if(i < valores -1)
                {
                    Console.Write(a + ",");
                }
                else
                {
                    Console.Write(a );
                }
               
                c = a + b;
                a = b;
                b = c;
            }


            //Console.ReadKey();

        }
    }
}
