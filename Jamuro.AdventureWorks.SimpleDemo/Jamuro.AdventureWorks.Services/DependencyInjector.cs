using Unity;
using Unity.Lifetime;
using Unity.Injection;


namespace Jamuro.AdventureWorks.Services
{
    public static class DependencyInjector
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();

        public static void RegisterType<I, T>() where T : I
        {
            UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }

        public static void RegisterType<I, T>(params object[] injectionMembers) where T : I
        {
            UnityContainer.RegisterType<I, T>(new InjectionConstructor(injectionMembers));
        }

        public static T Retrieve<T>()
        {
            return UnityContainer.Resolve<T>();
        }
    }
}
