using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BookCat.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column("Name")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string? Name { get; set; }

        public virtual List<Book> Books { get; set; }

        public Category()
        {
        }
    }
}

