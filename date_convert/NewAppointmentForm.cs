using DateTimeConverter;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeConverter
{
    public partial class NewAppointmentForm : Form
    {
        public DateTime? ChoosenDateTime { get; private set; } = DateTime.MinValue;

        public NewAppointmentForm()
        {
            InitializeComponent();
            RemindDateTimePicker.MinDate = DateTime.Now;
            RemindCalenderComboBox.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;
        }

        private void AddRemindButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = RemindDateTimePicker.Value;
            DialogResult = DialogResult.Yes;
            Calendar calender;

            if (RemindCalenderComboBox.Text == "هجري")
            {
                calender = new UmAlQuraCalendar();
            }
            else
            {
                calender = new GregorianCalendar();
            }

            ToolTipIcon Status = (ToolTipIcon)StatusComboBox.SelectedIndex;
            Remind remind = new Remind(dateTime, TitleTextBox.Text, DescriptionTextBox.Text)
            {
                Status = Status
            };
            DataStore.SaveRemind(remind);

            try { ChoosenDateTime = dateTime; }
            catch (ArgumentOutOfRangeException) { ChoosenDateTime = DateTime.MinValue; }
            Close();
        }

        private void WithTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(WithTimeCheckBox.Checked)
            { RemindDateTimePicker.CustomFormat = "yyyy/M/d hh:mm:ss tt"; }
            else
            {
                RemindDateTimePicker.CustomFormat = "yyyy/M/d";
            }
        }

        private void CancelRemindButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TitleTextBox_Enter(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "العنوان")
            {
                TitleTextBox.ForeColor = Color.Black;
                TitleTextBox.Text = "";
            }
        }

        private void DescryptionTextBox_Enter(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text == "النص")
            {
                DescriptionTextBox.ForeColor = Color.Black;
                DescriptionTextBox.Text = "";
            }
        }

        private void TitleTextBox_Leave(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "")
            {
                TitleTextBox.ForeColor = Color.DarkGray;
                TitleTextBox.Text = "العنوان";
            }
        }

        private void DescryptionTextBox_Leave(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text == "")
            {
                DescriptionTextBox.ForeColor = Color.DarkGray;
                DescriptionTextBox.Text = "النص";
            }
        }
    }
}
