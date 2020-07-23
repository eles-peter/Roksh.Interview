using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roksh.Interview.Models
{
    public class PackProduct
    {
        public int PackId { get; set; }
        public Pack Pack { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
