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
    public class StudnetEF : IDataHelper<Studnets>
    {
        private DataContext db;
        public StudnetEF()
        {
            db = new DataContext();
        }
        public int Add(Studnets table)
        {
            try
            {
                db.Studnets.Add(table);
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
                    db.Studnets.Remove(college);
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

        public Studnets Find(int Id)
        {
            try
            {
                var college = db.Studnets.Find(Id);
                if (college == null)
                {
                    return new Studnets();
                }
                else
                {
                    return college;
                }
            }
            catch
            {
                return new Studnets();
            }
        }

        public List<Studnets> GetAllData()
        {
            try
            {
                return db.Studnets.OrderByDescending(x => x.Id).ToList();
            }
            catch { return new List<Studnets>(); }
        }

        public List<Studnets> GetAllDataByUser(int collegeId)
        {
            try
            {
                return db.Studnets.OrderByDescending(x => x.Id).Where(x => x.CollegesId == collegeId).ToList();
            }
            catch { return new List<Studnets>(); }
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

        public List<Studnets> Search(string searchIteam)
        {
            try
            {
                return db.Studnets.OrderByDescending(x => x.Id)
                    .Where(x => x.Id.ToString() == searchIteam ||
                    x.Name.Contains(searchIteam) ||
                    x.UniversityCode == searchIteam ||
                    x.FacultyCode == searchIteam ||
                    x.DepartmentCode == searchIteam ||
                    x.AdmissionYear == searchIteam ||
                    x.StudyLevel == searchIteam ||
                    x.StudySystem == searchIteam ||
                    x.AdmissionChannel == searchIteam ||
                    x.Gender == searchIteam ||
                    x.EnrollmentOrder == searchIteam ||
                    x.FullID == searchIteam ||
                    x.AddDate.Contains(searchIteam)
                    )
                    .ToList();
            }
            catch { return new List<Studnets>(); }
        }

        public List<Studnets> SearchByUser(string searchIteam, int collegeId)
        {
            try
            {
                return db.Studnets.OrderByDescending(x => x.Id).Where(X => X.CollegesId == collegeId)
                    .Where(x => x.Id.ToString() == searchIteam ||
                    x.Name.Contains(searchIteam) ||
                    x.UniversityCode == searchIteam ||
                    x.FacultyCode == searchIteam ||
                    x.DepartmentCode == searchIteam ||
                    x.AdmissionYear == searchIteam ||
                    x.StudyLevel == searchIteam ||
                    x.StudySystem == searchIteam ||
                    x.AdmissionChannel == searchIteam ||
                    x.Gender == searchIteam ||
                    x.EnrollmentOrder == searchIteam ||
                    x.FullID == searchIteam ||
                    x.AddDate.Contains(searchIteam)
                    )
                    .ToList();
            }
            catch { return new List<Studnets>(); }
        }

        public int Update(Studnets table)
        {
            try
            {
                db = new DataContext();
                db.Studnets.Update(table);
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
