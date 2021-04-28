using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutsBoltsAndBeyond.Models
{
    public class ItemModel
    {
        public ItemModel() { }
        public int ITEM_ID { get; set; }
        public String Item_Name { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public String Department { get; set; }
    }
}
