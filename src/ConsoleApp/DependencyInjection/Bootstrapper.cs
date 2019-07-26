using ConsoleApp.Interfaces;

namespace ConsoleApp.DependencyInjection
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IBusiness, Business>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
