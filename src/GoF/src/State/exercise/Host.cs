/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Exercise
{
    public class Host
    {
        public static readonly IState UP_HARD = new UPHard();
        public static readonly IState UP_SOFT = new UPSoft();
        public static readonly IState DOWN_HARD = new DownHard();
        public static readonly IState DOWN_SOFT = new DownSoft();
        private IState currentState = UP_HARD;
        private Command checkCommand;
        private int maxAttempt = 3;
        private int attempt = 0;
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
        public IState getState()
        {
            return currentState;
        }
        public void changeState(IState newState)
        {
            resetAttempt();
            currentState = newState;
        }
        public int getMaxAttempt()
        {
            return maxAttempt;
        }
        public void increateAttempt()
        {
            attempt++;
        }
        private void resetAttempt()
        {
            attempt = 1;
        }
        public void doGracefulPowerOff()
        {
            Console.WriteLine("Power off gracefully.");
        }
        public void doPowerOff(int delay)
        {
            Console.WriteLine("Power off after " + delay + " second(s).");
        }
        public void doPowerOn()
        {
            Console.WriteLine("Power On.");
        }
        public String inBandDiagnostic()
        {
            return "Diagnostic via the remote agent.";
        }
        public String outOfBandDiagnostic()
        {
            return "Diagnostic via IPMI.";
        }
    }
}
