using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public sealed class LibraryMember : Person
    {
        public DateTime MembershipDate { get; set; }

        public LibraryMember(int id, string name, DateTime membershipDate) : base(name)
        {
            Id = id;
            MembershipDate = membershipDate;
        }
    }

}
