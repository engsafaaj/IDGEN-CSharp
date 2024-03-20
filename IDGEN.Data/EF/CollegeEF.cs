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
    public class CollegeEF : IDataHelper<Colleges>
    {
        private DataContext db;
        public CollegeEF()
        {
            db = new DataContext();
        }
        public int Add(Colleges table)
        {
            try
            {
                db.Add(table);
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
                var college = Find(Id);
                if (college != null)
                {
                    db.Colleges.Remove(college);
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

        public Colleges Find(int Id)
        {
            try
            {
                var college = db.Colleges.Find(Id);
                if (college == null)
                {
                    return new Colleges();
                }
                else
                {
                    return college;
                }
            }
            catch
            {
                return new Colleges();
            }
        }

        public List<Colleges> GetAllData()
        {
            try
            {
                return db.Colleges.ToList();
            }
            catch { return new List<Colleges>(); }
        }

        public bool IsConAvailable()
        {
            try
            {
                if (db.Database.CanConnect()) return true; return false;

            }
            catch { return false; }
        }

        public List<Colleges> Search(string searchIteam)
        {
            try
            {
                return db.Colleges
                    .Where(x => x.Id.ToString() == searchIteam||
                    x.CollegeName.Contains(searchIteam)||
                    x.UserName.Contains(searchIteam)||
                    x.Password.Contains(searchIteam)||
                    x.Phone.Contains(searchIteam)||
                    x.Email.Contains(searchIteam)||
                    x.Details.Contains(searchIteam)||
                    x.CollegeCode.ToString()==searchIteam
                    )
                    .ToList();
            }
            catch { return new List<Colleges>(); }
        }

        public int Update(Colleges table)
        {
            try
            {
                db = new DataContext();
                db.Update(table);
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
