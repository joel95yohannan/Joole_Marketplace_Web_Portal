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

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
    }
}