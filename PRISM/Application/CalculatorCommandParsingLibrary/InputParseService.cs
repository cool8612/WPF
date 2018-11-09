using System;

namespace Application
{
    public class InputParseService : IInputParseService
    {
        public CommandTypes ParseCommand(string command)
        {
            return (CommandTypes)Enum.Parse(typeof(CommandTypes), command);
        }
    }
}
