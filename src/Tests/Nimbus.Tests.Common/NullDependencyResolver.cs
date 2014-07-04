using Nimbus.DependencyResolution;

namespace Nimbus.Tests.Common
{
    public class NullDependencyResolver : IDependencyResolver
    {
        public IDependencyResolverScope CreateChildScope()
        {
            return new NullDependencyResolverScope();
        }

        public void Dispose()
        {
        }
    }
}