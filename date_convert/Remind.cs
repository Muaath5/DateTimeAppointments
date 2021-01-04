using Microsoft.Toolkit.Uwp.Notifications;
using System;
using Windows.UI.Xaml.Markup;
using Windows.UI;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace DateTimeConverter
{
    [Serializable]
    public class Remind
    {
        public Remind(short year, short month, short day, short hour, short minute, short second)
        {
            AppointmantTime = new DateTime(year, month, day, hour, minute, second, new UmAlQuraCalendar());
        }

        public Remind(short year, short month, short day, Calendar calendar)
        {
            AppointmantTime = new DateTime(year, month, day, calendar);
        }

        public Remind(DateTime time, string title, string description)
        {
            AppointmantTime = time;
            Title = title;
            Description = description;
        }

        public ToolTipIcon Status { get; set; } = ToolTipIcon.None;

        public string Title { get;  set; }

        public string Description { get;  set; }

        public int Timeout { get; set; } = 1000;

        public DateTime AppointmantTime { get; set; } = DateTime.Now;

        public bool ShowInLockScreen { get; set; }

        public void Edit(ToolTipIcon icon, string title, string description, DateTime dateTime, bool lockScreen)
        {
            Status = icon;
            Title = title;
            Description = description;
            ShowInLockScreen = lockScreen;
        }

        public bool Check()
        {
            List<Remind> reminds = DataStore.GetList();
            foreach (Remind item in reminds)
            {
                if (DateTime.Now > AppointmantTime)
                {
                    return true;
                }
            }
            return false;
        }

        public void SendNotification(NotifyIcon notify)
        {
            notify.ShowBalloonTip(Timeout, Title, Description, Status);
            if (ShowInLockScreen)
            {
                TileContent content = new TileContent()
                {
                    Visual = new TileVisual()
                    {
                        LockDetailedStatus1 = Title,
                        LockDetailedStatus2 = Description,
                        TileWide = new TileBinding() { }
                    }
                };

                //TileNotification notification = new TileNotification(content.GetXml());
                //TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
            }
        }
    }


}
