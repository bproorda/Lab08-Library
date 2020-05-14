namespace Lab08Library
{
    public class Book
    {
        public Book(string title, Author author, int numberPages, Genres genre)
        {
            this.Title = title;
            this.bookAuthor = author;
            this.NumberOfPages = numberPages,
            this.Genre = genre;
        }

        public string Title { get; set; }
        public Author bookAuthor { get;  set; }
        public int NumberOfPages { get;  set; }
        private Genres Genre { get; set; }

        public enum Genres
        {
            Speculative,
            Fantasy,
            Mystery,
            Horror,
            Classic,
            History,
            Science,
        }
    }
}
