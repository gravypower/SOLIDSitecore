using DependencyInversion.Adapters;
using Sitecore.Pipelines.HttpRequest;

namespace DependencyInversion.Pipelines
{
    public class ExamplePipeline: HttpRequestProcessor
    {
        private readonly ILogAdapter _logAdapter;

        public ExamplePipeline(ILogAdapter logAdapter)
        {
            _logAdapter = logAdapter;
        }

        public override void Process(HttpRequestArgs args)
        {
            _logAdapter.LogInfo($"Hello from ExamplePipeline");
        }
    }
}