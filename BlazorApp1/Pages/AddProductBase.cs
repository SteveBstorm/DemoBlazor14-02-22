using BlazorApp1.Models;
using DataAccessLayer.Abstraction;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class AddProductBase : ComponentBase
    {
        [Inject]
        public IProductRepo _repo { get; set; }
        public ProductForm MyForm{ get; set; }

        public void SubmitForm()
        {
            _repo.PublishData(MyForm.Name, MyForm.Price);
        }

        public AddProductBase()
        {
            MyForm = new ProductForm();
        }
    }
}
