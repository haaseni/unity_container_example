using ConsoleApp.Interfaces;
using Unity;
using Unity.Extension;

namespace ConsoleApp.DependencyInjection
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IData, Data>();
        }
    }
}
