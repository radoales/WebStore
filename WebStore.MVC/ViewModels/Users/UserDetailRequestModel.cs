namespace WebStore.MVC.ViewModels.Users
{
    using WebStore.MVC.Data.Models;
    public class UserDetailRequestModel
    {
        public string Id { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }
    }
}
