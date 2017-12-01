using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace BitcoinAddressViewer
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient HTTP_CLIENT = new HttpClient();

        private static readonly string BTC_ADDRESS_API = "https://chain.api.btc.com/v3/address/";
        private static readonly string BCH_ADDRESS_API = "https://bch-chain.api.btc.com/v3/address/";

        private List<string> addressBTC;
        private List<Address> btc;

        private List<string> addressBCH;
        private List<Address> bch;

        public MainForm()
        {
            InitializeComponent();
        }

        #region BTC

        private void ButtonRefreshBTC_Click(object sender, EventArgs e)
        {
            LoadAddressBTC();
            RetrieveAddressBTC();
            UpdateFinalBalanceBTC();
            dataGridViewBTC.DataSource = btc;
        }

        private void LoadAddressBTC()
        {
            try
            {
                addressBTC = new List<string>();
                using (StreamReader sr = new StreamReader("btc.address"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        addressBTC.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Load BTC address error.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetrieveAddressBTC()
        {
            try
            {
                btc = new List<Address>();
                if (addressBTC.Count == 0)
                {
                    return;
                }
                HttpResponseMessage response = HTTP_CLIENT.GetAsync(BTC_ADDRESS_API + string.Join(",", addressBTC)).Result;
                string json = "";
                if (response.IsSuccessStatusCode)
                {
                    json = response.Content.ReadAsStringAsync().Result;
                    if (addressBTC.Count == 1)
                    {
                        var result = JsonConvert.DeserializeObject<SingleAddressAPICallResult<Address>>(json);
                        if (result.IsSuccessServerResponse())
                        {
                            if (result.Data != null)
                            {
                                btc.Add(result.Data);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Retrieve BTC data from server error.\n" + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        var result = JsonConvert.DeserializeObject<MultiAddressAPICallResult<Address>>(json);
                        if (result.IsSuccessServerResponse())
                        {
                            foreach (var item in result.Data)
                            {
                                if (item != null)
                                {
                                    btc.Add(item);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Retrieve BTC data from server error.\n" + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Retrieve BTC data from server error.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFinalBalanceBTC()
        {
            long finalBalance = 0;
            foreach (var element in btc)
            {
                finalBalance += element.Balance;
            }
            labelFinalBalanceBTC.Text = (finalBalance / 100000000.0).ToString("0.00000000");
        }

        #endregion

        #region BCH

        private void ButtonRefreshBCH_Click(object sender, EventArgs e)
        {
            LoadAddressBCH();
            RetrieveAddressBCH();
            UpdateFinalBalanceBCH();
            dataGridViewBCH.DataSource = bch;
        }

        private void LoadAddressBCH()
        {
            try
            {
                addressBCH = new List<string>();
                using (StreamReader sr = new StreamReader("bch.address"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        addressBCH.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Load BCH address error.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetrieveAddressBCH()
        {
            try
            {
                bch = new List<Address>();
                if (addressBCH.Count == 0)
                {
                    return;
                }
                HttpResponseMessage response = HTTP_CLIENT.GetAsync(BCH_ADDRESS_API + string.Join(",", addressBCH)).Result;
                string json = "";
                if (response.IsSuccessStatusCode)
                {
                    json = response.Content.ReadAsStringAsync().Result;
                    if (addressBCH.Count == 1)
                    {
                        var result = JsonConvert.DeserializeObject<SingleAddressAPICallResult<Address>>(json);
                        if (result.IsSuccessServerResponse())
                        {
                            if (result.Data != null)
                            {
                                bch.Add(result.Data);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Retrieve BCH data from server error.\n" + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        var result = JsonConvert.DeserializeObject<MultiAddressAPICallResult<Address>>(json);
                        if (result.IsSuccessServerResponse())
                        {
                            foreach (var item in result.Data)
                            {
                                if (item != null)
                                {
                                    bch.Add(item);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Retrieve BCH data from server error.\n" + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Retrieve BCH data from server error.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFinalBalanceBCH()
        {
            long finalBalance = 0;
            foreach (var element in bch)
            {
                finalBalance += element.Balance;
            }
            labelFinalBalanceBCH.Text = (finalBalance / 100000000.0).ToString("0.00000000");
        }

        #endregion        
    }
}
