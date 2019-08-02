using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milestone
{
    public class Inventory : IComparable<Inventory>
    {
        private int id;
        private String name;
        private int stock;
        private double price;
        private double size;
        private String resolution;
        private String model;
        private String picture;

        public Inventory(int aID, String aName, String aModel, int aStock, double aPrice, double aSize, String aResolution, String aPicture)
        {
            id = aID;
            name = aName;
            model = aModel;
            stock = aStock;
            price = aPrice;
            size = aSize;
            resolution = aResolution;
            picture = aPicture;
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

        public String Model
        {
            get { return model; }
            set { model = value; }
        }


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

        public String Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public int CompareTo(Inventory obj)
        {
            return this.id.CompareTo(obj.id);
        }
    }
}
