using Unity;
using Unity.Extension;

namespace ConsoleApp
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IData, Data>();
        }
    }
}
