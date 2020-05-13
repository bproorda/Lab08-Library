namespace Lab08Library
{
    public class Book
    {
        public Book(string title, Author author, Genres genre)
        {
            this.Title = title;
            this.bookAuthor = author;
            this.Genre = genre;
        }

        public string Title { get; private set; }
        public Author bookAuthor { get; private set; }
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
