using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public class CustomBookError : Exception
    {
        public CustomBookError(string message) : base(message) { }
    }

}
