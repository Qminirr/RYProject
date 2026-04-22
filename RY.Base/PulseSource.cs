using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RY.Base
{
    public class PulseSource
    {

        static List<PulseSource> lst=new List<PulseSource>();

        public static void Clean()
        {
            foreach(PulseSource ps in lst)
            {
                ps.StopPulse();
            }
            foreach (PulseSource ps in lst)
            {
                ps.WaitStop();
            }
            lst.Clear();
        }

        public int TimeTick
        { get; set; } = 10;

        public string Name
        { get; set; } = "默认脉冲";

        private bool IsStarted
        { get; set; } = false;

        private bool IsStopped
        { get; set; } = false;


        private bool IsPaused
        { get; set; } = false;
        public PulseSource(int timetick,string name)
        {
            TimeTick= timetick;
            Name = name;
            lst.Add(this);
        }

        public EventHandler PulseOut;
        public EventHandler PulseStop;
        private BackgroundWorker timer = null;
        //开始触发脉冲
        public void StartPulse()
        {
            if (IsPaused) IsPaused = false;
            if (IsStarted) return;
            IsStarted = true;
            IsStopped = false;
            timer=new BackgroundWorker();
            timer.DoWork += timer_DoWork;
            timer.RunWorkerCompleted += timer_RunWorkerCompleted;
            timer.RunWorkerAsync();
        }
        //等待时钟停止
        public bool WaitStop(int timeout = 3000)
        {
            if (timeout <= 0) return IsStopped;
            return WaitTimer.Wait(timeout, () =>
            {
                if (IsStopped) return true;
                return false;
            });
        }
        //暂停脉冲
        public void PausePulse()
        {
            IsPaused = true;
        }
        public void StopPulse()
        {
            IsStarted = false;

        }
        //停止时钟脉冲，并从列表把脉冲移除掉
        public void StopAddRemovePulse()
        {
            StopPulse();
            WaitStop();
            lst.Remove(this);
        }
        public void timer_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!IsStarted) return;
            while(IsStarted)
            {
                Thread.Sleep(TimeTick);
                if (IsStopped) break;
                if (IsPaused) continue;
                if (PulseOut != null)
                {
                    PulseOut(this, e);
                }
            }
            IsStopped = true;
            IsPaused = false;
        }
        private void timer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IsStarted = false;
            if(PulseStop!=null)
            {
                PulseStop(this, e);
            }
            timer.DoWork -= timer_DoWork;
            timer.RunWorkerCompleted -= timer_RunWorkerCompleted;
        }
    }
}
