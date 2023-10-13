using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using WinFormsApp3.Domain;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Insurers insurers;

        public Form1()
        {
            InitializeComponent();
            insurers = new Insurers();

        }
        private void FormResize(object sender, EventArgs e)
        {
            if (this.Width > 1000 && this.Height > 600)
            {
                lb_Clients.Width = (int)(this.Width / 1.35);
                lb_Clients.Height = this.Height - 50;
            }
            else
            {
                lb_Clients.Width = 500;
                lb_Clients.Height = 724;
            }
            lb_Clients.Update();
        }
        private void CheckedChangedAuto(object sender, EventArgs e)
        {
            if (cb_isAuto.Checked)
            {
                tc_Tab.Enabled = true;
                tc_Tab.SelectedIndex = 0;
            }
            else
            {
                tb_CarBrand.Text = "";
                tb_CarModel.Text = "";
                tb_CarYear.Text = "";
                tb_MarketValue.Text = "";
                tb_EngineVal.Text = "";
                tb_PriceCasco.Text = "";
                tb_PriceOscpv.Text = "";
                tb_PriceDcv.Text = "";
                tc_Tab.TabPages[0].Hide();
            }
        }
        private void lb_SizeChanged()
        {
            if (lb_Clients.Items.Count == 0)
            {
                gb_ResultBox.Visible = false;
            }
            else
            {
                gb_ResultBox.Visible = true;
            }
        }
        private void CheckedChengedProperty(object sender, EventArgs e)
        {
            if (cb_isProperty.Checked)
            {
                tc_Tab.Enabled = true;
                tc_Tab.SelectedIndex = 1;
            }
            else
            {
                tb_Tipe.Text = "";
                tb_Square.Text = "";
                tb_MarketValueProp.Text = "";
                tc_Tab.TabPages[1].Hide();
            }
        }
        private void CheckedChangedTravel(object sender, EventArgs e)
        {
            if (cb_isTravel.Checked)
            {
                tc_Tab.Enabled = true;
                tc_Tab.SelectedIndex = 2;
            }
            else
            {
                tb_Country.Text = "";
                tb_InsCover.Text = "";
                tb_Period.Text = "";
                tb_Travelers.Text = "";
                tc_Tab.TabPages[2].Hide();
            }
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_isAuto.Checked && cb_isProperty.Checked && cb_isTravel.Checked)
            {
                tc_Tab.Visible = true;

            }
            else if (cb_isAuto.Checked && cb_isProperty.Checked)
            {
                tc_Tab.TabPages[2].Hide();

            }
            else if (cb_isAuto.Checked && cb_isTravel.Checked)
            {
                tc_Tab.TabPages[1].Hide();

            }
            else if (cb_isProperty.Checked && cb_isTravel.Checked)
            {
                tc_Tab.TabPages[0].Hide();
            }
            else if (cb_isAuto.Checked)
            {
                tc_Tab.TabPages[1].Hide();
                tc_Tab.TabPages[2].Hide();
            }
            else if (cb_isProperty.Checked)
            {
                tc_Tab.TabPages[0].Hide();
                tc_Tab.TabPages[2].Hide();
            }
            else if (cb_isTravel.Checked)
            {
                tc_Tab.TabPages[0].Hide();
                tc_Tab.TabPages[1].Hide();
            }
            else
            {
                tc_Tab.Visible = false;
            }
        }
        private void AddToBasketClick(object sender, EventArgs e)
        {
            
           
            //var item = new Client(tb_FirstName.Text, tb_LastName.Text, tb_MiddleName.Text, mtb_PhoneNumber.Text, tb_Age.Text, tb_City.Text,                
            //                   new Car(tb_CarBrand.Text, tb_CarModel.Text, Convert.ToInt32(tb_CarYear.Text), Convert.ToDecimal(tb_MarketValue.Text), Convert.ToDouble(tb_EngineVal.Text)),
            //                                  new Property(tb_Tipe.Text, Convert.ToDecimal(tb_MarketValueProp.Text), Convert.ToDouble(tb_Square.Text)),
            //                                                 new Journeys(tb_Country.Text, Convert.ToInt32(tb_InsCover.Text), Convert.ToInt32(tb_Period.Text), Convert.ToInt32(tb_Travelers.Text)),
            //                          Convert.ToDecimal(tb_PriceCasco.Text) , Convert.ToDecimal(tb_PriceOscpv.Text), Convert.ToDecimal(tb_PriceDcv.Text), Convert.ToDecimal(tb_PriceProp.Text), Convert.ToDecimal(tb_TravelPrice.Text), Convert.ToDecimal(tb_TotalSum.Text), Convert.ToDecimal(tb_resultPrice.Text)).ToString();
            var item = new Client(tb_FirstName.Text, tb_LastName.Text, tb_MiddleName.Text, mtb_PhoneNumber.Text, tb_Age.Text, tb_City.Text,
                               new Car(tb_CarBrand.Text, tb_CarModel.Text, Convert.ToInt32(tb_CarYear.Text), Convert.ToDecimal(tb_MarketValue.Text), Convert.ToDouble(tb_EngineVal.Text)),
                                              new Property(tb_Tipe.Text, Convert.ToDecimal(tb_MarketValueProp.Text), Convert.ToDouble(tb_Square.Text)),
                                                             new Journeys(tb_Country.Text, Convert.ToInt32(tb_InsCover.Text), Convert.ToInt32(tb_Period.Text), Convert.ToInt32(tb_Travelers.Text)),
                                      Convert.ToDecimal(tb_PriceCasco.Text), Convert.ToDecimal(tb_PriceOscpv.Text), Convert.ToDecimal(tb_PriceDcv.Text), Convert.ToDecimal(tb_PriceProp.Text), Convert.ToDecimal(tb_TravelPrice.Text), Convert.ToDecimal(tb_TotalSum.Text), Convert.ToDecimal(tb_resultPrice.Text));

            insurers.Collection.Add(item);
            lb_Clients.Items.Add(item);
            lb_SizeChanged();
            if (lb_Clients.Items.Count >= 1)
            {
                tb_resultPrice.Text = insurers.Collection.Sum(x => x.TotalSum).ToString();
            }
            else
            {
                tb_resultPrice.Text = "0";
            }






        }

        private void GetClient(object sender, EventArgs e)
        {



        }
        private void CascoClick(object sender, EventArgs e)
        {
            try
            {
                if (tb_CarBrand.Text == "" || tb_CarModel.Text == "" || tb_CarYear.Text == "" || tb_MarketValue.Text == "" || tb_EngineVal.Text == "")
                {
                    return;
                }
                else
                {
                    bt_Casko1.Enabled = true;
                    Car car = new(tb_CarBrand.Text, tb_CarModel.Text, Convert.ToInt32(tb_CarYear.Text), Convert.ToDecimal(tb_MarketValue.Text), Convert.ToDouble(tb_EngineVal.Text));
                    Calculator calc = new();
                    decimal result = calc.CascoIns(car.CarYear, car.MarketValue);
                    tb_PriceCasco.Text = result.ToString();
                    tb_PriceCasco.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OscpvClick(object sender, EventArgs e)
        {
            try
            {
                if (tb_CarBrand.Text == "" || tb_CarModel.Text == "" || tb_CarYear.Text == "" || tb_MarketValue.Text == "" || tb_EngineVal.Text == "")
                {
                    return;
                }
                else
                {
                    Car car = new(tb_CarBrand.Text, tb_CarModel.Text, Convert.ToInt32(tb_CarYear.Text), Convert.ToDecimal(tb_MarketValue.Text), Convert.ToDouble(tb_EngineVal.Text));
                    Calculator calc = new();
                    decimal result = calc.OscpvIns(car.EngineVal);
                    tb_PriceOscpv.Text = result.ToString();
                    tb_PriceOscpv.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DcvClick(object sender, EventArgs e)
        {
            try
            {
                if (tb_CarBrand.Text == "" || tb_CarModel.Text == "" || tb_CarYear.Text == "" || tb_MarketValue.Text == "" || tb_EngineVal.Text == "")
                {
                    return;
                }
                else
                {

                    Car car = new(tb_CarBrand.Text, tb_CarModel.Text, Convert.ToInt32(tb_CarYear.Text), Convert.ToDecimal(tb_MarketValue.Text), Convert.ToDouble(tb_EngineVal.Text));
                    Calculator calc = new();
                    decimal result = calc.DcvIns();
                    tb_PriceDcv.Text = result.ToString();
                    tb_PriceDcv.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tb_MarketValue_TextChanged(object sender, EventArgs e)
        {
            if (tb_MarketValue.Text != null)
            {
                bt_Casko1.Enabled = true;
            }
            else
            {
                bt_Casko1.Enabled = false;
                MessageBox.Show("Вкажіть ринкову вартість авто", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tb_EngineVal_TextChanged(object sender, EventArgs e)
        {
            if (tb_EngineVal.Text != null)
            {
                bt_Oscpv1.Enabled = true;
                bt_Dcv1.Enabled = true;
            }
            else
            {
                bt_Oscpv1.Enabled = false;
                bt_Dcv1.Enabled = false;
                MessageBox.Show("Вкажіть об'єм двигуна авто", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GetTotalSum(object sender, EventArgs e)
        {
            if (cb_isAuto.Checked && cb_isProperty.Checked && cb_isTravel.Checked)
            {
                if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked && cb_PropChoice.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_PriceProp.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_PropChoice.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceProp.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_PropChoice.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceProp.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked && cb_PropChoice.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_PriceProp.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_PropChoice.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceProp.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else
                {
                    tb_TotalSum.Text = "0";
                }
            }
            else if (cb_isAuto.Checked && cb_isProperty.Checked)
            {
                if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text)).ToString();
                }
                else if (cb_Casco.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
                }
                else if (cb_Oscpv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text)).ToString();
                }
                else if (cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else
                {
                    tb_TotalSum.Text = "0";
                }
            }
            else if (cb_isAuto.Checked && cb_isTravel.Checked)
            {
                if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text)).ToString();
                }
                else if (cb_Casco.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
                }
                else if (cb_Oscpv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text)).ToString();
                }
                else if (cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else
                {
                    tb_TotalSum.Text = "0";
                }
            }
            else if (cb_isProperty.Checked && cb_isTravel.Checked)
            {
                if (cb_PropChoice.Checked && cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceProp.Text) + Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else if (cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else if (cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else
                {
                    tb_TotalSum.Text = "0";
                }
            }
            else if (cb_isAuto.Checked)
            {
                if (cb_Casco.Checked && cb_Oscpv.Checked && cb_Dcv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
                }
                else if (cb_Casco.Checked && cb_Oscpv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text) + Convert.ToDecimal(tb_PriceOscpv.Text)).ToString();
                }
                else if (cb_Oscpv.Checked && cb_Dcv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text) + Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
                }
                else if (cb_Casco.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceCasco.Text)).ToString();
                }
                else if (cb_Oscpv.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceOscpv.Text)).ToString();
                }
                else
                {
                    tb_TotalSum.Text = "0";
                }
            }
            else if (cb_isProperty.Checked)
            {
                if (cb_PropChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_PriceProp.Text)).ToString();
                }
                else
                {
                    tb_TotalSum.Text = "0";
                }
            }
            else if (cb_isTravel.Checked)
            {
                if (cb_TravelChoice.Checked)
                {
                    tb_TotalSum.Text = (Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
                }
                else
                {
                    tb_TotalSum.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Оберіть хоча б один вид страхування", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_TotalSum.Text = "0";
            }
        }

        private void Casco_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Casco.Checked)
            {
                tb_TotalSum.Text += Convert.ToDecimal(tb_PriceCasco.Text).ToString();
            }
            else
            {
                tb_TotalSum.Text = (Convert.ToDecimal(tb_TotalSum.Text) - Convert.ToDecimal(tb_PriceCasco.Text)).ToString();
            }
        }

        private void Oscpv_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Oscpv.Checked)
            {
                tb_TotalSum.Text += Convert.ToDecimal(tb_PriceOscpv.Text).ToString();
                cb_Dcv.Enabled = true;
            }
            else
            {
                tb_TotalSum.Text = (Convert.ToDecimal(tb_TotalSum.Text) - Convert.ToDecimal(tb_PriceOscpv.Text)).ToString();
                cb_Dcv.Checked = false;
                cb_Dcv.Enabled = false;
            }
        }

        private void Dcv_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Dcv.Checked)
            {
                tb_TotalSum.Text += Convert.ToDecimal(tb_PriceDcv.Text).ToString();
            }
            else
            {
                tb_TotalSum.Text = (Convert.ToDecimal(tb_TotalSum.Text) - Convert.ToDecimal(tb_PriceDcv.Text)).ToString();
            }
        }

        private void bt_PropEco_Click(object sender, EventArgs e)
        {
            if (tb_Tipe.Text == "" || tb_Square.Text == "" || tb_MarketValueProp.Text == "")
            {
                return;
            }
            else
            {
                Property property = new(tb_Tipe.Text, Convert.ToDecimal(tb_MarketValueProp.Text), Convert.ToDouble(tb_Square.Text));
                Calculator calc = new Calculator();
                decimal result = calc.PropertyIns(1);
                tb_PriceProp.Text = result.ToString();
                tb_PriceProp.Visible = true;
            }
        }

        private void bt_PropStandart_Click(object sender, EventArgs e)
        {
            if (tb_Tipe.Text == "" || tb_Square.Text == "" || tb_MarketValueProp.Text == "")
            {
                return;
            }
            else
            {
                Property property = new(tb_Tipe.Text, Convert.ToDecimal(tb_MarketValueProp.Text), Convert.ToDouble(tb_Square.Text));
                Calculator calc = new Calculator();
                decimal result = calc.PropertyIns(2);
                tb_PriceProp.Text = result.ToString();
                tb_PriceProp.Visible = true;
            }
        }

        private void bt_PropBonus_Click(object sender, EventArgs e)
        {
            if (tb_Tipe.Text == "" || tb_Square.Text == "" || tb_MarketValueProp.Text == "")
            {
                return;
            }
            else
            {
                Property property = new(tb_Tipe.Text, Convert.ToDecimal(tb_MarketValueProp.Text), Convert.ToDouble(tb_Square.Text));
                Calculator calc = new Calculator();
                decimal result = calc.PropertyIns(3);
                tb_PriceProp.Text = result.ToString();
                tb_PriceProp.Visible = true;
            }
        }

        private void cb_PropChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PropChoice.Checked)
            {
                tb_TotalSum.Text += Convert.ToDecimal(tb_PriceProp.Text).ToString();
            }
            else
            {
                tb_TotalSum.Text = (Convert.ToDecimal(tb_TotalSum.Text) - Convert.ToDecimal(tb_PriceProp.Text)).ToString();
            }

        }


        private void bt_TravelEcoClick(object sender, EventArgs e)
        {
            if (tb_Country.Text == "" || tb_Period.Text == "" || tb_Travelers.Text == "" || tb_InsCover.Text == "")
            {
                return;
            }
            else
            {
                Journeys journeys = new(tb_Country.Text, Convert.ToInt32(tb_InsCover.Text), Convert.ToInt32(tb_Period.Text), Convert.ToInt32(tb_Travelers.Text));
                Calculator calc = new();
                decimal result = calc.TravelIns(journeys.JourneyDays, journeys.JourneyPeople, journeys.JourneyInsCover, 1);
                tb_TravelPrice.Text = result.ToString();
                tb_TravelPrice.Visible = true;
            }

        }

        private void bt_TravelStandart_Click(object sender, EventArgs e)
        {
            if (tb_Country.Text == "" || tb_Period.Text == "" || tb_Travelers.Text == "" || tb_InsCover.Text == "")
            {
                return;
            }
            else
            {
                Journeys journeys = new(tb_Country.Text, Convert.ToInt32(tb_InsCover.Text), Convert.ToInt32(tb_Period.Text), Convert.ToInt32(tb_Travelers.Text));
                Calculator calc = new();
                decimal result = calc.TravelIns(journeys.JourneyDays, journeys.JourneyPeople, journeys.JourneyInsCover, 2);
                tb_TravelPrice.Text = result.ToString();
                tb_TravelPrice.Visible = true;
            }
        }

        private void bt_TravelAll_Click(object sender, EventArgs e)
        {
            if (tb_Country.Text == "" || tb_Period.Text == "" || tb_Travelers.Text == "" || tb_InsCover.Text == "")
            {
                return;
            }
            else
            {
                Journeys journeys = new(tb_Country.Text, Convert.ToInt32(tb_InsCover.Text), Convert.ToInt32(tb_Period.Text), Convert.ToInt32(tb_Travelers.Text));
                Calculator calc = new();
                decimal result = calc.TravelIns(journeys.JourneyDays, journeys.JourneyPeople, journeys.JourneyInsCover, 3);
                tb_TravelPrice.Text = result.ToString();
                tb_TravelPrice.Visible = true;
            }
        }

        private void cb_TravelChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_TravelChoice.Checked)
            {
                tb_TotalSum.Text += Convert.ToDecimal(tb_TravelPrice.Text).ToString();
            }
            else
            {
                tb_TotalSum.Text = (Convert.ToDecimal(tb_TotalSum.Text) - Convert.ToDecimal(tb_TravelPrice.Text)).ToString();
            }
        }

       
        //private void AddNewClient(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (tb_LastName.Text == "" || mtb_PhoneNumber.Text == "" || tb_Age.Text == "" || tb_City.Text == "")
        //        {
        //            MessageBox.Show("Заповніть всі поля", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            client = new(tb_LastName.Text, tb_FirstName.Text, tb_MiddleName.Text, mtb_PhoneNumber.Text, Convert.ToInt32(tb_Age.Text), tb_City.Text, null, null, null);
        //            lb_Clients.Items.Add(client);
        //            tb_LastName.Text = "";
        //            mtb_PhoneNumber.Text = "";
        //            tb_Age.Text = "";
        //            tb_City.Text = "";
        //            Car car = new(tb_CarBrand.Text, tb_CarModel.Text, Convert.ToInt32(tb_CarYear.Text), Convert.ToDecimal(tb_MarketValue.Text), Convert.ToDouble(tb_EngineVal.Text));
        //            Property property = new(tb_Tipe.Text, Convert.ToDecimal(tb_MarketValueProp.Text), Convert.ToDouble(tb_Square.Text));
        //            Journeys journeys = new(tb_Country.Text, Convert.ToDecimal(tb_Period.Text));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}




    }
}
