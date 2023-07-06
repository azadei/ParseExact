using System;
using System.Globalization;

namespace ParseExact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var date = DateTime.ParseExact("16_06_1992", "dd_MM_yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("Date:" + date.ToString());
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid date format");
            }
        }
    }
}
