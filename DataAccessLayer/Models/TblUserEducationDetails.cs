using System;
using System.Collections.Generic;

namespace JSEProject.Models
{
    public partial class TblUserEducationDetails
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Course { get; set; }
        public string Universityname { get; set; }
        public string UniversityAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string CourseTitle { get; set; }
    }
}
