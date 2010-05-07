using System;

namespace MyApp.Models
{
    public class Patient : Entity
    {
        public string Name { get; set; }
        public string Hometown { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime Anniversary { get; set; }
    }
}