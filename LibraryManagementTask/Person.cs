using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; }

        protected Person(string name)
        {
            Name = name;
        }
    }

}
