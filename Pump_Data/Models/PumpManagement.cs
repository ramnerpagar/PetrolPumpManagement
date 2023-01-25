using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pump_Data.Models
{
    [Table("tblPumpType")]
    public class PumpManagement
    {
        [Key]
        public short tblPumpID { get; set; }
        public string tblPumpType { get; set; }
        public double tblLastReading { get; set; }
        public double tblResetValue { get; set; }
    }
}
