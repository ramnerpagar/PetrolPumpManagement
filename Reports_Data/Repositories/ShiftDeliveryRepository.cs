using Reports_Data.DBContext;
using Reports_Data.Models;
using Reports_Data.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Reports_Data.Repositories
{
    public class ShiftDeliveryRepository : IShiftDeliveryRepository
    {
        private readonly StaffSalaryDBContext staffSalaryDBContext1;
        public ShiftDeliveryRepository(StaffSalaryDBContext staffSalaryDBContext)
        {
            this.staffSalaryDBContext1 = staffSalaryDBContext;
        }

        public IEnumerable<Object> ShiftDeliveryData(string shift, DateTime date1)
        {
            try
            {
                if (shift == "Both Shifts")
                {
                    var data = (from s in staffSalaryDBContext1.Sales_Data
                                join p in staffSalaryDBContext1.pump_data on s.tblShiftPump equals p.tblPumpID
                                join st in staffSalaryDBContext1.Staff_Data on s.tblStaffID equals st.tblStaffID
                                where s.tblDate == date1
                                select new
                                {
                                    tblShiftPump = s.tblShiftPump,
                                    tblShift = s.tblShift,
                                    tblInitialLitres = p.tblInitialLitres,
                                    tblFinalLitres = p.tblFinalLitres,
                                    tblWasteLitres = p.tblWasteLitres,
                                    tblshiftLitres = s.tblshiftLitres,
                                    tblUnitCost = p.tblUnitCost,
                                    tblTotalCost = p.tblTotalCost,
                                    tblSalesRecord_tblDate = s.tblDate,
                                    tblSalesRecord_tblStaffID = s.tblStaffID,
                                    tblStaffName = p.tblStaffName,
                                    tblReturn = p.tblReturn
                                }).ToList();
                    Console.WriteLine(data);
                    return data;
                    
                }

                else
                {
                var data = (from s in staffSalaryDBContext1.Sales_Data
                            join p in staffSalaryDBContext1.pump_data on s.tblShiftPump equals p.tblPumpID
                            where s.tblShift == shift && s.tblDate == date1
                            join st in staffSalaryDBContext1.Staff_Data on s.tblStaffID equals st.tblStaffID
                            select p).ToList();
                    Console.WriteLine(data);
                    return data;
                }

            }
            catch
            {
                throw null;
            }
        }
    }
}
