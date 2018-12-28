using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    class Fibonachi
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; }
        public int N { get; set; }
        static void Main(string[] args)
        {
            Fibonachi F = new Fibonachi();
            F.Val2=F.Val1 = 1; int a;
            F.N = int.Parse(Console.ReadLine());
            if (F.N > 0)
            {
               for (int i=0; i<F.N;i++ )
                {
                    Console.WriteLine(F.Val1);
                    a = F.Val2; F.Val2 = F.Val2 + F.Val1; F.Val1 = a;
                }
                Console.ReadKey();
            }
        }
    }
}
