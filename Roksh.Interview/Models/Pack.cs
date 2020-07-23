using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Roksh.Interview.Models
{
    public class Pack
    {
        public int Id { get; set; }
        public string PackId { get; set; }
        public PackState PackState { get; set; }
        public List<PackProduct> PackProducts { get; set; }
    }
}
