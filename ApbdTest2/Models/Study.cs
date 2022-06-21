using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class Study
    {
        public Study()
        {
            Students = new HashSet<Student>();
        }

        public int IdStudies { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
