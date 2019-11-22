﻿/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Facade.Ans
{
    public class MultiFunctionPrinter
	{
		private Scanner scanner;
		private Printer printer;
		private Fax fax;
		private LCD lcd;

		public MultiFunctionPrinter(Printer printer, Scanner scanner, Fax fax, LCD lcd)
		{
			this.printer = printer;
			this.scanner = scanner;
			this.fax = fax;
			this.lcd = lcd;
		}

		public bool copy()
		{
			try
			{
				scanner.warmup();
			}
			catch (ScannerException e)
			{
                lcd.display("Scanner error: " + e.Message);
				return false;
			}

			Image image = scanner.start();
			try
			{
				return printer.print(image);
			}
			catch (PrinterException e)
			{
				lcd.display("Scanner error. " + e.Message);
			}
			return false;
		}

		public String getLCDMessage()
		{
			return lcd.getMessage();
		}

		public int getNumberOfPapers()
		{
			return printer.numberOfPapers();
		}

		public void scanToComputer()
		{
		}

		public void scanToEmail()
		{
		}

		public void sendFax()
		{
		}

		public void print()
		{
		}
	}
}
