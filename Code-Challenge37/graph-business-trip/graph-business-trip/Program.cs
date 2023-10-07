namespace graph_business_trip
{
    public class Program
    {
        public static int? BusinessTrip(Graph graph, string[] cities)
        {
            int totalCost = 0;

            for (int i = 0; i < cities.Length - 1; i++)
            {
                City currentCity = graph.Cities.FirstOrDefault(city => city.Name == cities[i]);
                City nextCity = graph.Cities.FirstOrDefault(city => city.Name == cities[i + 1]);

                if (currentCity == null || nextCity == null || !currentCity.Neighbors.ContainsKey(nextCity))
                {
                    return null;
                }

                totalCost += currentCity.Neighbors[nextCity];
            }

            return totalCost;
        }

        public static void Main()
        {
            Graph graph = new Graph();


            City city1 = new City("Amman");
            City city2 = new City("NY");
            city1.Neighbors.Add(city2, 500);
            graph.Cities.Add(city1);
            graph.Cities.Add(city2);

            string[] citiesToVisit = { "Amman", "NY" };

            int? cost = BusinessTrip(graph, citiesToVisit);

            if (cost != null)
            {
                Console.WriteLine($"The total cost of the trip is: ${cost}");
            }
            else
            {
                Console.WriteLine("The trip is not possible.");
            }
            Console.ReadKey();
        }
    }

}