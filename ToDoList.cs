namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ToDoList
    {
     
        internal static void Main(string[] args)
        {
            Console.WriteLine("MY TO DO LIST");
            Console.WriteLine(" Type A - to add a note \n Type D + # (corresponding to a node number) - to delete a note \n " +
                "Type S - to see your list \n Type Q - to quit");

            LinkedList<string> info = new LinkedList<string>();

            do
            {
                Console.Write("your selection: ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "q")
                {
                    if (info.Count >= 1)
                    {

                        if (userInput == "a")
                        {
                            Console.Write("Type your note: ");
                            string userInputNote = Console.ReadLine();
                            info.AddLast(userInputNote);

                        }
                        else if (userInput == "d")
                        {
                            Console.Write("Type NUMBER of item to delete: ");
                            string userInputDelete = Console.ReadLine();
                            int index = Int32.Parse(userInputDelete);
                            string toDelete = info.ElementAt(index - 1);
                            info.Remove(toDelete);



                        }
                        else if (userInput == "s")
                        {
                            int count = 0;
                            foreach (string str in info)
                            {
                                count++;
                                Console.WriteLine(count + " " + str);
                            }
                        }
                        else if (userInput == "q")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid symbol, please select \"A\" to create a list");
                        }
                    }
                    else
                    {
                        if (userInput == "a")
                        {
                            Console.Write("Type your note: ");
                            string userInputNote = Console.ReadLine();
                            info.AddLast(userInputNote);
                        }
                        else if (userInput == "d" || userInput == "s")
                        {
                            Console.WriteLine("You did not create a list yet to delete or save it!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid symbol, please select \"A\" to create a list");
                        }
                    }
                }
                else { break; }
            } while (true);

            Console.WriteLine("The End");
        }
    }
}
