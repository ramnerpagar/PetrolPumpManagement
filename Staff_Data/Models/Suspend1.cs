using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Staff_Data.Models
{
    [Table("tblSuspend1")]
    public class Suspend1
    {
        [Key]
        public string tblStaffID { get; set; }
        public bool tblCaptaincy { get; set; }
        public string tblSurname { get; set; }
        public string tblFirstName { get; set; }
        public string tblSex { get; set; }
        public short tblAge { get; set; }
        public string tblAddress { get; set; }
        public string tblPhoneNo { get; set; }
        public string tblNextofKin { get; set; }
        public string tblNOKAddress { get; set; }
        public string tblNOKPhone { get; set; }
        public string tblStaffGuarantor { get; set; }
        public string tblStaffGuarantorPhone { get; set; }
        public string tblStaffGuarantorAddress { get; set; }
    }
}
