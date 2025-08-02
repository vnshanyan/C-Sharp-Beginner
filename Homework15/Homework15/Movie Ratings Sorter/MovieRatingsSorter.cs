namespace Homework15
{
    public class MovieRatingsSorter
    {
        /*
        4. Movie Ratings Sorter
        ------------------------------------------------
        Topic: IComparable<Movie>
        Create a `Movie` class:
        - string Title
        - double Rating
        - int ReleaseYear
        - string Genre
        Tasks:
        - Sort movies by Rating (descending).
        - If ratings are equal, sort by ReleaseYear (descending).
        - Optional: Filter top 5 movies per Genre.
        */
        public MovieRatingsSorter()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "Inception", Rating = 8.8, ReleaseYear = 2010, Genre = "Sci-Fi" },
                new Movie { Title = "Interstellar", Rating = 8.6, ReleaseYear = 2014, Genre = "Sci-Fi" },
                new Movie { Title = "The Matrix", Rating = 8.7, ReleaseYear = 1999, Genre = "Sci-Fi" },
                new Movie { Title = "The Godfather", Rating = 9.2, ReleaseYear = 1972, Genre = "Crime" },
                new Movie { Title = "The Dark Knight", Rating = 9.0, ReleaseYear = 2008, Genre = "Action" },
                new Movie { Title = "Pulp Fiction", Rating = 8.9, ReleaseYear = 1994, Genre = "Crime" },
                new Movie { Title = "Avengers: Endgame", Rating = 8.4, ReleaseYear = 2019, Genre = "Action" },
                new Movie { Title = "The Prestige", Rating = 8.5, ReleaseYear = 2006, Genre = "Drama" },
                new Movie { Title = "The Irishman", Rating = 7.9, ReleaseYear = 2019, Genre = "Crime" },
                new Movie { Title = "Dune", Rating = 8.1, ReleaseYear = 2021, Genre = "Sci-Fi" },
                new Movie { Title = "John Wick", Rating = 7.4, ReleaseYear = 2014, Genre = "Action" }
            };
            movies.Sort();

            foreach (var m in movies)
            {
                Console.WriteLine(m.Title);
                Console.WriteLine(m.Rating);
                Console.WriteLine(m.ReleaseYear);
                Console.WriteLine("####################");
            }
            Console.WriteLine("________________________________");
            var topPerGenre = movies.GroupBy(m => m.Genre).SelectMany(i => i.Take(5));
            foreach (var m in topPerGenre)
            {
                Console.WriteLine(m.Title);
                Console.WriteLine(m.Rating);
                Console.WriteLine(m.ReleaseYear);
                Console.WriteLine("####################");
            }
        }
    }
}
