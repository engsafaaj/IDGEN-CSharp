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
    public class DepEF : IDataHelper<CollegeDep>
    {
        private DataContext db;
        public DepEF()
        {
            db = new DataContext();
        }

        public int Add(CollegeDep table)
        {
            try
            {
                db.CollegeDep.Add(table);
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
                var CollegeDep = Find(Id);
                if (CollegeDep != null)
                {
                    db.CollegeDep.Remove(CollegeDep);
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

        public CollegeDep Find(int Id)
        {
            try
            {
                var CollegeDep = db.CollegeDep.Find(Id);
                if (CollegeDep == null)
                {
                    return new CollegeDep();
                }
                else
                {
                    return CollegeDep;
                }
            }
            catch
            {
                return new CollegeDep();
            }
        }

        public List<CollegeDep> GetAllData()
        {
            try
            {
                return db.CollegeDep.ToList();
            }
            catch { return new List<CollegeDep>(); }
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

        public List<CollegeDep> Search(string searchIteam)
        {
            try
            {
                return db.CollegeDep
                    .Where(x => x.Id.ToString() == searchIteam ||
                    x.DepName.Contains(searchIteam) ||
                    x.DepCode.ToString() == searchIteam

                    )
                    .ToList();
            }
            catch { return new List<CollegeDep>(); }
        }

        public int Update(CollegeDep table)
        {
            try
            {
                db = new DataContext();
                db.CollegeDep.Update(table);
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
