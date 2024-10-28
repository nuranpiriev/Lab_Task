using LibraryManagementTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public class LibrarianService : ILibrarianService
    {
        private Librarian[] librarians = new Librarian[100];
        private int count = 0;

        public Librarian GetLibrarianById(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (librarians[i].Id == id)
                    return librarians[i];
            }
            return null;
        }

        public Librarian[] GetAllLibrarians()
        {
            Librarian[] result = new Librarian[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = librarians[i];
            }
            return result;
        }

        public void CreateLibrarian(Librarian librarian)
        {
            if (count < librarians.Length)
            {
                librarians[count] = librarian;
                count++;
            }
        }

        public void DeleteLibrarian(Librarian librarian, bool isSoftDelete)
        {
            if (isSoftDelete)
            {
                // Soft delete logic
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (librarians[i] == librarian)
                    {
                        for (int j = i; j < count - 1; j++)
                        {
                            librarians[j] = librarians[j + 1];
                        }
                        count--;
                        break;
                    }
                }
            }
        }
    }

}
