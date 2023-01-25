using Admin_Data.DataContext;
using Admin_Data.Models;
using System.Text;
using System.Security.Cryptography;

namespace Admin_Data.Repositories
{
    public class AdminLoginRepository
    {
        AdminDBContext adminDBContext;

        public AdminLoginRepository(AdminDBContext adminDBContext)
        {
            this.adminDBContext = adminDBContext;
        }

        public Boolean AdminLogin(AdminLogin Details)
        {
            try
            {
                var data = adminDBContext.Admin_Data.Find(Details.tblUsername);
                if (data == null)
                {
                    return false;
                }
                else
                {
                    string password = this.encryption(Details.tblPassword);
                    Console.WriteLine(password);
                    if (password.Equals(data.tblPassword))
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                //left for logging
                throw null;
            }

        }

        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
    }
}
