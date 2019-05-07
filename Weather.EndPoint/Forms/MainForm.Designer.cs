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
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barBtnFavoritesCity = new DevExpress.XtraBars.BarButtonItem();
            this.scrollBar = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelRowWeather = new DevExpress.XtraEditors.PanelControl();
            this.lblCityMain = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.picWeather = new DevExpress.XtraEditors.PictureEdit();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblDayName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblSunset = new DevExpress.XtraEditors.LabelControl();
            this.lblTemp = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblLat = new DevExpress.XtraEditors.LabelControl();
            this.lblHumidity = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.lbl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblSpeed = new DevExpress.XtraEditors.LabelControl();
            this.lblSunrise = new DevExpress.XtraEditors.LabelControl();
            this.label = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblLng = new DevExpress.XtraEditors.LabelControl();
            this.lblPressure = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.timerWeather = new System.Windows.Forms.Timer(this.components);
            this.imageCollectionWeather = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRowWeather)).BeginInit();
            this.panelRowWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionWeather)).BeginInit();
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
            this.barBtnEditUser,
            this.barBtnFavoritesCity,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4});
            this.barManagerWeather.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4)});
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
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "                       ";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "ابراهیم رعیت پرور تلوکی         ebrahim rayatparvar talooki";
            this.barStaticItem2.Id = 6;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "                       ";
            this.barStaticItem3.Id = 7;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Github Address : https://github.com/ebrahimrayatparvar/Weather";
            this.barStaticItem4.Id = 8;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
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
            // barBtnFavoritesCity
            // 
            this.barBtnFavoritesCity.Id = 4;
            this.barBtnFavoritesCity.Name = "barBtnFavoritesCity";
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollBar.Location = new System.Drawing.Point(2, 2);
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(618, 483);
            this.scrollBar.TabIndex = 0;
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
            // lblCityMain
            // 
            this.lblCityMain.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCityMain.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCityMain.Location = new System.Drawing.Point(324, 67);
            this.lblCityMain.Name = "lblCityMain";
            this.lblCityMain.Size = new System.Drawing.Size(183, 30);
            this.lblCityMain.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(273, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(234, 30);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "1398/02/01";
            // 
            // picWeather
            // 
            this.picWeather.EditValue = global::Weather.EndPoint.Properties.Resources.images;
            this.picWeather.Location = new System.Drawing.Point(62, 63);
            this.picWeather.MenuManager = this.barManagerWeather;
            this.picWeather.Name = "picWeather";
            this.picWeather.Parmida_ActivePlusMultiKeys = false;
            this.picWeather.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picWeather.Properties.Appearance.Options.UseBackColor = true;
            this.picWeather.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picWeather.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picWeather.Size = new System.Drawing.Size(205, 174);
            this.picWeather.TabIndex = 16;
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUserName.Location = new System.Drawing.Point(273, 207);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(234, 30);
            this.lblUserName.TabIndex = 21;
            this.lblUserName.Text = "ابراهیم رعیت پرور تلوکی";
            // 
            // lblDayName
            // 
            this.lblDayName.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDayName.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblDayName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDayName.Location = new System.Drawing.Point(273, 167);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(234, 30);
            this.lblDayName.TabIndex = 22;
            this.lblDayName.Text = "Admin";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.lblSunset);
            this.panelControl2.Controls.Add(this.lblTemp);
            this.panelControl2.Controls.Add(this.lblDescription);
            this.panelControl2.Controls.Add(this.lblLat);
            this.panelControl2.Controls.Add(this.lblHumidity);
            this.panelControl2.Controls.Add(this.labelControl20);
            this.panelControl2.Controls.Add(this.lbl2);
            this.panelControl2.Controls.Add(this.lblSpeed);
            this.panelControl2.Controls.Add(this.lblSunrise);
            this.panelControl2.Controls.Add(this.label);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.lblLng);
            this.panelControl2.Controls.Add(this.lblPressure);
            this.panelControl2.Controls.Add(this.labelControl16);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl15);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.lblCity);
            this.panelControl2.Location = new System.Drawing.Point(62, 250);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(445, 341);
            this.panelControl2.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(354, 295);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 30);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "غروب آفتاب :";
            // 
            // lblSunset
            // 
            this.lblSunset.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSunset.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblSunset.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSunset.Location = new System.Drawing.Point(211, 295);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(137, 30);
            this.lblSunset.TabIndex = 19;
            // 
            // lblTemp
            // 
            this.lblTemp.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTemp.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblTemp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTemp.Location = new System.Drawing.Point(199, 194);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(149, 30);
            this.lblTemp.TabIndex = 18;
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDescription.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDescription.Location = new System.Drawing.Point(199, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(149, 30);
            this.lblDescription.TabIndex = 18;
            // 
            // lblLat
            // 
            this.lblLat.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLat.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblLat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLat.Location = new System.Drawing.Point(199, 140);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(149, 30);
            this.lblLat.TabIndex = 18;
            // 
            // lblHumidity
            // 
            this.lblHumidity.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHumidity.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblHumidity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHumidity.Location = new System.Drawing.Point(20, 90);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(98, 30);
            this.lblHumidity.TabIndex = 18;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl20.Location = new System.Drawing.Point(124, 194);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(69, 30);
            this.labelControl20.TabIndex = 17;
            this.labelControl20.Text = "سرعت باد :";
            // 
            // lbl2
            // 
            this.lbl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl2.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lbl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl2.Location = new System.Drawing.Point(124, 249);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 30);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "طلوع آفتاب :";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSpeed.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblSpeed.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSpeed.Location = new System.Drawing.Point(20, 194);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(98, 30);
            this.lblSpeed.TabIndex = 15;
            // 
            // lblSunrise
            // 
            this.lblSunrise.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSunrise.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblSunrise.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSunrise.Location = new System.Drawing.Point(20, 249);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(98, 30);
            this.lblSunrise.TabIndex = 15;
            // 
            // label
            // 
            this.label.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label.Location = new System.Drawing.Point(354, 194);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 30);
            this.label.TabIndex = 16;
            this.label.Text = "دما : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(354, 90);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 30);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "آسمان :";
            // 
            // lblLng
            // 
            this.lblLng.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLng.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblLng.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLng.Location = new System.Drawing.Point(20, 140);
            this.lblLng.Name = "lblLng";
            this.lblLng.Size = new System.Drawing.Size(98, 30);
            this.lblLng.TabIndex = 15;
            // 
            // lblPressure
            // 
            this.lblPressure.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPressure.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblPressure.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPressure.Location = new System.Drawing.Point(211, 249);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(137, 30);
            this.lblPressure.TabIndex = 15;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl16.Location = new System.Drawing.Point(124, 140);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(69, 30);
            this.labelControl16.TabIndex = 14;
            this.labelControl16.Text = "Lng : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(354, 249);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 30);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "فشار : ";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Location = new System.Drawing.Point(354, 140);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(69, 30);
            this.labelControl15.TabIndex = 13;
            this.labelControl15.Text = "Lat : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(124, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 30);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "رطوبت :";
            // 
            // lblCity
            // 
            this.lblCity.Appearance.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCity.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCity.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCity.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCity.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCity.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCity.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCity.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCity.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCity.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCity.Location = new System.Drawing.Point(5, 5);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(435, 39);
            this.lblCity.TabIndex = 12;
            // 
            // timerWeather
            // 
            this.timerWeather.Enabled = true;
            this.timerWeather.Interval = 1000;
            this.timerWeather.Tick += new System.EventHandler(this.timerWeather_Tick);
            // 
            // imageCollectionWeather
            // 
            this.imageCollectionWeather.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionWeather.ImageStream")));
            this.imageCollectionWeather.InsertGalleryImage("geopoint_16x16.png", "images/maps/geopoint_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/maps/geopoint_16x16.png"), 0);
            this.imageCollectionWeather.Images.SetKeyName(0, "geopoint_16x16.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.lblDayName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblCityMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.picWeather.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionWeather)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblCityMain;
        private DevExpress.XtraEditors.XtraScrollableControl scrollBar;
        private DevExpress.XtraEditors.PictureEdit picWeather;
        private DevExpress.XtraEditors.LabelControl lblDayName;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblHumidity;
        private DevExpress.XtraEditors.LabelControl lbl2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblPressure;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraBars.BarStaticItem barStaticTime;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private System.Windows.Forms.Timer timerWeather;
        private DevExpress.XtraBars.BarButtonItem barBtnEditUser;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LabelControl lblSunrise;
        private DevExpress.XtraBars.BarButtonItem barBtnFavoritesCity;
        private DevExpress.Utils.ImageCollection imageCollectionWeather;
        private DevExpress.XtraEditors.LabelControl lblTemp;
        private DevExpress.XtraEditors.LabelControl lblLat;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl lblSpeed;
        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.LabelControl lblLng;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblSunset;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
    }
}