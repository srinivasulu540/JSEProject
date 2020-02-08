using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TblUserLoginCheckList
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MandatoryQuestion1 { get; set; }
        public string MandatoryQuestion2 { get; set; }
        public string MandatoryQuestion3 { get; set; }
    }
}
