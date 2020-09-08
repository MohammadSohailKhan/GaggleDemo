using Microsoft.AspNet.Identity.EntityFramework;


namespace MdSohail_GaggleChallenge.Migrations.Identity
{
    internal class RoleManger<T>
    {
        //private RoleStore<IdentityRole> roleStore;
        private RoleStore<IdentityRole> roleStore1;

        public RoleManger(RoleStore<IdentityRole> roleStore1)
        {
            this.roleStore1 = roleStore1;
        }

        //public RoleManger(RoleStore<IdentityRole> roleStore)
        //{
        //    this.roleStore = roleStore;
        //}
    }
}

