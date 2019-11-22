/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public interface Subject
	{
		void addObserver(Observer observer);
		void deleteObserver(Observer observer);
		void notifyObserver();
	}
}
