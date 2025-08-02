using System.Runtime.InteropServices;

namespace Homework15
{
    public class BookCloningForLibraryArchive
    {
        //2. Book Cloning for Library Archive
        //------------------------------------------------
        //Topic: ICloneable
        //Model a `Book` class:
        //- string Title
        //- string Author
        //- int Year
        //- string Isbn
        //- Edition EditionInfo(class)
        //Tasks:
        //- Implement deep cloning of Book using ICloneable.
        //- Ensure `EditionInfo` is also deeply cloned.
        public BookCloningForLibraryArchive()
        {
            Book original = new Book
            {
                Title = "Original",
                Author = "Robert C. Martin",
                Year = 2008,
                Isbn = "9780132350884",
                EditionInfo = new Edition
                {
                    EditionNumber = 1,
                    Publisher = "Prentice Hall"
                }
            };
            Book clone = (Book) original.Clone();

            clone.Title = "Copy";
            clone.EditionInfo.EditionNumber = 2;
            clone.EditionInfo.Publisher = "Clone Publisher";

            Console.WriteLine("Original Book:");
            Console.WriteLine(original.Title);

            Console.WriteLine("Cloned Book:");
            Console.WriteLine(clone.Title);
        }
    }
}
