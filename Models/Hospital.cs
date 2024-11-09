using System;
using System.Collections.Generic;

namespace Authentication_Demo.Models
{
    public partial class Hospital
    {
        public Hospital()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int HospitalId { get; set; }
        public string HospitalName { get; set; } = null!;
        public string Location { get; set; } = null!;

        public virtual ICollection<Doctor>? Doctors { get; set; }
    }
}
