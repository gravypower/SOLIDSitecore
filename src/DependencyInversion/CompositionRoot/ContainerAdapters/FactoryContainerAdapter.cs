using System;
using Sitecore.Reflection;

namespace DependencyInversion.CompositionRoot.ContainerAdapters
{
    public class FactoryContainerAdapter: IFactory
    {
        public object GetObject(string identifier)
        {
            var type = Type.GetType(identifier);
            return Bootstrapper.Container.GetInstance(type);
        }
    }
}