using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrade.Domain.Models
{
    public class AssetTransaction : DomainObject
    {
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public Stock Stock { get; set; }
        public int Share { get; set; }
        public DateTime DateProcessed { get; set; }

    }
}
