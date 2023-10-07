using graph_business_trip;

namespace BusinessTripTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBusinessTripPossible()
        {
            // Arrange
            Graph graph = new Graph();
            City metroville = new City("Metroville");
            City pandora = new City("Pandora");
            metroville.Neighbors.Add(pandora, 82);
            graph.Cities.Add(metroville);
            graph.Cities.Add(pandora);

            string[] cities = { "Metroville", "Pandora" };

            // Act
            int? result = Program.BusinessTrip(graph, cities);

            // Assert
            Assert.Equal(82, result);
        }

        [Fact]
        public void TestBusinessTripPossibleWithMultipleCities()
        {
            // Arrange
            Graph graph = new Graph();
            City arendelle = new City("Arendelle");
            City newMonstropolis = new City("New Monstropolis");
            City naboo = new City("Naboo");
            arendelle.Neighbors.Add(newMonstropolis, 42);
            newMonstropolis.Neighbors.Add(naboo, 73);
            graph.Cities.Add(arendelle);
            graph.Cities.Add(newMonstropolis);
            graph.Cities.Add(naboo);

            string[] cities = { "Arendelle", "New Monstropolis", "Naboo" };

            // Act
            int? result = Program.BusinessTrip(graph, cities);

            // Assert
            Assert.Equal(115, result);
        }

        [Fact]
        public void TestBusinessTripNotPossible()
        {
            // Arrange
            Graph graph = new Graph();
            City naboo = new City("Naboo");
            City pandora = new City("Pandora");
            graph.Cities.Add(naboo);
            graph.Cities.Add(pandora);

            string[] cities = { "Naboo", "Pandora" };

            // Act
            int? result = Program.BusinessTrip(graph, cities);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TestBusinessTripNotPossibleWithDisconnectedCities()
        {
            // Arrange
            Graph graph = new Graph();
            City narnia = new City("Narnia");
            City arendelle = new City("Arendelle");
            City naboo = new City("Naboo");
            arendelle.Neighbors.Add(naboo, 42);
            graph.Cities.Add(narnia);
            graph.Cities.Add(arendelle);
            graph.Cities.Add(naboo);

            string[] cities = { "Narnia", "Arendelle", "Naboo" };

            // Act
            int? result = Program.BusinessTrip(graph, cities);

            // Assert
            Assert.Null(result);
        }
    }
}