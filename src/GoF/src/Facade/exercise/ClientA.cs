/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Facade.Exercise
{
    public class ClientA
    {
		private Scanner scanner;
		private Printer printer;

		public ClientA(int numberOfPapers)
		{
			scanner = new Scanner();
			printer = new Printer(numberOfPapers);
		}

        public void copy(int copies) 
        {
			scanner.warmup();
	        Image image = scanner.start();

	        for(int i = 0; i<copies; i++){
	            printer.print(image);
	        }
        }

		public int getNumberOfPapers()
		{
			return printer.numberOfPapers();
		}
    }
}
