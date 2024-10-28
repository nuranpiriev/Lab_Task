using LibraryManagementTask.Enums;
using LibraryManagementTask.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public class Book : LibraryItem
    {
        public BookGenre Genre { get; set; }
        public LibraryLocation Location { get; set; }

        public Book(int id, string title, int? publicationYear, BookGenre genre, LibraryLocation location)
            : base(title, publicationYear)
        {
            Id = id;
            Genre = genre;
            Location = location;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}, Genre: {Genre}, Location: Aisle {Location.Aisle}, Shelf {Location.Shelf}");
        }
    }

}
