using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Base
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList(); //Reading the attributes of the related class
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true); //Reading the attributes of the related method
            classAttributes.AddRange(methodAttributes);

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
