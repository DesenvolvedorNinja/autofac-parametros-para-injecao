using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemoWin
{
    public sealed class ContainerManager
    {
        private IContainer _container;

        public ContainerManager()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DesenvolvedorNinja>().As<IDesenvolvedor>().InstancePerDependency();
            _container = builder.Build();
        }

        public T GetInstance<T>()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}
