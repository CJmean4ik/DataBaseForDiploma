using System.Data.Entity;
using CreateDbForDiplom.Entityes.AIRLINEPLANES;
using CreateDbForDiplom.ExtensionsForModelBuilder;

namespace CreateDbForDiplom
{
    internal class AirCompanyContext : DbContext
    {
        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<AirlinePlane> AirlinePlanes { get; set; }

        public AirCompanyContext() : base("Data Source=СТАС-ПК\\SQLEXPRESS;Initial Catalog=AIRCOMPANYS;Integrated Security=True")
        {
            if (Database.Exists()) Database.Delete();
            
            Database.Create();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ConfigurePrimaryKeyForRoutAndFlight();
            modelBuilder.ConfigurePrimaryKeyForAirPlaneLine();
            modelBuilder.ConfigurePrimaryKeyTicket();
            modelBuilder.ConfigurePrimaryKeyForUsers();
            modelBuilder.ConfigPKeyForPassAndOrders();


            modelBuilder.ConfigureRelatedForTicketFlight();
            modelBuilder.ConfigureRelatedForAirlinePlane();
            modelBuilder.ConfigureRelatedForRouteFlight();
            modelBuilder.ConfigureRelatedForAccount();
            modelBuilder.ConfigureRelatedForOrders();
        }
    }
}
