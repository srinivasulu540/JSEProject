using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TblUserLogin
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime LogInDtTime { get; set; }
    }
}
