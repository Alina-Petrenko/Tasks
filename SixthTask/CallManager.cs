using System;

namespace SixthTask
{
    /// <summary>
    /// Provides functionality to call methods based on input values
    /// </summary>
    public class CallManager
    {
        private Journal journal = new Journal();

        /// <summary>
        /// Calls methods depending on input values
        /// </summary>
        public void InputOutputData()
        {
            journal.FillStudentArray();
            var appIsRunning = true;
            while (appIsRunning)
            {
                Console.WriteLine("Show all students - 1, \nFind student by name - 2, \nSort students by average score - 3, \nGroup by grade - 4, \nChange student - 5, \nGet average age - 6, \nExit - 7");
                // TODO: Added code
                Console.WriteLine("Make your choose (1-7)");
                
                var resultOfParsing = int.TryParse(Console.ReadLine(), out var operation);
               
                if (!resultOfParsing || (operation <= 0) || (operation > 7))
                {
                    GetErrorMessage();
                    continue;
                }

                Console.WriteLine("");
                switch (operation)
                {
                    // TODO: instead of using 1,2,3... 
                    // TODO: it could be enum with proper named actions
                    case 1:
                        journal.GetToConcoleStudentArray();
                        Console.WriteLine("____________________________");
                        break;
                    case 2:
                        Console.Write("Write name: ");
                        var name = Console.ReadLine();
                        TimeSpan spentFindTime = journal.FindByName(name);
                        WriteSpentTimeToConsole(spentFindTime);
                        Console.WriteLine("____________________________");
                        break;
                    case 3:
                        Console.Write("How do you want to sort: by ascending - 1, by descending - 2: ");
                        resultOfParsing = int.TryParse(Console.ReadLine(), out var sortDirection);
                        // TODO: variable is not needed at all
                        var isSortByAscending = true;
                        if (!resultOfParsing || (sortDirection <= 0) || (sortDirection > 2))
                        {
                            GetErrorMessage();
                            continue;
                        }
                        else if (sortDirection == 1)
                        {
                            // TODO: updated code
                            TimeSpan spentSortTime = journal.SortByAverageScore();
                            WriteSpentTimeToConsole(spentSortTime);
                            Console.WriteLine("____________________________");
                            break;
                        }
                        else
                        {
                            // TODO: updated code
                            TimeSpan spentSortTime =  journal.SortByAverageScore(false);
                            WriteSpentTimeToConsole(spentSortTime);
                            Console.WriteLine("____________________________");
                            break;
                        }
                    case 4:
                        {
                            // TODO: updated code
                            TimeSpan spentGroupTime =  journal.GroupByGrade();
                            WriteSpentTimeToConsole(spentGroupTime);
                            Console.WriteLine("____________________________");
                            break;
                        }
                    case 5:
                        {
                            journal.GetToConcoleStudentArray();
                            Console.Write("Write index of Student which you want to change: ");
                            resultOfParsing = int.TryParse(Console.ReadLine(), out var index);
                            // TODO: don`t limit possible value by 10. Number of students could be changed in future.
                            // TODO: better to write like this:
                            // if (!resultOfParsing || index <= 0 || index > journal.CountOfStudents - 1)
                            if (!resultOfParsing || (index <= 0) || (index > 10))
                            {
                                GetErrorMessage();
                                continue;
                            }
                            TimeSpan spentChangeTime = journal.ChangeStudent(index-1);
                            WriteSpentTimeToConsole(spentChangeTime);
                            Console.WriteLine("____________________________");
                            break;
                        }
                    case 6:
                        {
                            TimeSpan spentAverageTime = journal.GetAverageAge();
                            WriteSpentTimeToConsole(spentAverageTime);
                            Console.WriteLine("____________________________");
                            break;
                        }
                    case 7:
                        {
                            appIsRunning = false;
                            break;
                        }                       
                }
            }
        }

        /// <summary>
        /// Writes spent time to console
        /// </summary>
        /// <param name="time">Spent time</param>
        private void WriteSpentTimeToConsole (TimeSpan time)
        {
            var elapsedTime = time.ToString(@"mm\:ss\.FFFFFF");
            Console.WriteLine($"\nSpent time: {elapsedTime}");
        }

        /// <summary>
        /// Writes an error message, if value was wrong
        /// </summary>
        private void GetErrorMessage()
        {
            Console.WriteLine("Looks like wrong value, try again");
            Console.WriteLine("_________________________________");
        }
    }
}
