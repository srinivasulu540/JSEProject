using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TbluserExitForm
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime? ExitDateTime { get; set; }
        public string ExitFaq1 { get; set; }
        public string ExitFaq2 { get; set; }
        public string ExitFaq3 { get; set; }
        public DateTime? ExitDeleteTimestamp { get; set; }
        public string ExitDeleteUpdatedby { get; set; }
    }
}
