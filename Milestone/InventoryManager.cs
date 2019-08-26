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
        //Views selected order
        public List<Inventory> ViewOrder(String order)
        {
            List<Inventory> previousOrders = new List<Inventory>();
            String path = "../../Orders/" + order + ".txt";
            try
            {
                String[] input = File.ReadAllLines(path);
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

                    Inventory product = new Inventory(id, name, model, stock, price, size, rez, picture);
                    previousOrders.Add(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return previousOrders;
        }

        //Returns a list of all previous orders (by name)
        public List<String> ViewAllOrders()
        {
            List<String> allOrders = new List<String>();
            try
            {
                String[] input = File.ReadAllLines("../../Orders/PreviousOrders.txt");

                foreach (String order in input)
                {
                    allOrders.Add(order);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return allOrders;
        }

        //Saves order to be viewed later
        public void SaveOrder(List<Inventory> order)
        {
            DateTime dt = DateTime.Now;
            String orderDateTime = dt.ToString("M-d_hhmmss");
            if (order.Count > 1)
            {
                try
                {
                    StreamWriter output;
                    output = File.AppendText("../../Orders/PreviousOrders.txt");
                    
                    output.WriteLine("Order_{0}", orderDateTime);
                    output.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    String fileName = "../../Orders/Order_" + orderDateTime + ".txt";
                    if (!File.Exists(fileName))
                    {
                        StreamWriter output;
                        output = File.CreateText(fileName);

                        for (int x = 0; x < order.Count; x++)
                        {
                            String id = order[x].Id.ToString();
                            String name = order[x].Name;
                            String model = order[x].Model;
                            String stock = order[x].Stock.ToString();
                            String price = order[x].Price.ToString();
                            String size = order[x].Size.ToString();
                            String rez = order[x].Resolution;
                            String pic = order[x].Picture;

                            String[] productArray = { id, name, model, stock, price, size, rez, pic };
                            String product = string.Join(",", productArray);

                            output.WriteLine(product);
                        }
                        output.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

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

        //creates a list of inventory
        public static List<Inventory> LoadList()
        {
            List<Inventory> invList = new List<Inventory>();
            Inventory[] inv = Load();
            foreach(Inventory item in inv)
            {
                invList.Add(item);
            }
            return invList;
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
        public List<Inventory> Remove(List<Inventory> inv, int index)
        {
            int size = inv.Count;
            List<Inventory> inv2 = new List<Inventory>();
            int x = 0;

            while (x < index)
            {
                inv2.Add(inv[x]);
                x++;
            }
            while (index < size - 1)
            {
                inv2.Add(inv[index + 1]);
                index++;
            }
            return inv2;
        }

        public List<Inventory> AddToList(List<Inventory> inv, Inventory product)
        {
            inv.Add(product);
            inv.Sort();
            return inv;
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
        public void Save(List<Inventory> inv)
        {
            var invArray = inv.ToArray();
            Array.Sort(invArray);
            try
            {
                File.WriteAllText("../../inventory.txt", string.Empty);
                StreamWriter output;
                output = File.AppendText("../../inventory.txt");

                for (int x = 0; x < invArray.Length; x++)
                {
                    String id = invArray[x].Id.ToString();
                    String name = invArray[x].Name;
                    String model = invArray[x].Model;
                    String stock = invArray[x].Stock.ToString();
                    String price = invArray[x].Price.ToString();
                    String size = invArray[x].Size.ToString();
                    String rez = invArray[x].Resolution;
                    String pic = invArray[x].Picture;

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
