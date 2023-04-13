using System;

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();

            // 订阅嘀嗒事件
            clock.Tick += (sender, e) => Console.WriteLine("Tick...");

            // 订阅响铃事件
            clock.Alarm += (sender, e) => Console.WriteLine("Alarm! Time to wake up!");

            // 设置闹钟时间为 8:00
            clock.SetAlarm(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0));

            // 开始闹钟
            clock.Start();

            Console.ReadLine();
        }
    }

    public class Clock
    {
        // 定义闹钟事件
        public event EventHandler Tick;
        public event EventHandler Alarm;

        private DateTime _alarmTime;

        // 设置闹钟时间
        public void SetAlarm(DateTime alarmTime)
        {
            _alarmTime = alarmTime;
        }

        // 开始闹钟
        public void Start()
        {
            while (true)
            {
                // 获取当前时间
                var now = DateTime.Now;

                // 触发嘀嗒事件
                Tick?.Invoke(this, EventArgs.Empty);

                // 如果当前时间等于闹钟时间，触发响铃事件
                if (now.Hour == _alarmTime.Hour && now.Minute == _alarmTime.Minute && now.Second == _alarmTime.Second)
                {
                    Alarm?.Invoke(this, EventArgs.Empty);
                    break;
                }

                // 休眠 1 秒钟
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
