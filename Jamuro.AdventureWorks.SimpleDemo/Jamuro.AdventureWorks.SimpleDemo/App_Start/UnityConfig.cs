using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Unity.Injection;
using Jamuro.AdventureWorks.Services.Workers.Interfaces;
using Jamuro.AdventureWorks.Services.Workers;

namespace Jamuro.AdventureWorks.SimpleDemo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IProductWorker, ProductWorker>();           
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}