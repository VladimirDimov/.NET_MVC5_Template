﻿namespace MvcTemplate.Services.Data
{
    using System.Linq;

    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;

    public class UsersService : IUsersService
    {
        private IDbGenericRepository<User, string> users;

        public UsersService(IDbGenericRepository<User, string> users)
        {
            this.users = users;
        }

        public IQueryable<User> All()
        {
            return this.users.All();
        }
    }
}
