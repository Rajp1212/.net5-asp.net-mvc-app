using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3_Patel.Models
{
    public class RegisterViewModel
    {
        public RegisteredUser Registration { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string ClientInfo { get; set; }
    }
}
