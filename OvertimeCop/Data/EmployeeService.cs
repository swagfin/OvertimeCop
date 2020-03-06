using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeCop.Data
{
    public class EmployeeService
    {

        ApplicationDbContext Db { get; set; }

        public EmployeeService(ApplicationDbContext db)
        {
            this.Db = db;
        }


        public void Add(Employee employee)
        {
            Db.Employees.Add(employee);
            Db.SaveChanges();
        }

        public Task AddAsync(Employee employee)
        {
            return Task.Run(() =>
             {
                 Add(employee);
             });
        }


        public Employee GetById(int EmployeeId)
        {
            return Db.Employees.Include(x => x.Department).FirstOrDefault(x => x.Id == EmployeeId);
        }

        public Task<Employee> GetByIdAsync(int EmployeeId)
        {
            return Task.Run(() =>
             {
                 return GetById(EmployeeId);
             });
        }

        public IEnumerable<Employee> GetAll()
        {
            return Db.Employees.Include(x => x.Department).AsNoTracking().ToList();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            return Task.Run(() =>
             {
                 return GetAll();
             });
        }

        public void Remove(int EmployeeId)
        {
            var employee = GetById(EmployeeId);
            Db.Employees.Remove(employee);
        }

        public Task RemoveAsync(int EmployeeId)
        {
            return Task.Run(() =>
             {
                 Remove(EmployeeId);
             });
        }

        public void Update(Employee employee)
        {
            Db.Employees.Update(employee);
            Db.SaveChanges();
        }

        public Task UpdateAsync(Employee employee)
        {
            return Task.Run(() =>
             {
                 Update(employee);
             });
        }

    }

}
