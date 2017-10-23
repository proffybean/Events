using System;
using System.Threading;

namespace TimerLib
{
    public delegate void TimerHandler(object sender, TimerEventArgs e);

    public class Timer
    {
        public event TimerHandler DivByTen;
        public int count;

        public void StartTimer()
        {
            count = 1;

            for(count = 1; count < 100; ++count)
            {
                Thread.Sleep(1000);

                if(count%10 == 0)
                {
                    DivByTen(this, new TimerEventArgs { message = "foo", count = this.count});
                }
            }

        }
    }

    public class TimerEventArgs : EventArgs
    {
        public string message;
        public int count;
    }
}
