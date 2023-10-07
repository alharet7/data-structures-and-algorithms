using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_business_trip
{
    public class Graph
    {
        public List<City> Cities { get; set; }

        public Graph()
        {
            Cities = new List<City>();
        }
    }

}
