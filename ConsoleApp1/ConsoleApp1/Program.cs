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
            double gpa = 3.9; // float, double, decimal
            bool martalia = true; 
            Boolean mtyuani = false;

            Console.WriteLine(mtyuani);
            Console.WriteLine("Im " + grade + gpa);

            if (mtyuani == false)
            {
                Console.WriteLine(martalia);
                Console.WriteLine("Giorgi");
            }

            string praza = "fasanauris akademia";

            Console.WriteLine(praza[2]);
            Console.WriteLine(praza.Substring(8,5)); // 8 დან 3 ს დაბეჭდავს

            // რიცხვებთან მუშაობა 
            Console.WriteLine(3 + 2.0);
            Console.WriteLine(5 % 2.0);

            // math ოპერაციები, მეთოდები
            Console.WriteLine( Math.Sin(0.5) ); // უნდა გავარკვიო რა არგუმენტებს იღებს 

            // ინფუთ კლავიატურიდან
            Console.Write("Enter your name: "); 
            string name = Console.ReadLine();
            Console.WriteLine(name);

            // კალკულატორ გეიმ 




            Console.ReadLine();
        }
    }
}