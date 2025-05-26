using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPOCSystem.DAL.Models
{
    public class Department
    {
        [Key]
        public decimal DeptId { get; set; }
        public string ArDeptName { get; set; }
        public string HCMOrgId { get; set; }
        public int? Used { get; set; }
        public int? Party_Type { get; set; }

    }
}
