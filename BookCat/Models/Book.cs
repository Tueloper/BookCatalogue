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
        public string? Author { get; set; }

        [Required]
        [Column("bookTitle")]
        [Display(Name = "Book Title")]
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

