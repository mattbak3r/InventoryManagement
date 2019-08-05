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
        //Loads inventory into an Array (later needs to be changed to List)
        public static Inventory[] Load()
        {
            try
            {
                String[] input = File.ReadAllLines("../../inventory.txt");
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
                    String picture = splitInput[7];

                    inv[x] = new Inventory(id, name, model, stock, price, size, rez, picture);
                }
                return inv;
            } catch (Exception) {
                return null;
            }
        }

        //Adds removed product to a removedProduct.txt file
        public void Remove(Inventory product)
        {
            try
            {
                String id = product.Id.ToString();
                String name = product.Name;
                String model = product.Model;
                String stock = product.Stock.ToString();
                String price = product.Price.ToString();
                String size = product.Size.ToString();
                String rez = product.Resolution;
                String pic = product.Picture;

                String[] removedProductArray = { id, name, model, stock, price, size, rez, pic };
                String removedProduct = string.Join(",", removedProductArray);

                StreamWriter output;
                output = File.AppendText("../../removedInventory.txt");

                output.WriteLine(removedProduct);
                output.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Removes the product from the inventory array by creating a new array with -1 spots
        //Loading new array with old spots up to index, then loads next to end (skipping entered index)
        public Inventory[] Remove(Inventory[] inv, int index)
        {
            int size = inv.Length;
            Inventory[] inv2 = new Inventory[size - 1];
            int x = 0;

            while (x < index)
            {
                inv2[x] = inv[x];
                x++;
            }
            while (index < size - 1)
            {
                inv2[index] = inv[index + 1];
                index++;
            }
            return inv2;
        }

        //Creates a new array with +1 items, copies old array to new array and adds new product to extra slot to be returned
        public Inventory[] Add(Inventory[] inv, Inventory product)
        {
            int size = inv.Length;
            Inventory[] inv2 = new Inventory[size + 1];
            int x = 0;

            while (x < size)
            {
                inv2[x] = inv[x];
                x++;
            }
            inv2[size] = product;
            return inv2;
        }

        //Saves Inventory array to inventory.txt file, after sorting it by id number (lowest to highest)
        public void Save(Inventory[] inv)
        {
            Array.Sort(inv);
            try
            {
                File.WriteAllText("../../inventory.txt", string.Empty);
                StreamWriter output;
                output = File.AppendText("../../inventory.txt");

                for (int x = 0; x < inv.Length; x++)
                {
                    String id = inv[x].Id.ToString();
                    String name = inv[x].Name;
                    String model = inv[x].Model;
                    String stock = inv[x].Stock.ToString();
                    String price = inv[x].Price.ToString();
                    String size = inv[x].Size.ToString();
                    String rez = inv[x].Resolution;
                    String pic = inv[x].Picture;

                    String[] productArray = { id, name, model, stock, price, size, rez, pic };
                    String product = string.Join(",", productArray);

                    output.WriteLine(product);
                }
                output.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
