using System.Data.Entity;

namespace OneToMayRelationship_JQueryFiltered.Models
{
    public class DepartmentEntities : DbContext
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Section> Sections { set; get; }
    }
}