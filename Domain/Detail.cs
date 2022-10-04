using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Detail
    {
        [Key]
        public int IdDetail { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Decimal Valor { get; set; }
        public Category Category { get; set; }
    }
}