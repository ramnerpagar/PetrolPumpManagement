using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_Data.Models
{
    [Table("tblProductType")]
    public class Product
    {
        [Key]
        public string tblProductType { get; set; }

        public double tblCost { get; set; }
    }
}
