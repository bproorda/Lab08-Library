using System;
using Xunit;

namespace Lab08Library.Tests
{
    public class LibraryTests
    {
        [Fact]
        public void Book_has_Author()
        {
            //arrange
            Author gb = new Author("Greg", "Bear");
            Book songs = new Book("Songs of Earth and Power", gb, 750, Book.Genres.Speculative);

            //act
            string actual = songs.bookAuthor.LastName;

            //Assert
            Assert.Equal("Bear", actual);
            //Assert.Equal("What?", $"{songs.Genre}");
        }

        [Fact]

        public void Initial_list_is_Empty()
        {
            //act
            Library<int> testCollection = new Library<int>();

            //assert
            Assert.Equal(0, testCollection.Count);
        }

        [Fact]

        public void Can_Add_To_List()
        {
            //arrange
            Library<int> testCollection = new Library<int>();

            //Act
            testCollection.Add(13);

            //Assert
            Assert.Equal(1, testCollection.Count);
            Assert.Equal(13, testCollection[0]);
        }

        [Fact]
        public void Can_Add_Beyond_Capacity()
        {
            //arrange
            int capacity = 1;
            Library<int> testCollection = new Library<int>(capacity);
            testCollection.Add(21);

            //act
            testCollection.Add(87);

            //assert
            Assert.Equal(2, testCollection.Count);
            Assert.Equal(87, testCollection[1]);

        }

        [Fact]
        public void Can_enumerate_a_list()
        {
            Library<string> ourList = new Library<string>
            {
                "Matt",
                "Brenn"
            };

            foreach (string item in ourList)
            {
                Assert.NotNull(item);
            }

            Assert.Equal(
                new[] { "Matt", "Brenn" },
                ourList);
        }

        [Fact]
        public void Can_remove_book()
        {
            // Arrange
            Library<int> testCollection = new Library<int>();
            testCollection.Add(17);

            // Act
            testCollection.Remove(0);

            // Assert
            Assert.Equal(0, testCollection.Count);
        }
        [Fact]
        public void Can_REALLY_remove_book()
        {
            // Arrange
            Library<string> testCollection = new Library<string>();
            testCollection.Add("Self Help");
            testCollection.Add("Help");


            // Act
            testCollection.Remove(0);

            // Assert
            string[] actual = testCollection.ViewAllBooks();
            string[] expected = new string[] { "Help" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_view_all_items()
        {
            // Arrange
            Library<string> testCollection = new Library<string>();
            testCollection.Add("Robinson Crusoe");
            testCollection.Add("Huckleberry Finn");
            testCollection.Add("Twilight");

            // Act
            string[] actual = testCollection.ViewAllBooks();
            string[] expected = new string[]
            {
            "Robinson Crusoe",
            "Huckleberry Finn",
            "Twilight"
            };

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Can_view_all_Books()
        {
            //arrange
            Author gb = new Author("Greg", "Bear");
            Book songs = new Book("Songs of Earth and Power", gb, 750, Book.Genres.Speculative);
            Author JrrT = new Author("J.R.R.", "Tolkien");
            Book lotr = new Book("Lord of the Rings", JrrT, 1952, Book.Genres.Fantasy);

            Library<Book> testCollection = new Library<Book>();
            testCollection.Add(songs);
            testCollection.Add(lotr);


            //act
            string[] actual = testCollection.ViewAllBooks();
            string[] expected = new string[] { "1", "2" };

            //assert
            Assert.Equal(expected, actual);


        }
      

    }
}
