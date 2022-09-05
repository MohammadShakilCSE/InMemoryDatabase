using Autofac;
using WebApi.Models;
using WebApi.Repositories;
using WebApi.Services;
using WebApi.UnitOfWorks;

public class ApiModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ContactUnitOfWork>().As<ContactUnitOfWork>()
            .InstancePerLifetimeScope();

        builder.RegisterType<ContactRepository>().As<IContactRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<ContactService>().As<IContactService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<AddContactModel>().AsSelf()
            .InstancePerLifetimeScope();

        base.Load(builder);
    }
}