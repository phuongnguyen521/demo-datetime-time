using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoDateTime
{
    class GetDateTimeDb
    {
        static void Main(string[] args)
        {
            IEnumerable<Testdatetime> result = getData();
            if (result!= null)
            {
                Console.WriteLine("|\tID\t|\tDateTime\t|\tDate\t|");
                foreach (Testdatetime temp in result)
                {
                    Console.WriteLine($"\t{temp.Id}\t|{temp.Time1}\t|\t{temp.Time2}");
                }
            }
        }

        static IEnumerable<Testdatetime> getData()
        {
            IEnumerable<Testdatetime> result = null;
            using var context = new DEMOTIMEDATEContext();
            result = context.Testdatetimes.ToList();
            return result;
        }
    }
}
