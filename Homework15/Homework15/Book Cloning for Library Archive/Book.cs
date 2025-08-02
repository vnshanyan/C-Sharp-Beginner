namespace Homework15
{
    public class Book: ICloneable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }
        public Edition EditionInfo { get; set; }

        public object Clone()
        {
            return new Book
            {
                Title = this.Title,
                Author = this.Author,
                Year = this.Year,
                Isbn = this.Isbn,
                EditionInfo = (Edition) this.EditionInfo.Clone(),
            };
        }
    }
}
