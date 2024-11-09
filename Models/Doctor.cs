using System;
using System.Collections.Generic;

namespace Authentication_Demo.Models
{
    public partial class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;
        public string Specialization { get; set; } = null!;
        public int? HospitalId { get; set; }

        public virtual Hospital? Hospital { get; set; }
    }
}
