using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouchbaseDI.Models
{
    public class Airline
    {
        public string Id { get; set; }
        //META(a).id, a.name, a.country, a.callsign
        public string Name { get; set; }
        public string Country { get; set; }
        public string Callsign { get; set; }
    }
}
