using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPOCSystem.DAL.Models
{
    public partial class Branch
    {
        public decimal BranchId { get; set; }
        public decimal? DeptId { get; set; }
        public decimal SecId { get; set; }
        public string BranchCode { get; set; } = null!;
        public string? ArBranchName { get; set; }
        public string? EnBranchName { get; set; }
        public decimal? BranchId1 { get; set; }
        public bool? ActiveRec { get; set; }

        public virtual Section Sec { get; set; } = null!;
    }
}
