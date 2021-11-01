using Joole_MVC_Core;
using Joole_MVC_Infrastructure.Repository;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_MVC
{
    public class UnityContainerRegistration
    {
        public static IUnityContainer InitialiseContainer() {
            //initialize the container
            var container = new UnityContainer();

            // Register the dependency
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IDetailRepository, DetailRepository>();
            container.RegisterType<IProductRepository, ProductsRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        //public static IUnityContainer InitialiseContainer2()
        //{
        //    //initialize the container
        //    var container2 = new UnityContainer();

        //    // Register the dependency
        //    container2.RegisterType<IDetailRepository, DetailRepository>();

        //    DependencyResolver.SetResolver(new UnityDependencyResolver(container2));
        //    return container2;
        //}
    }
}