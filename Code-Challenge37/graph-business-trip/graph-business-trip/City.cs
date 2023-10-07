using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_business_trip
{
    public class City
    {
        public string Name { get; set; }
        public Dictionary<City, int> Neighbors { get; set; }

        public City(string name)
        {
            Name = name;
            Neighbors = new Dictionary<City, int>();
        }
    }

}
