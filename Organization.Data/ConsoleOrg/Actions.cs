using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organization.Data;
using Organization.Data.Tables;


namespace ConsoleOrg
{
    public class Actions
    {
        CRUDemp Demp = new CRUDemp();
        public string Add()
        {
            Employee employee = new Employee();

            Console.WriteLine("Enter EmpName:");
            employee.Name = Console.ReadLine();

            Console.WriteLine("enter EMP age:");
            employee.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter how many oragization that you have worked: ");
            int count = Convert.ToInt32(Console.ReadLine());



            ICollection<EmployeeOrganization> employeeOrgList = new List<EmployeeOrganization>();

            for (int i = 0; i < count; i++)
            {

                EmployeeOrganization employeeOrg = new EmployeeOrganization();

                Console.WriteLine("Enter Org" + (i + 1) + " Name:");
                employeeOrg.OrgName = Console.ReadLine();

                Console.WriteLine("Enter Org" + (i + 1) + " Location:");
                employeeOrg.Location = Console.ReadLine();


                employeeOrgList.Add(employeeOrg);
            }

            employee.EmpOrg = employeeOrgList;

           return Demp.AddEmployee(employee);
        }
        public void Show()
        {
            var empList = Demp.ListAllEmployess();
            if (empList != null)
            {
                foreach (Employee emp in empList)
                {
                    Console.WriteLine("Employe Name   :" + emp.Name);
                    Console.WriteLine("Employee Age   :" + emp.Age);
                    Console.WriteLine("===============Orgnizations AND Locations=================");
                    foreach (var empOrg in emp.EmpOrg)
                    {
                        Console.WriteLine("Employee Organization  :" + empOrg.OrgName);
                        Console.WriteLine("Employee Organization Location  :" + empOrg.Location);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(" Record not Found with Id :");
            }
        }
        public string Update()
        {
            Console.WriteLine("enter emp id that do want to update");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter new emp name:");
            var name = Console.ReadLine();
            return Demp.UpdateEmployee(id, name);
        }
        public string Delete()
        {
            Console.WriteLine("enter emp id that do want to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            return Demp.DeleteEmployee(id);
        }
    }
}
