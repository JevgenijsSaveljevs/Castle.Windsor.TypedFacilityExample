using Castle.Facilities.TypedFactory;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    public class MessageBasedComponentSelector : DefaultTypedFactoryComponentSelector
    {
        protected override string GetComponentName(MethodInfo method, object[] arguments)
        {
            if (method.Name == nameof(ILoggerFactory.Create) && arguments.Length == 1 && arguments[0] is string)
            {
                var asm = Assembly.GetAssembly(typeof(CodeAttribute));
                var types = asm.GetTypes()
                    .Where(x => x.IsDefined(typeof(CodeAttribute), inherit: false));

                foreach (var type in types)
                {
                    var attr = type.GetCustomAttribute<CodeAttribute>();
                    if (attr.Code.Equals(arguments[0]))
                    {
                        return type.FullName;
                    }
                }


                return (string)arguments[0];
            }

            return base.GetComponentName(method, arguments);
        }
    }
}
