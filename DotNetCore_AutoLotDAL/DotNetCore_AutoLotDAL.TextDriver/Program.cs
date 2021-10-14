using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DotNetCore_AutoLotDAL.DataInitialization;
using DotNetCore_AutoLotDAL.EF;
using DotNetCore_AutoLotDAL.Models;
using DotNetCore_AutoLotDAL.Repos;

namespace DotNetCore_AutoLotDAL.TextDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ADO.NET EF Coew 2 ***");

            /*
            using (var context = new AutoLotContext())
            {
                MyDataInitializer.RecreateDatabase(context);
                MyDataInitializer.InitializeData(context);

                foreach (var inventory in context.Cars)
                {
                    Console.WriteLine(inventory);
                }
            }
            */

            Console.WriteLine("** Using Repo **");
            using (var repo = new InventoryRepo())
            {
                foreach (var inventory in repo.GetAll())
                {
                    Console.WriteLine(inventory);
                }
            }

            Console.ReadLine();
        }
    }
}
