using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales_Data.Models
{
    [Table("tblPumpRecord")]
    public class PumpRecord
    {
        [Key]
        public int tblPumpID { get; set; }
        public DateTime tblDate { get; set; }
        public string tblShift { get; set; }
        public string tblStaffId { get; set; }
        public double tblInitialLitres { get; set; }
        public double tblFinalLitres { get; set; }
        public double tblWasteLitres { get; set; }
        public int tblLitresSold { get; set; }
        public decimal tblUnitCost { get; set; }
        public decimal tblTotalCost { get; set; }
        public string tblReturn { get; set; }
        public string tblStaffName { get; set; }
    }
}
