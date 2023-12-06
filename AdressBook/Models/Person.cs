using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdressBook.Interfaces;

namespace AdressBook.Models
{
    public class Person : IPerson
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int PhoneNumber { get; set; }

        public string Email { get; set; } = null!;

        public string StreetName { get; set; } = null!;

        public int StreetNumber { get; set; }

        public string City { get; set; } = null!;
    }
}
