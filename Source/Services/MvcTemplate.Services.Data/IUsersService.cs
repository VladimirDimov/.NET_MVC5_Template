namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using MvcTemplate.Data.Models;
    
    public interface IUsersService
    {
        IQueryable<User> All();
    }
}