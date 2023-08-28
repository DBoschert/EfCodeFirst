using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        [StringLength(30)]
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = 0;
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } = null;

        public virtual ICollection<OrderLine> OrderLines { get; set; }

    }
}
