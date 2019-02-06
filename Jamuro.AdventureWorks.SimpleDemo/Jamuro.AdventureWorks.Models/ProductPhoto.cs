using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamuro.AdventureWorks.Models
{
    public class ProductPhoto
    {
        public ProductPhoto()
        {

        }

        public int ProductPhotoID { get; set; }

        public byte[] ThumbNailPhoto { get; set; }

        public byte[] LargePhoto { get; set; }

    }
}
