namespace Homework15
{
    public class Movie:IComparable<Movie>
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }

        public int CompareTo(Movie? other)
        {
            if (other is null) return 1;
            //if(other.Rating == this.Rating) return other.ReleaseYear.CompareTo(this.ReleaseYear);
            int ratingComparison = other.Rating.CompareTo(this.Rating);
            if (ratingComparison == 0) return other.ReleaseYear.CompareTo(this.ReleaseYear);

            return other.Rating.CompareTo(this.Rating);
        }
    }
}
