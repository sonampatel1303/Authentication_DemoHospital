using System;
using System.Collections.Generic;

namespace Authentication_Demo.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
