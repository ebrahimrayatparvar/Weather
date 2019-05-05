using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Weather.EndPoint.Class.Enum;
using Weather.EndPoint.Class.Model;
using Weather.EndPoint.UserControl;

namespace Weather.EndPoint.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var json = File.ReadAllText("CityList.json");
            var playerList = JsonConvert.DeserializeObject<List<CityModel>>(json);
            int row = 1;
            foreach (var item in playerList)
            {
                //var url = $"http://api.openweathermap.org/data/2.5/weather?q={item.Name}&appid=e0a0922d1b8321fc878e172cfba764b8";
                //var client = new WebClient();
                //var contact = client.DownloadString(url);
                //var result = JsonConvert.DeserializeObject(contact);

                var userControl = new RowWeather
                {
                    Row = row++,
                    Name = item.Persion,
                    Degre = 25,
                    PictureWeather = PictureWeather.PartlyCloudy,
                    Odd = (row % 2) != 0
                };

                userControl.Dock = DockStyle.Top;
                scrollBar.Controls.Add(userControl);
            }
            
        }

        private void timerWeather_Tick(object sender, EventArgs e)
        {
            barStaticTime.Caption = "ساعت : " + DateTime.Now.ToShortTimeString();
        }

        private void barBtnEditUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new EditUser();
            frm.ShowDialog();
        }
    }
}
