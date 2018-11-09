using Unity;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            // 인스턴스 등록 버전
            //Calculator calculator = new Calculator();
            //container.RegisterInstance<ICalculator>(calculator);

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
