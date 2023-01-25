using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports_Data.Models
{
    [Table("tblDump")]
    [Keyless]
    public class Dump_Data
    {
        
        public string tblStaffID { get; set; }
        public string tblStaffName { get; set; }
        public int tblPresent { get; set; }
        public int tblAbsent { get; set; }
        public int tblOff { get; set; }
        public float tblTarget { get; set; }
        public float tblBonus { get; set; }
        public float tblSalary { get; set; }
        public float tblsales { get; set; }
    }
}
