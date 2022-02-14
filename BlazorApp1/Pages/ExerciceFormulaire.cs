using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class ExerciceFormulaire
    {
        public string Status { get; set; }
        public ContactForm MyForm { get; set; }
        public ExerciceFormulaire()
        {
            MyForm = new ContactForm();

    }

        public void ValidSubmit()
        {
            Status = "Validation OK";
        }

        public void InvalidSubmit()
        {
            Status = "Vérifiez le formulaire";
        }
    }
}
