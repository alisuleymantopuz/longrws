using Autofac;
using NorthwindLRA.IoC.HostInitialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLRA.IoC
{
    public class ApplicationBootstrapper : IDisposable
    {
        readonly IContainer _container;

        public ApplicationBootstrapper()
        {
            var builder = new ContainerBuilder();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterAssemblyModules(assemblies);

            builder.RegisterAssemblyTypes(assemblies)
                .Where(type => type.IsAssignableTo<IServiceHostInitializer>())
                .As<IServiceHostInitializer>()
                .SingleInstance();

            _container = builder.Build();
        }

        public void Start()
        {
            foreach (var serviceHostInitializer in _container.Resolve<IEnumerable<IServiceHostInitializer>>())
                serviceHostInitializer.Initialize();
        }

        public void Dispose()
        {
            if (_container != null)
                _container.Dispose();
        }
    }
}
