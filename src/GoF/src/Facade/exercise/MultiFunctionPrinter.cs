/*
* Copyright 2017 TeddySoft Technology. 
* 
*/
using System;

namespace Tw.Teddysoft.Gof.Facade.Exercise
{
    internal class MultiFunctionPrinter
    {
        private Printer printer;
        private Scanner scanner;
        private Fax fax;
        private LCD lCD;

        public MultiFunctionPrinter(Printer printer, Scanner scanner, Fax fax, LCD lCD)
        {
            this.printer = printer;
            this.scanner = scanner;
            this.fax = fax;
            this.lCD = lCD;
        }

        public bool copy()
        {
            return copy(1);
        }
        public bool copy(int copies)
        {
            if (!printer.hasPaper())
                return false;

            try {
                scanner.warmup();
            }
            catch (ScannerException ex)
            {
                return false;
            }
            Image image = scanner.start();

            for (int i = 0; i < copies; i++)
            {
                printer.print(image);
            }
            return true;
        }

        internal int getNumberOfPapers()
        {
            return printer.numberOfPapers();
        }

        internal string getLCDMessage()
        {
            if (!printer.hasPaper())
                return "Scanner error. No paper!";

            try { scanner.warmup(); }catch(ScannerException ex)
            {
                return "Scanner error: Internal error.";
            }

            return "";
        }
    }
}