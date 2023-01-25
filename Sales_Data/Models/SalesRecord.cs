using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales_Data.Models
{
    [Table("tblSalesRecord")]
    public class SalesRecord
    {
        [Key]
        public DateTime tblDate { get; set; }
        public string tblStaffID { get; set; }
        public string tblAttendance { get; set; }
        public string tblShift { get; set; }
        public int tblShiftPump { get; set; }
        public double tblshiftLitres { get; set; }
        public double tblTarget { get; set; }
        public decimal tblIncentive { get; set; }
        public decimal tblAmount { get; set; }
    }
}
