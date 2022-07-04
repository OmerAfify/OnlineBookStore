using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class UserIdentityModel
    {
        [StringLength(100)]
        public string firstName { get; set; }

        [StringLength(100)]
        public string lastName { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", 
            ErrorMessage = "Please make sure that you have entered a valid email.")]
        public string email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$",
            ErrorMessage="Please make sure that the password has a minimum 8 characters, atleast 1 Alphabet, 1 Number and 1 Special Character")]
        public string password { get; set; }

        public string returnUrl { get; set; }

    }
}
