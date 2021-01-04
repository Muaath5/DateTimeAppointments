namespace DateTimeConverter
{
    partial class DateAndTimeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateAndTimeForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "وقت صلاة الفجر",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("وقت الشروق");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("وقت صلاة الظهر");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("وقت صلاة العصر");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("وقت صلاة المغرب");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("وقت صلاة العشاء ");
            this.HijriLabel = new System.Windows.Forms.Label();
            this.AppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.GregorianLabel = new System.Windows.Forms.Label();
            this.TodayLabel = new System.Windows.Forms.Label();
            this.NextPrayerTimeLabel = new System.Windows.Forms.Label();
            this.PrayersListView = new System.Windows.Forms.ListView();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.InfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.NewRemindSuperButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConvertedDateLabel = new System.Windows.Forms.Label();
            this.DateTimePickerToConvert = new System.Windows.Forms.DateTimePicker();
            this.ConvertDateButton = new System.Windows.Forms.Button();
            this.ConnectLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PrayersGroupBox = new System.Windows.Forms.GroupBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemindsCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AppMenuStrip.SuspendLayout();
            this.MainContextMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.PrayersGroupBox.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HijriLabel
            // 
            this.HijriLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HijriLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HijriLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HijriLabel.Location = new System.Drawing.Point(300, 36);
            this.HijriLabel.Name = "HijriLabel";
            this.HijriLabel.Size = new System.Drawing.Size(188, 40);
            this.HijriLabel.TabIndex = 0;
            this.HijriLabel.Text = "التاريخ الهجري";
            this.HijriLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppMenuStrip
            // 
            this.AppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.AppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AppMenuStrip.Name = "AppMenuStrip";
            this.AppMenuStrip.Size = new System.Drawing.Size(711, 24);
            this.AppMenuStrip.TabIndex = 9;
            this.AppMenuStrip.Text = "AppMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.NightModeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "&ملف";
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.RefreshToolStripMenuItem.Text = "&تحديث";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // NightModeToolStripMenuItem
            // 
            this.NightModeToolStripMenuItem.CheckOnClick = true;
            this.NightModeToolStripMenuItem.Name = "NightModeToolStripMenuItem";
            this.NightModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NightModeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.NightModeToolStripMenuItem.Text = "الو&ضع الليلي";
            this.NightModeToolStripMenuItem.Click += new System.EventHandler(this.NightModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "&خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.EditToolStripMenuItem.Text = "تح&رير";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyToolStripMenuItem.Text = "نس&خ";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.helpToolStripMenuItem.Text = "م&ساعدة";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.SettingsToolStripMenuItem.Text = "ال&إعدادات";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(117, 6);
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.contentsToolStripMenuItem.Text = "&تواصل";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.ContentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(117, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "&حول...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.Location = new System.Drawing.Point(150, 22);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(146, 123);
            this.CurrentTimeLabel.TabIndex = 2;
            this.CurrentTimeLabel.Text = "التوقيت المحلي";
            this.CurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MainNotifyIcon.BalloonTipText = "السلام عليكم وحمة الله وبركاته";
            this.MainNotifyIcon.BalloonTipTitle = "تحية";
            this.MainNotifyIcon.ContextMenuStrip = this.MainContextMenuStrip;
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "التاريخ والوقت | التذكيرات";
            this.MainNotifyIcon.Visible = true;
            // 
            // GregorianLabel
            // 
            this.GregorianLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GregorianLabel.Location = new System.Drawing.Point(310, 98);
            this.GregorianLabel.Name = "GregorianLabel";
            this.GregorianLabel.Size = new System.Drawing.Size(177, 47);
            this.GregorianLabel.TabIndex = 11;
            this.GregorianLabel.Text = "التاريخ الميلادي";
            this.GregorianLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Location = new System.Drawing.Point(6, 67);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new System.Drawing.Size(46, 27);
            this.TodayLabel.TabIndex = 12;
            this.TodayLabel.Text = "اليوم";
            // 
            // NextPrayerTimeLabel
            // 
            this.NextPrayerTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPrayerTimeLabel.AutoSize = true;
            this.NextPrayerTimeLabel.Location = new System.Drawing.Point(18, 31);
            this.NextPrayerTimeLabel.Name = "NextPrayerTimeLabel";
            this.NextPrayerTimeLabel.Size = new System.Drawing.Size(162, 27);
            this.NextPrayerTimeLabel.TabIndex = 13;
            this.NextPrayerTimeLabel.Text = "وقت الصلاة المقبلة:";
            this.NextPrayerTimeLabel.Click += new System.EventHandler(this.labelNextPrayerTime_Click);
            // 
            // PrayersListView
            // 
            this.PrayersListView.HideSelection = false;
            this.PrayersListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.PrayersListView.Location = new System.Drawing.Point(6, 169);
            this.PrayersListView.Name = "PrayersListView";
            this.PrayersListView.RightToLeftLayout = true;
            this.PrayersListView.Size = new System.Drawing.Size(180, 220);
            this.PrayersListView.TabIndex = 15;
            this.PrayersListView.UseCompatibleStateImageBehavior = false;
            this.PrayersListView.View = System.Windows.Forms.View.List;
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAppointmentToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.ContextToolStripSeparator1,
            this.ExitContextToolStripMenuItem});
            this.MainContextMenuStrip.Name = "MainContextMenuStrip";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(169, 76);
            // 
            // NewAppointmentToolStripMenuItem
            // 
            this.NewAppointmentToolStripMenuItem.Name = "NewAppointmentToolStripMenuItem";
            this.NewAppointmentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.NewAppointmentToolStripMenuItem.Text = "تذكير جديد";
            this.NewAppointmentToolStripMenuItem.Click += new System.EventHandler(this.NewAppointmentToolStripMenuItem_Click);
            // 
            // ContextToolStripSeparator1
            // 
            this.ContextToolStripSeparator1.Name = "ContextToolStripSeparator1";
            this.ContextToolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // ExitContextToolStripMenuItem
            // 
            this.ExitContextToolStripMenuItem.Name = "ExitContextToolStripMenuItem";
            this.ExitContextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitContextToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ExitContextToolStripMenuItem.Text = "خروج";
            this.ExitContextToolStripMenuItem.Click += new System.EventHandler(this.ExitContextToolStripMenuItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoToolStripStatusLabel,
            this.RemindsCountToolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 473);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainStatusStrip.Size = new System.Drawing.Size(711, 22);
            this.MainStatusStrip.TabIndex = 19;
            // 
            // InfoToolStripStatusLabel
            // 
            this.InfoToolStripStatusLabel.Name = "InfoToolStripStatusLabel";
            this.InfoToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainLabel.Location = new System.Drawing.Point(0, 24);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(711, 48);
            this.MainLabel.TabIndex = 22;
            this.MainLabel.Text = "التاريخ والوقت";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.HijriLabel);
            this.InfoGroupBox.Controls.Add(this.GregorianLabel);
            this.InfoGroupBox.Controls.Add(this.CurrentTimeLabel);
            this.InfoGroupBox.Controls.Add(this.TodayLabel);
            this.InfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoGroupBox.Location = new System.Drawing.Point(5, 3);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(494, 151);
            this.InfoGroupBox.TabIndex = 23;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "التاريخ والوقت";
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.NewRemindSuperButton);
            this.OptionsGroupBox.Controls.Add(this.label2);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Controls.Add(this.ConvertedDateLabel);
            this.OptionsGroupBox.Controls.Add(this.DateTimePickerToConvert);
            this.OptionsGroupBox.Controls.Add(this.ConvertDateButton);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsGroupBox.Location = new System.Drawing.Point(5, 157);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(494, 241);
            this.OptionsGroupBox.TabIndex = 24;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "خيارات";
            // 
            // NewRemindSuperButton
            // 
            this.NewRemindSuperButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.NewRemindSuperButton.FlatAppearance.BorderSize = 0;
            this.NewRemindSuperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRemindSuperButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewRemindSuperButton.Location = new System.Drawing.Point(344, 167);
            this.NewRemindSuperButton.Name = "NewRemindSuperButton";
            this.NewRemindSuperButton.Size = new System.Drawing.Size(143, 68);
            this.NewRemindSuperButton.TabIndex = 29;
            this.NewRemindSuperButton.Text = "تذكير جديد";
            this.NewRemindSuperButton.UseVisualStyleBackColor = false;
            this.NewRemindSuperButton.Click += new System.EventHandler(this.NewRemindSuperButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "التاريخ بالميلادي:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "أدخل التاريخ:";
            // 
            // ConvertedDateLabel
            // 
            this.ConvertedDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConvertedDateLabel.Location = new System.Drawing.Point(61, 89);
            this.ConvertedDateLabel.Name = "ConvertedDateLabel";
            this.ConvertedDateLabel.Size = new System.Drawing.Size(274, 41);
            this.ConvertedDateLabel.TabIndex = 25;
            this.ConvertedDateLabel.Text = "حول التاريخ لترى النتيجة...";
            this.ConvertedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateTimePickerToConvert
            // 
            this.DateTimePickerToConvert.CustomFormat = "d / M / yyyy       ";
            this.DateTimePickerToConvert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerToConvert.Location = new System.Drawing.Point(61, 38);
            this.DateTimePickerToConvert.Name = "DateTimePickerToConvert";
            this.DateTimePickerToConvert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerToConvert.RightToLeftLayout = true;
            this.DateTimePickerToConvert.Size = new System.Drawing.Size(274, 35);
            this.DateTimePickerToConvert.TabIndex = 24;
            // 
            // ConvertDateButton
            // 
            this.ConvertDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertDateButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ConvertDateButton.Location = new System.Drawing.Point(6, 167);
            this.ConvertDateButton.Name = "ConvertDateButton";
            this.ConvertDateButton.Size = new System.Drawing.Size(143, 68);
            this.ConvertDateButton.TabIndex = 23;
            this.ConvertDateButton.Text = "حول التاريخ";
            this.ConvertDateButton.UseVisualStyleBackColor = true;
            this.ConvertDateButton.Click += new System.EventHandler(this.ConvertDateButton_Click);
            // 
            // ConnectLinkLabel
            // 
            this.ConnectLinkLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConnectLinkLabel.Location = new System.Drawing.Point(452, 24);
            this.ConnectLinkLabel.Name = "ConnectLinkLabel";
            this.ConnectLinkLabel.Size = new System.Drawing.Size(149, 48);
            this.ConnectLinkLabel.TabIndex = 25;
            this.ConnectLinkLabel.TabStop = true;
            this.ConnectLinkLabel.Text = "تواصل...";
            this.ConnectLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrayersGroupBox
            // 
            this.PrayersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrayersGroupBox.Controls.Add(this.NextPrayerTimeLabel);
            this.PrayersGroupBox.Controls.Add(this.PrayersListView);
            this.PrayersGroupBox.Location = new System.Drawing.Point(6, 3);
            this.PrayersGroupBox.Name = "PrayersGroupBox";
            this.PrayersGroupBox.Size = new System.Drawing.Size(186, 395);
            this.PrayersGroupBox.TabIndex = 26;
            this.PrayersGroupBox.TabStop = false;
            this.PrayersGroupBox.Text = "الصلوات";
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.OptionsGroupBox);
            this.RightPanel.Controls.Add(this.InfoGroupBox);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RightPanel.Location = new System.Drawing.Point(0, 72);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RightPanel.Size = new System.Drawing.Size(504, 401);
            this.RightPanel.TabIndex = 27;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(607, 24);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 48);
            this.ExitButton.TabIndex = 28;
            this.ExitButton.Text = "خروج";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.PrayersGroupBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LeftPanel.Location = new System.Drawing.Point(511, 72);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new System.Windows.Forms.Padding(5);
            this.LeftPanel.Size = new System.Drawing.Size(200, 401);
            this.LeftPanel.TabIndex = 29;
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.UpdateToolStripMenuItem.Text = "تحديث";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // RemindsCountToolStripStatusLabel
            // 
            this.RemindsCountToolStripStatusLabel.Name = "RemindsCountToolStripStatusLabel";
            this.RemindsCountToolStripStatusLabel.Size = new System.Drawing.Size(80, 17);
            this.RemindsCountToolStripStatusLabel.Text = "عدد التذكيرات: ";
            // 
            // DateAndTimeForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(711, 495);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.ConnectLinkLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.AppMenuStrip);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AppMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DateAndTimeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التاريخ والوقت";
            this.Load += new System.EventHandler(this.FormDateAndTime_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateAndTimeForm_KeyUp);
            this.AppMenuStrip.ResumeLayout(false);
            this.AppMenuStrip.PerformLayout();
            this.MainContextMenuStrip.ResumeLayout(false);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.PrayersGroupBox.ResumeLayout(false);
            this.PrayersGroupBox.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HijriLabel;
        private System.Windows.Forms.MenuStrip AppMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.Label GregorianLabel;
        private System.Windows.Forms.Label TodayLabel;
        private System.Windows.Forms.Label NextPrayerTimeLabel;
        private System.Windows.Forms.ToolStripMenuItem NightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView PrayersListView;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ContextToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel InfoToolStripStatusLabel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConvertedDateLabel;
        private System.Windows.Forms.DateTimePicker DateTimePickerToConvert;
        private System.Windows.Forms.Button ConvertDateButton;
        private System.Windows.Forms.LinkLabel ConnectLinkLabel;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.GroupBox PrayersGroupBox;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NewRemindSuperButton;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel RemindsCountToolStripStatusLabel;
    }
}

