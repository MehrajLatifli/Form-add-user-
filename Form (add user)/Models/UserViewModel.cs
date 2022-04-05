using Form__add_user_.Entities;
using Microsoft.AspNetCore.Http;

namespace Form__add_user_.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IFormFile FormFile { get; set; }


        public UserViewModel()
        {

        }
    }
}
