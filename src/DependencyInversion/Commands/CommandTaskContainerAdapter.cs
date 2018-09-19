using System;
using DependencyInversion.CompositionRoot;
using Sitecore.Data.Items;
using Sitecore.Tasks;

namespace DependencyInversion.Commands
{
    public class CommandTaskContainerAdapter
    {
        public void Execute(Item[] items, CommandItem commandItem, ScheduleItem schedule)
        {
            var commandTypeValue = commandItem["Command Type"];
            var commandType = Type.GetType(commandTypeValue);
            var command = (ICommand) Bootstrapper.Container.GetInstance(commandType);
            command.Execute(items, commandItem, schedule);
        }
    }
}