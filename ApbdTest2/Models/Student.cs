using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? IdStudy { get; set; }

        public virtual Study IdStudyNavigation { get; set; }
    }
}
