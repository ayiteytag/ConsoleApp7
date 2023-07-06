using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp7
{
    public class Program
    {
        static double GetSum2(double x = 1, double y = 1)
        {
            return x * y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        //----------FUNCTIONS -------
        // <Access specifier> <Return Type > <Method Name> (Parameters)
        // { <Body> }
        /*
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }*/

        /*static double GetSumMore(params double[] nums) 
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }*/

        /*public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
        */


        /*static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        */

        /*
        static double GetSum(double x = 1, double y = 1)
        {
            //return x + y;
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }
        */

        /*
        private static void SayHello()
        {
            string name = "";
            Console.WriteLine("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        //------- END OF FUNCTIONS-----*/

        static void Main(string[] args)
        {
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2(5.0, 4.5));
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5.0", "4.5"));


            // PrintInfo(zipCode: 00233, name: "Ewura Ajoa");

            /*
            Console.WriteLine("1+2+3 = {0}",
                  GetSumMore(1, 2, 3));
            */

            /*
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", 
                num3,num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num1 : {0} num2 : {1}", 
                num3, num4);
            */

            /*
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);
            */

            /*
        double x = 5;
        double y = 4;
        Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            Console.WriteLine("x = {0}", x);

            */

            //  SayHello();

            /*
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);
            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("length : {0}", sb2.Length);
            sb2.AppendLine("\nMore important text");
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Naa Ayeley";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb2.Equals(sb2));
            sb2.Insert(11, "that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            */


        }
    }
}