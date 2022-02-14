using DataAccessLayer.Abstraction;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public partial class Product
    {
        [Inject]
        public IProductRepo _repo { get; set; }

        public string LastName { get; set; }

        public string Toto { get; set; } = "Toto";

        public List<DataAccessLayer.Entities.Product> MyList { get; set; }

        protected override void OnInitialized()
        {
            MyList = new List<DataAccessLayer.Entities.Product>();

            MyList = _repo.GetAll().ToList();
        }


        public void InsertDB()
        {
            for (int i = 1; i <= 50; i++)
            {
                _repo.PublishData("Product nbr : " + i, i * 2);

            }
            MyList = _repo.GetAll().ToList();
        }
    }
}
