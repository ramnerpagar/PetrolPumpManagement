using Microsoft.AspNetCore.Mvc;
using Staff_Data.DataContext;
using Staff_Data.Models;

namespace Staff_Data.Repositories
{
    public class SecurityStaffRepository
    {
        private readonly StaffDBContext dbContext;
        public SecurityStaffRepository(StaffDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public IEnumerable<SecurityStaff> GetStaff()
        {
            try
            {
                return dbContext.Security_Data.ToList();
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public SecurityStaff AddStaff(SecurityStaff staff)
        {
            try
            {
                dbContext.Security_Data.Add(staff);
                dbContext.SaveChanges();

                return staff;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean UpdateStaff(SecurityStaff staff)
        {
            try
            {
                var NewStaff = dbContext.Security_Data.Find(staff.tblStaffID);
                Console.WriteLine(NewStaff);
                if (NewStaff != null)
                {
                    NewStaff.tblCaptaincy = staff.tblCaptaincy;
                    NewStaff.tblSurname = staff.tblSurname;
                    NewStaff.tblFirstName = staff.tblFirstName;
                    NewStaff.tblSex = staff.tblSex;
                    NewStaff.tblAge = staff.tblAge;
                    NewStaff.tblAddress = staff.tblAddress;
                    NewStaff.tblPhoneNo = staff.tblPhoneNo;
                    NewStaff.tblNextofKin = staff.tblNextofKin;
                    NewStaff.tblNOKAddress = staff.tblNOKAddress;
                    NewStaff.tblNOKPhone = staff.tblNOKPhone;
                    NewStaff.tblStaffGuarantor = staff.tblStaffGuarantorPhone;
                    NewStaff.tblStaffGuarantorPhone = staff.tblStaffGuarantorPhone;
                    NewStaff.tblStaffGuarantorAddress = staff.tblStaffGuarantorAddress;

                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean RetrenchStaff(string id)
        {
            try
            {
                var staff = dbContext.Security_Data.Find(id);
                if (staff == null)
                {
                    return false;
                }

                Retrench2 retrench = new Retrench2();
                retrench.tblStaffID = staff.tblStaffID;
                retrench.tblCaptaincy = staff.tblCaptaincy;
                retrench.tblSurname = staff.tblSurname;
                retrench.tblFirstName = staff.tblFirstName;
                retrench.tblSex = staff.tblSex;
                retrench.tblAge = staff.tblAge;
                retrench.tblAddress = staff.tblAddress;
                retrench.tblPhoneNo = staff.tblPhoneNo;
                retrench.tblNextofKin = staff.tblNextofKin;
                retrench.tblNOKAddress = staff.tblNOKAddress;
                retrench.tblNOKPhone = staff.tblNOKPhone;
                retrench.tblStaffGuarantor = staff.tblStaffGuarantor;
                retrench.tblStaffGuarantorAddress = staff.tblStaffGuarantorAddress;
                retrench.tblStaffGuarantorPhone = staff.tblStaffGuarantorPhone;

                dbContext.Retrench2_Data.Add(retrench);
                dbContext.Security_Data.Remove(staff);
                dbContext.SaveChanges();

                return true;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean SuspendStaff([FromRoute] string id)
        {
            try
            {
                var staff = dbContext.Security_Data.Find(id);
                if (staff == null)
                {
                    return false;
                }

                Suspend2 suspend = new Suspend2();
                suspend.tblStaffID = staff.tblStaffID;
                suspend.tblCaptaincy = staff.tblCaptaincy;
                suspend.tblSurname = staff.tblSurname;
                suspend.tblFirstName = staff.tblFirstName;
                suspend.tblSex = staff.tblSex;
                suspend.tblAge = staff.tblAge;
                suspend.tblAddress = staff.tblAddress;
                suspend.tblPhoneNo = staff.tblPhoneNo;
                suspend.tblNextofKin = staff.tblNextofKin;
                suspend.tblNOKAddress = staff.tblNOKAddress;
                suspend.tblNOKPhone = staff.tblNOKPhone;
                suspend.tblStaffGuarantor = staff.tblStaffGuarantor;
                suspend.tblStaffGuarantorAddress = staff.tblStaffGuarantorAddress;
                suspend.tblStaffGuarantorPhone = staff.tblStaffGuarantorPhone;

                dbContext.Suspend2_Data.Add(suspend);
                dbContext.Security_Data.Remove(staff);
                dbContext.SaveChanges();

                return true;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean RecallRetrenchStaff(string id)
        {
            try
            {
                var recall = dbContext.Retrench2_Data.Find(id);
                if (recall == null)
                {
                    return false;
                }

                SecurityStaff staff = new SecurityStaff();
                staff.tblStaffID = recall.tblStaffID;
                staff.tblCaptaincy = recall.tblCaptaincy;
                staff.tblSurname = recall.tblSurname;
                staff.tblFirstName = recall.tblFirstName;
                staff.tblSex = recall.tblSex;
                staff.tblAge = recall.tblAge;
                staff.tblAddress = recall.tblAddress;
                staff.tblPhoneNo = recall.tblPhoneNo;
                staff.tblNextofKin = recall.tblNextofKin;
                staff.tblNOKAddress = recall.tblNOKAddress;
                staff.tblNOKPhone = recall.tblNOKPhone;
                staff.tblStaffGuarantor = recall.tblStaffGuarantor;
                staff.tblStaffGuarantorAddress = recall.tblStaffGuarantorAddress;
                staff.tblStaffGuarantorPhone = recall.tblStaffGuarantorPhone;

                dbContext.Security_Data.Add(staff);
                dbContext.Retrench2_Data.Remove(recall);
                dbContext.SaveChanges();

                return true;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean RecallSuspendStaff(string id)
        {
            try
            {
                var suspend = dbContext.Suspend2_Data.Find(id);
                if (suspend == null)
                {
                    return false;
                }

                SecurityStaff staff = new SecurityStaff();
                staff.tblStaffID = suspend.tblStaffID;
                staff.tblCaptaincy = suspend.tblCaptaincy;
                staff.tblSurname = suspend.tblSurname;
                staff.tblFirstName = suspend.tblFirstName;
                staff.tblSex = suspend.tblSex;
                staff.tblAge = suspend.tblAge;
                staff.tblAddress = suspend.tblAddress;
                staff.tblPhoneNo = suspend.tblPhoneNo;
                staff.tblNextofKin = suspend.tblNextofKin;
                staff.tblNOKAddress = suspend.tblNOKAddress;
                staff.tblNOKPhone = suspend.tblNOKPhone;
                staff.tblStaffGuarantor = suspend.tblStaffGuarantor;
                staff.tblStaffGuarantorAddress = suspend.tblStaffGuarantorAddress;
                staff.tblStaffGuarantorPhone = suspend.tblStaffGuarantorPhone;

                dbContext.Security_Data.Add(staff);
                dbContext.Suspend2_Data.Remove(suspend);
                dbContext.SaveChanges();

                return true;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public IEnumerable<Suspend2> GetSuspendedStaff()
        {
            try
            {
                return dbContext.Suspend2_Data.ToList();
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public IEnumerable<Retrench2> GetRetrenchedStaff()
        {
            try
            {
                return dbContext.Retrench2_Data.ToList();
            }
            catch
            {
                //left for logging
                throw null;
            }
        }
    }
}
