using Autofac;
using Blog.Application.Services;
using Blog.Domain;
using Blog.Domain.Repositories;
using Blog.Domain.Services;
using Blog.Infrastructure;
using Blog.Infrastructure.Repositories;

namespace Blog.Web
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;
        public WebModule(string connectionString, string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionString",_connectionString)
                .WithParameter("migrationAssembly",_migrationAssembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<BookRepository>().As<IBookRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<BookService>().As<IBookService>()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
