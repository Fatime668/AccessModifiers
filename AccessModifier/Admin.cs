using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Admin:User
    {
        public bool isSuperAdmin;
        public string Section;

        public Admin(bool issperadmin,string section,string username,string password):base(username,password)
        {
            isSuperAdmin = issperadmin;
            Section = section;
        }
      
        public void AdminInfo()
        {
            Console.WriteLine($"isSuperAdmin: {isSuperAdmin} Section: {Section}");
        }
    }
}
