using Form__add_user_.Entities;
using System;
using System.Collections.Generic;

namespace Form__add_user_.Fake_Repo
{
    public class UserRepo
    {
        public static List<User> Users = new List<User>
        {
            new User{ Id = Guid.NewGuid(), Name ="Name_1", Surname ="Surname_1", Age=20, ImageUrl="1.png"},
            new User{ Id = Guid.NewGuid(), Name ="Name_2", Surname ="Surname_2", Age=22, ImageUrl="2.png"},
            new User{ Id = Guid.NewGuid(), Name ="Name_3", Surname ="Surname_3", Age=24, ImageUrl="3.png"},
            new User{ Id = Guid.NewGuid(), Name ="Name_4", Surname ="Surname_4", Age=26, ImageUrl="4.png"}
        };
    }
}
