using System;
using System.Reflection.Metadata.Ecma335;

namespace C_Sharp_raya_week_6
{
   
    class Program
    {
        static void Main(string[] args)
        {

            // 1.2.1
            Cookie cookie1 = new Cookie();
            // 1.2.2
            cookie1.Is_There_Glooten = true;
            cookie1.Number_Of_Eggs = 5;
            cookie1.Number_Of_Suger = 10;
            cookie1.Amount_Of_Flower = 400;

            Console.WriteLine(PrintCookie(cookie1)); // 1.2.5

            // 1.2.1
            Cookie cookie2 = new Cookie(); 
            // 1.2.3
            cookie2.Is_There_Glooten = false;
            cookie2.Number_Of_Eggs = 8;
            cookie2.Number_Of_Suger = 14;
            cookie2.Amount_Of_Flower = 950;


            Console.WriteLine(PrintCookie(cookie2)); //1.2.5


            //1.2.6

            cookie2.Number_Of_Suger = 23;

            Console.WriteLine(PrintCookie(cookie1)); // 1.2.7

            Console.WriteLine(PrintCookie(cookie2)); // 1.2.7

            cookie2 = cookie1; // 1.2.8

            cookie2.Number_Of_Eggs = 13; // 1.2.9

            Console.WriteLine(PrintCookie(cookie1)); //1.2.10

            Console.WriteLine(PrintCookie(cookie2)); //1.2.10 



            Car car1 = new Car(); //2.1

            car1.Current_Car_Speed = 90;

            Console.WriteLine(PrintCarData(car1)); //2.2

            Console.WriteLine($"in how much you want that car1 will encrease it's speed"); // 2.3

            int increase_speed = Convert.ToInt32 (Console.ReadLine());

            car1.Current_Car_Speed += increase_speed; // 2.4

            Console.WriteLine($"now the new speed of the car1 after the increasing is "  + car1.Current_Car_Speed +"\n");


            car1.Speeddown_By_one(car1);

            car1.Speeddown_By_one(car1); // after finishing 2.5

            Console.WriteLine($"now thw new speed of the car1 after dicreasing it's speed by two is " + car1.Current_Car_Speed  ); // 2.6 

            car1.stop(car1); // 2.7 


            Console.WriteLine($"and after car1 will decide to stop it's speed will be equals to " + car1.stop(car1)); // 2.7 









                










            //Car c1 = new Car();
            // we cannot access c1.numOfwheels aside from the main program because it's private 
            // Console.WriteLine($"NumOfWheels: {c1.NumofWheels}");

            // Console.WriteLine($"NumOfWheels: {c1.NumofWheels}");

            Console.ReadKey();
        }

        public static string PrintCookie(Cookie c) // 1.2.4
        {
            string res1 = $"cookie data\n";
            res1 += $"Gloten: {c.Is_There_Glooten}\n";
            res1 += $"NumOfEggs: {c.Number_Of_Eggs}\n";
            res1 += $"NumOfSuger: {c.Number_Of_Suger}\n";
            res1 += $"AmountOfFlower: {c.Amount_Of_Flower}\n";

            return res1;

        }


        public static string PrintCarData(Car c)
        {
            string res2 = $"car one data\n";
            res2 += $"current speed: {c.Current_Car_Speed}\n";

            return res2; 

        }   


       




    }
}
