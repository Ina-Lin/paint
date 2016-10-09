using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDB_Server
{
    public partial class SPDB_S_Main : Form
    {
        private string name;

        private Thread soundThread;
        private Thread othread;
        private IPAddress SvrIP;
        private List<SPDB_Socket> clientList;
        private StrHandler msgHandler;
        private Socket handler;

        private string mode;
        private Color color;
        private int size;
        private int x0, y0;
        private Bitmap bg;
        private Bitmap dg;
        private Graphics g;
        private Pen p;

        public SPDB_S_Main()
        {
            InitializeComponent();

            // Sever IP
            SvrIP = new System.Net.IPAddress(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].Address);
            label_IP.Text = "IP : " + SvrIP.ToString();

            // 繪圖板初始化
            pictureBox_Draw.Parent = pictureBox_BG;
            pictureBox_Draw.Location = new Point(0, 0);
            pictureBox_BG.Image = Image.FromFile(Application.StartupPath + "\\null.jpg");
            pictureBox_Draw.Image = new Bitmap(590, 400);

            // 文字工具初始化
            textBox_A.Parent = pictureBox_Draw;

            // 模式初始化
            mode = "鉛筆";
            color = Color.Black;
            size = 1;

            // 聊天對象初始化
            comboBox1.SelectedIndex = 0;

            // 委派處理文字
            msgHandler = this.dealMsg;
        }

        // 視窗關閉
        private void SPDB_S_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopListening();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "開啟畫板")
            {
                if (textBox_Name.Text == "")
                {
                    MessageBox.Show("請輸入暱稱");
                }
                else
                {
                    enable_start(false);
                    enable_paint(true);

                    // 開啟監聽
                    try
                    {
                        // 開啟連接監聽 (11000)
                        soundThread = new Thread(soundListening);
                        soundThread.IsBackground = true;
                        soundThread.Start();

                        // 開啟討論版監聽 (4427)
                        clientList = new List<SPDB_Socket>();
                        othread = new Thread(StartListening);
                        othread.IsBackground = true;
                        othread.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex);
                    }
                }
            }
            else        // "關閉畫板"
            {
                DialogResult dialogResult = MessageBox.Show("您確定要關閉畫板嗎？", "關閉畫板", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    StopListening();
                    pictureBox_BG.Image = Image.FromFile(Application.StartupPath + "\\null.jpg");
                    pictureBox_Draw.Image = new Bitmap(590, 400);
                    listBox1.Items.Clear();
                    enable_start(true);
                    enable_paint(false);
                }
            }
        }

        // 自訂方法: 開啟連接監聽
        private void soundListening()
        {
            byte[] bytes = new Byte[1024];
            IPEndPoint localEndPoint = new IPEndPoint(SvrIP, 11000);
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Socket handler = listener.Accept();

                    byte[] msg = Encoding.Unicode.GetBytes(getAllClient());

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            MessageBox.Show("\nPress ENTER to continue...");

        }

        // 自訂方法: 所有線上使用者名稱
        private string getAllClient()
        {
            string s = name + " ";
            foreach (SPDB_Socket client in clientList)
            {
                s += client.userName + " ";
            }
            return s;
        }

        // 自訂方法: 開啟討論版監聽
        private void StartListening()
        {
            name = textBox_Name.Text + "(Sever)";

            IPEndPoint localEndPoint = new IPEndPoint(SvrIP, 4427);
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    handler = listener.Accept();
                    SPDB_Socket client = new SPDB_Socket(handler);

                    try
                    {
                        clientList.Add(client);
                        client.newListener(processMsgComeIn);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // 自訂方法: 關閉監聽
        private void StopListening()
        {       
            if (handler != null)
            {
                handler.Close();
            }
        }

        // 自訂方法: 收到訊息
        private String processMsgComeIn(String msg)
        {
            this.Invoke(msgHandler, new Object[] { msg });
            broadCast(msg);

            return "OK";
        }

        // 自訂方法: 對所有廣播
        private void broadCast(String msg)
        {
            foreach (SPDB_Socket client in clientList)
            {
                client.send(msg);
            }
        }

        // 自訂方法: 處理訊息
        private String dealMsg(String msg)
        {
            string[] act = msg.Split(new char[] { '#' }, 2);

            switch (act[0])
            {
                case "Enter":
                    listBox1.Items.Add(act[1] + " 進入討論板");
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    comboBox1.Items.Add(act[1]);
                    label_Count.Text = "在線人數： " + (clientList.Count + 1);
                    clientList[clientList.Count - 1].userName = act[1];
                    break;

                case "Leave":
                    listBox1.Items.Add(act[1] + " 離開討論板");
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    comboBox1.Items.Remove(act[1]);
                    foreach (SPDB_Socket client in clientList)
                    {
                        if (client.userName == act[1])
                        {
                            clientList.Remove(client);
                            break;
                        }
                    }
                    label_Count.Text = "在線人數： " + (clientList.Count + 1);
                    break;

                case "Mes":
                    listBox1.Items.Add(act[1]);
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    break;

                case "Pri":
                    string[] reciver = act[1].Split('/');
                    if (reciver[0] == name)
                    {
                        listBox1.Items.Add(reciver[1]);
                        listBox1.TopIndex = listBox1.Items.Count - 1;
                    }
                    break;

                case "Line":
                    string[] infoL = act[1].Split('/');
                    if (infoL[0] != name)
                    {
                        g = Graphics.FromImage(pictureBox_Draw.Image);
                        p = new Pen(dealColor(infoL[1]), Convert.ToInt32(infoL[2]));
                        g.DrawLine(p, Convert.ToInt32(infoL[3]), Convert.ToInt32(infoL[4]),
                                      Convert.ToInt32(infoL[5]), Convert.ToInt32(infoL[6]));
                        pictureBox_Draw.Refresh();
                    }
                    break;

                case "Eras":
                    string[] infoE = act[1].Split('/');
                    if (infoE[0] != name)
                    {
                        this.bg = new Bitmap(pictureBox_BG.Image);
                        Color tempC = bg.GetPixel(Convert.ToInt32(infoE[2]), Convert.ToInt32(infoE[3]));
                        g = Graphics.FromImage(pictureBox_Draw.Image);
                        p = new Pen(tempC, Convert.ToInt32(infoE[1]));
                        g.DrawLine(p, Convert.ToInt32(infoE[2]), Convert.ToInt32(infoE[3]),
                                      Convert.ToInt32(infoE[4]), Convert.ToInt32(infoE[5]));
                        pictureBox_Draw.Refresh();
                    }
                    break;

                case "Oval":
                    string[] infoO = act[1].Split('/');
                    if (infoO[0] != name)
                    {
                        g = Graphics.FromImage(pictureBox_Draw.Image);
                        p = new Pen(dealColor(infoO[1]), Convert.ToInt32(infoO[2]));
                        g.DrawEllipse(p, Convert.ToInt32(infoO[3]), Convert.ToInt32(infoO[4]),
                                      Convert.ToInt32(infoO[5]), Convert.ToInt32(infoO[6]));
                        pictureBox_Draw.Refresh();
                    }
                    break;

                case "Rect":
                    string[] infoR = act[1].Split('/');
                    if (infoR[0] != name)
                    {
                        g = Graphics.FromImage(pictureBox_Draw.Image);
                        p = new Pen(dealColor(infoR[1]), Convert.ToInt32(infoR[2]));
                        g.DrawRectangle(p, Convert.ToInt32(infoR[3]), Convert.ToInt32(infoR[4]),
                                      Convert.ToInt32(infoR[5]), Convert.ToInt32(infoR[6]));
                        pictureBox_Draw.Refresh();
                    }
                    break;

                case "Word":
                    string[] infoW = act[1].Split('/');
                    if (infoW[0] != name)
                    {
                        g = Graphics.FromImage(pictureBox_Draw.Image);
                        g.DrawString(infoW[3], new Font("新細明體", Convert.ToInt32(infoW[2])), new SolidBrush(dealColor(infoW[1])),
                                     Convert.ToInt32(infoW[4]), Convert.ToInt32(infoW[5]));
                        pictureBox_Draw.Refresh();
                    }
                    break;

                case "goNew":
                    newPic();
                    break;
            }

            return "OK";
        }

        // 自訂方法: 字串轉顏色
        private Color dealColor(String sColor)
        {
            return Color.FromName(sColor.Split('[')[1].Split(']')[0]);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string sendMode = comboBox1.SelectedItem.ToString();

            if (sendMode == "公開")
            {
                broadCast("Mes#" + name + " : " + textBox1.Text);
                listBox1.Items.Add(name + " : " + textBox1.Text);
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                broadCast("Pri#" + sendMode + "/[私人訊息] " + name + " : " + textBox1.Text);
                listBox1.Items.Add("[私人訊息] " + name + " : " + textBox1.Text);
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }

            
            textBox1.Text = "";
        }

        // 自訂方法: 連線設定
        private void enable_start(bool b)
        {
            textBox_Name.Enabled = b;
            if (b)
            {
                btn_Start.Text = "開啟畫板";
            }
            else
            {
                btn_Start.Text = "關閉畫板";
            }
        }

        // 自訂方法: 討論版設定
        private void enable_paint(bool b)
        {
            if (b)
            {
                label_Count.Text = "在線人數： 1";
            }
            else
            {
                label_Count.Text = "在線人數： 0";
            }
            label_Count.Enabled = b;
            label1.Enabled = b;
            label2.Enabled = b;
            label3.Enabled = b;
            label4.Enabled = b;
            label5.Enabled = b;
            label_Mode.Enabled = b;
            label_Color.Enabled = b;
            label_Size.Enabled = b;
            btn_Pen.Enabled = b;
            btn_Eraser.Enabled = b;
            btn_Words.Enabled = b;
            btn_Line.Enabled = b;
            btn_Oval.Enabled = b;
            btn_Rectangle.Enabled = b;
            btn_Red.Enabled = b;
            btn_Yellow.Enabled = b;
            btn_Blue.Enabled = b;
            btn_Orange.Enabled = b;
            btn_Green.Enabled = b;
            btn_Cyan.Enabled = b;
            btn_Pink.Enabled = b;
            btn_White.Enabled = b;
            btn_Black.Enabled = b;
            trackBar1.Enabled = b;
            btn_New.Enabled = b;
            btn_Picture.Enabled = b;
            btn_Save.Enabled = b;
            listBox1.Enabled = b;
            comboBox1.Enabled = b;
            textBox1.Enabled = b;
            btn_Send.Enabled = b;
            pictureBox_BG.Enabled = b;
            pictureBox_Draw.Enabled = b;
        }

        /** 模式 */
        private void btn_Pen_Click(object sender, EventArgs e)
        {
            change_mode("鉛筆");
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            change_mode("橡皮擦");
        }

        private void btn_Words_Click(object sender, EventArgs e)
        {
            change_mode("字");
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            change_mode("直線");
        }

        private void btn_Oval_Click(object sender, EventArgs e)
        {
            change_mode("橢圓");
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            change_mode("矩形");
        }

        // 自訂方法: 切換模式
        private void change_mode(string mode)
        {
            this.mode = mode;
            label_Mode.Text = mode;
        }

        /** 顏色 */
        private void btn_Red_Click(object sender, EventArgs e)
        {
            change_color(Color.Red);
        }

        private void btn_Yellow_Click(object sender, EventArgs e)
        {
            change_color(Color.Yellow);
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            change_color(Color.Blue);
        }

        private void btn_Orange_Click(object sender, EventArgs e)
        {
            change_color(Color.DarkOrange);
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            change_color(Color.LimeGreen);
        }

        private void btn_Cyan_Click(object sender, EventArgs e)
        {
            change_color(Color.Cyan);
        }

        private void btn_Pink_Click(object sender, EventArgs e)
        {
            change_color(Color.HotPink);
        }

        private void btn_White_Click(object sender, EventArgs e)
        {
            change_color(Color.White);
        }

        private void btn_Black_Click(object sender, EventArgs e)
        {
            change_color(Color.Black);
        }

        // 自訂方法: 切換顏色
        private void change_color(Color color)
        {
            this.color = color;
            label_Color.BackColor = color;
        }

        /** 粗細 */
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.size = trackBar1.Value + 1;
            label_Size.Text = size.ToString();
        }

        /** 新畫板 */
        private void btn_New_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("您確定要開啟新的畫板嗎？", "開新畫板", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                newPic();
            }
        }

        private void newPic()
        {
            timer1.Enabled = true;
        }

        private void btn_Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "選擇圖檔";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "jpg 檔 (*.jpg*)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_BG.Image = Image.FromFile(dialog.FileName);
                pictureBox_Draw.Image = new Bitmap(590, 400);
            }
        }

        /** 儲存 */
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "儲存圖檔";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "jpg 檔 (*.jpg*)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 合併儲存
                Bitmap mergePic = new Bitmap(pictureBox_BG.Image);
                Graphics p_copy = Graphics.FromImage(mergePic);
                p_copy.DrawImage(pictureBox_Draw.Image, new Point(0, 0));
                mergePic.Save(dialog.FileName, ImageFormat.Jpeg);
            }

        }

        /** 繪畫 */
        private void pictureBox_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            this.x0 = e.X;
            this.y0 = e.Y;
            this.bg = new Bitmap(pictureBox_BG.Image);
            this.dg = new Bitmap(pictureBox_Draw.Image);
        }

        private void pictureBox_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (mode)
                {
                    case "鉛筆":
                        g = Graphics.FromImage(pictureBox_Draw.Image);
                        p = new Pen(color, size);
                        g.DrawLine(p, x0, y0, e.X, e.Y);
                        broadCast("Line#" + name + "/" + color + "/" + size + "/" +
                                              x0 + "/" + y0 + "/" + e.X + "/" + e.Y);
                        x0 = e.X;
                        y0 = e.Y;
                        pictureBox_Draw.Refresh();
                        break;

                    case "橡皮擦":
                        g = Graphics.FromImage(pictureBox_Draw.Image);
                        p = new Pen(bg.GetPixel(x0, y0), size);
                        g.DrawLine(p, x0, y0, e.X, e.Y);
                        broadCast("Eras#" + name + "/" + size + "/" + x0 + "/" + y0 + "/" + e.X + "/" + e.Y);
                        x0 = e.X;
                        y0 = e.Y;
                        pictureBox_Draw.Refresh();
                        break;

                    case "直線":
                        Bitmap bf_Line = new Bitmap(dg);
                        Graphics fg_Line = Graphics.FromImage(bf_Line);
                        p = new Pen(color, size);
                        fg_Line.DrawLine(p, x0, y0, e.X, e.Y);
                        pictureBox_Draw.Image = bf_Line;
                        break;

                    case "橢圓":
                        Bitmap bf_Oval = new Bitmap(dg);
                        Graphics fg_Oval = Graphics.FromImage(bf_Oval);
                        p = new Pen(color, size);
                        fg_Oval.DrawEllipse(p, x0, y0, e.X - x0, e.Y - y0);
                        pictureBox_Draw.Image = bf_Oval;
                        break;

                    case "矩形":
                        Bitmap bf_Rectangle = new Bitmap(dg);
                        Graphics fg_Rectangle = Graphics.FromImage(bf_Rectangle);
                        p = new Pen(color, size);
                        fg_Rectangle.DrawRectangle(p, x0, y0, e.X-x0, e.Y-y0);
                        pictureBox_Draw.Image = bf_Rectangle;
                        break;

                } 
            }
        }

        private void pictureBox_Draw_MouseClick(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case "字":
                    textBox_A.Location = new Point(e.X, e.Y);
                    textBox_A.Visible = true;
                    break;
            }
        }

        private void textBox_A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                g = Graphics.FromImage(pictureBox_Draw.Image);
                int tempS = 16 + size * 5;
                g.DrawString(textBox_A.Text, new Font("新細明體", tempS), new SolidBrush(color), textBox_A.Location.X, textBox_A.Location.Y);
                broadCast("Word#" + name + "/" + color + "/" + tempS + "/" + textBox_A.Text + "/" + textBox_A.Location.X + "/" + textBox_A.Location.Y);
                pictureBox_Draw.Refresh();
                textBox_A.Text = "";
                textBox_A.Visible = false;
            }
        }

        private void pictureBox_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (mode)
                {
                    case "直線":
                        broadCast("Line#" + name + "/" + color + "/" + size + "/" +
                                              x0 + "/" + y0 + "/" + e.X + "/" + e.Y);
                        break;

                    case "橢圓":
                        broadCast("Oval#" + name + "/" + color + "/" + size + "/" +
                                              x0 + "/" + y0 + "/" + (e.X - x0) + "/" + (e.Y - y0));
                        break;

                    case "矩形":
                        broadCast("Rect#" + name + "/" + color + "/" + size + "/" +
                                              x0 + "/" + y0 + "/" + (e.X - x0) + "/" + (e.Y - y0));
                        break;
                }
            }
        }

        // 自訂方法 : 更換新畫布倒數
        private int sec = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                broadCast("New#");
                pictureBox_BG.Image = Image.FromFile(Application.StartupPath + "\\null.jpg");
                pictureBox_Draw.Image = new Bitmap(590, 400);
                timer1.Enabled = false;
                sec = 5;
                return;
            }
            broadCast("Mes#" + sec + " 後更換新畫布");
            listBox1.Items.Add(sec + " 後更換新畫布");
            listBox1.TopIndex = listBox1.Items.Count - 1;
            sec--;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Send.Focus();
                btn_Send_Click(sender, e);
                textBox1.Focus();
            }
        }
    }
}
