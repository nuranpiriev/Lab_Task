using LibraryManagementTask.Enums;
using LibraryManagementTask.Structs;

namespace LibraryManagementTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var librarianService = new LibrarianService();
            var librarian = new Librarian(1, "Malik", DateTime.Now);
            librarianService.CreateLibrarian(librarian);

            var catalog = new LibraryCatalog();
            var location = new LibraryLocation { Aisle = 3, Shelf = 5 };
            var book = new Book(1, "Bir galanin sirri", 1925, BookGenre.Fiction, location);
            catalog.AddLibraryItem(book);

            book.DisplayInfo();
            Console.WriteLine("Book Age: " + book.CalculateAge());
        }
    }

}
