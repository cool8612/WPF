using Unity;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<ICalculatorReplLoop, CalculatorReplLoop>();
            container.RegisterType<ICalculator, Calculator>();
            container.RegisterType<IInputParseService, InputParseService>();
            container.RegisterType<IInputService, ConsoleInputService>();
            container.RegisterType<IOutputService, ConsoleOutputService>();

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            loop.Run();
        }
    }
}
