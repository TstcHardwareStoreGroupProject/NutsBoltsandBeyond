using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutsBoltsAndBeyond.Models
{
    public class TransactionModel
    {
        public TransactionModel() { }
        public int TRANSACTION_ID { get; set; }
        public String Username { get; set; }
        public int ITEM_ID { get; set; }
        public Decimal Total { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
