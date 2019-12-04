using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clXPos.DataModel
{
    [Table("MstOrderHeader")]
    public class OrderHeader : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required, StringLength(15)]
        public string Reference{ get; set; }
        public decimal Amount { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
