using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidLibrary;
using ScaleInterface;

namespace Postage
{
    public partial class FormPostage : Form
    {
        public FormPostage()
        {
            InitializeComponent();
            decimal? weight;
            bool? isStable;
            decimal iPounds = 0;
            decimal iOunces = 0;
            decimal postageCalculated;

            USBScale s = new USBScale();
            s.Connect();
            if (s.IsConnected)
            {
                labelStatus.Text = "Status:  Found Stamps.com scale";
                s.GetWeight(out weight, out isStable);
                //s.DebugScaleData();
                s.Disconnect();
                iPounds = Math.Floor(Convert.ToDecimal(weight));
                iOunces = Convert.ToDecimal(Math.Round(
                    Convert.ToDecimal(weight - iPounds) * 16, 2, MidpointRounding.AwayFromZero
                    ));
                textBoxPounds.Text = iPounds.ToString();
                textBoxOunces.Text = iOunces.ToString();
                if (iPounds > 1 || (iOunces > Convert.ToDecimal(3.5)))
                {
                    if (iPounds > 1 || (iOunces > Convert.ToDecimal(13.499)))
                    {
                        // ----------------------------------------------------------------------------
                        // 13.5 ounces and over, need Priority Mail flat-rate envelope
                        labelStatus.Text = "Status:  > 13.5 oz., use Priority Mail flat-rate envelope";
                        textBoxPostage.Text = "";
                        textBoxNum49Stamps.Text = "";
                        textBoxNum21Stamps.Text = "";
                    }
                    else
                    {
                        // ----------------------------------------------------------------------------
                        // Over 3.5 ounces but under 13.5, need FLATS calculation
                        labelStatus.Text = "Status:  > 3.5 oz., using FLATS calculation";
                        if (iPounds < Convert.ToDecimal(4.0) && iOunces < Convert.ToDecimal(0.999))
                        {
                            // 3.5 to 3.99
                            textBoxPostage.Text = "1.61";
                            textBoxNum49Stamps.Text = "2";
                            textBoxNum21Stamps.Text = "3";
                        }
                        else
                        {
                            if (iPounds < Convert.ToDecimal(4.0) && iOunces < Convert.ToDecimal(0.5))
                            {
                                // 4.0 to 4.5 ounces = $0.98
                                textBoxPostage.Text = "1.61";
                                textBoxNum49Stamps.Text = "2";
                                textBoxNum21Stamps.Text = "3";
                            }
                            else
                            {
                                // 5 ounces and over = $0.98 + $0.21 per ounce after the first
                                postageCalculated = Convert.ToDecimal(0.98) +
                                    ((iPounds * 16) + Math.Round(iOunces, 0, MidpointRounding.AwayFromZero) - Convert.ToDecimal(1.0)) * Convert.ToDecimal(0.21);
                                textBoxPostage.Text = postageCalculated.ToString();
                                // postage / cost of $0.98 stamp, rounded to integer
                                textBoxNum49Stamps.Text = "2";
                                textBoxNum21Stamps.Text = (
                                            Math.Ceiling((postageCalculated - Convert.ToDecimal(0.98))
                                                / Convert.ToDecimal(0.21))
                                        ).ToString();
                            }
                        }
                    }
                    // ----------------------------------------------------------------------------
                }
                else
                {
                    // ----------------------------------------------------------------------------
                    // Using standard calculation
                    // ----------------------------------------------------------------------------
                    if (iPounds < Convert.ToDecimal(1.0) && iOunces < Convert.ToDecimal(0.5))
                    {
                        // Less than 0.5 ounces assumes that the rounding for ounces makes that
                        // zero or 0 lbs. 0 oz.
                        textBoxPostage.Text = "0.49";
                        textBoxNum49Stamps.Text = "1";
                        textBoxNum21Stamps.Text = "0";
                    }
                    else
                    {
                        if (iOunces < Convert.ToDecimal(1.5))
                        {
                            // 0.5 to 1.5 ounces = $0.49
                            textBoxPostage.Text = "0.49";
                            textBoxNum49Stamps.Text = "1";
                            textBoxNum21Stamps.Text = "0";
                        } else
                        {
                            // 1.5 to 3.5 ounces = $0.49 + $0.21 per ounce after the first
                            postageCalculated = Convert.ToDecimal(0.49) +
                                ((iPounds * 16) + Math.Round(iOunces, 0, MidpointRounding.AwayFromZero) - Convert.ToDecimal(1.0)) * Convert.ToDecimal(0.21);
                            textBoxPostage.Text = postageCalculated.ToString();
                            // postage / cost of $0.49 stamp, rounded to integer
                            textBoxNum49Stamps.Text = "1";
                            textBoxNum21Stamps.Text = (
                                        Math.Ceiling((postageCalculated - Convert.ToDecimal(0.49))
                                            / Convert.ToDecimal(0.21))
                                    ).ToString();
                        }
                    }
                    // ----------------------------------------------------------------------------
                }
            }
            else
            {
                labelStatus.Text = "Status:  Could not find Stamps.com scale";
            }
        }
    }
}
