using System;
using System.Drawing;
using DevExpress.XtraEditors;
using Weather.EndPoint.Class.Enum;

namespace Weather.EndPoint.UserControl
{
    public partial class RowWeather : XtraUserControl
    {
        public RowWeather()
        {
            InitializeComponent();
        }
        public bool Odd { get; set; }
        public int Row { get; set; }
        public string Name { get; set; }
        public int Degre { get; set; }
        public PictureWeather PictureWeather { get; set; }

       

        private void RowWeather_Load(object sender, EventArgs e)
        {
            lblRow.Text = Row.ToString();
            lblName.Text = Name;
            lblDegre.Text = Degre.ToString();
            if(Odd)
                this.BackColor = Color.FromArgb(62,62,65);
        }
    }
}
