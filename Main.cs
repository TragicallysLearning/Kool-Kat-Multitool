using System;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kool_Kat_Panel
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();

        }

        private void thirteenButton1_Click(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Host");

            }

            else
            {
                WebClient wc = new WebClient { };
                string lookup = wc.DownloadString($"http://ip-api.com/json/{tbHost.Text}?fields=16989721");
                if (lookup == tbHost.Text)
                {
                    MessageBox.Show("Invalid Host!");
                }

                else
                {
                    JObject trace = JObject.Parse(lookup);
                    string final = "IP - " + trace["query"];
                    MessageBox.Show(final);
                }
            }
        }

        private void thirteenButton2_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    FileName = "ping.exe",
                    Arguments = tbHost.Text + " -t"
                }
            }.Start();
        }

        private void pscan_Click(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Host");

            }

            else
            {
                WebClient wc = new WebClient { };
                string portscan = wc.DownloadString("https://api.hackertarget.com/nmap/?q=" + tbHost.Text);
                if (portscan == "Error enter single IP or Host only on Free Scan")
                {
                    MessageBox.Show("Invalid Host!");
                }

                else
                {
                    MessageBox.Show(portscan);
                }
            }
        }

        private void logInThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void pscan_Click_1(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Host");

            }

            else
            {
                WebClient wc = new WebClient { };
                string portscan = wc.DownloadString("https://api.hackertarget.com/nmap/?q=" + tbHost.Text);
                if (portscan == "Error enter single IP or Host only on Free Scan")
                {
                    MessageBox.Show("Invalid Host!");
                }

                else
                {
                    logInRichTextBox1.Clear();
                    logInRichTextBox1.AppendText(portscan);
                }
            }
        }

        private void thirteenButton1_Click_1(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Host");

            }

            else
            {
                WebClient wc = new WebClient { };
                string lookup = wc.DownloadString($"http://ip-api.com/json/{tbHost.Text}?fields=16989721");
                if (lookup == tbHost.Text)
                {
                    MessageBox.Show("Invalid Host!");
                }

                else
                {
                    JObject trace = JObject.Parse(lookup);
                    string final = $"IP - {trace["query"]}\r\nISP - {trace["isp"]}\r\nOrganization - {trace["org"]}\r\nAS - {trace["as"]}\r\nReverse DNS/Hostname - {trace["reverse"]}\r\nCity - {trace["city"]}\r\nRegion/State - {trace["regionName"]}\r\nCountry - {trace["country"]}\r\nMobile? - {trace["mobile"]}\r\nProxy/VPN? - {trace["proxy"]}\r\nHosting? - {trace["hosting"]}";
                    logInRichTextBox1.Clear();
                    logInRichTextBox1.AppendText(final);
                }
            }
        }

        private void thirteenButton2_Click_1(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    FileName = "ping.exe",
                    Arguments = tbHost.Text + " -t"
                }
            }.Start();
        }

        private void thirteenButton3_Click(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Host!");

            }

            if (tbPort.Text == "Port")
            {
                MessageBox.Show("Enter A Port!");

            }

            else
            {
                new Process
                {
                    StartInfo =
                {
                    UseShellExecute = false,
                    FileName = Application.StartupPath + @"\paping.exe",
                    Arguments = tbHost.Text + " -p " + tbPort.Text
                }
                }.Start();
            }
        }

        private void thirteenButton4_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { };
            string ipv4 = wc.DownloadString($"https://api.ipify.org/?format=plain");
            logInRichTextBox1.Clear();
            string final = $"Your IPv4 Is - {ipv4}";
            logInRichTextBox1.AppendText(final);
        }

        private void thirteenButton5_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { };
            string ipv6 = wc.DownloadString($"https://api64.ipify.org?format=plain");
            logInRichTextBox1.Clear();
            string final = $"Your IPv6 Is - {ipv6}";
            logInRichTextBox1.AppendText(final);
        }

        private void thirteenButton6_Click(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Domain!");

            }

            else
            {
                WebClient wc = new WebClient { };
                string dns = wc.DownloadString($"https://api.hackertarget.com/dnslookup/?q={tbHost.Text}");

                if (dns == "error input invalid - enter IP or Hostname")
                {
                    MessageBox.Show("Invalid Domain!");
                }

                if (dns == "try reverse dns tool for ipaddress")
                {
                    MessageBox.Show("Use Domain, Not IP!");
                }

                else
                {
                    logInRichTextBox1.Clear();
                    logInRichTextBox1.AppendText(dns);
                }
            }
        }

        private void thirteenButton7_Click(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Host/Domain");

            }
            
            else
            {
                MessageBox.Show("Please Wait While We Send Packets");

                WebClient wc = new WebClient { };
                string tracert = wc.DownloadString($"https://api.hackertarget.com/mtr/?q={tbHost.Text}");

                if (tracert == "error input invalid - enter IP or Hostname")
                {
                    MessageBox.Show("Invalid Host/Domain");
                }

                else
                {
                    logInRichTextBox1.Clear();
                    logInRichTextBox1.AppendText(tracert);
                }
            }
        }

        private void thirteenButton8_Click(object sender, EventArgs e)
        {
            if (tbHost.Text == "Host/Domain")
            {
                MessageBox.Show("Enter A Host");
            }

            else
            {
                WebClient wc = new WebClient { };
                string subnet = wc.DownloadString($"https://api.hackertarget.com/subnetcalc/?q={tbHost.Text}");

                if (subnet == "error check your api query")
                {
                    MessageBox.Show("Invalid Host");
                }

                else
                {
                    logInRichTextBox1.AppendText(subnet);
                }
            }

        }

        private void xRails_Label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

		private void thirteenButton8_Click_1(object sender, EventArgs e)
		{
            Clipboard.SetText(logInRichTextBox1.Text);

			MessageBox.Show("Results Copied To Clipboard");
		}
	}
}
