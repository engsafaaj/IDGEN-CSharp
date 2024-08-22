using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Data
{
    public interface IDataHelper<Table>
    {
        // Read
        List<Table> GetAllData();
        List<Table> GetAllDataByUser(int collegeId);
        List<Table> Search(string searchIteam);
        List<Table> SearchByUser(string searchIteam, int collegeId);
        Table Find(int Id);

        // Write
        int Add(Table table);
        int Update(Table table);
        int Delete(int Id);

        // Check Connection
        bool IsConAvailable();

    }
}
