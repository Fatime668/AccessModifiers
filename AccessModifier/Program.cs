using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Fatime","1234536F");
            Admin admin = new Admin(true, "admin panel",user.Name,user.Pass);
            user.UserAdmin();
            admin.AdminInfo();

        }
    }
}
