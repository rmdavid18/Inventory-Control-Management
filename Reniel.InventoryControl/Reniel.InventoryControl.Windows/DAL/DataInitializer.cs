using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reniel.InventoryControl.Windows.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<DataAccess>
    {
        protected override void Seed(DataAccess context)
        {
            context.LoginUsers.Add(new Models.LoginUser()
            {
                Id = Guid.Parse("2ceee862-a549-4f31-9939-dbfc91ed2471"),
                FirstName = "RenielKalboMasamangtao",
                LastName = "David",
                EmailAddress = "youjizz.com",
                Status = Models.Enums.Status.Probationary,
                Assignment = Models.Enums.Assignment.Field,




            });


        }

    }
}
