using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class GradGetRequest
    {

        public int ID { get; set; }
        public string NazivGrada { get; set; }
        public int? PostanskiBroj { get; set; }
    }
}
