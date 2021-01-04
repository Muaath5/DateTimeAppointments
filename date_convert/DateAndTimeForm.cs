using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DateTimeConverter
{
    public partial  class DateAndTimeForm : Form
    {
        private GregorianCalendar cal2 = new GregorianCalendar();
        private CultureInfo saCulture2 = new CultureInfo("ar-SA");
        //private PrayerTimesCalculator prayerTimes;

        public const string DefaultDateTimeFormat = "yyyy / M / d";
        public const string DefaultDateTimeFormat_RTL = "d/\u200fM/\u200fyyyy";

        private bool nightMode = false;
        public bool NightMode
        {
            get { return nightMode; }
            set 
            { 
                nightMode = value;
                OnNightModeChanged(EventArgs.Empty);
            }
        }

        public event EventHandler NightModeChanged;

        protected void OnNightModeChanged(EventArgs e)
        {
            EventHandler handler = NightModeChanged;
            handler?.Invoke(this, e);
        }

        public DateTimeOffset NextPrayerTime { get; private set; }

        //public Times PrayerTimes { get; set; }

        public DateAndTimeForm(double latitude, double longitude)
        {
            InitializeComponent();
            //prayerTimes = new PrayerTimesCalculator(latitude, longitude);
        }

        public DateAndTimeForm()
        {
            InitializeComponent();
        }

        public DateTimeOffset GetNextPrayerTime()
        {
            CheckReminds();
            throw new Exception();
        }

        private void FormDateAndTime_Load(object sender, EventArgs e)
        {
            CheckReminds();
            GetDate();
            //Times times = prayerTimes.GetPrayerTimes(DateTimeOffset.Now, 3);

            //TimeSpan[] tspans = new TimeSpan[] { times.Fajr, times.Dhuhr, times.Asr, times.Maghrib, times.Isha };

            //var timeNow = DateTime.Now.TimeOfDay;
            //TimeSpan closerTimeSpan;
            //TimeSpan lastSpanDiff = new TimeSpan(24, 0, 0);

            //for (int i = 0; i < tspans.Length; i++)
            //{
            //    var spanDiff = tspans[i].Subtract(timeNow);
            //    if (spanDiff < lastSpanDiff)
            //        closerTimeSpan = tspans[i];
            //}



            var timer = new Timer();
            timer.Interval = 900;
            timer.Tick += Timer_Tick;


            CurrentTimeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
            timer.Start();

            TodayLabel.Text = DateTime.Now.ToString("dddd");
        }

        public void GetDate()
        {
            var saCulture1 = new CultureInfo("ar-SA");
            var cal1 = new UmAlQuraCalendar();
            saCulture1.DateTimeFormat.Calendar = cal1;

            saCulture2.DateTimeFormat.Calendar = cal2;

            var datetime = DateTime.Now;

            HijriLabel.Text = datetime.ToString(DefaultDateTimeFormat_RTL, saCulture1) + "هـ";

            GregorianLabel.Text = datetime.ToString(DefaultDateTimeFormat_RTL, saCulture2) + "مـ";
        }

        public void CheckReminds()
        {
            var reminds = DataStore.GetList();
            if (reminds == null)
            { return; }
            for (int i = 0; i < reminds.Count; i++)
            {
                if (reminds[i].Check())
                {
                    reminds[i].SendNotification(MainNotifyIcon);
                    reminds.RemoveAt(i);
                }
            }
            DataStore.SaveListOfRemind(reminds);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
        }



        #region خربوطة
        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Muaath_5");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "صنع هذا التطبيق بواسطة معاذ القرني.",
                "التاريخ والوقت",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading, "mailto:muaath1428");
        }




        private void ComboBoxStatus_DropDownClosed(object sender, EventArgs e)
        {
            CurrentTimeLabel.Focus();
        }

        private void ComboBoxRemindType_DropDownClosed(object sender, EventArgs e)
        {
            CurrentTimeLabel.Focus();
        }

        #endregion}



        private void NumericUpDownDays_ValueChanged(object sender, EventArgs e)
        {

        }

        public ushort GetDaysInCurrentMounth(ushort Month)
        {
            if (Month == 2)
            {
                if (DateTime.IsLeapYear(DateTime.Now.Year) == true)
                {
                    return 29;
                }
                else
                    return 28;
            }
            else if (Month % 2 == 0)
            {
                return 31;
            }
            else
            {
                return 30;
            }
        }

        private void labelNextPrayerTime_Click(object sender, EventArgs e)
        {

        }

        private void NightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (NightMode)
            {
                case true:
                    BackColor = Color.Black;
                    HijriLabel.ForeColor = Color.White;
                    GregorianLabel.ForeColor = Color.White;
                    break;
                case false:
                    break;
                default:
                    break;
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckReminds();
            TodayLabel.Text = DateTime.Now.ToString("dddd");

        }

        private void DateAndTimeForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(DateTime.Now.ToString("yyyy/MM/dd") + "    " + DateTime.Now.ToString("h:mm:ss tt"));
            }
        }

        private void NewRemindButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DateTime.Now.ToString("yyyy / M / d") + Environment.NewLine );
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void NewRemindSuperButton_Click(object sender, EventArgs e)
        {
            NewRemind();
        }

        private void ConvertDateButton_Click(object sender, EventArgs e)
        {
            ConvertedDateLabel.Text = ConvertDate(DateTimePickerToConvert.Value).ToString("yyyy / M / d");
        }

        private void NewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRemind();
        }



        public void NewRemind()
        {
            NewAppointmentForm appointmentForm = new NewAppointmentForm();
            DialogResult result = appointmentForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                InfoToolStripStatusLabel.BackColor = Color.Green;
                InfoToolStripStatusLabel.Text = "تم حفظ التذكير";
            }
            CheckReminds();
        }

        public void CopyDate()
        {

        }

        public DateTime ConvertDate(DateTime from)
        {
            DateTimeFormatInfo formatInfo = new CultureInfo("en-us", false).DateTimeFormat;
            formatInfo.Calendar = new GregorianCalendar();
            return DateTime.Parse(from.ToString("d / M / yyyy", formatInfo));
        }

        public void Exit()
        {
            Application.Exit();
        }

        private void ExitContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateForm();
        }
    }
}
