using System.Web.Mvc;
using DependencyInversion.Adapters;
using DependencyInversion.Controllers;
using SimpleInjector;
using SimpleInjector.Diagnostics;

namespace DependencyInversion.CompositionRoot
{
    public static class Bootstrapper
    {
        public static Container Container;

        public static Container Bootstrap()
        {
            Container = new Container();

            Container.RegisterSingleton<ILoggedOnUser, SitecoreLoggedOnUser>();
            RegisterController<HelloController>();

#if DEBUG
            Container.Verify(VerificationOption.VerifyAndDiagnose);
#else
            _container.Verify();
#endif
            return Container;
        }

        private static void RegisterController<TController>()
            where TController : IController
        {
            var controllerType = typeof(TController);
            var lifestyle = Container.Options.LifestyleSelectionBehavior.SelectLifestyle(controllerType);
            var registration = lifestyle.CreateRegistration(controllerType, Container);

            // Microsoft.AspNetCore.Mvc.Controller implements IDisposable (which is a design flaw).
            // This will cause false positives in Simple Injector's diagnostic services, so we suppress
            // this warning in case the registered type doesn't override Dispose from Controller.
            registration.SuppressDiagnosticWarning(
                DiagnosticType.DisposableTransientComponent,
                "Derived type doesn't override Dispose, so it can be safely ignored.");

            Container.AddRegistration<IController>(registration);
        }
    }
}