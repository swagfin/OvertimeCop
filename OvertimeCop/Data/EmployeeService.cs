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


        public Employee GetById(int EmployeeNo)
        {
            return Db.Employees.FirstOrDefault(x => x.PersonNo == EmployeeNo);
        }

        public Task<Employee> GetByIdAsync(int EmployeeNo)
        {
            return Task.Run(() =>
             {
                 return GetById(EmployeeNo);
             });
        }

        public IEnumerable<Employee> GetAll()
        {
            return Db.Employees.AsNoTracking().ToList();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            return Task.Run(() =>
             {
                 return GetAll();
             });
        }

        public void Remove(int EmployeeNo)
        {
            var employee = GetById(EmployeeNo);
            Db.Employees.Remove(employee);
        }

        public Task RemoveAsync(int EmployeeNo)
        {
            return Task.Run(() =>
             {
                 Remove(EmployeeNo);
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
