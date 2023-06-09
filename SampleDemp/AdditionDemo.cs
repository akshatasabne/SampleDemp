using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemp
{
    internal class AdditionDemo
    {
        static void Main(string[] args)
        {
            //    int num1 = 10, num2=20, sum;
            //   // Console.WriteLine("ENTER nnumber"+num1+num2);

            //    sum = num1 + num2;
            //    Console.WriteLine("Sum="+sum); 

            //int num1, num2, sum,sub,mul,div;
            //Console.WriteLine("Enter First Number");
            //num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //num2=Convert.ToInt32(Console.ReadLine());
            //sum = num1 + num2;
            //sub = num1 - num2;
            //mul = num1 * num2;
            //div = num1 / num2;
            //Console.WriteLine("Addition =" + sum+"\nsubtraction="+sub+"\nMultilply="+mul+"\nDiv="+div);

            int sub1, sub2, sub3, total;
            double percentage;
            Console.WriteLine("Maths=");
            sub1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("English=");
            sub2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Science=");
            sub3=Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;
            percentage = (total / 3);
            Console.WriteLine("total of marks=" +total+"\npercentage="+percentage);
                }
                

    }
}
