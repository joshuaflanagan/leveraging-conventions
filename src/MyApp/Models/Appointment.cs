using System;

namespace MyApp.Models
{
    public class Appointment
    {
        public string Patient { get; set; }
        public DateTime CoverageDate { get; set; }
        public string Physician { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}