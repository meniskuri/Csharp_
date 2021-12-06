using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapana
{
    class program
    {
        static void Main(string[] args)
        {
            // მთავარი კონტეინერი
            string saxeli = "giorgi";
            int asaki = 30;
            saxeli = "svani";

            Console.WriteLine("My name is " + saxeli);
            Console.WriteLine("Im " + asaki);

            // დატა ტაიფს 
            string names = "saxelebi"; // ტექსტების შესანახად 
            char grade = 'A'; // ერთი სიმბოლოს შენახვა შემიძლია, ერთიანი ბრჭყალით  
            int age = 30;
            // float, double, decimal
            double gpa = 3.9;
            bool martalia = true; 
            Boolean mtyuani = false;

            Console.WriteLine(mtyuani);
            Console.WriteLine("Im " + grade + gpa);

            if (mtyuani == false)
            {
                Console.WriteLine(martalia);
                Console.WriteLine("Giorgi");
            }


            Console.ReadLine();

        }
    }
}