//using InputOutputLibrary;
using System;

namespace Application
{
    public class CalculatorReplLoop : ICalculatorReplLoop
    {
        public CalculatorReplLoop(ICalculator calculator,
                                   IInputService inputService,
                                   IOutputService outputService,
                                   IInputParseService parsingService)
        {
            this.calculator = calculator;
            this.inputService = inputService;
            this.outputService = outputService;
            this.parsingService = parsingService;
        }

        // 유니티 컨테이너가 생성자를 선택할때 인자가 많은버전부터 선택하는듯.
        //public CalculatorReplLoop(ICalculator calculator,
        //                        IInputService inputService,
        //                        IInputParseService parsingService)
        //{
        //    this.calculator = calculator;
        //    this.inputService = inputService;
        //    this.outputService = new MsgBoxOutputService();
        //    this.parsingService = parsingService;
        //}

        public ICalculator calculator;
        public IInputService inputService;
        public IOutputService outputService;
        public IInputParseService parsingService;

        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();
                try
                {
                    CommandTypes commandType = parsingService.ParseCommand(command);

                    Arguments args = inputService.ReadArguments();
                    outputService.WriteMessage(
                        calculator.Execute(commandType, args).ToString());

                }
                catch (Exception)
                {
                    outputService.WriteMessage("Mistake!");
                }
            }
        }
    }
}
