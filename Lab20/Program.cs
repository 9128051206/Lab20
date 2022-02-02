using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Сircle;
            double d= myDelegate(10);
            Console.WriteLine(d);

            myDelegate = Round;
            double s=myDelegate(10);
            Console.WriteLine(s);

            myDelegate = Ball;
           double v= myDelegate(10);
            Console.WriteLine(v);

            Console.ReadKey();
        }

        static double Сircle(double r)
        {
            double d=(double)2 *3.14 * r;            
            return d;
        }
        
        static double Round (double r)
        {
            double s=3.14* r*r;            
            return s;
        } 
        static double Ball(double r)
        {
            double v = 4 / 3 * 3.14 * Math.Pow(r, 3);            
            return v;
        }




    }
}
