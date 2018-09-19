namespace DependencyInversion.Adapters
{
    public class SitecoreLogAdapter: ILogAdapter
    {
        public void LogInfo(string message)
        {
            Sitecore.Diagnostics.Log.Info(message, this);
        }
    }
}