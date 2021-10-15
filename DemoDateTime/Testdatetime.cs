using System;
using System.Collections.Generic;

#nullable disable

namespace DemoDateTime
{
    public partial class Testdatetime
    {
        public int Id { get; set; }
        public DateTime? Time1 { get; set; }
        public DateTime? Time2 { get; set; }
        public string Note { get; set; }

        public Testdatetime(DateTime t1, DateTime t2)
        {
            this.Time1 = t1;
            this.Time2 = t2;
        }

        public Testdatetime()
        {

        }
    }
}
