using System.Collections.Generic;
using System.Data.Entity;

namespace OneToMayRelationship_JQueryFiltered.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<DepartmentEntities>
    {
        protected override void Seed(DepartmentEntities context)
        {
            var departments = new List<Department>
                                  {
                                      new Department {Code = "Acco", Name = "Accounts"},
                                      new Department {Code = "Proc", Name = "Procurement"},
                                      new Department {Code = "Prod", Name = "Production"},
                                  };            
            new List<Section>
                               {
                                   new Section {Code = "Cash", Department = departments[0], Description = "Deal with cash transaction"},
                                   new Section {Code = "Finance", Department = departments[0], Description = "Deal with financial activities"},
                                   new Section {Code = "Procurement", Department = departments[1], Description = "Procurement"},
                                   new Section {Code = "Raw Materials", Department = departments[2], Description = "Deal with Raw materials details."},
                                   new Section {Code = "Finished goods", Department = departments[2], Description = "Deal with finished goods delivery and stock"}
                               }.ForEach(section => context.Sections.Add(section));

        }
    }
}