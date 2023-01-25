using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Sales_Data.DataContext;
using Sales_Data.Models;
using Sales_Data.Repositories.Interfaces;

namespace Sales_Data.Repositories
{
    public class StaffAttaindanceRepository : IStaffAttaindanceRepository
    {
        private readonly SalesDBContext salesDBContext;

        public StaffAttaindanceRepository(SalesDBContext salesDBContext)
        {
            this.salesDBContext = salesDBContext;
        }

        public SalesRecord GetStaffEntry(string tblStaffId, DateTime tblDate)
        {
            try
            {
                var newData = salesDBContext.Sales_Data.Where(s => s.tblStaffID == tblStaffId && DateTime.Compare(s.tblDate.Date, tblDate.Date) == 0).FirstOrDefault();
                if (newData == null)
                {
                    return new SalesRecord();
                }
                Console.WriteLine(newData);
                return newData;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean RemoveStaffEntry(string tblStaffId, DateTime tblDate)
        {
            try
            {
                var data = salesDBContext.Sales_Data.Where(s => s.tblStaffID == tblStaffId && DateTime.Compare(s.tblDate.Date, tblDate.Date) == 0).FirstOrDefault();
                if (data == null)
                {
                    return false;
                }
                salesDBContext.Remove(data);
                salesDBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
