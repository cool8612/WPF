﻿using InputOutputLibrary;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorReplLoop loop = new CalculatorReplLoop();
            loop.OutputService = new MsgBoxOutputService();
            loop.Run();
        }
    }
}
