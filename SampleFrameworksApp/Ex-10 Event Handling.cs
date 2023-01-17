using System;
using System.Threading;

namespace SampleFrameworksApp
{
    delegate void CallMe(string msg);

    class Clock
    {
        private static DateTime _alarmTime;

        public static event CallMe OnAlarmTime;

        public static void SetAlarm(DateTime time)
        {
            _alarmTime = time;
        }

        public static void DisplayClock()
        {
            do
            {
                if(DateTime.Now.Minute == _alarmTime.Minute)
                {
                    if (OnAlarmTime != null)
                    {
                        OnAlarmTime("Time for a break!");
                        Console.Beep(2500,10000);
                    }
                }

                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
                Console.Clear();


            } while (true);
        }
    }
    class Ex_10_Event_Handling
    {
        static void Main(string[] args)
        {
            Clock.OnAlarmTime += Clock_OnAlarmTime;
            Clock.SetAlarm(DateTime.Now.AddMinutes(1));
            Clock.DisplayClock();
        }

            private static void Clock_OnAlarmTime(string msg)
            {
                Console.WriteLine(msg);
            }
    }
}
