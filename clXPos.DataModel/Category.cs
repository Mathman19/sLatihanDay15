using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clXPos.DataModel
{
    [Table("MstCategory")]
    public class Category : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required, StringLength(10)]
        public string Initial { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Variant> Variants { get; set; }
    }
}
