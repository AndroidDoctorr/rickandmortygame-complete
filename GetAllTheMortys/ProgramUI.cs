using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllTheMortys
{
    public class ProgramUI
    {
        public enum Item { plumbus, meeseeks };

        public List<Item> inventory = new List<Item>();
        public static Room garage = new Room(
            Texts.Splashes["garage"],
            new List<string> { "driveway", "house" },
            new List<Item> { Item.meeseeks, Item.plumbus }
        );
        public static Room driveway = new Room(
            Texts.Splashes["driveway"],
            new List<string> {  },
            new List<Item> {  }
        );
        public static Room house = new Room(
            Texts.Splashes["house"],
            new List<string> {  },
            new List<Item> {  }
        );

        public Dictionary<string, Room> RoomDictionary = new Dictionary<string, Room>
        {
            { "garage", garage },
            { "driveway", driveway },
            { "house", house },
        };
        public void Run()
        {
            Room room = garage;
            bool alive = true;
            Console.Clear();
            while (alive)
            {
                Console.WriteLine(room.Splash);
                string command = Console.ReadLine().ToLower();
                Console.Clear();
                if (command.StartsWith("go ") || command.StartsWith("exit"))
                {
                    bool foundExit = false;
                    foreach (string exit in room.Exits)
                    {
                        if (!foundExit && command.Contains(exit))
                        {
                            room = RoomDictionary[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if (!foundExit)
                    {
                        Console.WriteLine("Uh... Go where?");
                    }
                } else if (command.StartsWith("get ") || command.StartsWith("take ") || command.StartsWith("grab "))
                {
                    bool foundItem = false;
                    foreach (Item item in room.Items)
                    {
                        if (!foundItem && command.Contains(item.ToString()))
                        {
                            room = RoomDictionary[item.ToString()];
                            foundItem = true;
                            break;
                        }
                    }
                    if (!foundItem)
                    {
                        Console.WriteLine("I don't know what you're talking about.");
                    }
                }
                else if (command.StartsWith("look ") || command.StartsWith("check "))
                {
                    Console.WriteLine("It looks fine.");
                }
                else if (command.StartsWith("use ") || command.StartsWith("activate "))
                {
                    Console.WriteLine("I doubt you know how.");
                }
                else
                {
                    Console.WriteLine("*BUUUUURP* What?");
                }
            }
        }
    }
}
