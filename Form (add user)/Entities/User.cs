using System;

namespace Form__add_user_.Entities
{
    public class User
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long Age { get; set; }
        public string ImageUrl { get; set; }

        public User()
        {

        }

    }
}
