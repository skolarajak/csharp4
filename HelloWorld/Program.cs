using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Web;

namespace HelloWorld
{
    class Cas22
    {
        static void Main(string[] args)
        {

            //int a = 16;
            //int b = 32767;
            //int c = 8;
            //int result, result2;

            Cas22 c22 = new Cas22();
            //result = c22.FindMax(a, b);
            //result2 = c22.Factorial(c);
            //Console.WriteLine("Veca vrednost je: {0}", result);
            //Console.WriteLine("Vrednost {0}! je {1}", c, result2);

            //int a = 100;
            //int b = 200;

            //Console.WriteLine("Pre zamene, vrednost a je : {0}", a);
            //Console.WriteLine("Pre zamene, vrednost b je : {0}", b);
            //c22.Swap(ref a, ref b);
            //Console.WriteLine("Posle zamene, vrednost a je : {0}", a);
            //Console.WriteLine("Posle zamene, vrednost b je : {0}", b);

            int a, b;
            c22.GetValues(out a, out b);
            Console.WriteLine("Posle poziva GetValues, a je : {0}", a);
            Console.WriteLine("Posle poziva GetValues, b je : {0}", b);

            Console.ReadKey();

        }

        public void GetValues(out int x, out int y)
        {
            Console.WriteLine("Unesite prvu vrednost: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite drugu vrednost: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        public int Factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            } else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }

        public void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

    }
}

