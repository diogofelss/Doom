namespace Gaya.Database.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Gaya.Database.Context.GayaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Gaya.Database.Context.GayaContext context)
        {
            //var usuarioRoot = context.USUARIO.Where(c => c.Nome == "root").FirstOrDefault();
            //
            //if (usuarioRoot == null)
            //{
            //    usuarioRoot = new Usuario();
            //
            //    usuarioRoot.EmpresaId = 1;
            //    usuarioRoot.Nome = "root";
            //    usuarioRoot.Senha = "difel123";
            //    usuarioRoot.UsuarioCadastroId = 0;
            //    usuarioRoot.Ativo = true;
            //
            //    context.USUARIO.AddOrUpdate(usuarioRoot);
            //}

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
        }
    }
}
