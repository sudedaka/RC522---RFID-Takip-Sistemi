namespace SudeTeslimeDaka_YonlendirilmisCalisma
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Bagla = new System.Windows.Forms.Button();
            this.btn_Kes = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gln_Veri = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.status_pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sude Teslime DAKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFID Kart Okuyucu";
            // 
            // btn_Bagla
            // 
            this.btn_Bagla.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Bagla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Bagla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Bagla.Location = new System.Drawing.Point(6, 23);
            this.btn_Bagla.Name = "btn_Bagla";
            this.btn_Bagla.Size = new System.Drawing.Size(129, 29);
            this.btn_Bagla.TabIndex = 2;
            this.btn_Bagla.Text = "BAĞLA";
            this.btn_Bagla.UseVisualStyleBackColor = false;
            this.btn_Bagla.Click += new System.EventHandler(this.btn_Bagla_Click);
            // 
            // btn_Kes
            // 
            this.btn_Kes.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Kes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Kes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Kes.Location = new System.Drawing.Point(6, 58);
            this.btn_Kes.Name = "btn_Kes";
            this.btn_Kes.Size = new System.Drawing.Size(129, 29);
            this.btn_Kes.TabIndex = 3;
            this.btn_Kes.Text = "KES";
            this.btn_Kes.UseVisualStyleBackColor = false;
            this.btn_Kes.Click += new System.EventHandler(this.btn_Kes_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadBufferSize = 2048;
            this.serialPort1.WriteBufferSize = 8192;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // gln_Veri
            // 
            this.gln_Veri.AutoSize = true;
            this.gln_Veri.Location = new System.Drawing.Point(6, 31);
            this.gln_Veri.Name = "gln_Veri";
            this.gln_Veri.Size = new System.Drawing.Size(100, 18);
            this.gln_Veri.TabIndex = 6;
            this.gln_Veri.Text = "Bağlantı Yok!";
            this.gln_Veri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // status_pictureBox
            // 
            this.status_pictureBox.Image = global::SudeTeslimeDaka_YonlendirilmisCalisma.Properties.Resources.door_png;
            this.status_pictureBox.Location = new System.Drawing.Point(221, 123);
            this.status_pictureBox.Name = "status_pictureBox";
            this.status_pictureBox.Size = new System.Drawing.Size(184, 134);
            this.status_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status_pictureBox.TabIndex = 7;
            this.status_pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Bagla);
            this.groupBox1.Controls.Add(this.btn_Kes);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Connect Panel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 84);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gln_Veri);
            this.groupBox4.Location = new System.Drawing.Point(12, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 74);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(446, 308);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status_pictureBox);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID Kart Okuyucu-Sude Teslime Daka";
            ((System.ComponentModel.ISupportInitialize)(this.status_pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Bagla;
        private System.Windows.Forms.Button btn_Kes;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label gln_Veri;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox status_pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

