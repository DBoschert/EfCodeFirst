using EfCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;
        public int OrderId { get; set; }
        [JasonIgnore]
        public virtual Order? Order { get; set; }
        public int ItemId { get; set; }
        public virtual Item? Item { get; set; }


    }
}
