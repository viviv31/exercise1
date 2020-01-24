using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a is equal to: ");
            string afactor = Console.ReadLine();
            int anumber = Convert.ToInt32(afactor);

            Console.Write("b is equal to: ");
            string bfactor = Console.ReadLine();
            int bnumber = Convert.ToInt32(bfactor);

            Console.Write("c is equal to: ");
            string cfactor = Console.ReadLine();
            int cnumber = Convert.ToInt32(cfactor);

            int sresult = anumber + bnumber + cnumber;

            int sminusa = sresult - anumber;
            int sminusb = sresult - bnumber;
            int sminusc = sresult - cnumber;

            int productresult = sresult * sminusa * sminusb * sminusc;
            double areatriangle = Math.Sqrt(productresult);

            Console.WriteLine("the area of the triangle is: " + areatriangle);


            //Exercise 2

            Console.Write("discover if your number is even or odd, put is here: ");
            string factortodiscover = Console.ReadLine();
            int factorasnumber = Convert.ToInt32(factortodiscover);
            int remainder = factorasnumber % 2;
            if (remainder == 0)
            {
                Console.WriteLine("your number is even!");
            }
           else
            {
                Console.WriteLine("your number is odd");

            }



            //Exercise 3

            Console.Write("please enter your first number: ");
            string firstcharacter = Console.ReadLine();
            double firstnumber = Convert.ToInt32(firstcharacter);

            Console.Write("please enter your second number: ");
            string secondcharacter = Console.ReadLine();
            double secondnumber = Convert.ToInt32(secondcharacter);

            Console.Write("please write your third number");
            string thirdcharacter = Console.ReadLine();
            double thirdnumber = Convert.ToInt32(thirdcharacter);

            






            
            
        }
    }
}
