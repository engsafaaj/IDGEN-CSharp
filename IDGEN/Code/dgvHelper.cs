using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Code
{
    public static class dgvHelper
    {
        public static bool IsDataGridNull(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0) return false; return true;
        }
    }
}
