using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milestone
{
    class Inventory
    {
        private int id;
        private String name;
        private int stock;
        private double price;
        private double size;
        private String resolution;
        private String model;

       public Inventory(int aID, String aName, String aModel, int aStock, double aPrice, double aSize, String aResolution)
        {
            id = aID;
            name = aName;
            model = aModel;
            stock = aStock;
            price = aPrice;
            size = aSize;
            resolution = aResolution;
        }

        public override String ToString()
        {
            if (this.name.Length <= 14)
            {
                return id + "    "  + stock + " " + price + " " + size + " " + resolution + " " + name + " " + model ;
            }
            else
            {
                return id + "    " + name + " " + model + " " + stock + " " + price + " " + size + " " + resolution;
            }
            
        }

        public static Array getInventory()
        {
            //Inventory[] inv;
            List<Inventory> inventory = new List<Inventory>();
            String[] input = File.ReadAllLines("inventory.txt");
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

                inventory.Add(new Inventory(id, name, model, stock, price, size, rez));
            }
            Inventory[] inv = inventory.ToArray();
            return inv;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Model { get { return model; }set { model = value; } }


        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public String Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }
    }
}
