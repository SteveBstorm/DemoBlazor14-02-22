using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace BlazorApp1.Models
{
    public class ContactForm
    {
        [Required]
        [MinLength(5)]
        public string Nom { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public Color ColorChoice { get; set; }
    }
}
