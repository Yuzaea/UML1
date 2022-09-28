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

            Console.ReadLine();


            string filePAth = @"C:\Temp\CostumerList.txt";

            List<string> liness = File.ReadAllLines(filePAth).ToList();

            liness.Add("1, Sure, your, mom ");

            File.WriteAllLines(filePAth, liness);

            foreach (string line in liness)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();


        }



    }


}


