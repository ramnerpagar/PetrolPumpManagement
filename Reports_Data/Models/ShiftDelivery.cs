namespace Reports_Data.Models
{
    public class ShiftDelivery
    {
        public int tblShiftPump { get; set; }
        public string tblStaffID { get; set; }
        public string tblShift { get; set; }
        public double tblInitialLitres { get; set; }
        public double tblFinalLitres { get; set; }
        public double tblWasteLitres { get; set; }
        public double tblshiftLitres { get; set; }
        public decimal tblUnitCost { get; set; }
        public decimal tblTotalCost { get; set; }
        public DateTime tblDate { get; set; }
        public string tblStaffName { get; set; }
        public string tblReturn { get; set; }
    }
}
