using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparision
{
    class Equality
    {
        public static void CheckEquality()
        {
            double a1, a2, b1, b2;
            double c1, c2, d1, d2;
            double length1, length2;
            Console.WriteLine("Enter the points of line1");

            Console.WriteLine("Enter points (a1,b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter points (a2,b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the points of line2");

            Console.WriteLine("Enter points (c1,d1): ");
            c1 = double.Parse(Console.ReadLine());
            d1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter points (c2,d2): ");
            c2 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());

            length1 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)));
            length2 = Math.Sqrt(((c2 - c1) * (c2 - c1)) + ((d2 - d1) * (d2 - d1)));
            Console.WriteLine("The length between two points are:" + length1 + length2);

            if (length1.Equals(length2))
            {
                Console.WriteLine("The length of the two are lines are equal");
            }
            else
            {
                Console.WriteLine("The length of the two are lines are not equal");
            }
        }
    }
}
