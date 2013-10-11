#region

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#endregion

namespace Scheduler{
    public partial class SchedulerWindow : Form{
        readonly List<DisplayEvent> _deployedWarnings;
        readonly List<DisplayEvent> _warningsToDeploy;

        void DailyReminder(){
            while (true){
                Thread.Sleep(1000);
                var events = _scheduler.GetActiveEvents();
                bool upcomingEventDetected = false;
                foreach (var @event in events){
                    if (@event.EventDateTime - DateTime.Now < new TimeSpan(1, 0, 0, 0)){
                        upcomingEventDetected = true;
                        if (!_deployedWarnings.Contains(@event)){
                            _warningsToDeploy.Add(@event);
                        }
                    }
                }

                if (upcomingEventDetected){
                    UpcomingEventDetected();
                    NotifyIcon.Icon = new Icon("Content/unhappyface.ico");
                }
                else{
                    NotifyIcon.Icon = new Icon("Content/happyface.ico");
                }
                UpdateNotifyIconTooltip(events);
                CullDeployedWarnings();
                _scheduler.RefreshActiveEvents();
            }
        }

        void UpdateNotifyIconTooltip(List<DisplayEvent> events){
            var sorted = events.OrderBy(e => e.EventDateTime).ToArray();
            if (sorted.Length > 0){
                var iconText = "";
                iconText += "Next event: ";
                iconText += sorted[0].Description + Environment.NewLine;
                iconText += "ETA: ";
                iconText += sorted[0].TimeUntil;

                NotifyIcon.Text = iconText;
            }
            else{
                NotifyIcon.Text = "No events scheduled";
            }

            int g = 5;
        }

        void CullDeployedWarnings(){
            for (int i = 0; i < _deployedWarnings.Count; i++){
                if (_deployedWarnings[i].EventDateTime < DateTime.Now){
                    _deployedWarnings.RemoveAt(i);
                    i--;
                }
            }
        }

        void UpcomingEventDetected(){
            var lastInput = GetLastInputTime();
            if (lastInput < 10){
                if (_warningsToDeploy.Count > 0){
                    NotifyIcon.ShowBalloonTip(60000, "Upcoming event today", _warningsToDeploy[0].Description, new ToolTipIcon());
                    _deployedWarnings.AddRange(_warningsToDeploy);
                    _warningsToDeploy.Clear();
                }
            }
        }

        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        static int GetLastInputTime(){
            int idleTime = 0;
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;

            int envTicks = Environment.TickCount;

            if (GetLastInputInfo(ref lastInputInfo)){
                int lastInputTick = (int) lastInputInfo.dwTime;

                idleTime = envTicks - lastInputTick;
            }

            return ((idleTime > 0) ? (idleTime/1000) : idleTime);
        }

        #region Nested type: LASTINPUTINFO

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO{
            public static readonly int SizeOf = Marshal.SizeOf(typeof (LASTINPUTINFO));

            [MarshalAs(UnmanagedType.U4)] public int cbSize;
            [MarshalAs(UnmanagedType.U4)] public UInt32 dwTime;
        }

        #endregion
    }
}