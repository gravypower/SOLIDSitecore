using Sitecore.Data.Items;
using Sitecore.Tasks;

namespace DependencyInversion.Commands
{
    public interface ICommand
    {
        void Execute(Item[] items, CommandItem command, ScheduleItem schedule);
    }
}
