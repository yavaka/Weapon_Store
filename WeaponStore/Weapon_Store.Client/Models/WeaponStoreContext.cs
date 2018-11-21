using Weapon_Store.Client.Models;
using Microsoft.EntityFrameworkCore;

namespace Weapon_Store.Client.Models
{
    public class WeaponStoreContext : DbContext
    {
        public WeaponStoreContext(DbContextOptions<WeaponStoreContext> options)
            : base(options)
        { }

        
    }
}
