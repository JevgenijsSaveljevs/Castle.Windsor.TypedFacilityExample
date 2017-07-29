using Castle.Windsor;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            DependencyConfig.Configure(container);
            var component = container.Resolve<IComplexComponent>();
            component.DoJob();

            Console.ReadKey();
        }
    }
}
