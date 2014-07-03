
namespace E07TimerWidthDelegates
{
    using System;
    using System.Threading;

    
    public class Timer
    {
        public Timer (int ticksCount, int interval, ElapsedTime callback) 
        {
            this.TicksCount = ticksCount;
            this.Interval = interval;
            this.callback = callback;
        }

        public int TicksCount { get; private set; }
        public int Interval { get; private set; }

        private ElapsedTime callback; 

        public void Run () 
        {
            int tickCounter = this.TicksCount;

            while (tickCounter > 0)
            {
                Thread.Sleep (Interval);
                tickCounter--;
                this.callback (tickCounter);
            }
        }
    }


    public delegate void ElapsedTime (int ticksCount);
    
}
