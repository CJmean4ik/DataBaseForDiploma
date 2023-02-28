using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDbForDiplom.Entityes.UsersAndAccounts
{
    internal class Passenger
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Orders> Orders { get; set; }

    }
    enum GenderType
    {
        Male,
        Female
    }
}
