namespace WebStore.MVC.Services.Implementations
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using ViewModels.Users;
    using WebStore.MVC.Data.Models;

    public class UserService : IUserService
    {
        private readonly WebStoreDbContext context;
        public UserService(WebStoreDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<UserDetailRequestModel>> GetAll()
        {
            return this.context.Users.Select(x => new UserDetailRequestModel
            {
                Id = x.Id,
                Username = x.UserName,
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address, 
                AddressId = x.AddressId
            });
        }

        public async Task<UserDetailRequestModel> GetUser(string id)
        {
            return await this.context
                .Users
                .Include(x => x.Address)
                .Where(u => u.Id == id)
                .Select(x => new UserDetailRequestModel
                {
                    Id = x.Id,
                    Username = x.UserName,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PhoneNumber = x.PhoneNumber,
                    Address = x.Address,
                    AddressId = x.AddressId
                }).FirstOrDefaultAsync();
        }

        public async Task Delete(string id)
        {
            var user = await this.context.Users.FindAsync(id);
            this.context.Users.Remove(user);
            await this.context.SaveChangesAsync();
        }

        public async Task<string> UpdateUser(string id, string firstName, string lastName, string email, string phoneNumber,
            string town, int zip, string addressField)
        {
            var user = await this.context.Users
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (user.Address == null)
            {
                user.Address = new Address()
                {
                    Town = town,
                    Zip = zip,
                    AddressField = addressField
                };
            }

            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.PhoneNumber = phoneNumber;

            this.context.Users.Update(user);
            await this.context.SaveChangesAsync();

            return user.Id;
        }
    }
}
