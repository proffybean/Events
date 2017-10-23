using TimerLib;
using static System.Console;

namespace EventConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.DivByTen += HandleDivByTen;
            timer.StartTimer();

            WriteLine("done!");
            ReadLine();
        }

        private static void HandleDivByTen(object sender, TimerEventArgs e)
        {
            //Timer t = (Timer)sender;
            //WriteLine($"Hit div by ten: {t.count}");
            WriteLine($"Hit div by ten: {e.message} count: {e.count}");
        }
    }
}
