using System;
using System.Linq;
using System.Diagnostics;

namespace SixthTask
{
    /// <summary>
    /// Provides functionality for modifying and interacting with an array
    /// </summary>
    public class Journal
    {
        private Student[] _students = new Student[10];
        private Stopwatch _stopwatch = new Stopwatch();
        private TimeSpan _time = new TimeSpan();

        /// <summary>
        /// Fills empty array with elements
        /// </summary>
        public void FillStudentArray()
        {
            var firstStudent = new Student();
            var secondStudent = new Student();
            var thirdStudent = new Student();
            var foutrhStudent = new Student();
            var fifthStudent = new Student();
            var sixthStudent = new Student();
            var seventhStudent = new Student();
            var eighthStudent = new Student();
            var ninthStudent = new Student();
            var tenthStudent = new Student();
            firstStudent.Info = ("Ahmed Mahomedov", 14, 8, Math.Round(4.35d,2));
            _students[0] = firstStudent;
            secondStudent.Info = ("Stepan Bandera", 15, 9, Math.Round(5.00d,2));
            _students[1] = secondStudent;
            thirdStudent.Info = ("Julia Timoshenko", 6, 1, Math.Round(3.219d,2));
            _students[2] = thirdStudent;
            foutrhStudent.Info = ("Michael Jackson", 8, 3, Math.Round(4.66d,2));
            _students[3] = foutrhStudent;
            fifthStudent.Info = ("Kate Smith", 14, 8, Math.Round(4.99d,2));
            _students[4] = fifthStudent;
            sixthStudent.Info = ("Maria Ivanova", 6, 1, Math.Round(4.743d,2));
            _students[5] = sixthStudent;
            seventhStudent.Info = ("Mehmed Mahomedov", 14, 8, Math.Round(3.732d,2));
            _students[6] = seventhStudent;
            eighthStudent.Info = ("Vladimir Zelenskiy", 16, 10, Math.Round(5.00d,2));
            _students[7] = eighthStudent;
            ninthStudent.Info = ("Elon Musk", 17, 11, Math.Round(3.932d,2));
            _students[8] = ninthStudent;
            tenthStudent.Info = ("Alina Petrenko", 7, 2, Math.Round(4.21d,2));
            _students[9] = tenthStudent;
            _students = _students.OrderBy(s => s.Info.fullName).ToArray();
        }

        /// <summary>
        /// Writes array to console
        /// </summary>
        public void GetToConcoleStudentArray()
        {
            for (int i = 0; i < _students.Length; i++)
            {
                Console.WriteLine($"№ {i + 1}. Name: {_students[i].Info.fullName}, Age: {_students[i].Info.age}, Grage: {_students[i].Info.grade}, Score: {_students[i].Info.averageScore}");
            }
        }

        /// <summary>
        /// Finds value in the array
        /// </summary>
        /// <param name="inputName">Value to find in the array</param>
        /// <returns>Returns the time spent on calculations</returns>
        public TimeSpan FindByName(string inputName)
        {
            _stopwatch.Start();
            var studentIsFounded = false;
            for (int i = 0; i < _students.Length; i++)
            {
                var fullName = _students[i].Info.fullName.Split(" ");
                var firstName = fullName[0];
                var secondName = fullName[1];
                if (_students[i].Info.fullName.Equals(inputName) || firstName.Equals(inputName) || secondName.Equals(inputName))
                {
                    Console.WriteLine("Student has founded!");
                    Console.WriteLine($"Name: {_students[i].Info.fullName}, Age: {_students[i].Info.age}, Grage: {_students[i].Info.grade}, Score: {_students[i].Info.averageScore}");
                    studentIsFounded = true;
                }
            }
            if (!studentIsFounded)
            {
                Console.WriteLine("There is no student with that name in the class");
            }
            _stopwatch.Stop();
            _time = _stopwatch.Elapsed;
            _stopwatch.Reset();
            return _time;
        }

        /// <summary>
        /// Sorts in <paramref name="byAscending"/> order
        /// </summary>
        /// <param name="byAscending">Direction sort</param>
        /// <returns>Returns the time spent on calculations</returns>
        public TimeSpan Sort(bool byAscending)
        {
            _stopwatch.Start();
            Student[] sortedStudents = _students;
            var temp = new Student();
            if (!byAscending)
            {
                sortedStudents = _students.OrderByDescending(s => s.Info.averageScore).ToArray();
            }
            else
            {
                sortedStudents = _students.OrderBy(s => s.Info.averageScore).ToArray();
            }
            for (int i = 0; i < sortedStudents.Length; i++)
            {
                Console.WriteLine($"Name: {sortedStudents[i].Info.fullName}, Age: {sortedStudents[i].Info.age}, Grage: {sortedStudents[i].Info.grade}, Score: {sortedStudents[i].Info.averageScore}");
            }
            _stopwatch.Stop();
            _time = _stopwatch.Elapsed;
            _stopwatch.Reset();
            return _time;
        }

        /// <summary>
        /// Groups students according to grade
        /// </summary>
        /// <returns>Returns the time spent on calculations</returns>
        public TimeSpan Group()
        {
            _stopwatch.Start();
            var temp = new Student();
            var groupStudents = _students.GroupBy(s => s.Info.grade).SelectMany(group => group).ToArray();
            for (int i = 0; i < groupStudents.Length; i++)
            {
                Console.WriteLine($"Name: {groupStudents[i].Info.fullName}, Age: {groupStudents[i].Info.age}, Grage: {groupStudents[i].Info.grade}, Score: {groupStudents[i].Info.averageScore}");
            }
            _stopwatch.Stop();
            _time = _stopwatch.Elapsed;
            _stopwatch.Reset();
            return _time;
        }

        /// <summary>
        /// Changes an array element by <paramref name="index"/>
        /// </summary>
        /// <param name="index">Index of the element to change</param>
        /// <returns>Returns the time spent on calculations</returns>
        public TimeSpan ChangeStudent(int index)
        {
            _stopwatch.Start();
            var isChangeStudent = true;
            while (isChangeStudent)
            {
                Console.Write("Print what you want to change: 1 - full name, 2 - age, 3 - grade, 4 - average score, 5 - want to exit: ");
                var resultOfParsing = int.TryParse(Console.ReadLine(), out var value);
                if (!resultOfParsing || (value <= 0) || (value > 5))
                {
                    Console.WriteLine("Seems like wrong value");
                    continue;
                }
                switch (value)
                {
                    case 1:
                        Console.Write("Write new full name: ");
                        _students[index].Info = (Console.ReadLine(), _students[index].Info.age, _students[index].Info.grade, _students[index].Info.averageScore);
                        break;
                    case 2:
                        Console.Write("Write new age: ");
                        resultOfParsing = int.TryParse(Console.ReadLine(), out var newAge);
                        if (!resultOfParsing || (value <= 0))
                        {
                            Console.WriteLine("Seems like wrong value");
                            continue;
                        }
                        _students[index].Info = (_students[index].Info.fullName, newAge, _students[index].Info.grade, _students[index].Info.averageScore);
                        break;
                    case 3:
                        Console.Write("Write new grade: ");
                        resultOfParsing = int.TryParse(Console.ReadLine(), out var newGrade);
                        if (!resultOfParsing || (value <= 0) || (value > 11))
                        {
                            Console.WriteLine("Seems like wrong value");
                            continue;
                        }
                        _students[index].Info = (_students[index].Info.fullName, _students[index].Info.age, newGrade, _students[index].Info.averageScore);
                        break;
                    case 4:
                        Console.Write("Write new average Score: ");
                        resultOfParsing = double.TryParse(Console.ReadLine(), out var newAverageScore);
                        if (!resultOfParsing || (value <= 0) || (value > 5))
                        {
                            Console.WriteLine("Seems like wrong value");
                            continue;
                        }
                        _students[index].Info = (_students[index].Info.fullName, _students[index].Info.age, _students[index].Info.grade, Math.Round(newAverageScore,2));
                        break;
                    case 5:
                        isChangeStudent = false;
                        break;
                    default:
                        Console.WriteLine("Wrong value!");
                        break;
                }
            }
            _stopwatch.Stop();
            _time = _stopwatch.Elapsed;
            _stopwatch.Reset();
            return _time;
        }

        /// <summary>
        /// Calculates the average value of array elements by age
        /// </summary>
        /// <returns>Returns the time spent on calculations</returns>
        public TimeSpan GetAverageAge()
        {
            _stopwatch.Start();
            var averageAge = 0d;
            for (int i = 0; i < _students.Length; i++)
            {
                averageAge += _students[i].Info.age;
            }
            averageAge /= _students.Length;
            Console.WriteLine($"Average age is: {averageAge}");
            _stopwatch.Stop();
            _time = _stopwatch.Elapsed;
            _stopwatch.Reset();
            return _time;
        }
    }
}
