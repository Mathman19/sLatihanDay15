using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clXPos.DataModel
{
    [Table("MstProduct")]
    public class Product : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long VariantId { get; set; }

        [Required, StringLength(10)]
        public string Initial { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }

        [ForeignKey("VariantId")]
        public virtual Variant Variant { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
