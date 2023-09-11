namespace Sorting_Comparisons
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "King Kong", Year = 2005, Genres = new List<string> { " Adventure", "Drama" } },
            new Movie { Title = "The Shawshank Redemption", Year = 1994, Genres = new List<string> { "Drama" } },
            new Movie { Title = "The Dark Knight", Year = 2008, Genres = new List<string> { "Action", "Super Heros" } },
            new Movie { Title = "The Godfather", Year = 1972, Genres = new List<string> { "Crime", "Drama" } },
        };



            List<Movie> sortedByYear = SortMoviesByYear(movies);
            Console.WriteLine("Sorted by Year:");
            Console.WriteLine();
            foreach (var movie in sortedByYear)
            {
                Console.WriteLine($"{movie.Title} ({movie.Year})");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            List<Movie> sortedByTitle = SortMoviesByTitle(movies);
            Console.WriteLine("Sorted by Title:");
            Console.WriteLine();
            foreach (var movie in sortedByTitle)
            {
                Console.WriteLine(movie.Title);
            }
            Console.ReadKey();
        }
        public static List<Movie> SortMoviesByYear(List<Movie> movies)
        {
            return movies.OrderByDescending(movie => movie.Year).ToList();
        }



        // Sort movies alphabetically 

        public static List<Movie> SortMoviesByTitle(List<Movie> movies)
        {
            return movies.OrderBy(movie => RemoveLeadingArticlesAndTrim(movie.Title)).ToList();
        }



        public static string RemoveLeadingArticlesAndTrim(string title)
        {
            // Remove leading "A", "An", or "The" and trim spaces
            string[] articles = { "A ", "An ", "The " };
            string trimmedTitle = title.Trim();

            foreach (var article in articles)
            {
                if (trimmedTitle.StartsWith(article, StringComparison.OrdinalIgnoreCase))
                {
                    trimmedTitle = trimmedTitle.Substring(article.Length).Trim();
                    break;
                }
            }

            return trimmedTitle;
        }
    }
}