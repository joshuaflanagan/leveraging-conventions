using System;

namespace MyApp.Models
{
    public class Patient : Entity
    {
        [MaximumLength(50), Required]
        public string Name { get; set; }
        [MaximumLength(80)]
        public string Hometown { get; set; }
        [MaximumLength(2)]
        public string State { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime Anniversary { get; set; }
    }
}