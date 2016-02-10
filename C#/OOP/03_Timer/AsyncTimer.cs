using System;
using System.Threading;

namespace _03_Timer
{
    public class AsyncTimer
    {
        private int ticks;
        private int interval;

        public AsyncTimer(int ticks, int t, Action<int> action)
        {
            this.Ticks = ticks;
            this.Interval = interval;
            this.Action = action;
        }

        public Action<int> Action { get; private set; }
        public int Ticks { get; set; }
        public int Interval { get; set; }

        public void TurnOn()
        {
            Thread paralelThread = new Thread(this.Start);
            paralelThread.Start();
        }

        public void Start()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.Interval);

                if (this.Action != null)
                {
                    this.Action(i);
                }
            }
        }
    }
}
