using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TblUsrDocs
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string DocType { get; set; }
        public string FilePath { get; set; }
    }
}
