using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPOCSystem.DAL.Models
{
    public partial class Section
    {
        public Section()
        {
            Branches = new HashSet<Branch>();
            InverseParent = new HashSet<Section>();
        }

        public decimal SecId { get; set; }
        public decimal DeptId { get; set; }
        public string SecCode { get; set; } = null!;
        public string? ArSecName { get; set; }
        public string? EnSecName { get; set; }
        public int? SecType { get; set; }
        public string? Location { get; set; }
        public decimal? ParentId { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? ActiveRec { get; set; }

        public virtual Section? Parent { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Section> InverseParent { get; set; }
    }
}
