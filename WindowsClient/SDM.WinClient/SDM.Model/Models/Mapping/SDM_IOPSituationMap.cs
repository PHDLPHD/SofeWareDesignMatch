using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SDM.Model.Models.Mapping
{
    public class SDM_IOPSituationMap : EntityTypeConfiguration<SDM_IOPSituation>
    {
        public SDM_IOPSituationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SDM_IOPSituation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IAPTID).HasColumnName("IAPTID");
            this.Property(t => t.IOPMoney).HasColumnName("IOPMoney");
            this.Property(t => t.IOPTime).HasColumnName("IOPTime");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
