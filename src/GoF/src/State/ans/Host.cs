/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ans
{
    public class Host
    {
        public static readonly State UP_HARD = new UpHard();
        public static readonly State UP_SOFT = new UpSoft();
        public static readonly State DOWN_HARD = new DownHard();
        public static readonly State DOWN_SOFT = new DownSoft();
        private Command checkCommand;
        private int maxAttempt = 3;
        private int attempt = 0;
        private State currentState = UP_HARD;
        public Host(Command command)
        {
            checkCommand = command;
        }
        public void setCommand(Command command)
        {
            checkCommand = command;
        }
        public void check()
        {
            CheckResult result = checkCommand.execute();
            currentState.check(this, result);
        }
        public void powerOff()
        {
            currentState.powerOff(this);
        }
        public void powerOn()
        {
            currentState.powerOn(this);
        }
        public String diagnostic()
        {
            return currentState.diagnostic(this);
        }
        public int getAttempt()
        {
            return attempt;
        }
        public State getState()
        {
            return currentState;
        }
        public void changeState(State newState)
        {
            resetAttempt();
            currentState = newState;
        }
        public int getMaxAttempt()
        {
            return maxAttempt;
        }
        private void resetAttempt()
        {
            attempt = 1;
        }
        internal void doGracefulPowerOff()
        {
            Console.WriteLine("Power off gracefully.");
        }
        internal void doPowerOff(int delay)
        {
            Console.WriteLine("Power off after " + delay + " second(s).");
        }
        internal void doPowerOn()
        {
            Console.WriteLine("Power On.");
        }
        internal String inBandDiagnostic()
        {
            return "Diagnostic via the remote agent.";
        }
        internal String outOfBandDiagnostic()
        {
            return "Diagnostic via IPMI.";
        }
        internal void incAttempt()
        {
            attempt++;
        }
    }
}
