using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC11.EFCore
{
    internal class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        [MaxLength(60)]
        public string FirstName { get; set; }
        [MaxLength(60)]
        public string SurName { get; set; }
        public double BirthDate { get; set; }        
    }
}
