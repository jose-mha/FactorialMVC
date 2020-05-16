using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace FactorialMVC.Models
{
    public partial class Factorial
    {
        public long Number { get; set; }
        public long Result { get; set; }
        public IList<long> Results { get; set; }
    }
}
