namespace WebStore.MVC.Services.Implementations
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using ViewModels;
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
                Email = x.Email
            });
        }

        public async Task<UserDetailRequestModel> GetUser(string id)
        {
            return await this.context
                .Users
                .Where(u => u.Id == id)
                .Select(x => new UserDetailRequestModel
                {
                    Id = x.Id,
                    Username = x.UserName,
                    Email = x.Email
                }).FirstOrDefaultAsync();
        }

        public async Task Delete(string id)
        {
            var user = await this.context.Users.FindAsync(id);
            this.context.Users.Remove(user);
            await this.context.SaveChangesAsync();
        }
    }
}
