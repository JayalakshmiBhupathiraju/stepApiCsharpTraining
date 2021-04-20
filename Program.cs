using GradeBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace hii
{
    class program
    {
        static void Main(string[] args)
        {

            Grades.GradeBook book = new Grades.GradeBook();
            book.AddGrade(10);
            book.AddGrade(29.5f);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            string name1 = "Jaya";
            string name2 = "jaya";
            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);
        }
    }
}
