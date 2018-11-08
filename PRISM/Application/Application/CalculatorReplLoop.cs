using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CalculatorReplLoop
    {
        public CalculatorReplLoop()
        {
            inputService = new ConsoleInputService();
            outputService = new ConsoleOutputService();
            calculator = new Calculator();
            inputParseService = new InputParseService();
        }
        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();
                try
                {
                    CommandTypes commandType = inputParseService.ParseCommand(command);

                    Arguments args = inputService.ReadArguments();
                    outputService.WriteMessage(
                        calculator.Execute(commandType, args).ToString());

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        ConsoleInputService inputService;
        ConsoleOutputService outputService;
        Calculator calculator;
        InputParseService inputParseService;

    }
}
