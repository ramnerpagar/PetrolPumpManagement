using Microsoft.AspNetCore.Mvc;
using Reports_Data.DBContext;
using Reports_Data.Models;
using Reports_Data.Repositories.Interfaces;
using Sales_Data.Models;
using Staff_Data.Models;

namespace Reports_Data.Repositories
{
    public class StaffSalaryRepositoy : IStaffSalaryRepositoy
    {
        private readonly StaffSalaryDBContext staffSalaryDBContext1;
        public StaffSalaryRepositoy(StaffSalaryDBContext staffSalaryDBContext) 
        { 
            this.staffSalaryDBContext1 = staffSalaryDBContext;
        }

        
        public IEnumerable<Object> CalculateSalary(DateTime date1, DateTime date2)
        {
            try
            {
                List<Dump_Data> dump_data= new List<Dump_Data>();
                if(date1>date2)
                {
                    return null;
                }
                
                var staff_data = staffSalaryDBContext1.Staff_Data.ToList();
                int intOffA = 4, intSalesTarget = 20, intSalesPresent = 20, dblSalesBonus1 = 5000, dblSalesBonus2 = 1400, dblSalesBonus3 = 0;
                foreach (Staff s in staff_data)
                {
                    int intP = 0;
                    int intA = 0;
                    int intOff = 0 ;
                    int intTargetCount = 0;
                    int dblBonus = 0;
                    double dblSalary = 0;
                    float pmsSales = 0;
                    var sales_data = staffSalaryDBContext1.Sales_Data.Where(sa => sa.tblStaffID == s.tblStaffID && DateTime.Compare(sa.tblDate.Date, date1.Date) >= 0 && DateTime.Compare(sa.tblDate.Date, date2.Date) <= 0).ToList();
                    foreach(SalesRecord salesRecord in sales_data)
                    {
                        if (salesRecord.tblAttendance == "Present")
                            intP += 1;
                        else if(salesRecord.tblAttendance == "Absent")
                            intA += 1;
                        else if(salesRecord.tblAttendance == "Off")
                            intOff+= 1;

                        if (salesRecord.tblTarget != 0)
                            intTargetCount++;
                        dblSalary += salesRecord.tblTarget + Convert.ToDouble(salesRecord.tblIncentive);

                        if ((intOff + intA <= intOffA) && (intTargetCount >= intSalesTarget) && (intP >= intSalesPresent))
                            dblBonus = dblSalesBonus1;
                        else if (((intOff + intA <= 4) && (intTargetCount <= 20) && (intP >= 20)))
                            dblBonus = dblSalesBonus2;
                        else if ((intOff + intA <= 4) && (intTargetCount <= 20) && (intP <= 20))
                            dblBonus = dblSalesBonus3;

                        dblSalary += dblBonus;
                        pmsSales = (float)salesRecord.tblshiftLitres;
                    }
                    Dump_Data dump_Data = new Dump_Data();
                    dump_Data.tblStaffID = s.tblStaffID;
                    dump_Data.tblStaffName = s.tblFirstName + s.tblSurname;
                    dump_Data.tblPresent = intP;
                    dump_Data.tblAbsent = intA;
                    dump_Data.tblOff = intOff;
                    dump_Data.tblTarget = intTargetCount;
                    dump_Data.tblBonus = dblBonus;
                    dump_Data.tblSalary = (float)dblSalary;
                    dump_Data.tblsales = pmsSales;

                    dump_data.Add(dump_Data);
                }
                foreach(Dump_Data dump_data1 in dump_data)
                {
                    Console.WriteLine(dump_data1);
                }
                return dump_data;
            }
            catch 
            {
                throw null;
            }

            
        }
    }
}
