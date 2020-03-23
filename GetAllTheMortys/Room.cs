using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GetAllTheMortys.ProgramUI;

namespace GetAllTheMortys
{
    public class Room
    {
        public string Splash { get; }
        public List<string> Exits { get; }
        public List<Item> Items { get; }
        public Room(string splash, List<string> exits, List<Item> items)
        {
            Splash = splash;
            Items = items;
            Exits = exits;
        }
        public void AddExit(string newExit)
        {
            Exits.Add(newExit);
        }
    }
}
