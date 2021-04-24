using System;

namespace PropertiesDemo
{
    public class TimePeriod
    {
        private double _seconds;
        public double Hours
        {
            get { return _seconds; }
            set { _seconds = value * 3600; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in hours");
            TimePeriod t = new TimePeriod();
            string Input;
            Input= Console.ReadLine();
            int hours = Int32.Parse(Input);
            t.Hours = hours;
            Console.WriteLine("Time in seconds {0}",t.Hours);
        }
    }
}