using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Common
{
    public class UnityConfig
    {
        public UnityContainer Config()
        {
            var container = new UnityContainer();

            //container.RegisterType<IGameClient, GameClientDroid>(new ContainerControlledLifetimeManager());
            return container;
        }
    }
}
