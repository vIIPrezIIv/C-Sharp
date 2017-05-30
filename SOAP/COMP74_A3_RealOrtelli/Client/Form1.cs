using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Client.CurrencyService;
using Client.AirportInformationService;
using Client.CountryDetailsService;
using Client.CurrencyConvertorService;
using Client.GlobalWeatherService;
using Client.SunSetAndSunRiseService;

namespace Client
{
    public partial class Form1 : Form
    {
        
        CurrencyServiceClient currencyApi = new CurrencyServiceClient();
        SunSetRiseServiceSoapClient sunSetSunRiseApi = new SunSetRiseServiceSoapClient();
        airportSoapClient airportApi = new airportSoapClient();
        countrySoapClient countryApi = new countrySoapClient();
        CurrencyConvertorSoapClient currencyConvertorApi = new CurrencyConvertorSoapClient();
        GlobalWeatherSoapClient weatherApi = new GlobalWeatherSoapClient();
        XmlDocument xmldoc = new XmlDocument();

        string[] currencies = new string[0];
        string[] currencyCodes = new string[0];
        string[] currencyCountries = new string[0];
        string exchangeRate;
        int originDateDay = 0;
        int originDateMonth = 0;
        int originDateYear = 0;
        int destDateDay = 0;
        int destDateMonth = 0;
        int destDateYear = 0;
        LatLonDate originSun = new LatLonDate();
        LatLonDate originSunReturn = new LatLonDate();
        LatLonDate destSun = new LatLonDate();
        LatLonDate destSunReturn = new LatLonDate();
        Currency destinationCurrencyCode = 0;
        Currency originCurrencyCode = 0;
        XmlNode gmt;
        XmlNode isoCode;
        XmlNode airportCode;
        XmlNode airportCity;
        XmlNode airportCountryCode;
        XmlNode airportRunwayLength;
        XmlNode airportRunwayElevation;
        XmlNode airportLatitude;
        XmlNode airportLongitude;
        XmlNode airportLatitudeMinutes;
        XmlNode airportLatitudeSeconds;
        XmlNode airportLongitudeMinutes;
        XmlNode airportLongitudeSeconds;
        XmlNode airportNS;
        XmlNode airportLongNS;
        XmlNode gmtDest;
        XmlNode isoCodeDest;
        XmlNode airportCodeDest;
        XmlNode airportCityDest;
        XmlNode airportCountryCodeDest;
        XmlNode airportRunwayLengthDest;
        XmlNode airportRunwayElevationDest;
        XmlNode airportLatitudeDest;
        XmlNode airportLongitudeDest;
        XmlNode airportLatitudeMinutesDest;
        XmlNode airportLatitudeSecondsDest;
        XmlNode airportLongitudeMinutesDest;
        XmlNode airportLongitudeSecondsDest;
        XmlNode airportNSDest;
        XmlNode airportLongNSDest;

        public Form1()
        {
            InitializeComponent();
            originDateTimePicker.Enabled = false;
            destDateTimePicker.Enabled = false;
            setupCurrencies();
            addCountries();
        }

        private void countryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            airportCodeBox.Clear();
            countryCodeBox.Clear();
            runwayLengthBox.Clear();
            runwayElevationBox.Clear();
            countryTimezoneBox.Clear();
            originLatBox.Clear();
            originLongBox.Clear();
            originSunSetBox.Clear();

            loadCurrenciesOrigin();
            loadISOCodeOrigin();

            originCityListBox.Items.Clear();

            loadCityOrigin();
            loadCurrencyConOrigin();
        }

        private void addCountries()
        {
            countryListBox.Items.AddRange(currencyApi.getCountries());
            destinationCountryListBox.Items.AddRange(currencyApi.getCountries());  
        }

        private float degreeConverter(int deg, int min, int sec)
        {
            return deg + (min / (float)60.0) + (sec / (float)3600.0);
        }

        private void setupCurrencies()
        {
            currencies = currencyApi.getCurrencies();
            currencyCodes = currencyApi.getCurrencyCodes();
            currencyCountries = currencyApi.getCountries();
        }

        private void sunSetAndSunRise()
        {
            originSun.Latitude = int.Parse(airportLatitude.InnerText);
            originSun.Longitude = int.Parse(airportLongitude.InnerText);

            originSunSetBox.Text = sunSetSunRiseApi.GetSunSetRiseTime(originSun).SunRiseTime.ToString();
        }

        private void loadCurrenciesDest()
        {
            destinationCurrencyBox.Text = currencies.ElementAt(destinationCountryListBox.SelectedIndex);
            destinationCurrencyCodeBox.Text = currencyCodes.ElementAt(destinationCountryListBox.SelectedIndex);
        }

        private void loadCurrenciesOrigin()
        {
            currencyBox.Text = currencies.ElementAt(countryListBox.SelectedIndex);
            currencyCodeBox.Text = currencyCodes.ElementAt(countryListBox.SelectedIndex);
        }

        private void loadISOCodeOrigin()
        {
            xmldoc.LoadXml(countryApi.GetISOCountryCodeByCountyName(currencyCountries.ElementAt(countryListBox.SelectedIndex)));

            if(xmldoc.FirstChild.InnerText.Length != 0)
            {
                XmlNodeList nodes = xmldoc.GetElementsByTagName("Table");

                foreach (XmlNode node in nodes)
                {
                    isoCode = node.SelectSingleNode("CountryCode");
                    if (isoCode.InnerText.Length == 0) continue;
                }

                isoCodeBox.Text = isoCode.FirstChild.InnerText.ToUpper();
            }
            else
            {
                isoCodeBox.Text = "N/A";
            }
        }

        private void loadISOCodeDest()
        {
            xmldoc.LoadXml(countryApi.GetISOCountryCodeByCountyName(currencyCountries.ElementAt(destinationCountryListBox.SelectedIndex)));

            if (xmldoc.FirstChild.InnerText.Length != 0)
            {
                XmlNodeList nodes = xmldoc.GetElementsByTagName("Table");

                foreach (XmlNode node in nodes)
                {
                    isoCodeDest = node.SelectSingleNode("CountryCode");
                    if (isoCodeDest.InnerText.Length == 0) continue;
                }

                destinationISOCodeBox.Text = isoCodeDest.FirstChild.InnerText.ToUpper();
            }
            else
            {
                destinationISOCodeBox.Text = "N/A";
            }
        }

        private void loadCityOrigin()
        {
            xmldoc.LoadXml(airportApi.GetAirportInformationByCountry(countryListBox.GetItemText(countryListBox.SelectedItem)));

            if(xmldoc.FirstChild.InnerText.Length != 0)
            {
                XmlNodeList nodes = xmldoc.GetElementsByTagName("Table");

                foreach (XmlNode node in nodes)
                {
                    airportCity = node.SelectSingleNode("CityOrAirportName");

                    if (originCityListBox.Items.Contains(airportCity.InnerText) == false)
                    {
                        originCityListBox.Items.Add(airportCity.InnerText);
                    }

                    if (airportCity.InnerText.Length == 0) continue;
                }
            }
            else
            {
                airportCodeBox.Text = "N/A";
                countryCodeBox.Text = "N/A";
                runwayLengthBox.Text = "N/A";
                runwayElevationBox.Text = "N/A";
                countryTimezoneBox.Text = "N/A";
                originLatBox.Text = "N/A";
                originLongBox.Text = "N/A";
                originSunSetBox.Text = "N/A";
            }
        }

        private void loadCityDest()
        {
            xmldoc.LoadXml(airportApi.GetAirportInformationByCountry(destinationCountryListBox.GetItemText(destinationCountryListBox.SelectedItem)));

            if (xmldoc.FirstChild.InnerText.Length != 0)
            {
                XmlNodeList nodes = xmldoc.GetElementsByTagName("Table");

                foreach (XmlNode node in nodes)
                {
                    airportCityDest = node.SelectSingleNode("CityOrAirportName");

                    if (cityDestListBox.Items.Contains(airportCityDest.InnerText) == false)
                    {
                        cityDestListBox.Items.Add(airportCityDest.InnerText);
                    }

                    if (airportCityDest.InnerText.Length == 0) continue;
                }
            }
            else
            {
                destinationAirportCodeBox.Text = "N/A";
                destinationCountryCodeBox.Text = "N/A";
                destinationRunwayLengthBox.Text = "N/A";
                destinationRunwayElevationBox.Text = "N/A";
                destinationTimezoneBox.Text = "N/A";
                destLatBox.Text = "N/A";
                destLongBox.Text = "N/A";
                destSunSetBox.Text = "N/A";
            }
        }

        private void loadCurrencyConDest()
        {
            try
            {
                destinationCurrencyCode = (Currency)Enum.Parse(typeof(Currency), currencyCodes.ElementAt(destinationCountryListBox.SelectedIndex));
                curConverter();
            }

            catch
            {
                converterBox.Text = "No Conversion";
            }
        }

        private void loadCurrencyConOrigin()
        {
            try
            {
                originCurrencyCode = (Currency)Enum.Parse(typeof(Currency), currencyCodes.ElementAt(countryListBox.SelectedIndex));
                curConverter();
            }

            catch
            {
                converterBox.Text = "No Conversion";
            }
        }

        private void curConverter()
        {
            if(originCurrencyCode != 0 || destinationCurrencyCode != 0)
            {
                exchangeRate = currencyConvertorApi.ConversionRate(originCurrencyCode, destinationCurrencyCode).ToString();

                if(exchangeRate != "-1")
                {
                    converterBox.Text = exchangeRate;
                }
                else
                {
                    converterBox.Text = " ";
                }
            }
            else
            {
                converterBox.Text = " ";
            }
        
        }

        private void destinationCountryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationAirportCodeBox.Clear();
            destinationCountryCodeBox.Clear();
            destinationRunwayLengthBox.Clear();
            destinationRunwayElevationBox.Clear();
            destinationTimezoneBox.Clear();
            destLatBox.Clear();
            destLongBox.Clear();
            destSunSetBox.Clear();

            loadCurrenciesDest();
            loadISOCodeDest();

            cityDestListBox.Items.Clear();

            loadCityDest();
            loadCurrencyConDest();
        }

        private void cityDestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            destDateTimePicker.Enabled = true;
            xmldoc.LoadXml(airportApi.GetAirportInformationByCountry(destinationCountryListBox.GetItemText(destinationCountryListBox.SelectedItem)));

            XmlNodeList nodes = xmldoc.GetElementsByTagName("Table");

            foreach (XmlNode node in nodes)
            {
                if(node.SelectSingleNode("CityOrAirportName").InnerText == cityDestListBox.SelectedItem.ToString())
                {
                    airportCodeDest = node.SelectSingleNode("AirportCode");
                    airportCountryCodeDest = node.SelectSingleNode("CountryCode");
                    airportRunwayLengthDest = node.SelectSingleNode("RunwayLengthFeet");
                    airportRunwayElevationDest = node.SelectSingleNode("RunwayElevationFeet");
                    gmtDest = node.SelectSingleNode("GMTOffset");
                    airportLatitudeDest = node.SelectSingleNode("LatitudeDegree");
                    airportLongitudeDest = node.SelectSingleNode("LongitudeDegree");
                    airportLatitudeMinutesDest = node.SelectSingleNode("LatitudeMinute");
                    airportLatitudeSecondsDest = node.SelectSingleNode("LatitudeSecond");
                    airportLongitudeMinutesDest = node.SelectSingleNode("LongitudeMinute");
                    airportLongitudeSecondsDest = node.SelectSingleNode("LongitudeSeconds");
                    airportNSDest = node.SelectSingleNode("LatitudeNpeerS");
                    airportLongNSDest = node.SelectSingleNode("LongitudeEperW");

                    if (airportCodeDest.InnerText.Length == 0) continue;
                }

            }

            destinationAirportCodeBox.Text = airportCodeDest.InnerText;
            destinationCountryCodeBox.Text = airportCountryCodeDest.InnerText;
            destinationRunwayLengthBox.Text = airportRunwayLengthDest.InnerText;
            destinationRunwayElevationBox.Text = airportRunwayElevationDest.InnerText;

            if (gmtDest != null)
            {
                destinationTimezoneBox.Text = gmtDest.InnerText;
            }
            else
            {
                destinationTimezoneBox.Text = "N/A";
            }

            destLatBox.Text = airportLatitudeDest.InnerText + "° " + airportLatitudeMinutesDest.InnerText + "." + airportLatitudeSecondsDest.InnerText + "\" " + airportNSDest.InnerText;
            destLongBox.Text = airportLongitudeDest.InnerText + "° " + airportLongitudeMinutesDest.InnerText + "." + airportLongitudeSecondsDest.InnerText + "\" " + airportLongNSDest.InnerText;

            if (gmtDest != null)
            {
                destSunDetails();
            }
            else
            {
                destSunSetBox.Text = "N/A";
            }
        }

        private void originCityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            originDateTimePicker.Enabled = true;
            xmldoc.LoadXml(airportApi.GetAirportInformationByCountry(countryListBox.GetItemText(countryListBox.SelectedItem)));

            XmlNodeList nodes = xmldoc.GetElementsByTagName("Table");

            foreach (XmlNode node in nodes)
            {
                if (node.SelectSingleNode("CityOrAirportName").InnerText == originCityListBox.SelectedItem.ToString())
                {
                    airportCode = node.SelectSingleNode("AirportCode");
                    airportCountryCode = node.SelectSingleNode("CountryCode");
                    airportRunwayLength = node.SelectSingleNode("RunwayLengthFeet");
                    airportRunwayElevation = node.SelectSingleNode("RunwayElevationFeet");
                    gmt = node.SelectSingleNode("GMTOffset");
                    airportLatitude = node.SelectSingleNode("LatitudeDegree");
                    airportLongitude = node.SelectSingleNode("LongitudeDegree");
                    airportLatitudeMinutes = node.SelectSingleNode("LatitudeMinute");
                    airportLatitudeSeconds = node.SelectSingleNode("LatitudeSecond");
                    airportLongitudeMinutes = node.SelectSingleNode("LongitudeMinute");
                    airportLongitudeSeconds = node.SelectSingleNode("LongitudeSeconds");
                    airportNS = node.SelectSingleNode("LatitudeNpeerS");
                    airportLongNS = node.SelectSingleNode("LongitudeEperW");

                    if (airportCode.InnerText.Length == 0) continue;
                }

            }

            airportCodeBox.Text = airportCode.InnerText;
            countryCodeBox.Text = airportCountryCode.InnerText;
            runwayLengthBox.Text = airportRunwayLength.InnerText;
            runwayElevationBox.Text = airportRunwayElevation.InnerText;

            if(gmt != null)
            {
                countryTimezoneBox.Text = gmt.InnerText;
            }
            else
            {
                countryTimezoneBox.Text = "N/A";
            }

            originLatBox.Text = airportLatitude.InnerText + "° " + airportLatitudeMinutes.InnerText + "." + airportLatitudeSeconds.InnerText + "\" " + airportNS.InnerText;
            originLongBox.Text = airportLongitude.InnerText + "° " + airportLongitudeMinutes.InnerText + "." + airportLongitudeSeconds.InnerText + "\" " + airportLongNS.InnerText;

            if(gmt != null)
            {
                originSunDetails();
            }
            else
            {
                originSunSetBox.Text = "N/A";
            }
        }

        private void originSunDetails()
        {
            originSun.Latitude = degreeConverter(int.Parse(airportLatitude.InnerText), int.Parse(airportLatitudeMinutes.InnerText), int.Parse(airportLatitudeSeconds.InnerText));
            originSun.Longitude = degreeConverter(int.Parse(airportLongitude.InnerText), int.Parse(airportLongitudeMinutes.InnerText), int.Parse(airportLongitudeSeconds.InnerText));
            originSun.TimeZone = (int) float.Parse(gmt.InnerText);
            originSun.Day = originDateDay;
            originSun.Month = originDateMonth;
            originSun.Year = originDateYear;

            originSunReturn = sunSetSunRiseApi.GetSunSetRiseTime(originSun);

            originSunSetBox.Text = convertTime(originSunReturn.SunRiseTime) + " - " + convertTime(originSunReturn.SunSetTime);
        }

        private void destSunDetails()
        {
            destSun.Latitude = degreeConverter(int.Parse(airportLatitudeDest.InnerText), int.Parse(airportLatitudeMinutesDest.InnerText), int.Parse(airportLatitudeSecondsDest.InnerText));
            destSun.Longitude = degreeConverter(int.Parse(airportLongitudeDest.InnerText), int.Parse(airportLongitudeMinutesDest.InnerText), int.Parse(airportLongitudeSecondsDest.InnerText));
            destSun.TimeZone = (int) float.Parse(gmtDest.InnerText);
            destSun.Day = destDateDay;
            destSun.Month = destDateMonth;
            destSun.Year = destDateYear;

            destSunReturn = sunSetSunRiseApi.GetSunSetRiseTime(destSun);

            destSunSetBox.Text = convertTime(destSunReturn.SunRiseTime) + " - " + convertTime(destSunReturn.SunSetTime);
        }

        private void originDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            originDateDay = originDateTimePicker.Value.Day;
            originDateMonth = originDateTimePicker.Value.Month;
            originDateYear = originDateTimePicker.Value.Year;
        }

        private void destDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            destDateDay = destDateTimePicker.Value.Day;
            destDateMonth = destDateTimePicker.Value.Month;
            destDateYear = destDateTimePicker.Value.Year;
        }

        private string convertTime(float time)
        {
            return TimeSpan.FromHours(time).ToString(@"hh\:mm\:ss");
        }
    }
}
