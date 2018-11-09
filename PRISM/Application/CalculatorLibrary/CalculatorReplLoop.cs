//using InputOutputLibrary;
using System;
using Unity.Attributes;

namespace Application
{
    public class CalculatorReplLoop : ICalculatorReplLoop
    {
        public CalculatorReplLoop()
        {

        }
       
        private ICalculator calculator;
        [Dependency]
        public ICalculator Calculator
        {
            get { return calculator; }
            set { calculator = value; }
        }

        private IInputService inputService;
        [Dependency]
        public IInputService InputService
        {
            get { return inputService; }
            set { inputService = value; }
        }

        private IOutputService outputService;
        [Dependency]
        public IOutputService OutputService
        {
            get { return outputService; }
            set { outputService = value; }
        }

        private IInputParseService parsingService;
        [Dependency]
        public IInputParseService ParsingService
        {
            get { return parsingService; }
            set { parsingService = value; }
        }

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
