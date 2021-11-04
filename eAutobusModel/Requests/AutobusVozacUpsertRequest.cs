using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class AutobusVozacUpsertRequest
    {
        public DateTime pocetak { get; set; }
        public DateTime kraj { get; set; }
        public int smjena { get; set; }
        
        public int autobusID { get; set; }
        
        public int VozacID { get; set; }
    }
}
