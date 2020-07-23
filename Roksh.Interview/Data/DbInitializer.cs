using Roksh.Interview.Models;
using Roksh.Interview.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roksh.Interview.Data
{
    public static class DbInitializer
    {

        public static void InitializeUsers(DataContext context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any())
            {
                return;
            }
            context.Users.Add(new User { UserName = "User", Password = "test1234", IsLoggedIn = false });
            context.SaveChanges();
        }

        public static void InitializePackStates(DataContext context)
        {
            context.Database.EnsureCreated();

            if (context.PackStates.Any())
            {
                return;
            }
            
            context.PackStates.Add(new PackState { StateCode = "WfPu", EnglishMessage = "Waiting for Pick Up" , HungarianMessage = "Csomag a feladónál. Futárra vár"});
            context.PackStates.Add(new PackState { StateCode = "Pu", EnglishMessage = "Picked Up", HungarianMessage = "Csomag a futárnál. depóba tart" });
            context.PackStates.Add(new PackState { StateCode = "ID", EnglishMessage = "In Depot", HungarianMessage = "Depóban van. Kiszállításra vár" });
            context.PackStates.Add(new PackState { StateCode = "OD", EnglishMessage = "On Delivery", HungarianMessage = "Kiszállítás alatt áll. Célba tart." });
            context.PackStates.Add(new PackState { StateCode = "DD", EnglishMessage = "Delivered", HungarianMessage = "Kiszállítva." });

            context.SaveChanges();

        }
    }
}
