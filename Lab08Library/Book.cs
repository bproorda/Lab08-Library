namespace Lab08Library
{
    public class Book
    {
        public Book(string title, Author author)
        {
            this.Title = title;
            this.bookAuthor = author;
        }

        public string Title { get; private set; }
        public Author bookAuthor { get; private set; }
    }
}
