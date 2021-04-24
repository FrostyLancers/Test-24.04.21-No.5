using System;

namespace Test_24._04._21_No._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int Breakfast = 5;
            int Weekend = 2;
            int Coffee = 3;
            string Foodset = Console.ReadLine();

            while ((Foodset == "Breakfast Set" && time > 11) || (Foodset == "Weekend Set" && days >= 1 && days <= 5))
            {
                Console.WriteLine("Sorry your order is not available.");
                Foodset = Console.ReadLine();
            }
            while ((Breakfast > 0 || Weekend > 0 || Coffee > 0) && Foodset != "End")
            {
                switch (Foodset)
                {
                    case "Breakfast Set":
                        Breakfast--;
                        if (Breakfast < 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock.");
                        }
                        Foodset = Console.ReadLine();
                        break;
                    case "Weekend Set":
                        Weekend--;
                        if (Weekend < 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock.");
                        }
                        Foodset = Console.ReadLine();
                        break;
                    case "Coffee":
                        Coffee--;
                        if (Coffee < 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock.");
                        }
                        Foodset = Console.ReadLine();
                        break;
                }
            }
            
        }
    }
}
