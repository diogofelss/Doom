using System.Data.Entity.Migrations;
using Gaya.Database.Context;
using Gaya.Domain.Entities;

namespace Gaya.Database.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<GayaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GayaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //var usuario = new Usuario();
            //
            //usuario.Ativo = true;
            //usuario.EmpresaId = 1;
            //usuario.Nome = "root";
            //usuario.Senha = "123456";
            //
            //context.Usuario.Add(usuario);
        }
    }
}