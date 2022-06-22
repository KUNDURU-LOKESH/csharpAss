using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Data
{
    public class CRUDemp
    {
        DemoContext context = new DemoContext();

        public string AddEmployee(Tables.Employee employee)
        {
            context.Employee.Add(employee);
            context.SaveChanges();
            return "Successfully added";
        }
        public string UpdateEmployee(int id,string name)
        {
            var empObj = context.Employee.Where(emp => emp.ID == id).Include(e => e.EmpOrg).FirstOrDefault();
            if (empObj != null)
            {
                empObj.Name = name;
                context.SaveChanges();
            }
            return "Updated successfully";
        }
        public List<Tables.Employee> ListAllEmployess()
        {
            var empl = context.Employee.Include(e => e.EmpOrg).ToList();
            return empl;
        }
        public string DeleteEmployee(int id)
        {

            var delEmp = context.Employee.Where(emp => emp.ID == id).Include(e => e.EmpOrg).FirstOrDefault();
            if (delEmp != null)
            {
                context.Employee.Remove(delEmp);
                delEmp.EmpOrg.Clear();
                context.SaveChanges();
                return "Delete succussfull";
            }
            else
            {
                return "No Record Found With This Id : " + id;
            }
        }
    }
}
