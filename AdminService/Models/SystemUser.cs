using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models
{
    public class SystemUser
    {

        public int UserID { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int UserName { get; set; }

        public int Password { get; set; }

        public virtual List<Customer> Customers { get; set; }

    }
}
