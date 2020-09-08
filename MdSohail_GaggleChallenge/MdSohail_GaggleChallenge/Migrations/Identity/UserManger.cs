using System;
using MdSohail_GaggleChallenge.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MdSohail_GaggleChallenge.Migrations.Identity
{
    internal class UserManger<T>
    {
        private UserStore<ApplicationUser> userStore;

        public UserManger(UserStore<ApplicationUser> userStore)
        {
            this.userStore = userStore;
        }

        internal object Create(ApplicationUser user, string v)
        {
            throw new NotImplementedException();
        }

        internal object Create(object users, string v)
        {
            throw new NotImplementedException();
        }

        internal void AddToRole(object id, string v)
        {
            throw new NotImplementedException();
        }

        internal object FindByEmail(string v)
        {
            throw new NotImplementedException();
        }

        internal object FindByEmail(ApplicationUser user, object email)
        {
            throw new NotImplementedException();
        }
    }
}