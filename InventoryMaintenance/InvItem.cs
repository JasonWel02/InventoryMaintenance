using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    /*
     * Encapsulation allows us for the object in the clas, itemNo, description and price to only 
     * be accessed with either the constructor or the public getters and setters properties that are available
     * to either edit or read the object.
     */
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;
        public int ItemNo
        {
            get { return itemNo; }
            set { itemNo = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        /*
         * This constructor allows us to initalize and access the objects above
         * Example...
         * InvItem invItem = new InvItem();
         * invItem.ItemNo = 1;
         * invItem.Description = "This is the Description";
         * invItem.Price = 11.95;
         */
        public InvItem()
        {

        }
        /*
         * Signature: Jason Welsh
         * From this constructor this allows us to create a new object without having to initalize it
         * Ex.. InvItem invItem = new InvItem(11, "Test", 11.75) - Those values being part of the constructor below.
         */
        public InvItem(int itemNum, string descriptions, decimal prices)
        {
            ItemNo = itemNum;
            Description = descriptions;
            Price = prices;
        }
        /*
         * Signature: Jason Welsh
         */
        public String GetDisplayText(int itemNo, string desc, decimal price)
        {
            return itemNo + " " + desc+ " ($" + price + ")";
        }
    }
}
