using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Core
{
    public class Studnets
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UniversityCode { get; set; }
        public string FacultyCode { get; set; }
        public string DepartmentCode { get; set; }
        public string AdmissionYear { get; set; }
        public string StudyLevel { get; set; }
        public string StudySystem { get; set; }
        public string AdmissionChannel { get; set; }
        public string Gender { get; set; }
        public string EnrollmentOrder { get; set; }
        public string FullID { get; set; }
        public string AddDate { get; set;}

        // Navigations
        public Colleges Colleges { get; set; }
        public int CollegesId { get; set; }
    }
}
