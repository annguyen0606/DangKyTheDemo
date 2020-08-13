using Firebase.Database;
using Firebase.Database.Query;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dang_Ky_The
{
    public partial class Form1 : Form
    {
        UdpClient udpClient = null;
        IPEndPoint RemoteIP = null;
        String dataUID = "";
        String pathDuLieuTouch = "DulieuTest/";
        String pathDanhSachThe = "AccountDuLieuTest/";

        String pathServer = "https://cloud-nfc-proj.firebaseio.com/";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XYcRpajciWgqrcQNUWovKfSOEUTUFv5hgkyGEvnI",
            BasePath = "https://cloud-nfc-proj.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            udpClient = new UdpClient(6699);
            try
            {
                udpClient.BeginReceive(new AsyncCallback(rev), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("Kết nối với Server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết nối với Server thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            if (cbComPort.Items.Count <= 0)
            {
                btnConnectComPort.Enabled = false;
            }
            else
            {
                btnConnectComPort.Enabled = true;
            }
        }
        void rev(IAsyncResult res)
        {
            try
            {   //Receive data
                RemoteIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] received = udpClient.EndReceive(res, ref RemoteIP);
                dataUID = Encoding.UTF8.GetString(received);
                this.Invoke(new EventHandler(GetIDTag));
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            udpClient.BeginReceive(new AsyncCallback(rev), null);
        }
        private void GetIDTag(object sender, EventArgs e)
        {
            txbUIDTag.Text = dataUID;
        }

        private void BtnConnectComPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            try
            {
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                progressBarX1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, ("Thông Báo"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataUID = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object sender, EventArgs e)
        {
            txbUIDTag.Text = dataUID;
        }

        public class ThongTinThe
        {
            public string uid { get; set; }
            public string name { get; set; }
            public string birth { get; set; }
        }

        private void CbComPort_DropDown(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            if (cbComPort.Items.Count <= 0)
            {
                btnConnectComPort.Enabled = false;
            }
            else
            {
                btnConnectComPort.Enabled = true;
            }
        }

        private async void BtnDangKy_Click(object sender, EventArgs e)
        {
            btnDangKy.Enabled = false;
            btnConnectComPort.Enabled = false;
            if (String.IsNullOrEmpty(txbUIDTag.Text))
            {
                MessageBox.Show("Chưa chạm thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDangKy.Enabled = true;
                btnDangKy.Enabled = true;
                return;
            }

            FirebaseResponse response;
            response = await client.GetAsync(pathDanhSachThe + txbUIDTag.Text);
            if(response.Body == "null")
            {
                var thongTinThe = new ThongTinThe
                {
                    birth = txbDateOfBirth.Text,
                    name = txbNameCustomer.Text,
                    uid = txbUIDTag.Text
                };
                SetResponse setResponse = await client.SetAsync(pathDanhSachThe + txbUIDTag.Text, thongTinThe);
                ThongTinThe result = setResponse.ResultAs<ThongTinThe>();
                if (result.uid.Trim().Equals(txbUIDTag.Text))
                {
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbUIDTag.Text = "";
                    txbNameCustomer.Text = "";
                    txbDateOfBirth.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnConnectComPort.Enabled = true;
            btnDangKy.Enabled = true;
        }
    }
}
