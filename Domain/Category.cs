using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string Descrition { get; set; }
        public ICollection<SubCategory> Categories { get; set; }
        public ICollection<Detail> Utilities { get; set; }
    }
}