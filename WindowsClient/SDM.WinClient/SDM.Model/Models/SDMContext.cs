using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SDM.Model.Models.Mapping;

namespace SDM.Model.Models
{
    public partial class SDMContext : DbContext
    {
        static SDMContext()
        {
            Database.SetInitializer<SDMContext>(null);
        }

        public SDMContext()
            : base("Name=SDMContext")
        {
        }

        public DbSet<SDM_IncomeAndPayType> SDM_IncomeAndPayType { get; set; }
        public DbSet<SDM_IOPSituation> SDM_IOPSituation { get; set; }
        public DbSet<SDM_Users> SDM_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SDM_IncomeAndPayTypeMap());
            modelBuilder.Configurations.Add(new SDM_IOPSituationMap());
            modelBuilder.Configurations.Add(new SDM_UsersMap());
        }
    }
}
