using Microsoft.AspNetCore.Mvc;
using Staff_Data.Controllers;
using Staff_Data.DataContext;
using Staff_Data.Models;
using Staff_Data.Repositories.Interfaces;

namespace Staff_Data.Repositories
{
    public class SeniorStaffRepository : ISeniorStaffRepository
    {
        private readonly StaffDBContext dbContext;
        public SeniorStaffRepository(StaffDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public IEnumerable<SeniorStaff> GetStaff()
        {
            try
            {
                return dbContext.SeniorStaff_Data.ToList();
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public SeniorStaff AddStaff(SeniorStaff seniorStaff)
        {
            try
            {
                dbContext.SeniorStaff_Data.Add(seniorStaff);
                dbContext.SaveChanges();

                return seniorStaff;
            }
            catch
            {
                throw null;
            }
        }

        public Boolean UpdateStaff(SeniorStaff seniorStaff)
        {
            try
            {
                var NewStaff = dbContext.SeniorStaff_Data.Find(seniorStaff.tblStaffID);
                if (NewStaff != null)
                {
                    NewStaff.tblCaptaincy = seniorStaff.tblCaptaincy;
                    NewStaff.tblSurname = seniorStaff.tblSurname;
                    NewStaff.tblFirstName = seniorStaff.tblFirstName;
                    NewStaff.tblSex = seniorStaff.tblSex;
                    NewStaff.tblAge = seniorStaff.tblAge;
                    NewStaff.tblAddress = seniorStaff.tblAddress;
                    NewStaff.tblPhoneNo = seniorStaff.tblPhoneNo;
                    NewStaff.tblNextofKin = seniorStaff.tblNextofKin;
                    NewStaff.tblNOKAddress = seniorStaff.tblNOKAddress;
                    NewStaff.tblNOKPhone = seniorStaff.tblNOKPhone;
                    NewStaff.tblStaffGuarantor = seniorStaff.tblStaffGuarantorPhone;
                    NewStaff.tblStaffGuarantorPhone = seniorStaff.tblStaffGuarantorPhone;
                    NewStaff.tblStaffGuarantorAddress = seniorStaff.tblStaffGuarantorAddress;

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
                var staff = dbContext.SeniorStaff_Data.Find(id);
                if (staff == null)
                {
                    return false;
                }

                Retrench1 retrench = new Retrench1();
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

                dbContext.Retrench1_Data.Add(retrench);
                dbContext.SeniorStaff_Data.Remove(staff);
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
                var staff = dbContext.SeniorStaff_Data.Find(id);
                if (staff == null)
                {
                    return false;
                }

                Suspend1 suspend = new Suspend1();
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

                dbContext.Suspend1_Data.Add(suspend);
                dbContext.SeniorStaff_Data.Remove(staff);
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
                var recall = dbContext.Retrench1_Data.Find(id);
                if (recall == null)
                {
                    return false;
                }

                SeniorStaff staff = new SeniorStaff();
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

                dbContext.SeniorStaff_Data.Add(staff);
                dbContext.Retrench1_Data.Remove(recall);
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
                var suspend = dbContext.Suspend1_Data.Find(id);
                if (suspend == null)
                {
                    return false;
                }

                SeniorStaff staff = new SeniorStaff();
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

                dbContext.SeniorStaff_Data.Add(staff);
                dbContext.Suspend1_Data.Remove(suspend);
                dbContext.SaveChanges();

                return true;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public IEnumerable<Suspend1> GetSuspendedStaff()
        {
            try
            {
                return dbContext.Suspend1_Data.ToList();
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public IEnumerable<Retrench1> GetRetrenchedStaff()
        {
            try
            {
                return dbContext.Retrench1_Data.ToList();
            }
            catch
            {
                //left for logging
                throw null;
            }
        }
    }
}
