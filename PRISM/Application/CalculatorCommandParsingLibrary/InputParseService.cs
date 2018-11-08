using System;

namespace Application
{
    public class InputParseService
    {
        public CommandTypes ParseCommand(string command)
        {
            return (CommandTypes)Enum.Parse(typeof(CommandTypes), command);
        }
    }
}
