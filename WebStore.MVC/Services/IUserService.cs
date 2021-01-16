namespace WebStore.MVC.Services
{
    using ViewModels.Users;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IUserService
    {
        public Task<IEnumerable<UserDetailRequestModel>> GetAll();
        public Task<UserDetailRequestModel> GetUser(string id);
        Task Delete(string id);
    }
}
