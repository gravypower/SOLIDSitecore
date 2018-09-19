namespace DependencyInversion.Adapters
{
    public class SitecoreLoggedOnUser:ILoggedOnUser
    {
        public string Name => Sitecore.Context.User.Name;
    }
}