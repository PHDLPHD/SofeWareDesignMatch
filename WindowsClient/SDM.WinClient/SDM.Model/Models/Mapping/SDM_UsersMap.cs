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
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MacAddress)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.LastLoginIpAddress)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SDM_Users");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.LastLoginTime).HasColumnName("LastLoginTime");
            this.Property(t => t.MacAddress).HasColumnName("MacAddress");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.isValid).HasColumnName("isValid");
            this.Property(t => t.LastLoginIpAddress).HasColumnName("LastLoginIpAddress");
        }
    }
}
