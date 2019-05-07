using System;
using System.Drawing;
using DevExpress.XtraEditors;
using Weather.EndPoint.Class;
using Weather.EndPoint.Class.Enum;

namespace Weather.EndPoint.UserControl
{
    public partial class RowWeather : XtraUserControl
    {
        #region Constructor user control rowWeather
        public RowWeather()
        {
            InitializeComponent();
        }
        #endregion

        #region variable
        public bool Odd { get; set; }
        public int Row { get; set; }
        public string NamePersion { get; set; }
        public string Degre { get; set; }
        public int PictureWeather { get; set; }
        #endregion
        
        #region Form load user control rowWeather
        private void RowWeather_Load(object sender, EventArgs e)
        {
            lblRow.Text = Row.ToString();
            lblName.Text = NamePersion;
            lblDegre.Text = Degre.ToString();
            if(Odd)
                this.BackColor = Color.FromArgb(62,62,65);
            picWeather.Image = GetWeatherImage.GetImage(PictureWeather);
            lblWeatherDescription.Text = GetWeatherImage.GetDescription(PictureWeather);
        }
        #endregion

    }
}
