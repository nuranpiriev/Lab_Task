using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask
{
    public class Magazine : LibraryItem
    {
        public Magazine(int id, string title, int? publicationYear) : base(title, publicationYear)
        {
            Id = id;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine Title: {Title}, Publication Year: {PublicationYear}");
        }
    }

}
