namespace DateTimeConverter
{
    partial class NewAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RemindDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WithTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddRemindButton = new System.Windows.Forms.Button();
            this.RemindCalenderComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.CancelRemindButton = new System.Windows.Forms.Button();
            this.RemindCalenderLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.IconLabel = new System.Windows.Forms.Label();
            this.RemindPropsGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.RemindPropsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RemindDateTimePicker
            // 
            this.RemindDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemindDateTimePicker.CustomFormat = " d /M / yyyy ";
            this.RemindDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.RemindDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindDateTimePicker.Location = new System.Drawing.Point(158, 314);
            this.RemindDateTimePicker.MinDate = new System.DateTime(2020, 5, 19, 0, 0, 0, 0);
            this.RemindDateTimePicker.Name = "RemindDateTimePicker";
            this.RemindDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemindDateTimePicker.RightToLeftLayout = true;
            this.RemindDateTimePicker.Size = new System.Drawing.Size(269, 35);
            this.RemindDateTimePicker.TabIndex = 4;
            this.RemindDateTimePicker.Value = new System.DateTime(2020, 10, 6, 20, 17, 0, 0);
            // 
            // WithTimeCheckBox
            // 
            this.WithTimeCheckBox.AutoSize = true;
            this.WithTimeCheckBox.Checked = true;
            this.WithTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WithTimeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithTimeCheckBox.Location = new System.Drawing.Point(74, 48);
            this.WithTimeCheckBox.Name = "WithTimeCheckBox";
            this.WithTimeCheckBox.Size = new System.Drawing.Size(122, 31);
            this.WithTimeCheckBox.TabIndex = 4;
            this.WithTimeCheckBox.Text = "محدود بوقت";
            this.WithTimeCheckBox.UseVisualStyleBackColor = true;
            this.WithTimeCheckBox.CheckedChanged += new System.EventHandler(this.WithTimeCheckBox_CheckedChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 96);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(561, 35);
            this.DescriptionTextBox.TabIndex = 2;
            this.DescriptionTextBox.Text = "النص";
            this.DescriptionTextBox.Enter += new System.EventHandler(this.DescryptionTextBox_Enter);
            this.DescriptionTextBox.Leave += new System.EventHandler(this.DescryptionTextBox_Leave);
            // 
            // AddRemindButton
            // 
            this.AddRemindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRemindButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddRemindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRemindButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRemindButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddRemindButton.Location = new System.Drawing.Point(433, 309);
            this.AddRemindButton.Name = "AddRemindButton";
            this.AddRemindButton.Size = new System.Drawing.Size(140, 42);
            this.AddRemindButton.TabIndex = 8;
            this.AddRemindButton.Text = "إضافة";
            this.AddRemindButton.UseVisualStyleBackColor = false;
            this.AddRemindButton.Click += new System.EventHandler(this.AddRemindButton_Click);
            // 
            // RemindCalenderComboBox
            // 
            this.RemindCalenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemindCalenderComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.RemindCalenderComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemindCalenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RemindCalenderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemindCalenderComboBox.FormattingEnabled = true;
            this.RemindCalenderComboBox.Items.AddRange(new object[] {
            "هجري",
            "ميلادي"});
            this.RemindCalenderComboBox.Location = new System.Drawing.Point(336, 46);
            this.RemindCalenderComboBox.Name = "RemindCalenderComboBox";
            this.RemindCalenderComboBox.Size = new System.Drawing.Size(148, 35);
            this.RemindCalenderComboBox.TabIndex = 1;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "بدون",
            "معلومة",
            "تحذير",
            "خطأ"});
            this.StatusComboBox.Location = new System.Drawing.Point(336, 94);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(148, 35);
            this.StatusComboBox.TabIndex = 3;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.TitleTextBox.Location = new System.Drawing.Point(12, 55);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(192, 35);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.Text = "العنوان";
            this.TitleTextBox.Enter += new System.EventHandler(this.TitleTextBox_Enter);
            this.TitleTextBox.Leave += new System.EventHandler(this.TitleTextBox_Leave);
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(584, 52);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "تذكير جديد";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelRemindButton
            // 
            this.CancelRemindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelRemindButton.BackColor = System.Drawing.Color.Red;
            this.CancelRemindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRemindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelRemindButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelRemindButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelRemindButton.Location = new System.Drawing.Point(12, 309);
            this.CancelRemindButton.Name = "CancelRemindButton";
            this.CancelRemindButton.Size = new System.Drawing.Size(140, 42);
            this.CancelRemindButton.TabIndex = 7;
            this.CancelRemindButton.Text = "إلغاء";
            this.CancelRemindButton.UseVisualStyleBackColor = false;
            this.CancelRemindButton.Click += new System.EventHandler(this.CancelRemindButton_Click);
            // 
            // RemindCalenderLabel
            // 
            this.RemindCalenderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemindCalenderLabel.AutoSize = true;
            this.RemindCalenderLabel.Location = new System.Drawing.Point(490, 49);
            this.RemindCalenderLabel.Name = "RemindCalenderLabel";
            this.RemindCalenderLabel.Size = new System.Drawing.Size(65, 27);
            this.RemindCalenderLabel.TabIndex = 0;
            this.RemindCalenderLabel.Text = "التقويم:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(6, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 31);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "إظهار في شاشة القفل";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // IconLabel
            // 
            this.IconLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IconLabel.AutoSize = true;
            this.IconLabel.Location = new System.Drawing.Point(497, 97);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(58, 27);
            this.IconLabel.TabIndex = 2;
            this.IconLabel.Text = "النوع:";
            // 
            // RemindPropsGroupBox
            // 
            this.RemindPropsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemindPropsGroupBox.Controls.Add(this.WithTimeCheckBox);
            this.RemindPropsGroupBox.Controls.Add(this.IconLabel);
            this.RemindPropsGroupBox.Controls.Add(this.RemindCalenderLabel);
            this.RemindPropsGroupBox.Controls.Add(this.checkBox1);
            this.RemindPropsGroupBox.Controls.Add(this.RemindCalenderComboBox);
            this.RemindPropsGroupBox.Controls.Add(this.StatusComboBox);
            this.RemindPropsGroupBox.Location = new System.Drawing.Point(12, 137);
            this.RemindPropsGroupBox.Name = "RemindPropsGroupBox";
            this.RemindPropsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemindPropsGroupBox.Size = new System.Drawing.Size(561, 145);
            this.RemindPropsGroupBox.TabIndex = 3;
            this.RemindPropsGroupBox.TabStop = false;
            this.RemindPropsGroupBox.Text = "خصائص التذكير";
            // 
            // TimeoutNumericUpDown
            // 
            this.TimeoutNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeoutNumericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TimeoutNumericUpDown.Location = new System.Drawing.Point(452, 55);
            this.TimeoutNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeoutNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TimeoutNumericUpDown.Name = "TimeoutNumericUpDown";
            this.TimeoutNumericUpDown.Size = new System.Drawing.Size(120, 35);
            this.TimeoutNumericUpDown.TabIndex = 6;
            this.TimeoutNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeoutNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(345, 58);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(101, 27);
            this.TimeoutLabel.TabIndex = 5;
            this.TimeoutLabel.Text = "مدة التذكير:";
            // 
            // NewAppointmentForm
            // 
            this.AcceptButton = this.AddRemindButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.CancelRemindButton;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.TimeoutLabel);
            this.Controls.Add(this.TimeoutNumericUpDown);
            this.Controls.Add(this.RemindPropsGroupBox);
            this.Controls.Add(this.CancelRemindButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.RemindDateTimePicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.AddRemindButton);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewAppointmentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "تذكير جديد";
            this.RemindPropsGroupBox.ResumeLayout(false);
            this.RemindPropsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker RemindDateTimePicker;
        private System.Windows.Forms.CheckBox WithTimeCheckBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button AddRemindButton;
        private System.Windows.Forms.ComboBox RemindCalenderComboBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button CancelRemindButton;
        private System.Windows.Forms.Label RemindCalenderLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.GroupBox RemindPropsGroupBox;
        private System.Windows.Forms.NumericUpDown TimeoutNumericUpDown;
        private System.Windows.Forms.Label TimeoutLabel;
    }
}