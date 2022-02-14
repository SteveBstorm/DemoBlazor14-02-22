using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class ProductForm
    {
        [Required(ErrorMessage = "Nom du produit Requis")]
        [Display(Name = "Nom du produit")]
        [MaxLength(50)]
        [DataType(DataType.PhoneNumber, ErrorMessage ="toto")]
        public string Name { get; set; }

        [Range(0.00, 150.00)]
        public int Price { get; set; }

        //[RegularExpression(string.Empty)]
        //public string Email { get; set; }

        //[DataType(DataType.Password)]
        //public string Password { get; set; }
        //[Compare(nameof(Password) , ErrorMessage = "Les 2 champs doivent correspondre")]
        //public string ConfirmPassword { get; set; }
    }
}
