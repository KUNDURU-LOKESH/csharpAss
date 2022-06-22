using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Data.Tables
{
    public class EmployeeOrganization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }


        public string? OrgName { get; set; }

        public string? Location { get; set; }

        public Employee Employee { get; set; }



    }
}
