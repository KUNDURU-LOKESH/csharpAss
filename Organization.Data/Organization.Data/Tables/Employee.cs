using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Data.Tables
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }


        public string? Name { get; set; }

        public int Age { get; set; }

        public ICollection<EmployeeOrganization> EmpOrg { get; set; }


    }
}
