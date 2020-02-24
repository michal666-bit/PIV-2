using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PIV_2
{
    [Table("Wykłady")]
    public class Zajecia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("NazwaPrzedmiotu")]
        [MinLength(1)]
        public string Nazwa { get; set; }
        public string Sala { get; set; }
        public DateTime Godzina { get; set; }
        public int IloscObecnych { get; set; }
    }
}
