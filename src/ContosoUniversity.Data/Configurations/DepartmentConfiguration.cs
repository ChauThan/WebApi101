using System.Data.Entity.ModelConfiguration;
using ContosoUniversity.Entities;

namespace ContosoUniversity.Data.Configurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Name).IsRequired().HasMaxLength(256);
            Property(e => e.Budget).IsRequired().HasColumnType("money");
            Property(e => e.StartDate).IsRequired();
        }
    }
}
