using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TblCandidCompaniesList
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string CompanyName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool? CurrentCompany { get; set; }
    }
}
