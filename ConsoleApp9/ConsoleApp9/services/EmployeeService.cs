﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp9.services
{
    public class EmployeeService : IService<Employee, int>
    {
        private CitiusContext context;

        public EmployeeService()
        {
            context = new CitiusContext();
        }

        public async Task<Employee> CreateAsync(Employee entity)
        {
            try
            {
                // The value of newly created entity will be returned
                var res = await context.Employee.AddAsync(entity);
                await context.SaveChangesAsync();
                return res.Entity; // newly created entity object
            }
            catch (Exception ex)
            {
                // throw
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                // search record
                var recordToDelete = await context.Employee.FindAsync(id);
                if (recordToDelete == null) return false; // record not found
                                                          // delete the record
                context.Employee.Remove(recordToDelete);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Employee>> GetAsync()
        {
            
            try
            {
                var result = await context.Employee.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Employee> GetAsync(int id)
        {
            try
            {
                var result = await context.Employee.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Employee> UpdateAsync(int id, Employee entity)
        {
            try
            {
                var result = await context.Employee.FindAsync(id);
                if (result == null) throw new Exception($"Record not found, update operation is failed");

                result.EmpUniqueId = entity.EmpUniqueId;
                result.EmpNo = entity.EmpNo;
                result.EmpName = entity.EmpName;
                result.Designation = entity.Designation;
                result.Salary = entity.Salary;
                result.DeptUniqueId = entity.DeptUniqueId;
                result.DeptUnique = entity.DeptUnique;


                // modify the record 
                //context.Entry(result).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}