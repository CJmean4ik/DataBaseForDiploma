using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using CreateDbForDiplom.Entityes.AIRLINEPLANES;
using CreateDbForDiplom.Entityes.RouteAndFlight;
using CreateDbForDiplom.Entityes.UsersAndAccounts;
using CreateDbForDiplom.Entityes;

namespace CreateDbForDiplom.ExtensionsForModelBuilder
{

    internal static partial class ModelExtention
    {
        public static void ConfigurePrimaryKeyForAirPlaneLine(this DbModelBuilder mb)
        {
            mb.Entity<AirLine>()
                .ToTable("Airline")
                .HasKey(k => k.ID)
                .Property(p => p.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Airplane>()
                .ToTable("Airplane")
                .HasKey(k => k.ID)
                .Property(p => p.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<AirlinePlane>()
                  .ToTable("AirlinePlane")
                  .HasKey(k => k.ID)
                  .Property(p => p.ID)
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }    
        public static void ConfigurePrimaryKeyForRoutAndFlight(this DbModelBuilder mb)
        {
            mb.Entity<Flight>()
                .HasKey(k => k.NumberFlight)
                .Property(p => p.NumberFlight)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Route>()
              .HasKey(k => k.ID)
              .Property(p => p.ID)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
        public static void ConfigurePrimaryKeyForUsers(this DbModelBuilder mb)
        {
            mb.Entity<Cashier>()
               .ToTable("Cahier")
               .HasKey(k => k.ID)
               .Property(p => p.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
      
            mb.Entity<Account>()
               .HasKey(k => k.ID)
               .Property(p => p.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

               mb.Entity<Account>()
               .Property(k => k.Email)
               .IsOptional();
        }
        public static void ConfigPKeyForPassAndOrders(this DbModelBuilder mb)
        {
            mb.Entity<Orders>()            
               .HasKey(k => k.ID)
               .Property(p => p.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Passenger>()
               .HasKey(k => k.ID)
               .Property(p => p.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }


        public static void ConfigureRelatedForAirlinePlane(this DbModelBuilder mb)
        {
            mb.Entity<AirlinePlane>()
                .HasRequired(p => p.Airplane)
                .WithMany(w => w.AirlinePlane)
                .HasForeignKey(fk => fk.AirplaneId);

            mb.Entity<AirlinePlane>()
                .HasRequired(m => m.AirLine)
                .WithMany(w => w.AirlinePlanes)
                .HasForeignKey(fk => fk.AirLineId);

        }
        public static void ConfigureRelatedForRouteFlight(this DbModelBuilder mb)
        {
            mb.Entity<Flight>()
                .HasRequired(h => h.Route)
                .WithMany(w => w.Flights)
                .HasForeignKey(fk => fk.RouteId);

            mb.Entity<Flight>()
                .HasRequired(h => h.AirlinePlane)
                .WithMany(w => w.Flights)
                .HasForeignKey(fk => fk.AirlinePlaneId);

        }
        public static void ConfigureRelatedForAccount(this DbModelBuilder mb)
        {
            mb.Entity<Account>()
                .HasOptional(h => h.Cashier)
                .WithOptionalDependent()
                .Map(m => m.MapKey("CashierId"));       
        }
        public static void ConfigureRelatedForOrders(this DbModelBuilder mb)
        {
            mb.Entity<Orders>()
                .HasRequired(h => h.Cashier)
                .WithMany(w => w.Orders)
                .HasForeignKey(fk => fk.CashierId);

            mb.Entity<Orders>()
              .HasRequired(h => h.Ticket)
              .WithMany(w => w.Orders)
              .HasForeignKey(fk => fk.TicketId);

            mb.Entity<Orders>()
              .HasRequired(h => h.Passenger)
              .WithMany(w => w.Orders)
              .HasForeignKey(fk => fk.PassengerId);
        }
    }
}
