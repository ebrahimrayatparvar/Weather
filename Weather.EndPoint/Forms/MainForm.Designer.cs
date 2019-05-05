namespace Weather.EndPoint.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formAssistant = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barManagerWeather = new DevExpress.XtraBars.BarManager(this.components);
            this.barWeather = new DevExpress.XtraBars.Bar();
            this.barBtnEditUser = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticTime = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelRowWeather = new DevExpress.XtraEditors.PanelControl();
            this.scrollBar = new DevExpress.XtraEditors.XtraScrollableControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.timerWeather = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRowWeather)).BeginInit();
            this.panelRowWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // barManagerWeather
            // 
            this.barManagerWeather.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barWeather,
            this.bar3});
            this.barManagerWeather.DockControls.Add(this.barDockControlTop);
            this.barManagerWeather.DockControls.Add(this.barDockControlBottom);
            this.barManagerWeather.DockControls.Add(this.barDockControlLeft);
            this.barManagerWeather.DockControls.Add(this.barDockControlRight);
            this.barManagerWeather.Form = this;
            this.barManagerWeather.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1,
            this.barStaticTime,
            this.barBtnEditUser});
            this.barManagerWeather.MaxItemId = 3;
            this.barManagerWeather.RightToLeft = DevExpress.Utils.DefaultBoolean.True;
            this.barManagerWeather.StatusBar = this.bar3;
            // 
            // barWeather
            // 
            this.barWeather.BarName = "Tools";
            this.barWeather.DockCol = 0;
            this.barWeather.DockRow = 0;
            this.barWeather.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barWeather.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnEditUser, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barWeather.OptionsBar.AllowQuickCustomization = false;
            this.barWeather.OptionsBar.DrawDragBorder = false;
            this.barWeather.OptionsBar.UseWholeRow = true;
            this.barWeather.Text = "Tools";
            // 
            // barBtnEditUser
            // 
            this.barBtnEditUser.Caption = "ویرایش کاربر";
            this.barBtnEditUser.Glyph = global::Weather.EndPoint.Properties.Resources.EditUser;
            this.barBtnEditUser.Id = 2;
            this.barBtnEditUser.Name = "barBtnEditUser";
            this.barBtnEditUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditUser_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticTime)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticTime
            // 
            this.barStaticTime.Caption = "ساعت : ";
            this.barStaticTime.Id = 1;
            this.barStaticTime.Name = "barStaticTime";
            this.barStaticTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1184, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
            this.barDockControlBottom.Size = new System.Drawing.Size(1184, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 607);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1184, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 607);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "ساعت";
            this.barHeaderItem1.Id = 0;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(527, 63);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(624, 40);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(624, 40);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "وضعیت هوای ایران";
            // 
            // panelRowWeather
            // 
            this.panelRowWeather.Controls.Add(this.scrollBar);
            this.panelRowWeather.Location = new System.Drawing.Point(529, 104);
            this.panelRowWeather.Name = "panelRowWeather";
            this.panelRowWeather.Size = new System.Drawing.Size(622, 487);
            this.panelRowWeather.TabIndex = 5;
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollBar.Location = new System.Drawing.Point(2, 2);
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(618, 483);
            this.scrollBar.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(324, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(183, 30);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "چهار محال بختیاری";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(391, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 30);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "1398/02/01";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Weather.EndPoint.Properties.Resources.images;
            this.pictureEdit1.Location = new System.Drawing.Point(62, 63);
            this.pictureEdit1.MenuManager = this.barManagerWeather;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Parmida_ActivePlusMultiKeys = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(205, 174);
            this.pictureEdit1.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(273, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(234, 30);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "ابراهیم رعیت پرور تلوکی";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(273, 207);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(234, 30);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Admin";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Location = new System.Drawing.Point(62, 250);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(445, 341);
            this.panelControl2.TabIndex = 27;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.Location = new System.Drawing.Point(235, 183);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(116, 30);
            this.labelControl14.TabIndex = 18;
            this.labelControl14.Text = "1398/02/01";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Location = new System.Drawing.Point(235, 117);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(116, 30);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "1398/02/01";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(145, 183);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(69, 30);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "دمای شب : ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Location = new System.Drawing.Point(23, 183);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(116, 30);
            this.labelControl13.TabIndex = 15;
            this.labelControl13.Text = "1398/02/01";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(357, 183);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 30);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "دمای روز : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(23, 117);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(116, 30);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "1398/02/01";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(145, 117);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 30);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Lng : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(357, 117);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 30);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Lat : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(104, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(223, 39);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "قائمشهر";
            // 
            // timerWeather
            // 
            this.timerWeather.Enabled = true;
            this.timerWeather.Interval = 1000;
            this.timerWeather.Tick += new System.EventHandler(this.timerWeather_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelRowWeather);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "هواشناسی آنلاین";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelRowWeather)).EndInit();
            this.panelRowWeather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarManager barManagerWeather;
        private DevExpress.XtraBars.Bar barWeather;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelRowWeather;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl scrollBar;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraBars.BarStaticItem barStaticTime;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private System.Windows.Forms.Timer timerWeather;
        private DevExpress.XtraBars.BarButtonItem barBtnEditUser;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}