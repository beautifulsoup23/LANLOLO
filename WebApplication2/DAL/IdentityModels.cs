using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication2.DAL
{

    public class P2PDbContext : IdentityDbContext<P2PUser>
    {
        public P2PDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static P2PDbContext Create()
        {
            return new P2PDbContext();
        }
    }
}