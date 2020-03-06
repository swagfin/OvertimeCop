using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeCop.Data
{
    public class DepartmentService
    {

        ApplicationDbContext Db { get; set; }

        public DepartmentService(ApplicationDbContext db)
        {
            this.Db = db;
        }


        public void Add(Department department)
        {
            Db.Departments.Add(department);
            Db.SaveChanges();
        }

        public Task AddAsync(Department department)
        {
            return Task.Run(() =>
             {
                 Add(department);
             });
        }


        public Department GetById(int DepartmentNo)
        {
            return Db.Departments.FirstOrDefault(x => x.Id == DepartmentNo);
        }

        public Task<Department> GetByIdAsync(int DepartmentNo)
        {
            return Task.Run(() =>
             {
                 return GetById(DepartmentNo);
             });
        }

        public IEnumerable<Department> GetAll()
        {
            return Db.Departments.AsNoTracking().ToList();
        }

        public Task<IEnumerable<Department>> GetAllAsync()
        {
            return Task.Run(() =>
             {
                 return GetAll();
             });
        }

        public void Remove(int DepartmentNo)
        {
            var department = GetById(DepartmentNo);
            Db.Departments.Remove(department);
        }

        public Task RemoveAsync(int DepartmentNo)
        {
            return Task.Run(() =>
             {
                 Remove(DepartmentNo);
             });
        }

        public void Update(Department department)
        {
            Db.Departments.Update(department);
            Db.SaveChanges();
        }

        public Task UpdateAsync(Department department)
        {
            return Task.Run(() =>
             {
                 Update(department);
             });
        }

    }
}
