using DataAccessLayer.Entities;

namespace DataAccessLayer.Abstraction
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product GetById(int Id);
        void PublishData(string name, int price);
    }
}