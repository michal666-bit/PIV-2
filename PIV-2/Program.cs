using System;
using System.Linq;
using PIV_2.NORTHWINDModel;

namespace PIV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();
            ctx.Database.EnsureCreated();
            ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4",IloscObecnych = 15,Sala = "B316" });
            ctx.SaveChanges();
            //  foreach (var item in ctx.Zajecias)
            // {
            //     Console.WriteLine(item.Nazwa);

            // }
            using var northwindContext = new NORTHWNDContext();
           var ukClients = northwindContext.Customers.Where(x => x.Country == "UK");
            foreach (var item in ukClients)
            {
                Console.WriteLine(item.CompanyName);
                }

            }

        }
    }

