using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanginInLINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly HireDate { get; set; }

        public DateTime LastPunchDate { get; set; }

    }
}
