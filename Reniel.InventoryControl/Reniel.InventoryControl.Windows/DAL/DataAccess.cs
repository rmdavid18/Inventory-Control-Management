using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reniel.InventoryControl.Windows.DAL
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(new Reniel.InventoryControl.Windows.DAL.DataInitializer());
        }
        public DbSet<Models.LoginUser> LoginUsers { get; set; }
    }

}