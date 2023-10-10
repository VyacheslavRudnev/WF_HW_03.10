namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gb_Clients = new GroupBox();
            tb_FirstName = new TextBox();
            label30 = new Label();
            tb_MiddleName = new TextBox();
            label29 = new Label();
            gb_Policies = new GroupBox();
            cb_isTravel = new CheckBox();
            cb_isProperty = new CheckBox();
            cb_isAuto = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            mtb_PhoneNumber = new MaskedTextBox();
            tb_Age = new TextBox();
            tb_City = new TextBox();
            tb_LastName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gb_ResultBox = new GroupBox();
            button1 = new Button();
            tb_resultPrice = new TextBox();
            label15 = new Label();
            label14 = new Label();
            lb_Clients = new ListBox();
            tc_Tab = new TabControl();
            tp_Auto = new TabPage();
            bt_Dcv1 = new Button();
            bt_Oscpv1 = new Button();
            bt_Casko1 = new Button();
            cb_Dcv = new CheckBox();
            cb_Oscpv = new CheckBox();
            cb_Casco = new CheckBox();
            label16 = new Label();
            tb_PriceDcv = new TextBox();
            lb_PriceDcv = new Label();
            label18 = new Label();
            tb_PriceOscpv = new TextBox();
            lb_PriceOscpv = new Label();
            label20 = new Label();
            tb_PriceCasco = new TextBox();
            lb_PriceCasco = new Label();
            lb_MV_UAH = new Label();
            lb_MarketValue = new Label();
            lb_CarYear = new Label();
            lb_EngineVal = new Label();
            lb_CarModel = new Label();
            lb_CarBrand = new Label();
            tb_CarModel = new TextBox();
            tb_EngineVal = new TextBox();
            tb_CarYear = new TextBox();
            tb_CarBrand = new TextBox();
            tp_Properties = new TabPage();
            label28 = new Label();
            cb_PropChoice = new CheckBox();
            label10 = new Label();
            tb_PriceProp = new TextBox();
            label11 = new Label();
            bt_PropBonus = new Button();
            bt_PropStandart = new Button();
            bt_PropEco = new Button();
            label8 = new Label();
            tb_MarketValueProp = new TextBox();
            label9 = new Label();
            lb_Square = new Label();
            tb_Square = new TextBox();
            lb_tipe = new Label();
            tb_Tipe = new TextBox();
            tp_Travel = new TabPage();
            tb_InsCover = new TextBox();
            cb_TravelChoice = new CheckBox();
            label24 = new Label();
            tb_TravelPrice = new TextBox();
            label25 = new Label();
            label23 = new Label();
            bt_TravelAll = new Button();
            bt_TravelStandart = new Button();
            bt_TravelEco = new Button();
            label22 = new Label();
            tb_Travelers = new TextBox();
            label21 = new Label();
            label19 = new Label();
            label17 = new Label();
            tb_Period = new TextBox();
            label13 = new Label();
            label12 = new Label();
            tb_Country = new TextBox();
            tb_MarketValue = new TextBox();
            gb_TotalSum = new GroupBox();
            label26 = new Label();
            tb_TotalSum = new TextBox();
            label27 = new Label();
            bt_AddToBasket = new Button();
            toolTip1 = new ToolTip(components);
            gb_Clients.SuspendLayout();
            gb_Policies.SuspendLayout();
            gb_ResultBox.SuspendLayout();
            tc_Tab.SuspendLayout();
            tp_Auto.SuspendLayout();
            tp_Properties.SuspendLayout();
            tp_Travel.SuspendLayout();
            gb_TotalSum.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Clients
            // 
            gb_Clients.Controls.Add(tb_FirstName);
            gb_Clients.Controls.Add(label30);
            gb_Clients.Controls.Add(tb_MiddleName);
            gb_Clients.Controls.Add(label29);
            gb_Clients.Controls.Add(gb_Policies);
            gb_Clients.Controls.Add(mtb_PhoneNumber);
            gb_Clients.Controls.Add(tb_Age);
            gb_Clients.Controls.Add(tb_City);
            gb_Clients.Controls.Add(tb_LastName);
            gb_Clients.Controls.Add(label4);
            gb_Clients.Controls.Add(label3);
            gb_Clients.Controls.Add(label2);
            gb_Clients.Controls.Add(label1);
            gb_Clients.Location = new Point(6, -1);
            gb_Clients.Name = "gb_Clients";
            gb_Clients.Size = new Size(450, 218);
            gb_Clients.TabIndex = 0;
            gb_Clients.TabStop = false;
            gb_Clients.Text = "Клієнт";
            // 
            // tb_FirstName
            // 
            tb_FirstName.Location = new Point(104, 54);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(192, 27);
            tb_FirstName.TabIndex = 2;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(7, 57);
            label30.Name = "label30";
            label30.Size = new Size(35, 20);
            label30.TabIndex = 10;
            label30.Text = "Ім'я";
            // 
            // tb_MiddleName
            // 
            tb_MiddleName.Location = new Point(104, 89);
            tb_MiddleName.Name = "tb_MiddleName";
            tb_MiddleName.Size = new Size(340, 27);
            tb_MiddleName.TabIndex = 3;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(6, 92);
            label29.Name = "label29";
            label29.Size = new Size(92, 20);
            label29.TabIndex = 8;
            label29.Text = "По батькові";
            // 
            // gb_Policies
            // 
            gb_Policies.Anchor = AnchorStyles.Left;
            gb_Policies.Controls.Add(cb_isTravel);
            gb_Policies.Controls.Add(cb_isProperty);
            gb_Policies.Controls.Add(cb_isAuto);
            gb_Policies.Controls.Add(label7);
            gb_Policies.Controls.Add(label6);
            gb_Policies.Controls.Add(label5);
            gb_Policies.Location = new Point(0, 155);
            gb_Policies.Name = "gb_Policies";
            gb_Policies.Size = new Size(450, 54);
            gb_Policies.TabIndex = 1;
            gb_Policies.TabStop = false;
            gb_Policies.Text = "Страховки";
            // 
            // cb_isTravel
            // 
            cb_isTravel.AutoSize = true;
            cb_isTravel.Location = new Point(381, 26);
            cb_isTravel.Name = "cb_isTravel";
            cb_isTravel.Size = new Size(18, 17);
            cb_isTravel.TabIndex = 9;
            cb_isTravel.UseVisualStyleBackColor = true;
            cb_isTravel.CheckedChanged += CheckedChangedTravel;
            // 
            // cb_isProperty
            // 
            cb_isProperty.AutoSize = true;
            cb_isProperty.Location = new Point(232, 26);
            cb_isProperty.Name = "cb_isProperty";
            cb_isProperty.Size = new Size(18, 17);
            cb_isProperty.TabIndex = 8;
            cb_isProperty.UseVisualStyleBackColor = true;
            cb_isProperty.CheckedChanged += CheckedChengedProperty;
            // 
            // cb_isAuto
            // 
            cb_isAuto.AutoSize = true;
            cb_isAuto.Location = new Point(74, 26);
            cb_isAuto.Name = "cb_isAuto";
            cb_isAuto.Size = new Size(18, 17);
            cb_isAuto.TabIndex = 7;
            cb_isAuto.UseVisualStyleBackColor = true;
            cb_isAuto.CheckedChanged += CheckedChangedAuto;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 23);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 2;
            label7.Text = "ТУРИЗМ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 23);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 1;
            label6.Text = "МАЙНО";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 23);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 0;
            label5.Text = "АВТО";
            // 
            // mtb_PhoneNumber
            // 
            mtb_PhoneNumber.Location = new Point(83, 122);
            mtb_PhoneNumber.Mask = "+38 (000) 000-00-00";
            mtb_PhoneNumber.Name = "mtb_PhoneNumber";
            mtb_PhoneNumber.Size = new Size(147, 27);
            mtb_PhoneNumber.TabIndex = 5;
            // 
            // tb_Age
            // 
            tb_Age.Location = new Point(368, 34);
            tb_Age.Name = "tb_Age";
            tb_Age.Size = new Size(54, 27);
            tb_Age.TabIndex = 4;
            // 
            // tb_City
            // 
            tb_City.Location = new Point(291, 122);
            tb_City.Name = "tb_City";
            tb_City.Size = new Size(153, 27);
            tb_City.TabIndex = 6;
            // 
            // tb_LastName
            // 
            tb_LastName.Location = new Point(104, 20);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(192, 27);
            tb_LastName.TabIndex = 1;
            tb_LastName.TextChanged += GetClient;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 125);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Місто";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 38);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 1;
            label2.Text = "Вік";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Прізвище";
            // 
            // gb_ResultBox
            // 
            gb_ResultBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gb_ResultBox.Controls.Add(button1);
            gb_ResultBox.Controls.Add(tb_resultPrice);
            gb_ResultBox.Controls.Add(label15);
            gb_ResultBox.Controls.Add(label14);
            gb_ResultBox.Location = new Point(6, 682);
            gb_ResultBox.Name = "gb_ResultBox";
            gb_ResultBox.Size = new Size(450, 109);
            gb_ResultBox.TabIndex = 46;
            gb_ResultBox.TabStop = false;
            gb_ResultBox.Text = "До сплати";
            gb_ResultBox.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(25, 56);
            button1.Name = "button1";
            button1.Size = new Size(397, 46);
            button1.TabIndex = 48;
            button1.Text = "Друкувати чек";
            button1.UseVisualStyleBackColor = true;
            // 
            // tb_resultPrice
            // 
            tb_resultPrice.Location = new Point(121, 20);
            tb_resultPrice.Name = "tb_resultPrice";
            tb_resultPrice.Size = new Size(173, 27);
            tb_resultPrice.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(300, 23);
            label15.Name = "label15";
            label15.Size = new Size(33, 20);
            label15.TabIndex = 19;
            label15.Text = "грн";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 23);
            label14.Name = "label14";
            label14.Size = new Size(109, 20);
            label14.TabIndex = 19;
            label14.Text = "Загальна сума";
            // 
            // lb_Clients
            // 
            lb_Clients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lb_Clients.FormattingEnabled = true;
            lb_Clients.ItemHeight = 20;
            lb_Clients.Location = new Point(479, 7);
            lb_Clients.Name = "lb_Clients";
            lb_Clients.Size = new Size(500, 784);
            lb_Clients.TabIndex = 49;
            // 
            // tc_Tab
            // 
            tc_Tab.Controls.Add(tp_Auto);
            tc_Tab.Controls.Add(tp_Properties);
            tc_Tab.Controls.Add(tp_Travel);
            tc_Tab.Enabled = false;
            tc_Tab.Location = new Point(6, 223);
            tc_Tab.Name = "tc_Tab";
            tc_Tab.SelectedIndex = 0;
            tc_Tab.Size = new Size(458, 322);
            tc_Tab.TabIndex = 11;
            tc_Tab.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // tp_Auto
            // 
            tp_Auto.Controls.Add(bt_Dcv1);
            tp_Auto.Controls.Add(bt_Oscpv1);
            tp_Auto.Controls.Add(bt_Casko1);
            tp_Auto.Controls.Add(cb_Dcv);
            tp_Auto.Controls.Add(tb_MarketValue);
            tp_Auto.Controls.Add(cb_Oscpv);
            tp_Auto.Controls.Add(cb_Casco);
            tp_Auto.Controls.Add(label16);
            tp_Auto.Controls.Add(tb_PriceDcv);
            tp_Auto.Controls.Add(lb_PriceDcv);
            tp_Auto.Controls.Add(label18);
            tp_Auto.Controls.Add(tb_PriceOscpv);
            tp_Auto.Controls.Add(lb_PriceOscpv);
            tp_Auto.Controls.Add(label20);
            tp_Auto.Controls.Add(tb_PriceCasco);
            tp_Auto.Controls.Add(lb_PriceCasco);
            tp_Auto.Controls.Add(lb_MV_UAH);
            tp_Auto.Controls.Add(lb_MarketValue);
            tp_Auto.Controls.Add(lb_CarYear);
            tp_Auto.Controls.Add(lb_EngineVal);
            tp_Auto.Controls.Add(lb_CarModel);
            tp_Auto.Controls.Add(lb_CarBrand);
            tp_Auto.Controls.Add(tb_CarModel);
            tp_Auto.Controls.Add(tb_EngineVal);
            tp_Auto.Controls.Add(tb_CarYear);
            tp_Auto.Controls.Add(tb_CarBrand);
            tp_Auto.Location = new Point(4, 29);
            tp_Auto.Name = "tp_Auto";
            tp_Auto.Padding = new Padding(3);
            tp_Auto.Size = new Size(450, 289);
            tp_Auto.TabIndex = 0;
            tp_Auto.Text = "АВТО";
            tp_Auto.UseVisualStyleBackColor = true;
            // 
            // bt_Dcv1
            // 
            bt_Dcv1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bt_Dcv1.Enabled = false;
            bt_Dcv1.Location = new Point(310, 142);
            bt_Dcv1.Name = "bt_Dcv1";
            bt_Dcv1.Size = new Size(125, 30);
            bt_Dcv1.TabIndex = 19;
            bt_Dcv1.Text = "ДЦВ";
            bt_Dcv1.UseVisualStyleBackColor = true;
            bt_Dcv1.Click += DcvClick;
            // 
            // bt_Oscpv1
            // 
            bt_Oscpv1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_Oscpv1.Enabled = false;
            bt_Oscpv1.Location = new Point(163, 142);
            bt_Oscpv1.Name = "bt_Oscpv1";
            bt_Oscpv1.Size = new Size(125, 30);
            bt_Oscpv1.TabIndex = 18;
            bt_Oscpv1.Text = "ОСЦПВ";
            bt_Oscpv1.UseVisualStyleBackColor = true;
            bt_Oscpv1.Click += OscpvClick;
            // 
            // bt_Casko1
            // 
            bt_Casko1.Anchor = AnchorStyles.None;
            bt_Casko1.Enabled = false;
            bt_Casko1.Location = new Point(16, 142);
            bt_Casko1.Name = "bt_Casko1";
            bt_Casko1.Size = new Size(125, 30);
            bt_Casko1.TabIndex = 17;
            bt_Casko1.Text = "КАСКО";
            bt_Casko1.UseVisualStyleBackColor = true;
            bt_Casko1.Click += CascoClick;
            // 
            // cb_Dcv
            // 
            cb_Dcv.AutoSize = true;
            cb_Dcv.Location = new Point(366, 254);
            cb_Dcv.Name = "cb_Dcv";
            cb_Dcv.Size = new Size(18, 17);
            cb_Dcv.TabIndex = 25;
            cb_Dcv.UseVisualStyleBackColor = true;
            cb_Dcv.CheckedChanged += Dcv_CheckedChanged;
            // 
            // cb_Oscpv
            // 
            cb_Oscpv.AutoSize = true;
            cb_Oscpv.Location = new Point(366, 221);
            cb_Oscpv.Name = "cb_Oscpv";
            cb_Oscpv.Size = new Size(18, 17);
            cb_Oscpv.TabIndex = 23;
            cb_Oscpv.UseVisualStyleBackColor = true;
            cb_Oscpv.CheckedChanged += Oscpv_CheckedChanged;
            // 
            // cb_Casco
            // 
            cb_Casco.AutoSize = true;
            cb_Casco.Location = new Point(366, 190);
            cb_Casco.Name = "cb_Casco";
            cb_Casco.Size = new Size(18, 17);
            cb_Casco.TabIndex = 21;
            cb_Casco.UseVisualStyleBackColor = true;
            cb_Casco.CheckedChanged += Casco_CheckedChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(294, 255);
            label16.Name = "label16";
            label16.Size = new Size(33, 20);
            label16.TabIndex = 94;
            label16.Text = "грн";
            // 
            // tb_PriceDcv
            // 
            tb_PriceDcv.Location = new Point(139, 252);
            tb_PriceDcv.Name = "tb_PriceDcv";
            tb_PriceDcv.Size = new Size(149, 27);
            tb_PriceDcv.TabIndex = 24;
            // 
            // lb_PriceDcv
            // 
            lb_PriceDcv.AutoSize = true;
            lb_PriceDcv.Location = new Point(8, 255);
            lb_PriceDcv.Name = "lb_PriceDcv";
            lb_PriceDcv.Size = new Size(100, 20);
            lb_PriceDcv.TabIndex = 92;
            lb_PriceDcv.Text = "Вартість ДЦВ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(294, 221);
            label18.Name = "label18";
            label18.Size = new Size(33, 20);
            label18.TabIndex = 91;
            label18.Text = "грн";
            // 
            // tb_PriceOscpv
            // 
            tb_PriceOscpv.Location = new Point(139, 218);
            tb_PriceOscpv.Name = "tb_PriceOscpv";
            tb_PriceOscpv.Size = new Size(149, 27);
            tb_PriceOscpv.TabIndex = 22;
            // 
            // lb_PriceOscpv
            // 
            lb_PriceOscpv.AutoSize = true;
            lb_PriceOscpv.Location = new Point(8, 221);
            lb_PriceOscpv.Name = "lb_PriceOscpv";
            lb_PriceOscpv.Size = new Size(121, 20);
            lb_PriceOscpv.TabIndex = 89;
            lb_PriceOscpv.Text = "Вартість ОСЦПВ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(294, 187);
            label20.Name = "label20";
            label20.Size = new Size(33, 20);
            label20.TabIndex = 88;
            label20.Text = "грн";
            // 
            // tb_PriceCasco
            // 
            tb_PriceCasco.Location = new Point(138, 184);
            tb_PriceCasco.Name = "tb_PriceCasco";
            tb_PriceCasco.Size = new Size(150, 27);
            tb_PriceCasco.TabIndex = 20;
            // 
            // lb_PriceCasco
            // 
            lb_PriceCasco.AutoSize = true;
            lb_PriceCasco.Location = new Point(7, 187);
            lb_PriceCasco.Name = "lb_PriceCasco";
            lb_PriceCasco.Size = new Size(118, 20);
            lb_PriceCasco.TabIndex = 86;
            lb_PriceCasco.Text = "Вартість КАСКО";
            // 
            // lb_MV_UAH
            // 
            lb_MV_UAH.AutoSize = true;
            lb_MV_UAH.Location = new Point(402, 108);
            lb_MV_UAH.Name = "lb_MV_UAH";
            lb_MV_UAH.Size = new Size(33, 20);
            lb_MV_UAH.TabIndex = 82;
            lb_MV_UAH.Text = "грн";
            // 
            // lb_MarketValue
            // 
            lb_MarketValue.AutoSize = true;
            lb_MarketValue.Location = new Point(6, 108);
            lb_MarketValue.Name = "lb_MarketValue";
            lb_MarketValue.Size = new Size(127, 20);
            lb_MarketValue.TabIndex = 80;
            lb_MarketValue.Text = "Ринкова вартість";
            // 
            // lb_CarYear
            // 
            lb_CarYear.AutoSize = true;
            lb_CarYear.Location = new Point(232, 76);
            lb_CarYear.Name = "lb_CarYear";
            lb_CarYear.Size = new Size(86, 20);
            lb_CarYear.TabIndex = 79;
            lb_CarYear.Text = "Рік випуску";
            // 
            // lb_EngineVal
            // 
            lb_EngineVal.AutoSize = true;
            lb_EngineVal.Location = new Point(6, 79);
            lb_EngineVal.Name = "lb_EngineVal";
            lb_EngineVal.Size = new Size(70, 20);
            lb_EngineVal.TabIndex = 78;
            lb_EngineVal.Text = "Об'єм дв";
            // 
            // lb_CarModel
            // 
            lb_CarModel.AutoSize = true;
            lb_CarModel.Location = new Point(6, 47);
            lb_CarModel.Name = "lb_CarModel";
            lb_CarModel.Size = new Size(63, 20);
            lb_CarModel.TabIndex = 77;
            lb_CarModel.Text = "Модель";
            // 
            // lb_CarBrand
            // 
            lb_CarBrand.AutoSize = true;
            lb_CarBrand.Location = new Point(6, 15);
            lb_CarBrand.Name = "lb_CarBrand";
            lb_CarBrand.Size = new Size(54, 20);
            lb_CarBrand.TabIndex = 73;
            lb_CarBrand.Text = "Марка";
            // 
            // tb_CarModel
            // 
            tb_CarModel.Location = new Point(89, 40);
            tb_CarModel.Name = "tb_CarModel";
            tb_CarModel.Size = new Size(355, 27);
            tb_CarModel.TabIndex = 13;
            // 
            // tb_EngineVal
            // 
            tb_EngineVal.Location = new Point(89, 72);
            tb_EngineVal.Name = "tb_EngineVal";
            tb_EngineVal.Size = new Size(137, 27);
            tb_EngineVal.TabIndex = 14;
            tb_EngineVal.TextChanged += tb_EngineVal_TextChanged;
            // 
            // tb_CarYear
            // 
            tb_CarYear.Location = new Point(324, 72);
            tb_CarYear.Name = "tb_CarYear";
            tb_CarYear.Size = new Size(120, 27);
            tb_CarYear.TabIndex = 15;
            // 
            // tb_CarBrand
            // 
            tb_CarBrand.Location = new Point(89, 8);
            tb_CarBrand.Name = "tb_CarBrand";
            tb_CarBrand.Size = new Size(355, 27);
            tb_CarBrand.TabIndex = 12;
            // 
            // tp_Properties
            // 
            tp_Properties.Controls.Add(label28);
            tp_Properties.Controls.Add(cb_PropChoice);
            tp_Properties.Controls.Add(label10);
            tp_Properties.Controls.Add(tb_PriceProp);
            tp_Properties.Controls.Add(label11);
            tp_Properties.Controls.Add(bt_PropBonus);
            tp_Properties.Controls.Add(bt_PropStandart);
            tp_Properties.Controls.Add(bt_PropEco);
            tp_Properties.Controls.Add(label8);
            tp_Properties.Controls.Add(tb_MarketValueProp);
            tp_Properties.Controls.Add(label9);
            tp_Properties.Controls.Add(lb_Square);
            tp_Properties.Controls.Add(tb_Square);
            tp_Properties.Controls.Add(lb_tipe);
            tp_Properties.Controls.Add(tb_Tipe);
            tp_Properties.Location = new Point(4, 29);
            tp_Properties.Name = "tp_Properties";
            tp_Properties.Padding = new Padding(3);
            tp_Properties.Size = new Size(450, 289);
            tp_Properties.TabIndex = 1;
            tp_Properties.Text = "МАЙНО";
            tp_Properties.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(138, 135);
            label28.Name = "label28";
            label28.Size = new Size(171, 20);
            label28.TabIndex = 82;
            label28.Text = "Програми страхування";
            // 
            // cb_PropChoice
            // 
            cb_PropChoice.AutoSize = true;
            cb_PropChoice.Location = new Point(362, 241);
            cb_PropChoice.Name = "cb_PropChoice";
            cb_PropChoice.Size = new Size(18, 17);
            cb_PropChoice.TabIndex = 33;
            cb_PropChoice.UseVisualStyleBackColor = true;
            cb_PropChoice.CheckedChanged += cb_PropChoice_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(290, 238);
            label10.Name = "label10";
            label10.Size = new Size(33, 20);
            label10.TabIndex = 80;
            label10.Text = "грн";
            // 
            // tb_PriceProp
            // 
            tb_PriceProp.Location = new Point(138, 235);
            tb_PriceProp.Name = "tb_PriceProp";
            tb_PriceProp.Size = new Size(146, 27);
            tb_PriceProp.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 238);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 78;
            label11.Text = "Вартість послуги";
            // 
            // bt_PropBonus
            // 
            bt_PropBonus.Location = new Point(316, 167);
            bt_PropBonus.Name = "bt_PropBonus";
            bt_PropBonus.Size = new Size(119, 53);
            bt_PropBonus.TabIndex = 31;
            bt_PropBonus.Text = "Бонус";
            bt_PropBonus.UseVisualStyleBackColor = true;
            bt_PropBonus.Click += bt_PropBonus_Click;
            // 
            // bt_PropStandart
            // 
            bt_PropStandart.Location = new Point(165, 167);
            bt_PropStandart.Name = "bt_PropStandart";
            bt_PropStandart.Size = new Size(119, 53);
            bt_PropStandart.TabIndex = 30;
            bt_PropStandart.Text = "Стандарт";
            bt_PropStandart.UseVisualStyleBackColor = true;
            bt_PropStandart.Click += bt_PropStandart_Click;
            // 
            // bt_PropEco
            // 
            bt_PropEco.Location = new Point(14, 167);
            bt_PropEco.Name = "bt_PropEco";
            bt_PropEco.Size = new Size(119, 53);
            bt_PropEco.TabIndex = 29;
            bt_PropEco.Text = "Економ";
            bt_PropEco.UseVisualStyleBackColor = true;
            bt_PropEco.Click += bt_PropEco_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(402, 93);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 74;
            label8.Text = "грн";
            // 
            // tb_MarketValueProp
            // 
            tb_MarketValueProp.Location = new Point(141, 90);
            tb_MarketValueProp.Name = "tb_MarketValueProp";
            tb_MarketValueProp.Size = new Size(250, 27);
            tb_MarketValueProp.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 93);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 72;
            label9.Text = "Ринкова вартість";
            // 
            // lb_Square
            // 
            lb_Square.AutoSize = true;
            lb_Square.Location = new Point(6, 55);
            lb_Square.Name = "lb_Square";
            lb_Square.Size = new Size(57, 20);
            lb_Square.TabIndex = 63;
            lb_Square.Text = "Площа";
            // 
            // tb_Square
            // 
            tb_Square.Location = new Point(89, 48);
            tb_Square.Name = "tb_Square";
            tb_Square.Size = new Size(355, 27);
            tb_Square.TabIndex = 27;
            // 
            // lb_tipe
            // 
            lb_tipe.AutoSize = true;
            lb_tipe.Location = new Point(6, 17);
            lb_tipe.Name = "lb_tipe";
            lb_tipe.Size = new Size(35, 20);
            lb_tipe.TabIndex = 61;
            lb_tipe.Text = "Тип";
            // 
            // tb_Tipe
            // 
            tb_Tipe.Location = new Point(89, 10);
            tb_Tipe.Name = "tb_Tipe";
            tb_Tipe.Size = new Size(355, 27);
            tb_Tipe.TabIndex = 26;
            // 
            // tp_Travel
            // 
            tp_Travel.Controls.Add(tb_InsCover);
            tp_Travel.Controls.Add(cb_TravelChoice);
            tp_Travel.Controls.Add(label24);
            tp_Travel.Controls.Add(tb_TravelPrice);
            tp_Travel.Controls.Add(label25);
            tp_Travel.Controls.Add(label23);
            tp_Travel.Controls.Add(bt_TravelAll);
            tp_Travel.Controls.Add(bt_TravelStandart);
            tp_Travel.Controls.Add(bt_TravelEco);
            tp_Travel.Controls.Add(label22);
            tp_Travel.Controls.Add(tb_Travelers);
            tp_Travel.Controls.Add(label21);
            tp_Travel.Controls.Add(label19);
            tp_Travel.Controls.Add(label17);
            tp_Travel.Controls.Add(tb_Period);
            tp_Travel.Controls.Add(label13);
            tp_Travel.Controls.Add(label12);
            tp_Travel.Controls.Add(tb_Country);
            tp_Travel.Location = new Point(4, 29);
            tp_Travel.Name = "tp_Travel";
            tp_Travel.Padding = new Padding(3);
            tp_Travel.Size = new Size(450, 289);
            tp_Travel.TabIndex = 2;
            tp_Travel.Text = "ТУРИЗМ";
            tp_Travel.UseVisualStyleBackColor = true;
            // 
            // tb_InsCover
            // 
            tb_InsCover.Location = new Point(100, 39);
            tb_InsCover.Name = "tb_InsCover";
            tb_InsCover.Size = new Size(261, 27);
            tb_InsCover.TabIndex = 85;
            toolTip1.SetToolTip(tb_InsCover, "Вкажіть необхідний розмір страхового покриття: 10000, 20000, ... 70000.");
            // 
            // cb_TravelChoice
            // 
            cb_TravelChoice.AutoSize = true;
            cb_TravelChoice.Location = new Point(372, 217);
            cb_TravelChoice.Name = "cb_TravelChoice";
            cb_TravelChoice.Size = new Size(18, 17);
            cb_TravelChoice.TabIndex = 42;
            cb_TravelChoice.UseVisualStyleBackColor = true;
            cb_TravelChoice.CheckedChanged += cb_TravelChoice_CheckedChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(290, 214);
            label24.Name = "label24";
            label24.Size = new Size(33, 20);
            label24.TabIndex = 84;
            label24.Text = "грн";
            // 
            // tb_TravelPrice
            // 
            tb_TravelPrice.Location = new Point(138, 211);
            tb_TravelPrice.Name = "tb_TravelPrice";
            tb_TravelPrice.Size = new Size(146, 27);
            tb_TravelPrice.TabIndex = 41;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(7, 214);
            label25.Name = "label25";
            label25.Size = new Size(125, 20);
            label25.TabIndex = 82;
            label25.Text = "Вартість послуги";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(140, 115);
            label23.Name = "label23";
            label23.Size = new Size(171, 20);
            label23.TabIndex = 81;
            label23.Text = "Програми страхування";
            // 
            // bt_TravelAll
            // 
            bt_TravelAll.Location = new Point(316, 143);
            bt_TravelAll.Name = "bt_TravelAll";
            bt_TravelAll.Size = new Size(119, 53);
            bt_TravelAll.TabIndex = 40;
            bt_TravelAll.Text = "ALLIN";
            bt_TravelAll.UseVisualStyleBackColor = true;
            bt_TravelAll.Click += bt_TravelAll_Click;
            // 
            // bt_TravelStandart
            // 
            bt_TravelStandart.Location = new Point(165, 143);
            bt_TravelStandart.Name = "bt_TravelStandart";
            bt_TravelStandart.Size = new Size(119, 53);
            bt_TravelStandart.TabIndex = 39;
            bt_TravelStandart.Text = "Стандарт";
            bt_TravelStandart.UseVisualStyleBackColor = true;
            bt_TravelStandart.Click += bt_TravelStandart_Click;
            // 
            // bt_TravelEco
            // 
            bt_TravelEco.Location = new Point(14, 143);
            bt_TravelEco.Name = "bt_TravelEco";
            bt_TravelEco.Size = new Size(119, 53);
            bt_TravelEco.TabIndex = 38;
            bt_TravelEco.Text = "Економ";
            bt_TravelEco.UseVisualStyleBackColor = true;
            bt_TravelEco.Click += bt_TravelEcoClick;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(236, 73);
            label22.Name = "label22";
            label22.Size = new Size(130, 20);
            label22.TabIndex = 69;
            label22.Text = "Кількість туристів";
            // 
            // tb_Travelers
            // 
            tb_Travelers.Location = new Point(372, 69);
            tb_Travelers.Name = "tb_Travelers";
            tb_Travelers.Size = new Size(75, 27);
            tb_Travelers.TabIndex = 37;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(149, 73);
            label21.Name = "label21";
            label21.Size = new Size(38, 20);
            label21.TabIndex = 67;
            label21.Text = "днів";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(406, 40);
            label19.Name = "label19";
            label19.Size = new Size(38, 20);
            label19.TabIndex = 66;
            label19.Text = "USD";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 73);
            label17.Name = "label17";
            label17.Size = new Size(58, 20);
            label17.TabIndex = 65;
            label17.Text = "Період";
            // 
            // tb_Period
            // 
            tb_Period.Location = new Point(68, 70);
            tb_Period.Name = "tb_Period";
            tb_Period.Size = new Size(75, 27);
            tb_Period.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 40);
            label13.Name = "label13";
            label13.Size = new Size(74, 20);
            label13.TabIndex = 63;
            label13.Text = "Покриття";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 9);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 61;
            label12.Text = "Країна";
            // 
            // tb_Country
            // 
            tb_Country.Location = new Point(68, 6);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new Size(376, 27);
            tb_Country.TabIndex = 34;
            // 
            // tb_MarketValue
            // 
            tb_MarketValue.Location = new Point(139, 105);
            tb_MarketValue.Name = "tb_MarketValue";
            tb_MarketValue.Size = new Size(250, 27);
            tb_MarketValue.TabIndex = 16;
            tb_MarketValue.TextChanged += tb_MarketValue_TextChanged;
            // 
            // gb_TotalSum
            // 
            gb_TotalSum.Controls.Add(label26);
            gb_TotalSum.Controls.Add(tb_TotalSum);
            gb_TotalSum.Controls.Add(label27);
            gb_TotalSum.Controls.Add(bt_AddToBasket);
            gb_TotalSum.Location = new Point(6, 551);
            gb_TotalSum.Name = "gb_TotalSum";
            gb_TotalSum.Size = new Size(458, 125);
            gb_TotalSum.TabIndex = 43;
            gb_TotalSum.TabStop = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(414, 30);
            label26.Name = "label26";
            label26.Size = new Size(33, 20);
            label26.TabIndex = 31;
            label26.Text = "грн";
            // 
            // tb_TotalSum
            // 
            tb_TotalSum.Location = new Point(142, 27);
            tb_TotalSum.Name = "tb_TotalSum";
            tb_TotalSum.Size = new Size(266, 27);
            tb_TotalSum.TabIndex = 44;
            tb_TotalSum.TextChanged += GetTotalSum;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(11, 30);
            label27.Name = "label27";
            label27.Size = new Size(132, 20);
            label27.TabIndex = 29;
            label27.Text = "Загальна вартість";
            // 
            // bt_AddToBasket
            // 
            bt_AddToBasket.Location = new Point(28, 63);
            bt_AddToBasket.Name = "bt_AddToBasket";
            bt_AddToBasket.Size = new Size(397, 46);
            bt_AddToBasket.TabIndex = 45;
            bt_AddToBasket.Text = "Додати до кошику";
            bt_AddToBasket.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 10;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 803);
            Controls.Add(gb_TotalSum);
            Controls.Add(tc_Tab);
            Controls.Add(gb_ResultBox);
            Controls.Add(gb_Clients);
            Controls.Add(lb_Clients);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsuranceForm";
            Resize += FormResize;
            gb_Clients.ResumeLayout(false);
            gb_Clients.PerformLayout();
            gb_Policies.ResumeLayout(false);
            gb_Policies.PerformLayout();
            gb_ResultBox.ResumeLayout(false);
            gb_ResultBox.PerformLayout();
            tc_Tab.ResumeLayout(false);
            tp_Auto.ResumeLayout(false);
            tp_Auto.PerformLayout();
            tp_Properties.ResumeLayout(false);
            tp_Properties.PerformLayout();
            tp_Travel.ResumeLayout(false);
            tp_Travel.PerformLayout();
            gb_TotalSum.ResumeLayout(false);
            gb_TotalSum.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Clients;
        private GroupBox gb_Policies;
        private GroupBox gb_ResultBox;
        private ListBox lb_Clients;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_Age;
        private TextBox tb_City;
        private TextBox tb_LastName;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private CheckBox cb_isTravel;
        private CheckBox cb_isProperty;
        private CheckBox cb_isAuto;
        private Label label14;
        private Button button1;
        private TextBox tb_resultPrice;
        private Label label15;
        private Label label16;
        private TextBox tb_MarketValue;
        private TextBox tb_CarModel;
        private TextBox tb_CarYear;
        private TextBox tb_CarBrand;
        private TextBox tb_PriceDcv;
        private Button bt_TravelAll;
        private TabControl tc_Tab;
        private TabPage tp_Auto;
        private TabPage tp_Properties;
        private TabPage tp_Travel;
        private CheckBox cb_Dcv;
        private CheckBox cb_Oscpv;
        private CheckBox cb_Casco;
        private Label lb_PriceDcv;
        private Label label18;
        private TextBox tb_PriceOscpv;
        private Label lb_PriceOscpv;
        private Label label20;
        private TextBox tb_PriceCasco;
        private Label lb_PriceCasco;
        private Label lb_MV_UAH;
        private Label lb_MarketValue;
        private Label lb_CarYear;
        private Label lb_EngineVal;
        private Label lb_CarModel;
        private Label lb_CarBrand;
        private TextBox tb_EngineVal;
        private Label lb_Square;
        private TextBox tb_Square;
        private Label lb_tipe;
        private TextBox tb_Tipe;
        private Label label10;
        private TextBox tb_PriceProp;
        private Label label11;
        private Button bt_PropBonus;
        private Button bt_PropStandart;
        private Button bt_PropEco;
        private Label label8;
        private TextBox tb_MarketValueProp;
        private Label label9;
        private Label label17;
        private TextBox tb_Period;
        private Label label13;
        private Label label12;
        private TextBox tb_Country;
        private Label label19;
        private Button bt_TravelStandart;
        private Button bt_TravelEco;
        private Label label22;
        private TextBox tb_Travelers;
        private Label label21;
        private Label label24;
        private TextBox tb_TravelPrice;
        private Label label25;
        private Label label23;
        private CheckBox cb_PropChoice;
        private Label label28;
        private CheckBox cb_TravelChoice;
        private GroupBox gb_TotalSum;
        private Label label26;
        private TextBox tb_TotalSum;
        private Label label27;
        private Button bt_AddToBasket;
        private Button bt_Dcv1;
        private Button bt_Oscpv1;
        private Button bt_Casko1;
        private MaskedTextBox mtb_PhoneNumber;
        private TextBox tb_MiddleName;
        private Label label29;
        private TextBox tb_FirstName;
        private Label label30;
        private TextBox tb_InsCover;
        private ToolTip toolTip1;
    }
}