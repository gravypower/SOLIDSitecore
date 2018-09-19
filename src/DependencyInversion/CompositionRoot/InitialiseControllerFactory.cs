using Sitecore.Pipelines;

namespace DependencyInversion.CompositionRoot
{
    public class InitialiseControllerFactory
    {
        public virtual void Process(PipelineArgs args)
        {
            var controllerBuilder = System.Web.Mvc.ControllerBuilder.Current;
            var controllerFactory = new DependencyInversionControllerFactory(controllerBuilder.GetControllerFactory());
            controllerBuilder.SetControllerFactory(controllerFactory);
        }
    }
}