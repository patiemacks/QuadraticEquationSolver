using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticSolver
{
    class Program
    {
        static void Main(string[] args)
        {

            /*For a second order polynomial equation in the form ax^2+bx+c=0 ,we can find the
            roots of the equation by firstly calcuating the discriminant d = b^2-4(a)(c)
            -if d is greater than 0, the equation has two distinct real roots and we calculate them
            using the formula x1=[-b+Math.Sqrt(Math.Pow(b,2)-4*a*c)/(2*a)] and x2=[-b-Math.Sqrt(Math.Pow(b,2)-4*a*c)/(2*a)]
            -if d equals 0 the equation has one double real root and calculated by -b/(2*a)
            and if d is less than zero the equation has no real roots
            */

            double a, b, c = 1;
            Console.Write("Enter the value of a : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of b : ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of c : ");
            c = double.Parse(Console.ReadLine());

            SolveEquation(a, b, c);
            Console.ReadLine();
        }

        public static void SolveEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double x, x1, x2, img;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("The equation has two real roots {0}and {1}", x1, x2);
            }
            else if (d == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("The equation has one double real root {0} ", x);
            }
            else if (d < 0)
            {
                d = -b;
                x = -b / 2 * a;
                img = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                Console.WriteLine("The equation has complex non real roots {0} and {1} ", x, img);
            }
            else
            {
                Console.WriteLine("Please check your equation again");
            }
        }
    }
}
