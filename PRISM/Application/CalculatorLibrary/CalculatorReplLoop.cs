using System;

namespace Application
{
    public class CalculatorReplLoop 
    {
        public CalculatorReplLoop()
        {
            InputService = new ConsoleInputService();
            OutputService = new ConsoleOutputService();
            Calculator = new Calculator();
            ParsingService = new InputParseService();
        }

        public ICalculator Calculator { get; set; }
        public IInputService InputService { get; set; }
        public IOutputService OutputService { get; set; }
        public IInputParseService ParsingService { get; set; }

        public void Run()
        {
            while (true)
            {
                string command = InputService.ReadCommand();
                try
                {
                    CommandTypes commandType = ParsingService.ParseCommand(command);

                    Arguments args = InputService.ReadArguments();
                    OutputService.WriteMessage(
                        Calculator.Execute(commandType, args).ToString());

                }
                catch (Exception)
                {
                    OutputService.WriteMessage("Mistake!");
                }
            }
        }
    }
}
