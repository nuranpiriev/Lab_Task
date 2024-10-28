using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public class LibraryCatalog
    {
        private LibraryItem[] catalog = new LibraryItem[100];
        private int count = 0;

        public LibraryItem GetLibraryItemById(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (catalog[i].Id == id)
                    return catalog[i];
            }

            throw new CustomBookError($"Book with ID {id} is not found in the catalog.");
        }

        public void AddLibraryItem(LibraryItem item)
        {
            if (count < catalog.Length)
            {
                catalog[count] = item;
                count++;
            }
        }
    }

}
