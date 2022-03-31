namespace FifthTask
{
    /// <summary>
    /// Starts the project
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point into application
        /// </summary>
        static void Main()
        {
            var result = new OutputValue();
            // TODO: split method into logically separated methods (.InputValues(), .Sort()/Calculate(), .OutputResults())
            // TODO: ideally it should be separated classes (InputOutputManager or smth, Sorter (ArraySorter)).
            result.GetInputValue();
        }
    }
}
