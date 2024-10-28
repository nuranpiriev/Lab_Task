using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public class DVD : LibraryItem
    {
        public DVD(int id, string title, int? publicationYear) : base(title, publicationYear)
        {
            Id = id;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD Title: {Title}, Publication Year: {PublicationYear}");
        }
    }

}
