using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace EmployeeAPI.Models
{
    public class DAL
    {
        public static MySqlConnection DB;
        public static List<Employee> ReadAllEmployees()
        {
            return DB.GetAll<Employee>().ToList();
        }

        public static Employee ReadOneEmployee(int id)
        {
            return DB.Get<Employee>(id);
        }

        public static List<Employee> ReadAllbyDepartment(string dept)
        {
            var myparams = new { thedept = dept };
            string sql = "select * from employee where department = @thedept";

            List<Employee> emps = DB.Query<Employee>(sql, myparams).ToList();
            return emps;
        }

        public static bool DeleteEmployee(int id)
        {
            var myparams = new { theid = id };
            Employee temp = new Employee() { id = id };
            DB.Delete<Employee>(temp);
            return true;
        }

        public static Employee AddEmployee(Employee emp)
        {
            DB.Insert<Employee>(emp);
            return emp;
        }

        public static Employee UpdateEmployee(Employee emp)
        {
            DB.Update<Employee>(emp);
            return emp;
        }

        public static List<Employee> SearchByLastName(string lastname)
        {
            var myparams = new { searchterm = $"%{lastname}%" };
            List<Employee> emps = DB.Query<Employee>("select * from employee where lastname like @searchterm", myparams).ToList();
            return emps;
        }
    }
}
