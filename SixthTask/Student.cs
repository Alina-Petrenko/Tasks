using System;

namespace SixthTask
{
    /// <summary>
    /// TODO: Better to write
    /// TODO: "Class represents student in university"
    /// Provides a field with a description of the element
    /// </summary>
    public class Student
    {
        public (string fullName, int age, int grade, double averageScore) Info { get; set; }
    }
}
