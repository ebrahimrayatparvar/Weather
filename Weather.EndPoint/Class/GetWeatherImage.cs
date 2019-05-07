using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.EndPoint.Class
{
    public static class GetWeatherImage
    {
        #region Get weather image
        public static Image GetImage(int id)
        {
            Image img = null; ;
            switch (id)
            {
                case 200:
                    img = Properties.Resources._200;
                    break;
                case 201:
                    img = Properties.Resources._201;
                    break;
                case 202:
                    img = Properties.Resources._202;
                    break;
                case 210:
                    img = Properties.Resources._210;
                    break;
                case 211:
                    img = Properties.Resources._211;
                    break;
                case 212:
                    img = Properties.Resources._212;
                    break;
                case 221:
                    img = Properties.Resources._221;
                    break;
                case 230:
                    img = Properties.Resources._230;
                    break;
                case 231:
                    img = Properties.Resources._231;
                    break;
                case 232:
                    img = Properties.Resources._232;
                    break;
                case 300:
                    img = Properties.Resources._300;
                    break;
                case 301:
                    img = Properties.Resources._301;
                    break;
                case 302:
                    img = Properties.Resources._302;
                    break;
                case 310:
                    img = Properties.Resources._310;
                    break;
                case 311:
                    img = Properties.Resources._311;
                    break;
                case 312:
                    img = Properties.Resources._312;
                    break;
                case 313:
                    img = Properties.Resources._313;
                    break;
                case 314:
                    img = Properties.Resources._314;
                    break;
                case 321:
                    img = Properties.Resources._321;
                    break;
                case 500:
                    img = Properties.Resources._500;
                    break;
                case 501:
                    img = Properties.Resources._501;
                    break;
                case 502:
                    img = Properties.Resources._502;
                    break;
                case 503:
                    img = Properties.Resources._503;
                    break;
                case 504:
                    img = Properties.Resources._504;
                    break;
                case 511:
                    img = Properties.Resources._511;
                    break;
                case 520:
                    img = Properties.Resources._520;
                    break;
                case 521:
                    img = Properties.Resources._521;
                    break;
                case 522:
                    img = Properties.Resources._522;
                    break;
                case 531:
                    img = Properties.Resources._531;
                    break;
                case 600:
                    img = Properties.Resources._600;
                    break;
                case 601:
                    img = Properties.Resources._601;
                    break;
                case 602:
                    img = Properties.Resources._602;
                    break;
                case 611:
                    img = Properties.Resources._611;
                    break;
                case 612:
                    img = Properties.Resources._612;
                    break;
                case 613:
                    img = Properties.Resources._613;
                    break;
                case 615:
                    img = Properties.Resources._615;
                    break;
                case 616:
                    img = Properties.Resources._616;
                    break;
                case 620:
                    img = Properties.Resources._620;
                    break;
                case 621:
                    img = Properties.Resources._621;
                    break;
                case 622:
                    img = Properties.Resources._622;
                    break;
                case 701:
                    img = Properties.Resources._701;
                    break;
                case 711:
                    img = Properties.Resources._711;
                    break;
                case 721:
                    img = Properties.Resources._721;
                    break;
                case 731:
                    img = Properties.Resources._731;
                    break;
                case 741:
                    img = Properties.Resources._741;
                    break;
                case 751:
                    img = Properties.Resources._751;
                    break;
                case 761:
                    img = Properties.Resources._761;
                    break;
                case 762:
                    img = Properties.Resources._762;
                    break;
                case 771:
                    img = Properties.Resources._771;
                    break;
                case 781:
                    img = Properties.Resources._781;
                    break;
                case 800:
                    img = Properties.Resources._800;
                    break;
                case 801:
                    img = Properties.Resources._801;
                    break;
                case 802:
                    img = Properties.Resources._802;
                    break;
                case 803:
                    img = Properties.Resources._803;
                    break;
                case 804:
                    img = Properties.Resources._804;
                    break;
                default:
                    break;
            }
            return img;
        }
        #endregion

        #region get weather description today 
        public static string GetDescription(int id)
        {
            string str = null; 
            switch (id)
            {
                case 200:
                    str = "رعد و برق با باران نور";
                    break;
                case 201:
                    str = "رعد و برق";
                    break;
                case 202:
                    str = "رعد و برق همراه با بارش باران سنگین";
                    break;
                case 210:
                    str = "رعد و برق نور";
                    break;
                case 211:
                    str = "رعد و برق";
                    break;
                case 212:
                    str = "رعد و برق شدید";
                    break;
                case 221:
                    str = "رعد و برق";
                    break;
                case 230:
                    str = "رعد و برق با ریزش نور";
                    break;
                case 231:
                    str = "رعد و برق و رطوبت";
                    break;
                case 232:
                    str = "رعد و برق با ریزش سنگین";
                    break;
                case 300:
                    str = "شدت نور خورشید";
                    break;
                case 301:
                    str = "نمنم باران";
                    break;
                case 302:
                    str = "شدید ریزش";
                    break;
                case 310:
                    str = "شدت نور بارش باران";
                    break;
                case 311:
                    str = "بارش باران";
                    break;
                case 312:
                    str = "باران شدید سنگین باران";
                    break;
                case 313:
                    str = "رگبار و نمنم باران";
                    break;
                case 314:
                    str = "بارش باران سنگین";
                    break;
                case 321:
                    str = "رگبار";
                    break;
                case 500:
                    str = "باران نور";
                    break;
                case 501:
                    str = "باران متوسط";
                    break;
                case 502:
                    str = "شدت باران سنگین";
                    break;
                case 503:
                    str = "باران بسیار سنگین است";
                    break;
                case 504:
                    str = "باران شدید";
                    break;
                case 511:
                    str = "باران انجماد";
                    break;
                case 520:
                    str = "شدت نور باران نمنم";
                    break;
                case 521:
                    str = "باران نمنم";
                    break;
                case 522:
                    str = "باران شدید باران قوی";
                    break;
                case 531:
                    str = "نمنم باران گرفتگی";
                    break;
                case 600:
                    str = "برف نور";
                    break;
                case 601:
                    str = "برف";
                    break;
                case 602:
                    str = "برف سنگین";
                    break;
                case 611:
                    str = "خواب";
                    break;
                case 612:
                    str = "یخ باد یخ";
                    break;
                case 613:
                    str = "آب و هوای دوش";
                    break;
                case 615:
                    str = "بارش برف و باران";
                    break;
                case 616:
                    str = "باران و برف";
                    break;
                case 620:
                    str = "برف دوتایی نور";
                    break;
                case 621:
                    str = "نمنم برف";
                    break;
                case 622:
                    str = "برف دوشش";
                    break;
                case 701:
                    str = "غبار";
                    break;
                case 711:
                    str = "دود";
                    break;
                case 721:
                    str = "بخار";
                    break;
                case 731:
                    str = "شن و ماسه / گرد و غبار گرد و غبار";
                    break;
                case 741:
                    str = "مه";
                    break;
                case 751:
                    str = "شن";
                    break;
                case 761:
                    str = "گرد و خاک";
                    break;
                case 762:
                    str = "خاکستر آتشفشانی";
                    break;
                case 771:
                    str = "توفانی شدن";
                    break;
                case 781:
                    str = "گردباد";
                    break;
                case 800:
                    str = "آسمان صاف";
                    break;
                case 801:
                    str = "چند ابرها";
                    break;
                case 802:
                    str = "ابرهای پراکنده";
                    break;
                case 803:
                    str = "ابرهای شکسته";
                    break;
                case 804:
                    str = "ابرهای خفیف";
                    break;
                default:
                    break;
            }
            return str;
        }
        #endregion

        #region Convert sunrise value and sunset value to time
        public static string ConvertUnixToDateTime(double unixTime)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return dt.AddSeconds(unixTime).ToLocalTime().ToShortTimeString();
        }
        #endregion

        #region Convert kelvin to cantigrad
        public static string ConvertKelvinToCantigerad(double value)
        {
            return (value - 273.15).ToString();
        }
        #endregion

    }
}
