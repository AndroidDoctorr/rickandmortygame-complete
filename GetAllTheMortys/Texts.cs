using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllTheMortys
{
    public class Texts
    {
        public static Dictionary<string, string> Splashes = new Dictionary<string, string>
        {
            {
                "garage", "\n\n\n\n\nYou're in the garage. You accidentally killed Morty.\n" +
                    "In order to construct a passable facsimile, you must collect " +
                    "enough Mortys from other dimensions to assemble froom them " +
                    "Morty's genetic structure and connectome.\n\n" +
                    "Obvious exits are DRIVEWAY and HOUSE\n"
            },
            {
                "driveway", "\n\n\n\n\nYou're in the driveway. The car is gone but " +
                    "the oil stain is still there.\n\n" +
                    "Obvious exits are GARAGE and YARD\n"
            },
            {
                "house", "\n\n\n\n\nYou're in the house now. It's drab and smells like " +
                    "lemon pine-sol with a hint of stale fart.\n\n" +
                    "Obvious exits are GARAGE and KITCHEN\n"
            },
        };
    }
}
