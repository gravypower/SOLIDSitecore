using DependencyInversion.Adapters;
using Sitecore.Data.Items;
using Sitecore.Tasks;

namespace DependencyInversion.Commands
{
    public class ExampleCommand
    {
        private readonly ILogAdapter _logAdapter;

        public ExampleCommand(ILogAdapter logAdapter)
        {
            _logAdapter = logAdapter;
        }
        public void Execute(Item[] items, CommandItem commandItem, ScheduleItem schedule)
        {
            _logAdapter.LogInfo($"Hello from ExampleCommand, called from {commandItem.Name}");
        }
    }
}