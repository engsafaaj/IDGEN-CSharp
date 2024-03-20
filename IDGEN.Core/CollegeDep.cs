using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Core
{
    public class CollegeDep
    {
        public int Id { get; set; }
        public string DepName { get; set; }
        public int DepCode { get; set; }

        // Navigations
        public Colleges Colleges { get; set; }
        public int CollegesId { get; set; }
    }
}
