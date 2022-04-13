using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListvol2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Priit\source\samples\ShoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to a shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter what you would like to add to the list:");
                    string userShopping = Console.ReadLine();
                    myShoppingList.Add(userShopping);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();

            foreach (string list in myShoppingList)
            {
                Console.WriteLine($"In youre list: {list}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
