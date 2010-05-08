using System;

namespace MyApp.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class MaximumLengthAttribute : Attribute
    {
        public MaximumLengthAttribute(int length)
        {
            Length = length;
        }

        public int Length { get; set; }
    }
}