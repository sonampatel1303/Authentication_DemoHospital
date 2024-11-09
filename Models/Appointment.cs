using System;
using System.Collections.Generic;

namespace Authentication_Demo.Models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int Doctorid { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}
