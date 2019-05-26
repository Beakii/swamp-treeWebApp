using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Models
{
    public class Review
    {
        public UserAccount User { get; set; }
        public String UserReview { get; set; }
    }
}
