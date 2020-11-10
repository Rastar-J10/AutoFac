using Autofac;
using Autofac.Features.AttributeFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Services;

namespace WebApplication2.AppModuleRegister
{
    public class RegisterModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TestService>()
                .AsSelf()
                .As<ITestService>()
                .WithAttributeFiltering();

            builder.RegisterInstance(new SingleService("LBW"))
                .Keyed<SingleService>("lbw")
                .SingleInstance();

            builder.RegisterInstance(new SingleService("XMZ"))
                .Keyed<SingleService>("xmz")
                .SingleInstance();
        }
    }
}
