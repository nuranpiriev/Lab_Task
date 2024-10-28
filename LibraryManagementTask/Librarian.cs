using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }

        public Librarian(int id, string name, DateTime hireDate) : base(name)
        {
            Id = id;
            HireDate = hireDate;
        }
    }

}
