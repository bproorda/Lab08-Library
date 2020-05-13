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
    }
}
