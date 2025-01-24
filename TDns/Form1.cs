using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;

namespace TDns
{
    public partial class Form1 : Form
    {
        private readonly List<Dns> dnsProviders = [];
        private Dns? dns;

        public Form1()
        {
            InitializeComponent();

            dnsProviders = [
                new() { Name = "403", Image = Properties.Resources._403o, Pds = "10.202.10.202", Ads = "10.202.10.102",Link="https://403.online/" },

                new() { Name = "Shecan", Image = Properties.Resources.shecan, Pds = "178.22.122.100", Ads = "185.51.200.2",Link="https://shecan.ir/" },

                new() { Name = "Electro", Image = Properties.Resources.electro, Pds = "78.157.42.101", Ads = "78.157.42.100",Link="https://electrotm.org/" },

                new() { Name = "Tci", Image = Properties.Resources.tci, Pds = "91.239.100.100", Ads = "89.233.43.71",Link="https://www.tci.ir/" },

                new() { Name = "Mci", Image = Properties.Resources.mci, Pds = "208.67.220.200", Ads = "208.67.222.222",Link="https://mci.ir/" },

                new() { Name = "Irancell", Image = Properties.Resources.irancell, Pds = "109.69.8.51", Ads = "74.82.42.42",Link="https://irancell.ir/" },

                new() { Name = "Rightel", Image = Properties.Resources.rightel, Pds = "91.239.100.100", Ads = "89.233.43.71",Link="https://www.rightel.ir/" },

                new() { Name = "Cloudflare", Image = Properties.Resources.cloudflare, Pds = "1.1.1.1", Ads = "1.0.0.1",Link="https://developers.cloudflare.com/1.1.1.1/ip-addresses/#:~:text=1.1.1.1%20is%20Cloudflare%E2%80%99s" },

                new() { Name = "Google", Image = Properties.Resources.google, Pds = "8.8.8.8", Ads = "8.8.4.4",Link="https://developers.google.com/speed/public-dns/" },

                new() { Name = "Quad9", Image = Properties.Resources.quad9, Pds = "9.9.9.9", Ads = "149.112.112.112",Link="https://www.quad9.net/" },

                new() { Name = "Spotify", Image = Properties.Resources.spotify, Pds = "78.157.42.100", Ads = "10.202.10.11",Link="https://spotify.com" },
            ];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var dnss in dnsProviders)
            {
                Cmx_Dns.Items.Add(dnss.Name);
            }
            Cmx_Dns.SelectedIndex = 0;

            Dns dns = dnsProviders[0];

            byte[] imageBytes = dns.Image;
            using MemoryStream ms = new(imageBytes);
            Pic_Dns.Image = Image.FromStream(ms);

            Lbl_Dnsname.Text = dns.Name;

            pds1.Text = dns.Pds.Split(".")[0].ToString();
            pds2.Text = dns.Pds.Split(".")[1].ToString();
            pds3.Text = dns.Pds.Split(".")[2].ToString();
            pds4.Text = dns.Pds.Split(".")[3].ToString();

            ads1.Text = dns.Ads.Split(".")[0].ToString();
            ads2.Text = dns.Ads.Split(".")[1].ToString();
            ads3.Text = dns.Ads.Split(".")[2].ToString();
            ads4.Text = dns.Ads.Split(".")[3].ToString();
        }

        private void CmxDnses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Cmx_Dns.SelectedIndex;

            dns = dnsProviders[index];

            using MemoryStream memoryStream = new(dns.Image);
            Pic_Dns.Image = Image.FromStream(memoryStream);

            Lbl_Dnsname.Text = dns.Name;

            pds1.Text = dns.Pds.Split(".")[0].ToString();
            pds2.Text = dns.Pds.Split(".")[1].ToString();
            pds3.Text = dns.Pds.Split(".")[2].ToString();
            pds4.Text = dns.Pds.Split(".")[3].ToString();

            ads1.Text = dns.Ads.Split(".")[0].ToString();
            ads2.Text = dns.Ads.Split(".")[1].ToString();
            ads3.Text = dns.Ads.Split(".")[2].ToString();
            ads4.Text = dns.Ads.Split(".")[3].ToString();
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            int index = Cmx_Dns.SelectedIndex;
            Dns dns = dnsProviders[index];

            string[] dnsServers = [dns.Pds, dns.Ads];

            string networkAdapterName = GetActiveNetworkAdapterName();

            if (!string.IsNullOrEmpty(networkAdapterName))
            {
                SetDnsServers(networkAdapterName, dnsServers);
                this.Text = dns.Name + " - TDns";
                MessageBox.Show("DNS Set!", dns.Name + " (By nuclearHesam)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Disconnect!", "Please Connect to Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string GetActiveNetworkAdapterName()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    foreach (var gateway in ni.GetIPProperties().GatewayAddresses)
                    {
                        if (gateway.Address.ToString() != "0.0.0.0")
                        {
                            return ni.Description;
                        }
                    }
                }
            }
            return null;
        }

        static void SetDnsServers(string networkAdapterName, string[] dnsServers)
        {
            try
            {
                ManagementClass networkConfigMng = new("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection networkConfigs = networkConfigMng.GetInstances();

                foreach (ManagementObject networkConfig in networkConfigs)
                {
                    if ((bool)networkConfig["IPEnabled"])
                    {
                        if (networkConfig["Description"].ToString().Equals(networkAdapterName, StringComparison.OrdinalIgnoreCase))
                        {
                            ManagementBaseObject newDns = networkConfig.GetMethodParameters("SetDNSServerSearchOrder");
                            newDns["DNSServerSearchOrder"] = dnsServers;
                            ManagementBaseObject setDns = networkConfig.InvokeMethod("SetDNSServerSearchOrder", newDns, null);

                            uint returnValue = (uint)setDns["ReturnValue"];
                            if (returnValue == 0)
                            {
                                Console.WriteLine("DNS سرورها با موفقیت تنظیم شدند.");
                            }
                            else
                            {
                                Console.WriteLine($"خطا در تنظیم DNS سرورها. کد خطا: {returnValue}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطا در تنظیم DNS سرورها: {ex.Message}");
            }
        }

        private void BtnUnset_Click(object sender, EventArgs e)
        {
            string networkAdapterName = GetActiveNetworkAdapterName();

            if (!string.IsNullOrEmpty(networkAdapterName))
            {
                bool success = ResetDnsServers(networkAdapterName);
                if (success)
                {
                    MessageBox.Show("DNS settings reset to default.", "DNS Reset!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Text = "TDns";
                }
                else
                {
                    MessageBox.Show("Failed to reset DNS servers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Connect to Internet", "Disconnect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool ResetDnsServers(string networkAdapterName)
        {
            try
            {
                ManagementClass networkConfigMng = new("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection networkConfigs = networkConfigMng.GetInstances();

                foreach (ManagementObject networkConfig in networkConfigs)
                {
                    if ((bool)networkConfig["IPEnabled"])
                    {
                        if (networkConfig["Description"].ToString().Equals(networkAdapterName, StringComparison.OrdinalIgnoreCase))
                        {
                            ManagementBaseObject newDns = networkConfig.GetMethodParameters("SetDNSServerSearchOrder");
                            newDns["DNSServerSearchOrder"] = null;
                            ManagementBaseObject setDns = networkConfig.InvokeMethod("SetDNSServerSearchOrder", newDns, null);

                            uint returnValue = (uint)setDns["ReturnValue"];
                            if (returnValue == 0)
                            {
                                Console.WriteLine("DNS سرورها به تنظیمات پیش‌فرض بازگردانده شدند.");
                                return true;
                            }
                            else
                            {
                                Console.WriteLine($"خطا در بازگرداندن تنظیمات DNS. کد خطا: {returnValue}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطا در بازگرداندن تنظیمات DNS: {ex.Message}");
            }
            return false;
        }

        private void Pic_Dns_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = dns.Link,
                UseShellExecute = true // برای اطمینان از باز شدن لینک در مرورگر پیش‌فرض
            });
        }
    }
}