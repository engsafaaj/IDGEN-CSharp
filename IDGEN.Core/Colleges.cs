using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Core
{
    public class Colleges
    {
        public int Id { get; set; }
        public string CollegeName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CollegeCode { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Details { get; set; }
        public int DepNo { get; set; }
        public bool IsAdmin { get; set; }

        // Navigations

        public List<CollegeDep> CollegeDep { get; set; } 

    }
}
