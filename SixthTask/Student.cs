using System;

namespace SixthTask
{
    /// <summary>
    /// Provides a field with a description of the element
    /// </summary>
    public class Student
    {
        public (string fullName, int age, int grade, double averageScore) Info { get; set; }
    }
}
