using System.ComponentModel.DataAnnotations;

namespace OneToMayRelationship_JQueryFiltered.Models
{
    public class Section
    {
        public int SectionId { set; get; }
        public int DepartmentId { set; get; }
        [Required(ErrorMessage = "Code missing")]
        public string Code { set; get; }
        public string Description { set; get; }
        public virtual Department Department { set; get; }

    }
}