using Application;

namespace Application
{
    public interface ICalculator
    {
        int Add(Arguments args);
        int Div(Arguments args);
        int Execute(CommandTypes commandType, Arguments args);
        int Mul(Arguments args);
        int Sub(Arguments args);
    }
}