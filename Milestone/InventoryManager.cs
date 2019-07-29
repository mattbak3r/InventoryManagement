using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milestone
{
    class InventoryManager
    {
        public Inventory[] Load()
        {
            try
            {
                String[] input = File.ReadAllLines("inventory.txt");
                int arrayLength = input.Length;
                Inventory[] inv = new Inventory[arrayLength];

                for (int x = 0; x < input.Length; x++)
                {
                    String[] splitInput = input[x].Split(',');
                    int id = int.Parse(splitInput[0]);
                    String name = splitInput[1];
                    String model = splitInput[2];
                    int stock = int.Parse(splitInput[3]);
                    double price = double.Parse(splitInput[4]);
                    double size = double.Parse(splitInput[5]);
                    String rez = splitInput[6];

                    inv[x] = new Inventory(id, name, model, stock, price, size, rez);
                }
                return inv;
            } catch (Exception) {
                return null;
            }
        }
    }
}
