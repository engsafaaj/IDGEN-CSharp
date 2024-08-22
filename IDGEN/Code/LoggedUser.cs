using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Code
{
    internal static class LoggedUser
    {

        public static int Id { get; set; }
        public static string CollegeName { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string CollegeCode { get; set; }
        public static string? Email { get; set; }
        public static string? Phone { get; set; }
        public static string? Details { get; set; }
        public static int DepNo { get; set; }
        public static bool IsAdmin { get; set; }
    }
}
