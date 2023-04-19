using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC11.EFCore
{
    internal class Assessment
    {
        public string AbbrvId { get; set; }
        public int StudentId { get; set; }
        public int Rate { get; set; }
    }
    
}
