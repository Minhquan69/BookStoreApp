using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCounterFinalProject.Classes
{
    public class SelectedItem
    {
        public string SelectedItem_ID { get; set; }
        public int NumberOfSelectedItem { get; set; }
        public decimal PriceAfterDiscount { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Itemname { get; set; }
        public decimal TotalAmount { get; set; }

        public SelectedItem()
        {
            
        }
        public SelectedItem(string electedItem_ID, int numberOfSelectedItem, decimal priceAfterDiscount, string image, decimal totalAmount, string itemname, int price)
        {
            SelectedItem_ID = electedItem_ID;
            NumberOfSelectedItem = numberOfSelectedItem;
            PriceAfterDiscount = priceAfterDiscount;
            Image = image;
            TotalAmount = totalAmount;
            Itemname = itemname;
            Price = price;
        }
    }
}
