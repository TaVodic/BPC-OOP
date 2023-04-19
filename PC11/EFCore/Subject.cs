using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC11.EFCore
{
    internal class Subject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string AbbrvId { get; set; }
        [MaxLength (60)]
        public string Name { get; set; }
    }
}
