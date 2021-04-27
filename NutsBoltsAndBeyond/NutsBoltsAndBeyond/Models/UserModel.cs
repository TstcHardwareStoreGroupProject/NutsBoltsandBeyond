using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutsBoltsAndBeyond.Models
{
    public class UserModel
    {
        public UserModel() { }
        public int ID { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Designation { get; set; }
        public String Email { get; set; }

        public void ResetUser()
        {
            ID = 0;
            Fname = String.Empty;
            Lname = String.Empty;
            Username = String.Empty;
            Password = String.Empty;
            Designation = String.Empty;
            Email = String.Empty;
        }
    }
}
