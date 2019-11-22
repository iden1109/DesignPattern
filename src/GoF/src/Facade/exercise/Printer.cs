﻿/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Facade.Exercise
{
    public class Printer
	{
		private IList<Paper> papers;

		public Printer()
		{
			papers = new List<Paper>();
		}

		public Printer(int initNumberOfPapers)
		{
			papers = new List<Paper>();
			for (int i = 0; i < initNumberOfPapers; i++)
				papers.Add(new Paper());
		}


		public bool print(Image image)
		{
	        if(!hasPaper())
	            throw new PrinterException("No paper!");
	        
	        if (null != image) {
	            Paper paper = loadPaper();
	            // print image to the loaded paper
	            return true;
	        }
	        return false;
        }   

		public bool hasPaper()
		{
            if (0 == numberOfPapers())
				return false;
			else
				return true;
		}

		public Paper loadPaper()
		{
            Paper Paper = papers.GetEnumerator().Current;
            papers.RemoveAt(numberOfPapers() - 1);
            return Paper;
		}

		public void addPaper(Paper paper)
		{
			papers.Add(paper);
		}

		public int numberOfPapers()
		{
			return papers.Count;
		}
    }
}
