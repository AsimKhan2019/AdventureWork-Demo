using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamuro.AdventureWorks.Models
{
    public class ProductReview
    {
        public ProductReview() { }

        public int ProductReviewID { get; set; }

        public int ProductID { get; set; }

        public string ReviewerName { get; set; }

        public DateTime ReviewDate { get; set; }

        public string EmailAddress { get; set; }

        public int Rating { get; set; }

        public string Comments { get; set; }

    }
}
