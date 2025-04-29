using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCounterFinalProject.Classes
{
    public class Item
    {
        public int Item_ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public Item() { }
        public Item(string name, int price, string image, int item_ID, int quantity)
        {
            Name = name;
            Price = price;
            Image = image;
            Item_ID = item_ID;
            Quantity = quantity;

        }
    }
}
