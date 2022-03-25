using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class PlatiKartuUpsertRequest
    {
        public int PlatiKartuID { get; set; }
        public int KupacID { get; set; }
        public int KartaID { get; set; }
        public double CijenaSaPopustom { get; set; }
    }
}
