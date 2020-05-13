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
            Book songs = new Book("Songs of Earth and Power", gb);

            //act
            string actual = songs.bookAuthor.LastName;

            //Assert
            Assert.Equal("Bear", actual);
        }
    }
}
