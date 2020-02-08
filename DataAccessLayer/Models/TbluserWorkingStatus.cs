using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TbluserWorkingStatus
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public bool? WorkingStatus { get; set; }
    }
}
