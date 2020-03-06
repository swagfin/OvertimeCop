using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeCop.Data
{
    public class OvertimeService
    {

        ApplicationDbContext Db { get; set; }

        public OvertimeService(ApplicationDbContext db)
        {
            this.Db = db;
        }


        public void Add(Overtime overtime)
        {
            Db.Overtimes.Add(overtime);
            Db.SaveChanges();
        }

        public Task AddAsync(Overtime overtime)
        {
            return Task.Run(() =>
             {
                 Add(overtime);
             });
        }


        public Overtime GetById(int OvertimeNo)
        {
            return Db.Overtimes.FirstOrDefault(x => x.Id == OvertimeNo);
        }

        public Task<Overtime> GetByIdAsync(int OvertimeNo)
        {
            return Task.Run(() =>
             {
                 return GetById(OvertimeNo);
             });
        }

        public IEnumerable<Overtime> GetAll()
        {
            return Db.Overtimes.AsNoTracking().ToList();
        }

        public Task<IEnumerable<Overtime>> GetAllAsync()
        {
            return Task.Run(() =>
             {
                 return GetAll();
             });
        }

        public void Remove(int OvertimeNo)
        {
            var overtime = GetById(OvertimeNo);
            Db.Overtimes.Remove(overtime);
        }

        public Task RemoveAsync(int OvertimeNo)
        {
            return Task.Run(() =>
             {
                 Remove(OvertimeNo);
             });
        }

        public void Update(Overtime overtime)
        {
            Db.Overtimes.Update(overtime);
            Db.SaveChanges();
        }

        public Task UpdateAsync(Overtime overtime)
        {
            return Task.Run(() =>
             {
                 Update(overtime);
             });
        }


    }
}
