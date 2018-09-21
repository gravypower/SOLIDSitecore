using System;
using DependencyInversion.CompositionRoot;
using Sitecore.Reflection;

namespace DependencyInversion.ContainerAdapters
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