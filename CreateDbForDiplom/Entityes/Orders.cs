using CreateDbForDiplom.Entityes.UsersAndAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDbForDiplom.Entityes
{
    internal class Orders
    {
        public Guid ID { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public int CashierId { get; set; }
        public Cashier Cashier { get; set; }
    }
}
