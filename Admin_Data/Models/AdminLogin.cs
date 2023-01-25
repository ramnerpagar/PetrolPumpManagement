using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin_Data.Models
{
    [Table("tblSecure")]
    public class AdminLogin
    {
        [Key]
        public string tblUsername { get; set; }
        public string tblPassword { get; set; }
    }
}
