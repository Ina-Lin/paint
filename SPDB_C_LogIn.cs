using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDB_Client
{
    public partial class SPDB_C_LogIn : Form
    {
        public SPDB_C_LogIn()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            var exp = @"^([1-9]|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])$";

            Match m = Regex.Match(textBox_IP.Text, exp);

            if (m.Success)
            {
                try
                {
                    soundOnline(textBox_IP.Text);

                    enable_connect(false);
                    enable_enter(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex);
                }
                
            }
            else
            {
                MessageBox.Show("IP格式錯誤");
            }
        }

        // 自訂方法 : 查看在線人員
        public void soundOnline(string ip)
        {
            byte[] bytes = new byte[1024];

            try
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);

                    int bytesRec = sender.Receive(bytes);
                    string[] users = Encoding.Unicode.GetString(bytes, 0, bytesRec).Split(' ');
                    
                    foreach(string user in users){
                        listBox1.Items.Add(user);
                    }
                    listBox1.Items.RemoveAt(users.Length-1);

                    label2.Text += users.Length - 1;

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (true)
            {
                SPDB_C_Main c_main = new SPDB_C_Main();

                c_main.get_name = textBox_Name.Text;
                c_main.get_severIP = textBox_IP.Text;

                int numOfOnline = listBox1.Items.Count;
                string[] onlineNames = new string[numOfOnline];
                for(int i = 0; i < numOfOnline; i++){
                    onlineNames[i] = listBox1.Items[i].ToString();
                }
                c_main.get_onlineNames = onlineNames;

                this.Visible = false;

                if (c_main.ShowDialog() == DialogResult.OK)
                {
                    c_main.Dispose();
                    this.Close();
                }
            }
        }

        // 自訂方法 : 控制連結列
        private void enable_connect(bool b)
        {
            label1.Enabled = b;
            textBox_IP.Enabled = b;
            btn_Connect.Enabled = b;
        }

        // 自訂方法 : 控制進入區
        private void enable_enter(bool b)
        {
            label2.Enabled = b;
            listBox1.Enabled = b;
            label3.Enabled = b;
            textBox_Name.Enabled = b;
            btn_Enter.Enabled = b;
        }
    }
}
