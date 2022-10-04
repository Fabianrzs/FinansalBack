using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class SubCategory
    {
        [Key]
        public int IdCategory { get; set; }
        public string Descrition { get; set; }
        public Category Category { get; set; }
    }
}