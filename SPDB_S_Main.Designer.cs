namespace SPDB_Server
{
    partial class SPDB_S_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_IP = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Count = new System.Windows.Forms.Label();
            this.pictureBox_Draw = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Picture = new System.Windows.Forms.Button();
            this.btn_Black = new System.Windows.Forms.Button();
            this.btn_White = new System.Windows.Forms.Button();
            this.btn_Pink = new System.Windows.Forms.Button();
            this.btn_Cyan = new System.Windows.Forms.Button();
            this.btn_Green = new System.Windows.Forms.Button();
            this.btn_Orange = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Yellow = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Oval = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Words = new System.Windows.Forms.Button();
            this.btn_Eraser = new System.Windows.Forms.Button();
            this.btn_Pen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox_BG = new System.Windows.Forms.PictureBox();
            this.label_Size = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.label_Mode = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BG)).BeginInit();
            this.SuspendLayout();
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_IP.Location = new System.Drawing.Point(48, 14);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(145, 16);
            this.label_IP.TabIndex = 54;
            this.label_IP.Text = "IP :  000.000.000.000";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Start.Location = new System.Drawing.Point(419, 8);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(92, 29);
            this.btn_Start.TabIndex = 57;
            this.btn_Start.Text = "開啟畫板";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(225, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "暱稱";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_Name.Location = new System.Drawing.Point(271, 9);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(129, 27);
            this.textBox_Name.TabIndex = 59;
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Enabled = false;
            this.label_Count.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_Count.Location = new System.Drawing.Point(570, 14);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(100, 16);
            this.label_Count.TabIndex = 58;
            this.label_Count.Text = "在線人數： 0";
            // 
            // pictureBox_Draw
            // 
            this.pictureBox_Draw.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Draw.Enabled = false;
            this.pictureBox_Draw.Location = new System.Drawing.Point(134, 46);
            this.pictureBox_Draw.Name = "pictureBox_Draw";
            this.pictureBox_Draw.Size = new System.Drawing.Size(590, 400);
            this.pictureBox_Draw.TabIndex = 88;
            this.pictureBox_Draw.TabStop = false;
            this.pictureBox_Draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseClick);
            this.pictureBox_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseDown);
            this.pictureBox_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseMove);
            this.pictureBox_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(14, 335);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(108, 45);
            this.trackBar1.TabIndex = 87;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_New
            // 
            this.btn_New.Enabled = false;
            this.btn_New.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(14, 401);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(30, 40);
            this.btn_New.TabIndex = 86;
            this.btn_New.Text = "□";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Picture
            // 
            this.btn_Picture.Enabled = false;
            this.btn_Picture.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Picture.Location = new System.Drawing.Point(53, 401);
            this.btn_Picture.Name = "btn_Picture";
            this.btn_Picture.Size = new System.Drawing.Size(30, 40);
            this.btn_Picture.TabIndex = 85;
            this.btn_Picture.Text = "▨";
            this.btn_Picture.UseVisualStyleBackColor = true;
            this.btn_Picture.Click += new System.EventHandler(this.btn_Picture_Click);
            // 
            // btn_Black
            // 
            this.btn_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Black.Enabled = false;
            this.btn_Black.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Black.Location = new System.Drawing.Point(92, 263);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(30, 40);
            this.btn_Black.TabIndex = 84;
            this.btn_Black.UseVisualStyleBackColor = false;
            this.btn_Black.Click += new System.EventHandler(this.btn_Black_Click);
            // 
            // btn_White
            // 
            this.btn_White.BackColor = System.Drawing.Color.White;
            this.btn_White.Enabled = false;
            this.btn_White.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_White.Location = new System.Drawing.Point(53, 263);
            this.btn_White.Name = "btn_White";
            this.btn_White.Size = new System.Drawing.Size(30, 40);
            this.btn_White.TabIndex = 83;
            this.btn_White.UseVisualStyleBackColor = false;
            this.btn_White.Click += new System.EventHandler(this.btn_White_Click);
            // 
            // btn_Pink
            // 
            this.btn_Pink.BackColor = System.Drawing.Color.HotPink;
            this.btn_Pink.Enabled = false;
            this.btn_Pink.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Pink.Location = new System.Drawing.Point(14, 263);
            this.btn_Pink.Name = "btn_Pink";
            this.btn_Pink.Size = new System.Drawing.Size(30, 40);
            this.btn_Pink.TabIndex = 82;
            this.btn_Pink.UseVisualStyleBackColor = false;
            this.btn_Pink.Click += new System.EventHandler(this.btn_Pink_Click);
            // 
            // btn_Cyan
            // 
            this.btn_Cyan.BackColor = System.Drawing.Color.Cyan;
            this.btn_Cyan.Enabled = false;
            this.btn_Cyan.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Cyan.Location = new System.Drawing.Point(92, 221);
            this.btn_Cyan.Name = "btn_Cyan";
            this.btn_Cyan.Size = new System.Drawing.Size(30, 40);
            this.btn_Cyan.TabIndex = 81;
            this.btn_Cyan.UseVisualStyleBackColor = false;
            this.btn_Cyan.Click += new System.EventHandler(this.btn_Cyan_Click);
            // 
            // btn_Green
            // 
            this.btn_Green.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Green.Enabled = false;
            this.btn_Green.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Green.Location = new System.Drawing.Point(53, 221);
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(30, 40);
            this.btn_Green.TabIndex = 80;
            this.btn_Green.UseVisualStyleBackColor = false;
            this.btn_Green.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_Orange
            // 
            this.btn_Orange.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Orange.Enabled = false;
            this.btn_Orange.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Orange.Location = new System.Drawing.Point(14, 221);
            this.btn_Orange.Name = "btn_Orange";
            this.btn_Orange.Size = new System.Drawing.Size(30, 40);
            this.btn_Orange.TabIndex = 79;
            this.btn_Orange.UseVisualStyleBackColor = false;
            this.btn_Orange.Click += new System.EventHandler(this.btn_Orange_Click);
            // 
            // btn_Blue
            // 
            this.btn_Blue.BackColor = System.Drawing.Color.Blue;
            this.btn_Blue.Enabled = false;
            this.btn_Blue.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Blue.Location = new System.Drawing.Point(92, 179);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(30, 40);
            this.btn_Blue.TabIndex = 78;
            this.btn_Blue.UseVisualStyleBackColor = false;
            this.btn_Blue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_Yellow
            // 
            this.btn_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_Yellow.Enabled = false;
            this.btn_Yellow.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Yellow.Location = new System.Drawing.Point(53, 179);
            this.btn_Yellow.Name = "btn_Yellow";
            this.btn_Yellow.Size = new System.Drawing.Size(30, 40);
            this.btn_Yellow.TabIndex = 77;
            this.btn_Yellow.UseVisualStyleBackColor = false;
            this.btn_Yellow.Click += new System.EventHandler(this.btn_Yellow_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.Enabled = false;
            this.btn_Red.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Red.Location = new System.Drawing.Point(14, 179);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(30, 40);
            this.btn_Red.TabIndex = 76;
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Enabled = false;
            this.btn_Rectangle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(92, 106);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(30, 40);
            this.btn_Rectangle.TabIndex = 75;
            this.btn_Rectangle.Text = "⧠";
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Oval
            // 
            this.btn_Oval.Enabled = false;
            this.btn_Oval.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Oval.Location = new System.Drawing.Point(53, 106);
            this.btn_Oval.Name = "btn_Oval";
            this.btn_Oval.Size = new System.Drawing.Size(30, 40);
            this.btn_Oval.TabIndex = 74;
            this.btn_Oval.Text = "⚪";
            this.btn_Oval.UseVisualStyleBackColor = true;
            this.btn_Oval.Click += new System.EventHandler(this.btn_Oval_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.Enabled = false;
            this.btn_Line.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Line.Location = new System.Drawing.Point(14, 106);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(30, 40);
            this.btn_Line.TabIndex = 73;
            this.btn_Line.Text = "／";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Words
            // 
            this.btn_Words.Enabled = false;
            this.btn_Words.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Words.Location = new System.Drawing.Point(92, 63);
            this.btn_Words.Name = "btn_Words";
            this.btn_Words.Size = new System.Drawing.Size(30, 40);
            this.btn_Words.TabIndex = 72;
            this.btn_Words.Text = "A";
            this.btn_Words.UseVisualStyleBackColor = true;
            this.btn_Words.Click += new System.EventHandler(this.btn_Words_Click);
            // 
            // btn_Eraser
            // 
            this.btn_Eraser.Enabled = false;
            this.btn_Eraser.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eraser.Location = new System.Drawing.Point(53, 63);
            this.btn_Eraser.Name = "btn_Eraser";
            this.btn_Eraser.Size = new System.Drawing.Size(30, 40);
            this.btn_Eraser.TabIndex = 71;
            this.btn_Eraser.Text = "⦻";
            this.btn_Eraser.UseVisualStyleBackColor = true;
            this.btn_Eraser.Click += new System.EventHandler(this.btn_Eraser_Click);
            // 
            // btn_Pen
            // 
            this.btn_Pen.Enabled = false;
            this.btn_Pen.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pen.Location = new System.Drawing.Point(14, 63);
            this.btn_Pen.Name = "btn_Pen";
            this.btn_Pen.Size = new System.Drawing.Size(30, 40);
            this.btn_Pen.TabIndex = 70;
            this.btn_Pen.Text = "✎";
            this.btn_Pen.UseVisualStyleBackColor = true;
            this.btn_Pen.Click += new System.EventHandler(this.btn_Pen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(11, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "新畫板";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(11, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "粗細";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "顏色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "模式";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox1.Location = new System.Drawing.Point(142, 536);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 27);
            this.textBox1.TabIndex = 65;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "公開"});
            this.comboBox1.Location = new System.Drawing.Point(14, 537);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 64;
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Send.Location = new System.Drawing.Point(649, 535);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 29);
            this.btn_Send.TabIndex = 63;
            this.btn_Send.Text = "發送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(14, 458);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(710, 68);
            this.listBox1.TabIndex = 62;
            // 
            // pictureBox_BG
            // 
            this.pictureBox_BG.BackColor = System.Drawing.Color.White;
            this.pictureBox_BG.Enabled = false;
            this.pictureBox_BG.Location = new System.Drawing.Point(134, 46);
            this.pictureBox_BG.Name = "pictureBox_BG";
            this.pictureBox_BG.Size = new System.Drawing.Size(590, 400);
            this.pictureBox_BG.TabIndex = 61;
            this.pictureBox_BG.TabStop = false;
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Enabled = false;
            this.label_Size.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_Size.Location = new System.Drawing.Point(89, 311);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(16, 16);
            this.label_Size.TabIndex = 89;
            this.label_Size.Text = "1";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.BackColor = System.Drawing.Color.Black;
            this.label_Color.Enabled = false;
            this.label_Color.Location = new System.Drawing.Point(83, 159);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(29, 12);
            this.label_Color.TabIndex = 90;
            this.label_Color.Text = "　　";
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Enabled = false;
            this.label_Mode.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_Mode.Location = new System.Drawing.Point(69, 42);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(40, 16);
            this.label_Mode.TabIndex = 91;
            this.label_Mode.Text = "鉛筆";
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(92, 401);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(30, 40);
            this.btn_Save.TabIndex = 92;
            this.btn_Save.Text = "⎙";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(89, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 93;
            this.label5.Text = "存檔";
            // 
            // textBox_A
            // 
            this.textBox_A.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox_A.Location = new System.Drawing.Point(154, 70);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(129, 33);
            this.textBox_A.TabIndex = 94;
            this.textBox_A.Visible = false;
            this.textBox_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_A_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SPDB_S_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 572);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label_Mode);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.pictureBox_Draw);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Picture);
            this.Controls.Add(this.btn_Black);
            this.Controls.Add(this.btn_White);
            this.Controls.Add(this.btn_Pink);
            this.Controls.Add(this.btn_Cyan);
            this.Controls.Add(this.btn_Green);
            this.Controls.Add(this.btn_Orange);
            this.Controls.Add(this.btn_Blue);
            this.Controls.Add(this.btn_Yellow);
            this.Controls.Add(this.btn_Red);
            this.Controls.Add(this.btn_Rectangle);
            this.Controls.Add(this.btn_Oval);
            this.Controls.Add(this.btn_Line);
            this.Controls.Add(this.btn_Words);
            this.Controls.Add(this.btn_Eraser);
            this.Controls.Add(this.btn_Pen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox_BG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Count);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label_IP);
            this.Name = "SPDB_S_Main";
            this.Text = "同步繪畫暨討論版 － Sever";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SPDB_S_Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.PictureBox pictureBox_Draw;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Picture;
        private System.Windows.Forms.Button btn_Black;
        private System.Windows.Forms.Button btn_White;
        private System.Windows.Forms.Button btn_Pink;
        private System.Windows.Forms.Button btn_Cyan;
        private System.Windows.Forms.Button btn_Green;
        private System.Windows.Forms.Button btn_Orange;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Yellow;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Oval;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Words;
        private System.Windows.Forms.Button btn_Eraser;
        private System.Windows.Forms.Button btn_Pen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox_BG;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label label_Mode;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Timer timer1;
    }
}

