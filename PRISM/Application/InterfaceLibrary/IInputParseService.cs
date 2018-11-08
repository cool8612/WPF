namespace Application
{
    public interface IInputParseService
    {
        CommandTypes ParseCommand(string command);
    }
}