namespace WebStore.MVC.Services
{
    using System.Threading.Tasks;
    public interface IAddressService
    {
        Task<int> CreateAddress(string town, int zip, string addressField);
    }
}
