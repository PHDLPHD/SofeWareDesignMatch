using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SDM.Model.Models.Mapping
{
    public class SDM_UsersMap : EntityTypeConfiguration<SDM_Users>
    {
        public SDM_UsersMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SDM_Users");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
