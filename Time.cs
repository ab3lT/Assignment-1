using System.Timers;
using System;

namespace assignment_one
{
    public class Time
    {
        public static System.Timers.Timer aTimer;
        public static void SetTimer(int time)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(time);
            // Hook up the Elapsed event for the timer. 
            // aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }
    }
    // The example displays output like the following:
    //       Press the Enter key to exit the application...
    //
    //       The application started at 09:40:29.068
    //       The Elapsed event was raised at 09:40:31.084
    //       The Elapsed event was raised at 09:40:33.100
    //       The Elapsed event was raised at 09:40:35.100
    //       The Elapsed event was raised at 09:40:37.116
    //       The Elapsed event was raised at 09:40:39.116
    //       The Elapsed event was raised at 09:40:41.117
    //       The Elapsed event was raised at 09:40:43.132
    //       The Elapsed event was raised at 09:40:45.133
    //       The Elapsed event was raised at 09:40:47.148
    //
    //       Terminating the application...
}