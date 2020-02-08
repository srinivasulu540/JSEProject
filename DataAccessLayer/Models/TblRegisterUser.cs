using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TblRegisterUser
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Nationality { get; set; }
        public string Passport { get; set; }
        public string TurkishIdNumber { get; set; }
        public string ForeighnerIdNumber { get; set; }
        public string Gender { get; set; }
        public string MaritialStatus { get; set; }
        public string MaidenName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
    }
}
