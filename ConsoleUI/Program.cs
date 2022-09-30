using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Temp\PizzaList.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("1, Sure, your, mom ");
            //File.WriteAllLines(filePath, lines);


            List<Pizza> puzza = new List<Pizza>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(",");
                Pizza newPizza = new Pizza();
                newPizza.Number = entries[0];
                newPizza.Name = entries[1];
                newPizza.Price = entries[2];
                newPizza.Ingredients = entries[3];

                puzza.Add(newPizza);

            }

            foreach (var pizza in puzza)
            {
                Console.WriteLine($"{pizza.Number}{pizza.Name}{pizza.Price}{pizza.Ingredients}");
            }
            //new List<string> { "P1","P2","P3","P4","P5","P6","P7","P8","P9","P10","P11","P12" };

            Console.ReadLine();


            string filePAth = @"C:\Temp\CostumerList.txt";

            List<string> liness = File.ReadAllLines(filePAth).ToList();

            liness.Add("");

            File.WriteAllLines(filePAth, liness);

            foreach (string line in liness)
            {
                Console.WriteLine(line);
            }
            //Console.WriteLine();

            bool confirmed = false;
            string key;
            string Password;
            string Email;
            int TotalPrice = 0;





            while (true)
            {
                int Price;
                string z = "no";
                Console.Write("Hello");
                Console.Write("\nWhat do you want to order?");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nWhat's your E-Mail ? ");


                if (i == 1)
                {
                    Price = 70;
                    Console.Write("\nHow many do you want? ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Price = Calculator.Mult(Price, n);



                    TotalPrice = Calculator.Add(Price, TotalPrice);
                    Console.Write("Please create a password");
                    Password = Console.ReadLine();
                }
                else if (i == 2) { }
                else if (i == 3) { }
                else if (i == 4) { }
                else if (i == 5) { }
                else if (i == 6) { }
                else if (i == 7) { }
                else if (i == 8) { }
                else if (i == 9) { }
                else if (i == 10) { }
                else if (i == 11) { }
                else if (i == 12) { }


                Console.Write("Please create a password");
                Password = Console.ReadLine();
                z = Console.ReadLine();

                Console.WriteLine(TotalPrice);

                if (z == "no")
                    break;
            }







            //int myResult = Calculator.Add(10, 15);
            //Console.WriteLine($"Adding 10 + 25 = {myResult}");
            //Console.WriteLine($"Subtracting 10 - 25 = {Calculator.Subtract(10, 25)}");








        }



    }


}


