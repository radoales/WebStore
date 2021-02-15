namespace WebStore.MVC.Services.Implementations
{
    using System;
    using System.Threading.Tasks;
    using WebStore.MVC.Data;
    using Data.Models;

    public class AddressService : IAddressService
    {
        private readonly WebStoreDbContext context;

        public AddressService(WebStoreDbContext context)
        {
            this.context = context;
        }

        public async Task<int> CreateAddress(string town, int zip, string addressField)
        {
            var address = new Address
            {
                Town = town,
                Zip = zip,
                AddressField = addressField
            };

            await this.context.AddAsync(address);
            await this.context.SaveChangesAsync();

            return address.Id;
        }
    }
}
