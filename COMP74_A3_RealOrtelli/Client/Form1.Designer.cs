namespace Client
{
    partial class Form1
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
            this.countryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currencyBox = new System.Windows.Forms.TextBox();
            this.currencyCodeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.countryTimezoneBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.isoCodeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.runwayElevationBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.runwayLengthBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.countryCodeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.airportCodeBox = new System.Windows.Forms.TextBox();
            this.converter = new System.Windows.Forms.Label();
            this.converterBox = new System.Windows.Forms.TextBox();
            this.destinationCountryListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.destinationCountryCodeBox = new System.Windows.Forms.TextBox();
            this.destinationTimezoneBox = new System.Windows.Forms.TextBox();
            this.destinationISOCodeBox = new System.Windows.Forms.TextBox();
            this.destinationRunwayLengthBox = new System.Windows.Forms.TextBox();
            this.destinationRunwayElevationBox = new System.Windows.Forms.TextBox();
            this.destinationCurrencyBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.destinationCurrencyCodeBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cityDestListBox = new System.Windows.Forms.ListBox();
            this.destinationAirportCodeBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.destDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destSunSetBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.destLongBox = new System.Windows.Forms.TextBox();
            this.destLatBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.originDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.originSunSetBox = new System.Windows.Forms.TextBox();
            this.originLongBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.originLatBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.originCityListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryListBox
            // 
            this.countryListBox.AccessibleName = "";
            this.countryListBox.FormattingEnabled = true;
            this.countryListBox.Location = new System.Drawing.Point(9, 49);
            this.countryListBox.Name = "countryListBox";
            this.countryListBox.Size = new System.Drawing.Size(120, 95);
            this.countryListBox.TabIndex = 0;
            this.countryListBox.SelectedIndexChanged += new System.EventHandler(this.countryListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origin Country";
            // 
            // currencyBox
            // 
            this.currencyBox.Location = new System.Drawing.Point(9, 241);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.ReadOnly = true;
            this.currencyBox.Size = new System.Drawing.Size(100, 20);
            this.currencyBox.TabIndex = 2;
            // 
            // currencyCodeBox
            // 
            this.currencyCodeBox.Location = new System.Drawing.Point(9, 280);
            this.currencyCodeBox.Name = "currencyCodeBox";
            this.currencyCodeBox.ReadOnly = true;
            this.currencyCodeBox.Size = new System.Drawing.Size(74, 20);
            this.currencyCodeBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currency Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "City/AirportName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Airport Code";
            // 
            // countryTimezoneBox
            // 
            this.countryTimezoneBox.Location = new System.Drawing.Point(150, 202);
            this.countryTimezoneBox.Name = "countryTimezoneBox";
            this.countryTimezoneBox.ReadOnly = true;
            this.countryTimezoneBox.Size = new System.Drawing.Size(62, 20);
            this.countryTimezoneBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "TimeZone";
            // 
            // isoCodeBox
            // 
            this.isoCodeBox.Location = new System.Drawing.Point(9, 202);
            this.isoCodeBox.Name = "isoCodeBox";
            this.isoCodeBox.ReadOnly = true;
            this.isoCodeBox.Size = new System.Drawing.Size(60, 20);
            this.isoCodeBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ISO Code";
            // 
            // runwayElevationBox
            // 
            this.runwayElevationBox.Location = new System.Drawing.Point(150, 282);
            this.runwayElevationBox.Name = "runwayElevationBox";
            this.runwayElevationBox.ReadOnly = true;
            this.runwayElevationBox.Size = new System.Drawing.Size(100, 20);
            this.runwayElevationBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Runway Elevation";
            // 
            // runwayLengthBox
            // 
            this.runwayLengthBox.Location = new System.Drawing.Point(150, 241);
            this.runwayLengthBox.Name = "runwayLengthBox";
            this.runwayLengthBox.ReadOnly = true;
            this.runwayLengthBox.Size = new System.Drawing.Size(100, 20);
            this.runwayLengthBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Runway Length";
            // 
            // countryCodeBox
            // 
            this.countryCodeBox.Location = new System.Drawing.Point(9, 163);
            this.countryCodeBox.Name = "countryCodeBox";
            this.countryCodeBox.ReadOnly = true;
            this.countryCodeBox.Size = new System.Drawing.Size(60, 20);
            this.countryCodeBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Country Code";
            // 
            // airportCodeBox
            // 
            this.airportCodeBox.Location = new System.Drawing.Point(150, 163);
            this.airportCodeBox.Name = "airportCodeBox";
            this.airportCodeBox.ReadOnly = true;
            this.airportCodeBox.Size = new System.Drawing.Size(62, 20);
            this.airportCodeBox.TabIndex = 0;
            // 
            // converter
            // 
            this.converter.AutoSize = true;
            this.converter.Location = new System.Drawing.Point(13, 35);
            this.converter.Name = "converter";
            this.converter.Size = new System.Drawing.Size(60, 13);
            this.converter.TabIndex = 17;
            this.converter.Text = "Conversion";
            // 
            // converterBox
            // 
            this.converterBox.Location = new System.Drawing.Point(79, 32);
            this.converterBox.Name = "converterBox";
            this.converterBox.ReadOnly = true;
            this.converterBox.Size = new System.Drawing.Size(76, 20);
            this.converterBox.TabIndex = 18;
            // 
            // destinationCountryListBox
            // 
            this.destinationCountryListBox.FormattingEnabled = true;
            this.destinationCountryListBox.Location = new System.Drawing.Point(9, 51);
            this.destinationCountryListBox.Name = "destinationCountryListBox";
            this.destinationCountryListBox.Size = new System.Drawing.Size(120, 95);
            this.destinationCountryListBox.TabIndex = 17;
            this.destinationCountryListBox.SelectedIndexChanged += new System.EventHandler(this.destinationCountryListBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Destination Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Airport Code";
            // 
            // destinationCountryCodeBox
            // 
            this.destinationCountryCodeBox.Location = new System.Drawing.Point(9, 165);
            this.destinationCountryCodeBox.Name = "destinationCountryCodeBox";
            this.destinationCountryCodeBox.ReadOnly = true;
            this.destinationCountryCodeBox.Size = new System.Drawing.Size(56, 20);
            this.destinationCountryCodeBox.TabIndex = 3;
            // 
            // destinationTimezoneBox
            // 
            this.destinationTimezoneBox.Location = new System.Drawing.Point(151, 203);
            this.destinationTimezoneBox.Name = "destinationTimezoneBox";
            this.destinationTimezoneBox.ReadOnly = true;
            this.destinationTimezoneBox.Size = new System.Drawing.Size(62, 20);
            this.destinationTimezoneBox.TabIndex = 4;
            // 
            // destinationISOCodeBox
            // 
            this.destinationISOCodeBox.Location = new System.Drawing.Point(9, 204);
            this.destinationISOCodeBox.Name = "destinationISOCodeBox";
            this.destinationISOCodeBox.ReadOnly = true;
            this.destinationISOCodeBox.Size = new System.Drawing.Size(56, 20);
            this.destinationISOCodeBox.TabIndex = 5;
            // 
            // destinationRunwayLengthBox
            // 
            this.destinationRunwayLengthBox.Location = new System.Drawing.Point(151, 243);
            this.destinationRunwayLengthBox.Name = "destinationRunwayLengthBox";
            this.destinationRunwayLengthBox.ReadOnly = true;
            this.destinationRunwayLengthBox.Size = new System.Drawing.Size(100, 20);
            this.destinationRunwayLengthBox.TabIndex = 6;
            // 
            // destinationRunwayElevationBox
            // 
            this.destinationRunwayElevationBox.Location = new System.Drawing.Point(151, 282);
            this.destinationRunwayElevationBox.Name = "destinationRunwayElevationBox";
            this.destinationRunwayElevationBox.ReadOnly = true;
            this.destinationRunwayElevationBox.Size = new System.Drawing.Size(100, 20);
            this.destinationRunwayElevationBox.TabIndex = 7;
            // 
            // destinationCurrencyBox
            // 
            this.destinationCurrencyBox.Location = new System.Drawing.Point(9, 243);
            this.destinationCurrencyBox.Name = "destinationCurrencyBox";
            this.destinationCurrencyBox.ReadOnly = true;
            this.destinationCurrencyBox.Size = new System.Drawing.Size(100, 20);
            this.destinationCurrencyBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(148, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "City/Airport Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Country Code";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(148, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "TimeZone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "ISO Code";
            // 
            // destinationCurrencyCodeBox
            // 
            this.destinationCurrencyCodeBox.Location = new System.Drawing.Point(9, 282);
            this.destinationCurrencyCodeBox.Name = "destinationCurrencyCodeBox";
            this.destinationCurrencyCodeBox.ReadOnly = true;
            this.destinationCurrencyCodeBox.Size = new System.Drawing.Size(74, 20);
            this.destinationCurrencyCodeBox.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(148, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Runway Length";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(148, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Runway Elevation";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 227);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Currency";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 266);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Currency Code";
            // 
            // cityDestListBox
            // 
            this.cityDestListBox.FormattingEnabled = true;
            this.cityDestListBox.Location = new System.Drawing.Point(151, 51);
            this.cityDestListBox.Name = "cityDestListBox";
            this.cityDestListBox.Size = new System.Drawing.Size(120, 95);
            this.cityDestListBox.TabIndex = 18;
            this.cityDestListBox.SelectedIndexChanged += new System.EventHandler(this.cityDestListBox_SelectedIndexChanged);
            // 
            // destinationAirportCodeBox
            // 
            this.destinationAirportCodeBox.Location = new System.Drawing.Point(151, 165);
            this.destinationAirportCodeBox.Name = "destinationAirportCodeBox";
            this.destinationAirportCodeBox.ReadOnly = true;
            this.destinationAirportCodeBox.Size = new System.Drawing.Size(62, 20);
            this.destinationAirportCodeBox.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.destDateTimePicker);
            this.groupBox1.Controls.Add(this.destSunSetBox);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.destLongBox);
            this.groupBox1.Controls.Add(this.destLatBox);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cityDestListBox);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.destinationISOCodeBox);
            this.groupBox1.Controls.Add(this.destinationRunwayElevationBox);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.destinationCurrencyCodeBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.destinationRunwayLengthBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.destinationCountryListBox);
            this.groupBox1.Controls.Add(this.destinationTimezoneBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.destinationAirportCodeBox);
            this.groupBox1.Controls.Add(this.destinationCurrencyBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.destinationCountryCodeBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 481);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(148, 427);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 13);
            this.label28.TabIndex = 28;
            this.label28.Text = "Destination Date";
            // 
            // destDateTimePicker
            // 
            this.destDateTimePicker.Location = new System.Drawing.Point(71, 443);
            this.destDateTimePicker.Name = "destDateTimePicker";
            this.destDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.destDateTimePicker.TabIndex = 27;
            this.destDateTimePicker.ValueChanged += new System.EventHandler(this.destDateTimePicker_ValueChanged);
            // 
            // destSunSetBox
            // 
            this.destSunSetBox.Location = new System.Drawing.Point(151, 404);
            this.destSunSetBox.Name = "destSunSetBox";
            this.destSunSetBox.ReadOnly = true;
            this.destSunSetBox.Size = new System.Drawing.Size(120, 20);
            this.destSunSetBox.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(148, 388);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Sunset - Sunrise";
            // 
            // destLongBox
            // 
            this.destLongBox.Location = new System.Drawing.Point(151, 365);
            this.destLongBox.Name = "destLongBox";
            this.destLongBox.ReadOnly = true;
            this.destLongBox.Size = new System.Drawing.Size(100, 20);
            this.destLongBox.TabIndex = 24;
            // 
            // destLatBox
            // 
            this.destLatBox.Location = new System.Drawing.Point(151, 326);
            this.destLatBox.Name = "destLatBox";
            this.destLatBox.ReadOnly = true;
            this.destLatBox.Size = new System.Drawing.Size(100, 20);
            this.destLatBox.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(148, 310);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Latitude ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(148, 349);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Longitude";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.originDateTimePicker);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.originSunSetBox);
            this.groupBox2.Controls.Add(this.originLongBox);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.originLatBox);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.originCityListBox);
            this.groupBox2.Controls.Add(this.countryListBox);
            this.groupBox2.Controls.Add(this.runwayElevationBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.currencyCodeBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.countryCodeBox);
            this.groupBox2.Controls.Add(this.currencyBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.runwayLengthBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.isoCodeBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.airportCodeBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.countryTimezoneBox);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 481);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origin";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(151, 427);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 26;
            this.label27.Text = "Origin Date";
            // 
            // originDateTimePicker
            // 
            this.originDateTimePicker.Location = new System.Drawing.Point(70, 443);
            this.originDateTimePicker.Name = "originDateTimePicker";
            this.originDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.originDateTimePicker.TabIndex = 24;
            this.originDateTimePicker.ValueChanged += new System.EventHandler(this.originDateTimePicker_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(147, 388);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 13);
            this.label25.TabIndex = 25;
            this.label25.Text = "Sunset - Sunrise";
            // 
            // originSunSetBox
            // 
            this.originSunSetBox.Location = new System.Drawing.Point(150, 404);
            this.originSunSetBox.Name = "originSunSetBox";
            this.originSunSetBox.ReadOnly = true;
            this.originSunSetBox.Size = new System.Drawing.Size(120, 20);
            this.originSunSetBox.TabIndex = 24;
            // 
            // originLongBox
            // 
            this.originLongBox.Location = new System.Drawing.Point(150, 365);
            this.originLongBox.Name = "originLongBox";
            this.originLongBox.ReadOnly = true;
            this.originLongBox.Size = new System.Drawing.Size(100, 20);
            this.originLongBox.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(147, 349);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Longitude";
            // 
            // originLatBox
            // 
            this.originLatBox.Location = new System.Drawing.Point(150, 325);
            this.originLatBox.Name = "originLatBox";
            this.originLatBox.ReadOnly = true;
            this.originLatBox.Size = new System.Drawing.Size(100, 20);
            this.originLatBox.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(147, 309);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Latitude";
            // 
            // originCityListBox
            // 
            this.originCityListBox.FormattingEnabled = true;
            this.originCityListBox.Location = new System.Drawing.Point(150, 49);
            this.originCityListBox.Name = "originCityListBox";
            this.originCityListBox.Size = new System.Drawing.Size(120, 95);
            this.originCityListBox.TabIndex = 19;
            this.originCityListBox.SelectedIndexChanged += new System.EventHandler(this.originCityListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.converter);
            this.groupBox3.Controls.Add(this.converterBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 72);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exchange Rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "APIClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox countryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currencyBox;
        private System.Windows.Forms.TextBox currencyCodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox countryTimezoneBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox isoCodeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox runwayElevationBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox runwayLengthBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox countryCodeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox airportCodeBox;
        private System.Windows.Forms.Label converter;
        private System.Windows.Forms.TextBox converterBox;
        private System.Windows.Forms.ListBox destinationCountryListBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox destinationCountryCodeBox;
        private System.Windows.Forms.TextBox destinationTimezoneBox;
        private System.Windows.Forms.TextBox destinationISOCodeBox;
        private System.Windows.Forms.TextBox destinationRunwayLengthBox;
        private System.Windows.Forms.TextBox destinationRunwayElevationBox;
        private System.Windows.Forms.TextBox destinationCurrencyBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox destinationCurrencyCodeBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox cityDestListBox;
        private System.Windows.Forms.TextBox destinationAirportCodeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox originCityListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox destLongBox;
        private System.Windows.Forms.TextBox destLatBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox originLongBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox originLatBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox originSunSetBox;
        private System.Windows.Forms.TextBox destSunSetBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker originDateTimePicker;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker destDateTimePicker;
        private System.Windows.Forms.Label label27;
    }
}

