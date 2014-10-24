using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SDM.Model.Models.Mapping
{
    public class SDM_IncomeAndPayTypeMap : EntityTypeConfiguration<SDM_IncomeAndPayType>
    {
        public SDM_IncomeAndPayTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IAOName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SDM_IncomeAndPayType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IncomeOrPay).HasColumnName("IncomeOrPay");
            this.Property(t => t.IAOName).HasColumnName("IAOName");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Systematics).HasColumnName("Systematics");
        }
    }
}
