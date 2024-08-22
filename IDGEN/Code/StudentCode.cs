using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Code
{
    internal class StudentCode
    {
        public string UniversityCode { get; set; }
        public string FacultyCode { get; set; }
        public string DepartmentCode { get; set; }
        public string AdmissionYear { get; set; }
        public string StudyLevel { get; set; }
        public string StudySystem { get; set; }
        public string AdmissionChannel { get; set; }
        public string Gender { get; set; }
        public string EnrollmentOrder { get; set; }

        public string GenerateStudentID()
        {
            string space = "    ";
            // Concatenate the properties to form the student ID
            string studentID = $"{UniversityCode}{space}{FacultyCode}{space}{DepartmentCode}{space}{AdmissionYear}{space}{StudyLevel}{space}{StudySystem}{space}{AdmissionChannel}{space}{Gender}{space}{EnrollmentOrder}";

            return studentID;
        }

        public string GenerateStudentIDWithOutSpace()
        {
            // Concatenate the properties to form the student ID
            string studentID = $"{UniversityCode}{FacultyCode}{DepartmentCode}{AdmissionYear}{StudyLevel}{StudySystem}{AdmissionChannel}{Gender}{EnrollmentOrder}";

            return studentID;
        }
    }
}
