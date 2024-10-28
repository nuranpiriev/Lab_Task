using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public abstract class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; }
        public int? PublicationYear { get; }

        protected LibraryItem(string title, int? publicationYear = null)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public abstract void DisplayInfo();
    }

}
