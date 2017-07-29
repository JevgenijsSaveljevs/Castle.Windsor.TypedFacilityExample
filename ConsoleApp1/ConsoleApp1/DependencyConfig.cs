using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Facilities.TypedFactory;

namespace ConsoleApp1
{
    public class DependencyConfig
    {
        public static void Configure(WindsorContainer container)
        {
            var userKernel = true;

            if (userKernel)
            {
                container.Kernel.AddFacility<TypedFactoryFacility>();
                container.Kernel.Register(Component.For<ITypedFactoryComponentSelector>().ImplementedBy<MessageBasedComponentSelector>());
                container.Kernel.Register(Component.For<ILoggerFactory>().AsFactory(x => x.SelectedWith<MessageBasedComponentSelector>()));
                container.Kernel.Register(Component.For<ILogger>().ImplementedBy<ConsoleLogger>());
                container.Kernel.Register(Component.For<IComplexComponent>().ImplementedBy<ComplexComponent>());
                container.Kernel.Register(Component.For<ILogger>().ImplementedBy<DebugLogger>());
               
            }
            else
            {
                container.AddFacility<TypedFactoryFacility>();
                container.Register(Component.For<ITypedFactoryComponentSelector>().ImplementedBy<MessageBasedComponentSelector>());
                container.Register(Component.For<ILoggerFactory>().AsFactory());
                container.Register(Component.For<ILogger>().ImplementedBy<ConsoleLogger>());
                container.Register(Component.For<ILogger>().ImplementedBy<DebugLogger>());
                container.Register(Component.For<IComplexComponent>().ImplementedBy<ComplexComponent>());
                
            }
        }
    }
}
