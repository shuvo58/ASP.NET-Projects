using System.Collections.Generic;

namespace OneToMayRelationship_JQueryFiltered.Models
{
    public class Department
    {
        public int DepartmentId { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public virtual List<Section> Sections { set; get; } 
    }
}