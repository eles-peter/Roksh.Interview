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
            context.Users.Add(new User { UserName = "User", Password = "test1234" });
            context.SaveChanges();
        }

        public static void InitializePackStates(DataContext context)
        {
            context.Database.EnsureCreated();

            if (context.PackStates.Any())
            {
                return;
            }

            var packStates = new PackState[]
            {
                new PackState{Id = 1, StateCode = "WfPu", EnglishMessage = "Waiting for Pick Up" , HungarianMessage = "Csomag a feladónál. Futárra vár"},
                new PackState{Id = 2, StateCode = "Pu", EnglishMessage = "Picked Up" , HungarianMessage = "Csomag a futárnál. depóba tart"},
                new PackState{Id = 3, StateCode = "ID", EnglishMessage = "In Depot" , HungarianMessage = "Depóban van. Kiszállításra vár"},
                new PackState{Id = 4, StateCode = "OD", EnglishMessage = "On Delivery" , HungarianMessage = "Kiszállítás alatt áll. Célba tart."},
                new PackState{Id = 5, StateCode = "DD", EnglishMessage = "Delivered" , HungarianMessage = "Kiszállítva."}
            };

            foreach (PackState ps in packStates)
            {
                context.PackStates.Add(ps);
            }
            context.SaveChanges();

        }
    }
}
