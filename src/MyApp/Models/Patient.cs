using System;

namespace MyApp.Models
{
    public class Patient : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Hometown { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime Anniversary { get; set; }
        [StringLength(2)]
        public string State { get; set; }
    }

    public class StringLengthAttribute : Attribute
    {
        public int Length { get; set; }

        public StringLengthAttribute(int length)
        {
            Length = length;
        }
    }

    public class RequiredAttribute : Attribute{}
}