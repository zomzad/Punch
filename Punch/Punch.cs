using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace Punch
{
    public partial class Punch : ServiceBase
    {
        private Timer timer;

        public Punch()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);//時間到要觸發的事件
            timer.Interval = 60 * 1000; //單位毫秒 檢查時間週期
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Process.Start(@"D:\GIT\PunchEXE\PunchEXE\bin\Debug\PunchEXE.exe");
        }
    }
}
