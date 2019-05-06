namespace Weather.EndPoint.UserControl
{
    partial class RowWeather
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RowWeather));
            this.lblRow = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblWeatherDescription = new DevExpress.XtraEditors.LabelControl();
            this.btnFavorites = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollectionWeatherRow = new DevExpress.Utils.ImageCollection(this.components);
            this.picWeather = new DevExpress.XtraEditors.PictureEdit();
            this.lblDegre = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionWeatherRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRow
            // 
            this.lblRow.Appearance.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRow.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRow.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblRow.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRow.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblRow.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRow.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblRow.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRow.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblRow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRow.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRow.Location = new System.Drawing.Point(510, 0);
            this.lblRow.MaximumSize = new System.Drawing.Size(52, 40);
            this.lblRow.MinimumSize = new System.Drawing.Size(52, 40);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(52, 40);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "1";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblName.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblName.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblName.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Location = new System.Drawing.Point(374, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "مازندران";
            // 
            // lblWeatherDescription
            // 
            this.lblWeatherDescription.Appearance.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWeatherDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWeatherDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblWeatherDescription.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWeatherDescription.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblWeatherDescription.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWeatherDescription.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblWeatherDescription.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWeatherDescription.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblWeatherDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWeatherDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWeatherDescription.Location = new System.Drawing.Point(187, 0);
            this.lblWeatherDescription.Name = "lblWeatherDescription";
            this.lblWeatherDescription.Size = new System.Drawing.Size(187, 40);
            this.lblWeatherDescription.TabIndex = 2;
            this.lblWeatherDescription.Text = "25\'";
            // 
            // btnFavorites
            // 
            this.btnFavorites.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFavorites.ImageIndex = 0;
            this.btnFavorites.ImageList = this.imageCollectionWeatherRow;
            this.btnFavorites.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFavorites.Location = new System.Drawing.Point(48, 0);
            this.btnFavorites.MaximumSize = new System.Drawing.Size(43, 40);
            this.btnFavorites.MinimumSize = new System.Drawing.Size(43, 40);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(43, 40);
            this.btnFavorites.TabIndex = 4;
            // 
            // imageCollectionWeatherRow
            // 
            this.imageCollectionWeatherRow.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionWeatherRow.ImageStream")));
            this.imageCollectionWeatherRow.Images.SetKeyName(0, "star.png");
            // 
            // picWeather
            // 
            this.picWeather.Dock = System.Windows.Forms.DockStyle.Left;
            this.picWeather.EditValue = global::Weather.EndPoint.Properties.Resources.images;
            this.picWeather.Location = new System.Drawing.Point(0, 0);
            this.picWeather.Name = "picWeather";
            this.picWeather.Parmida_ActivePlusMultiKeys = false;
            this.picWeather.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picWeather.Properties.Appearance.Options.UseBackColor = true;
            this.picWeather.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picWeather.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picWeather.Size = new System.Drawing.Size(48, 40);
            this.picWeather.TabIndex = 3;
            // 
            // lblDegre
            // 
            this.lblDegre.Appearance.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDegre.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDegre.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDegre.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDegre.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDegre.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDegre.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDegre.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDegre.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDegre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDegre.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDegre.Location = new System.Drawing.Point(142, 0);
            this.lblDegre.Name = "lblDegre";
            this.lblDegre.Size = new System.Drawing.Size(45, 40);
            this.lblDegre.TabIndex = 5;
            this.lblDegre.Text = "25\'";
            // 
            // RowWeather
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDegre);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.lblWeatherDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRow);
            this.Name = "RowWeather";
            this.Size = new System.Drawing.Size(562, 40);
            this.Load += new System.EventHandler(this.RowWeather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionWeatherRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblRow;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblWeatherDescription;
        private DevExpress.XtraEditors.PictureEdit picWeather;
        private DevExpress.Utils.ImageCollection imageCollectionWeatherRow;
        public DevExpress.XtraEditors.SimpleButton btnFavorites;
        private DevExpress.XtraEditors.LabelControl lblDegre;
    }
}
