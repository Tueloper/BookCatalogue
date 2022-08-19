using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BookCat.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("author")]
        [Display(Name = "Author")]
        [StringLength(50)]
        public string? Author { get; set; }

        [Required]
        [Column("bookTitle")]
        [Display(Name = "Book Title")]
        [StringLength(100)]
        public string? BookTitle { get; set; }

        [Column("description")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        public int CategorId { get; set; }

        public Category? Category { get; set; }

        public Book()
        {
        }
    }
}

