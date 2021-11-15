using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesTest
{
    public class EnemyInventory
    {
        Random random = new Random();
        private string[] strItems = { "Potion", "Bomb", "Elixir" };
        private int[] intQuantity = { 1, 2, 1 };

        public EnemyInventory() { }


        public string RandomItem()
        {
            int intItem = random.Next(3);

            if (intQuantity[0] == 0 && intQuantity[1] == 0 && intQuantity[2] == 0)
            {
                return "nomoreitems";
            }
            else if (intQuantity[intItem] <= 0)
            {
                return "";
            }

            else
            {
                intQuantity[intItem] -= 1;
                return strItems[intItem];
            }

        }
    }
}

