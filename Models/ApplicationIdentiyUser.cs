using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineBookStore.Models
{
    public class ApplicationIdentiyUser : IdentityUser
    {
        public ApplicationIdentiyUser()
        {

        }

        public string firstName { get; set; }
        public string lastName { get; set; }


    }
}
