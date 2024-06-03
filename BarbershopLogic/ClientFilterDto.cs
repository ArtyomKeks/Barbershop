using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLogic
{
    public class ClientFilterDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Day { get; set; }
    }
}
