using System;

namespace DynamicOverloading
{
    static class Program
    {
        public static void ProcessItem (string s)
        {
            Console.WriteLine($"Processing string: {s}");
        }

        public static void ProcessItem(int i)
        {
            Console.WriteLine($"Processing int: {i}");
        }

        public static void ProcessItem(double d)
        {
            Console.WriteLine($"Processing double: {d:N2}");
        }

        public static void ProcessItem(DateTime d)
        {
            Console.WriteLine($"Processing DateTime: {d.ToShortDateString()}");
        }

        public static void ProcessItem(decimal d)
        {
            Console.WriteLine($"Processing Decimal: {d:N3}");
        }

        public static void RunReport()
        {
            string v0 = "Hello World";
            int v1 = 4;
            double v2 = 3.14159;
            DateTime v3 = DateTime.Now;

            object[] items = { v0, v1, v2, v3, 4.5m };

            #region Using dynamic overloading
            foreach (object o in items)
                ProcessItem((dynamic)o);
            #endregion

            #region Using a switch and pattern matching
            //foreach (object o in items)
            //{
            //    switch(o)
            //    {
            //        case string s: ProcessItem(s); break;
            //        case int i: ProcessItem(i); break;
            //        case double d: ProcessItem(d); break;
            //        case DateTime dt: ProcessItem(dt); break;
            //        case decimal dc: ProcessItem(dc); break;
            //    }
            //}
            #endregion

            #region Using static overloding (will not work through object base class
            //ProcessItem(v0);
            //ProcessItem(v1);
            //ProcessItem(v2);
            //ProcessItem(v3);
            #endregion
        }

        static void Main(string[] args)
        {
            RunReport();
        }
    }
}
