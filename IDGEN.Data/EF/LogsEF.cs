using IDGEN.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Data.EF
{
    public class LogsEF : IDataHelper<Logs>
    {
        private DataContext db;
        public LogsEF()
        {
            db = new DataContext();
        }
        public int Add(Logs table)
        {
            try
            {
                db.Logs.Add(table);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Delete(int Id)
        {
            try
            {
                var logs = Find(Id);
                if (logs != null)
                {
                    db.Logs.Remove(logs);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch
            {
                return 0;
            }
        }

        public Logs Find(int Id)
        {
            try
            {
                var logs = db.Logs.Find(Id);
                if (logs == null)
                {
                    return new Logs();
                }
                else
                {
                    return logs;
                }
            }
            catch
            {
                return new Logs();
            }
        }

        public List<Logs> GetAllData()
        {
            try
            {
                return db.Logs.ToList();
            }
            catch { return new List<Logs>(); }
        }

        public bool IsConAvailable()
        {
            try
            {
                db = new DataContext();
                if (db.Database.CanConnect()) return true; return false;

            }
            catch { return false; }
        }

        public List<Logs> Search(string searchIteam)
        {
            try
            {
                return db.Logs
                    .Where(x => x.Id.ToString() == searchIteam||
                    x.LogTitle.Contains(searchIteam)||
                    x.LogDescriptions.Contains(searchIteam)||
                    x.LogDate.Contains(searchIteam)||
                    x.UserDeviceMac.Contains(searchIteam)||
                    x.UserDeviceName.Contains(searchIteam)||
                    x.UserFullName.Contains(searchIteam)
                    )
                    .ToList();
            }
            catch { return new List<Logs>(); }
        }

        public int Update(Logs table)
        {
            try
            {
                db = new DataContext();
                db.Logs.Update(table);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
