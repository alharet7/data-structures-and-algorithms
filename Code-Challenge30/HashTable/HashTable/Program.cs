namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyHashTable hashTable = new MyHashTable(1024);


            hashTable.Set("name", "Hareth");
            hashTable.Set("age", "28");
            hashTable.Set("city", "Amman");


            Node nameNode = hashTable.Get("name");
            Node ageNode = hashTable.Get("age");
            Node cityNode = hashTable.Get("city");


            bool containsName = hashTable.Contains("name");
            bool containsCountry = hashTable.Contains("country");


            Console.WriteLine("Value for 'name': " + nameNode?.Value);
            Console.WriteLine("\nValue for 'age': " + ageNode?.Value);
            Console.WriteLine("\nValue for 'city': " + cityNode?.Value);
            Console.WriteLine("\nContains 'name': " + containsName);
            Console.WriteLine("\nContains 'country': " + containsCountry);


            Console.ReadLine();

        }
    }
}