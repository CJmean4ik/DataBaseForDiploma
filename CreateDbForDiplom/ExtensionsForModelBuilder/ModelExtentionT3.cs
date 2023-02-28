using CreateDbForDiplom.Entityes;
using CreateDbForDiplom.Entityes.RouteAndFlight;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CreateDbForDiplom.ExtensionsForModelBuilder
{
    internal static partial class ModelExtention
    {
        public static void ConfigurePrimaryKeyTicket(this DbModelBuilder mb)
        {
            mb.Entity<Ticket>()
                .HasKey(k => k.NumberTicket)
                .Property(p => p.NumberTicket)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

          
        }

        public static void ConfigureRelatedForTicketFlight(this DbModelBuilder mb)
        {
            mb.Entity<Ticket>()
                .HasRequired(h => h.Flight)
                .WithMany(w => w.Tickets)
                .HasForeignKey(fk => fk.FlightId);
        }
    }
}
