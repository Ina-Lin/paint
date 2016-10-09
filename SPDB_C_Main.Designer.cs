namespace SPDB_Client
{
    partial class SPDB_C_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_BG = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Pen = new System.Windows.Forms.Button();
            this.btn_Eraser = new System.Windows.Forms.Button();
            this.btn_Words = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Oval = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Cyan = new System.Windows.Forms.Button();
            this.btn_Green = new System.Windows.Forms.Button();
            this.btn_Orange = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Yellow = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Picture = new System.Windows.Forms.Button();
            this.btn_Black = new System.Windows.Forms.Button();
            this.btn_White = new System.Windows.Forms.Button();
            this.btn_Pink = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox_Draw = new System.Windows.Forms.PictureBox();
            this.label_Mode = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.label_Size = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.textBox_A = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_BG
            // 
            this.pictureBox_BG.BackColor = System.Drawing.Color.White;
            this.pictureBox_BG.Location = new System.Drawing.Point(132, 12);
            this.pictureBox_BG.Name = "pictureBox_BG";
            this.pictureBox_BG.Size = new System.Drawing.Size(590, 400);
            this.pictureBox_BG.TabIndex = 0;
            this.pictureBox_BG.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 424);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(710, 68);
            this.listBox1.TabIndex = 1;
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Send.Location = new System.Drawing.Point(647, 501);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 29);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "發送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "公開"});
            this.comboBox1.Location = new System.Drawing.Point(12, 503);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox1.Location = new System.Drawing.Point(140, 502);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "模式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "顏色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(9, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "粗細";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(9, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "新畫板";
            // 
            // btn_Pen
            // 
            this.btn_Pen.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pen.Location = new System.Drawing.Point(12, 29);
            this.btn_Pen.Name = "btn_Pen";
            this.btn_Pen.Size = new System.Drawing.Size(30, 40);
            this.btn_Pen.TabIndex = 9;
            this.btn_Pen.Text = "✎";
            this.btn_Pen.UseVisualStyleBackColor = true;
            this.btn_Pen.Click += new System.EventHandler(this.btn_Pen_Click);
            // 
            // btn_Eraser
            // 
            this.btn_Eraser.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eraser.Location = new System.Drawing.Point(51, 29);
            this.btn_Eraser.Name = "btn_Eraser";
            this.btn_Eraser.Size = new System.Drawing.Size(30, 40);
            this.btn_Eraser.TabIndex = 10;
            this.btn_Eraser.Text = "⦻";
            this.btn_Eraser.UseVisualStyleBackColor = true;
            this.btn_Eraser.Click += new System.EventHandler(this.btn_Eraser_Click);
            // 
            // btn_Words
            // 
            this.btn_Words.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Words.Location = new System.Drawing.Point(90, 29);
            this.btn_Words.Name = "btn_Words";
            this.btn_Words.Size = new System.Drawing.Size(30, 40);
            this.btn_Words.TabIndex = 11;
            this.btn_Words.Text = "A";
            this.btn_Words.UseVisualStyleBackColor = true;
            this.btn_Words.Click += new System.EventHandler(this.btn_Words_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(90, 72);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(30, 40);
            this.btn_Rectangle.TabIndex = 14;
            this.btn_Rectangle.Text = "⧠";
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Oval
            // 
            this.btn_Oval.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Oval.Location = new System.Drawing.Point(51, 72);
            this.btn_Oval.Name = "btn_Oval";
            this.btn_Oval.Size = new System.Drawing.Size(30, 40);
            this.btn_Oval.TabIndex = 13;
            this.btn_Oval.Text = "⚪";
            this.btn_Oval.UseVisualStyleBackColor = true;
            this.btn_Oval.Click += new System.EventHandler(this.btn_Oval_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Line.Location = new System.Drawing.Point(12, 72);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(30, 40);
            this.btn_Line.TabIndex = 12;
            this.btn_Line.Text = "／";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Cyan
            // 
            this.btn_Cyan.BackColor = System.Drawing.Color.Cyan;
            this.btn_Cyan.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Cyan.Location = new System.Drawing.Point(90, 187);
            this.btn_Cyan.Name = "btn_Cyan";
            this.btn_Cyan.Size = new System.Drawing.Size(30, 40);
            this.btn_Cyan.TabIndex = 20;
            this.btn_Cyan.UseVisualStyleBackColor = false;
            this.btn_Cyan.Click += new System.EventHandler(this.btn_Cyan_Click);
            // 
            // btn_Green
            // 
            this.btn_Green.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Green.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Green.Location = new System.Drawing.Point(51, 187);
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(30, 40);
            this.btn_Green.TabIndex = 19;
            this.btn_Green.UseVisualStyleBackColor = false;
            this.btn_Green.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_Orange
            // 
            this.btn_Orange.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Orange.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Orange.Location = new System.Drawing.Point(12, 187);
            this.btn_Orange.Name = "btn_Orange";
            this.btn_Orange.Size = new System.Drawing.Size(30, 40);
            this.btn_Orange.TabIndex = 18;
            this.btn_Orange.UseVisualStyleBackColor = false;
            this.btn_Orange.Click += new System.EventHandler(this.btn_Orange_Click);
            // 
            // btn_Blue
            // 
            this.btn_Blue.BackColor = System.Drawing.Color.Blue;
            this.btn_Blue.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Blue.Location = new System.Drawing.Point(90, 145);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(30, 40);
            this.btn_Blue.TabIndex = 17;
            this.btn_Blue.UseVisualStyleBackColor = false;
            this.btn_Blue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_Yellow
            // 
            this.btn_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_Yellow.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Yellow.Location = new System.Drawing.Point(51, 145);
            this.btn_Yellow.Name = "btn_Yellow";
            this.btn_Yellow.Size = new System.Drawing.Size(30, 40);
            this.btn_Yellow.TabIndex = 16;
            this.btn_Yellow.UseVisualStyleBackColor = false;
            this.btn_Yellow.Click += new System.EventHandler(this.btn_Yellow_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Red.Location = new System.Drawing.Point(12, 145);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(30, 40);
            this.btn_Red.TabIndex = 15;
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(12, 367);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(30, 40);
            this.btn_New.TabIndex = 25;
            this.btn_New.Text = "□";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Picture
            // 
            this.btn_Picture.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Picture.Location = new System.Drawing.Point(51, 367);
            this.btn_Picture.Name = "btn_Picture";
            this.btn_Picture.Size = new System.Drawing.Size(30, 40);
            this.btn_Picture.TabIndex = 24;
            this.btn_Picture.Text = "▨";
            this.btn_Picture.UseVisualStyleBackColor = true;
            this.btn_Picture.Click += new System.EventHandler(this.btn_Picture_Click);
            // 
            // btn_Black
            // 
            this.btn_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Black.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Black.Location = new System.Drawing.Point(90, 229);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(30, 40);
            this.btn_Black.TabIndex = 23;
            this.btn_Black.UseVisualStyleBackColor = false;
            this.btn_Black.Click += new System.EventHandler(this.btn_Black_Click);
            // 
            // btn_White
            // 
            this.btn_White.BackColor = System.Drawing.Color.White;
            this.btn_White.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_White.Location = new System.Drawing.Point(51, 229);
            this.btn_White.Name = "btn_White";
            this.btn_White.Size = new System.Drawing.Size(30, 40);
            this.btn_White.TabIndex = 22;
            this.btn_White.UseVisualStyleBackColor = false;
            this.btn_White.Click += new System.EventHandler(this.btn_White_Click);
            // 
            // btn_Pink
            // 
            this.btn_Pink.BackColor = System.Drawing.Color.HotPink;
            this.btn_Pink.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Pink.Location = new System.Drawing.Point(12, 229);
            this.btn_Pink.Name = "btn_Pink";
            this.btn_Pink.Size = new System.Drawing.Size(30, 40);
            this.btn_Pink.TabIndex = 21;
            this.btn_Pink.UseVisualStyleBackColor = false;
            this.btn_Pink.Click += new System.EventHandler(this.btn_Pink_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 301);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(108, 45);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox_Draw
            // 
            this.pictureBox_Draw.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Draw.Location = new System.Drawing.Point(132, 12);
            this.pictureBox_Draw.Name = "pictureBox_Draw";
            this.pictureBox_Draw.Size = new System.Drawing.Size(590, 400);
            this.pictureBox_Draw.TabIndex = 27;
            this.pictureBox_Draw.TabStop = false;
            this.pictureBox_Draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseClick);
            this.pictureBox_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseDown);
            this.pictureBox_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseMove);
            this.pictureBox_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseUp);
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_Mode.Location = new System.Drawing.Point(67, 8);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(40, 16);
            this.label_Mode.TabIndex = 94;
            this.label_Mode.Text = "鉛筆";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.BackColor = System.Drawing.Color.Black;
            this.label_Color.Location = new System.Drawing.Point(81, 125);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(29, 12);
            this.label_Color.TabIndex = 93;
            this.label_Color.Text = "　　";
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_Size.Location = new System.Drawing.Point(87, 277);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(16, 16);
            this.label_Size.TabIndex = 92;
            this.label_Size.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(87, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 96;
            this.label5.Text = "存檔";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(90, 367);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(30, 40);
            this.btn_Save.TabIndex = 95;
            this.btn_Save.Text = "⎙";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // textBox_A
            // 
            this.textBox_A.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox_A.Location = new System.Drawing.Point(154, 29);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(129, 33);
            this.textBox_A.TabIndex = 97;
            this.textBox_A.Visible = false;
            this.textBox_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_A_KeyDown);
            // 
            // SPDB_C_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 542);
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
            this.Name = "SPDB_C_Main";
            this.Text = "同步繪畫暨討論版 － Clint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SPDB_C_Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_BG;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Pen;
        private System.Windows.Forms.Button btn_Eraser;
        private System.Windows.Forms.Button btn_Words;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Oval;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Cyan;
        private System.Windows.Forms.Button btn_Green;
        private System.Windows.Forms.Button btn_Orange;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Yellow;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Picture;
        private System.Windows.Forms.Button btn_Black;
        private System.Windows.Forms.Button btn_White;
        private System.Windows.Forms.Button btn_Pink;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox_Draw;
        private System.Windows.Forms.Label label_Mode;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox textBox_A;
    }
}