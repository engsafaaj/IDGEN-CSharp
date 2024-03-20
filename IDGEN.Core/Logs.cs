using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Core
{
    public class Logs
    {
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public string UserDeviceName { get; set; }
        public string UserDeviceMac { get; set; }
        public string LogTitle { get; set; }
        public string LogDescriptions { get; set; }
        public string LogDate { get; set; }
    }
}
