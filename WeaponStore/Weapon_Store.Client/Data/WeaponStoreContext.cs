using Weapon_Store.Client.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Weapon_Store.Client.Data
{
    public class WeaponStoreContext : IdentityDbContext
    {
        public WeaponStoreContext(DbContextOptions<WeaponStoreContext> options)
            : base(options)
        { }
    }
}
