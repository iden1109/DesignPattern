/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Facade.Exercise
{
    public class ClientB
    {
		private Scanner scanner;
		private Printer printer;

		public ClientB(int numberOfPapers)
		{
			scanner = new Scanner();
			printer = new Printer(numberOfPapers);
		}

		public String copy()
		{
			try
			{
				scanner.warmup();
			}
			catch (ScannerException e)
			{
                return "Scanner error: " + e.Message;
			}

			Image image = scanner.start();
			try
			{
				printer.print(image);
			}
			catch (PrinterException e)
			{
                return "Scanner error. " + e.Message; 
			}

			return "";
		}
    }
}
