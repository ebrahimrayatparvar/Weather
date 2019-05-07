using _03_Weather.Service.OpenWeatherMap;
using EfRipositpry.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Weather.EndPoint.Class;
using Weather.EndPoint.Class.Enum;
using Weather.EndPoint.Class.Model;
using Weather.EndPoint.UserControl;

namespace Weather.EndPoint.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private const string _apiKey = "e0a0922d1b8321fc878e172cfba764b8";
        private OpenWeatherMapApi openWeatherMapApi = new OpenWeatherMapApi();
        private EfUser _db = new EfUser();

        #region Constructor form main
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            var json = File.ReadAllText("CityList.json");
            var playerList = JsonConvert.DeserializeObject<List<CityModel>>(json);
            int row = playerList.Count;
            foreach (var item in playerList)
            {
                var result = openWeatherMapApi.GetApiResult(item.Name, _apiKey);

                var userControl = new RowWeather
                {
                    Row = row,
                    NamePersion = item.Persion,
                    Degre = " C° " + GetWeatherImage.ConvertKelvinToCantigerad(result.main.temp) ,
                    PictureWeather = result.weather[0].id,
                    Odd = (row % 2) != 0,
                    Dock = DockStyle.Top,
                    Name = "UserControlWeather" + row
                };
                userControl.btnFavorites.Click += (s, args) =>
                 {
                     AddFavorites(item.Name, item.Persion);
                 };

                scrollBar.Controls.Add(userControl);
                row--;
            }

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.CityName))
            {
                GetFavoritesInfo(Properties.Settings.Default.CityName);
            }
            GetUserInformation();
            lblDayName.Text = GetDayName();
        }
        #endregion

        #region Get user information name and family
        private void GetUserInformation()
        {
            var userInfo = _db.GetUserInformation(Properties.Settings.Default.UserName);
            lblUserName.Text = userInfo[0].Name + " " + userInfo[0].family;
        }
        #endregion

        #region Get today name
        private string GetDayName()
        {
            DateTime dt = DateTime.Now;
            return ((DayOfWeekPersion)(int)dt.DayOfWeek).ToString();            
        }
        #endregion
        
        #region Add city for favorites city
        private void AddFavorites(string cityName, string cityNamePersion)
        {
            Properties.Settings.Default.CityName = cityName;
            Properties.Settings.Default.CityNamePersion = cityNamePersion;
            Properties.Settings.Default.Save();
            _db.AddFavoriteCity(Properties.Settings.Default.UserName, cityName);
            GetFavoritesInfo(cityName);
        }
        #endregion
        
        #region Get favorites weather information for city
        private void GetFavoritesInfo(string cityName)
        {
            var result = openWeatherMapApi.GetApiResult(cityName, _apiKey);
            lblCity.Text = Properties.Settings.Default.CityNamePersion;
            lblCityMain.Text = Properties.Settings.Default.CityNamePersion;
            lblLat.Text = result.coord.lat;
            lblLng.Text = result.coord.lon;
            lblTemp.Text = GetWeatherImage.ConvertKelvinToCantigerad(result.main.temp);
            lblSpeed.Text = result.wind.speed.ToString();
            lblHumidity.Text = result.main.humidity.ToString();
            lblPressure.Text = result.main.pressure;

            lblSunrise.Text = GetWeatherImage.ConvertUnixToDateTime
                            (double.Parse(result.sys.sunrise.ToString()));
            lblSunset.Text = GetWeatherImage.ConvertUnixToDateTime
                            (double.Parse(result.sys.sunset.ToString()));

            picWeather.Image = GetWeatherImage.GetImage(result.weather[0].id);
            lblDescription.Text = GetWeatherImage.GetDescription(result.weather[0].id);
        }
        #endregion
        
        #region Timer local time system
        private void timerWeather_Tick(object sender, EventArgs e)
        {
            barStaticTime.Caption = "ساعت : " + DateTime.Now.ToShortTimeString();
        }
        #endregion
        
        #region Button click edit user information
        private void barBtnEditUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new EditUser();
            frm.ShowDialog();
            GetUserInformation();
        }
        #endregion


    }
}
