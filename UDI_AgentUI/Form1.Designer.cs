namespace UDI_AgentUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrAgent = new System.Windows.Forms.Timer(components);
            listen = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            TERAKO_DAS01_Panel = new Panel();
            TERAKO_DAS01_EXE = new PictureBox();
            TERAKO_DAS01_Reset = new Button();
            TERAKO_DAS01_Record = new Button();
            label4 = new Label();
            TERAKO_DAS01_OrderId = new Label();
            TERAKO_DAS01_Device = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            TERAKO_DAS01_Error = new Label();
            TERAKO_DAS01_Processing = new Label();
            PX_WAS01_Panel = new Panel();
            PX_WAS01_EXE = new PictureBox();
            PX_WAS01_Reset = new Button();
            PX_WAS01_Record = new Button();
            PX_WAS01_OrderId = new Label();
            PX_WAS01_Error = new Label();
            PX_WAS01_Processing = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            PX_WAS01_Device = new PictureBox();
            ISHIDA_PCRS01_Panel = new Panel();
            ISHIDA_PCRS01_EXE = new PictureBox();
            ISHIDA_PCRS01_Reset = new Button();
            ISHIDA_PCRS01_Record = new Button();
            ISHIDA_PCRS01_OrderId = new Label();
            ISHIDA_PCRS01_Error = new Label();
            ISHIDA_PCRS01_Processing = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ISHIDA_PCRS01_Device = new PictureBox();
            TERAKO_LCU01_Panel = new Panel();
            TERAKO_LCU01_EXE = new PictureBox();
            TERAKO_LCU01_Reset = new Button();
            TERAKO_LCU01_Record = new Button();
            TERAKO_LCU01_OrderId = new Label();
            TERAKO_LCU01_Error = new Label();
            TERAKO_LCU01_Processing = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            TERAKO_LCU01_Device = new PictureBox();
            assign = new System.Windows.Forms.Timer(components);
            result = new System.Windows.Forms.Timer(components);
            clearLog = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            TERAKO_DAS01_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TERAKO_DAS01_EXE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TERAKO_DAS01_Device).BeginInit();
            PX_WAS01_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PX_WAS01_EXE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PX_WAS01_Device).BeginInit();
            ISHIDA_PCRS01_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ISHIDA_PCRS01_EXE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ISHIDA_PCRS01_Device).BeginInit();
            TERAKO_LCU01_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TERAKO_LCU01_EXE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TERAKO_LCU01_Device).BeginInit();
            SuspendLayout();
            // 
            // tmrAgent
            // 
            tmrAgent.Enabled = true;
            tmrAgent.Interval = 1000;
            tmrAgent.Tick += tmrAgent_Tick;
            // 
            // listen
            // 
            listen.Enabled = true;
            listen.Interval = 5000;
            listen.Tick += listen_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(TERAKO_DAS01_Panel);
            flowLayoutPanel1.Controls.Add(PX_WAS01_Panel);
            flowLayoutPanel1.Controls.Add(ISHIDA_PCRS01_Panel);
            flowLayoutPanel1.Controls.Add(TERAKO_LCU01_Panel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(384, 506);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // TERAKO_DAS01_Panel
            // 
            TERAKO_DAS01_Panel.BackColor = Color.White;
            TERAKO_DAS01_Panel.BorderStyle = BorderStyle.FixedSingle;
            TERAKO_DAS01_Panel.Controls.Add(TERAKO_DAS01_EXE);
            TERAKO_DAS01_Panel.Controls.Add(TERAKO_DAS01_Reset);
            TERAKO_DAS01_Panel.Controls.Add(TERAKO_DAS01_Record);
            TERAKO_DAS01_Panel.Controls.Add(label4);
            TERAKO_DAS01_Panel.Controls.Add(TERAKO_DAS01_OrderId);
            TERAKO_DAS01_Panel.Controls.Add(TERAKO_DAS01_Device);
            TERAKO_DAS01_Panel.Controls.Add(label5);
            TERAKO_DAS01_Panel.Controls.Add(label3);
            TERAKO_DAS01_Panel.Controls.Add(TERAKO_DAS01_Error);
            TERAKO_DAS01_Panel.Controls.Add(TERAKO_DAS01_Processing);
            TERAKO_DAS01_Panel.Location = new Point(2, 2);
            TERAKO_DAS01_Panel.Margin = new Padding(2);
            TERAKO_DAS01_Panel.Name = "TERAKO_DAS01_Panel";
            TERAKO_DAS01_Panel.Size = new Size(382, 122);
            TERAKO_DAS01_Panel.TabIndex = 0;
            TERAKO_DAS01_Panel.Visible = false;
            // 
            // TERAKO_DAS01_EXE
            // 
            TERAKO_DAS01_EXE.Image = Properties.Resources.handelExe;
            TERAKO_DAS01_EXE.Location = new Point(313, 71);
            TERAKO_DAS01_EXE.Name = "TERAKO_DAS01_EXE";
            TERAKO_DAS01_EXE.Size = new Size(53, 46);
            TERAKO_DAS01_EXE.SizeMode = PictureBoxSizeMode.StretchImage;
            TERAKO_DAS01_EXE.TabIndex = 10;
            TERAKO_DAS01_EXE.TabStop = false;
            TERAKO_DAS01_EXE.Visible = false;
            // 
            // TERAKO_DAS01_Reset
            // 
            TERAKO_DAS01_Reset.Location = new Point(313, 40);
            TERAKO_DAS01_Reset.Name = "TERAKO_DAS01_Reset";
            TERAKO_DAS01_Reset.Size = new Size(53, 23);
            TERAKO_DAS01_Reset.TabIndex = 9;
            TERAKO_DAS01_Reset.Tag = "DAS01";
            TERAKO_DAS01_Reset.Text = "修復";
            TERAKO_DAS01_Reset.UseVisualStyleBackColor = true;
            TERAKO_DAS01_Reset.Click += HandleError_Click;
            // 
            // TERAKO_DAS01_Record
            // 
            TERAKO_DAS01_Record.Location = new Point(313, 8);
            TERAKO_DAS01_Record.Margin = new Padding(2);
            TERAKO_DAS01_Record.Name = "TERAKO_DAS01_Record";
            TERAKO_DAS01_Record.Size = new Size(53, 23);
            TERAKO_DAS01_Record.TabIndex = 8;
            TERAKO_DAS01_Record.Tag = "TERAKO\\DAS01";
            TERAKO_DAS01_Record.Text = "檢視";
            TERAKO_DAS01_Record.UseVisualStyleBackColor = true;
            TERAKO_DAS01_Record.Click += Reader_Record_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 24);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "DAS";
            // 
            // TERAKO_DAS01_OrderId
            // 
            TERAKO_DAS01_OrderId.AutoSize = true;
            TERAKO_DAS01_OrderId.Location = new Point(138, 44);
            TERAKO_DAS01_OrderId.Margin = new Padding(2, 0, 2, 0);
            TERAKO_DAS01_OrderId.Name = "TERAKO_DAS01_OrderId";
            TERAKO_DAS01_OrderId.Size = new Size(146, 15);
            TERAKO_DAS01_OrderId.TabIndex = 7;
            TERAKO_DAS01_OrderId.Text = "TERAKO_DAS01_OrderId";
            // 
            // TERAKO_DAS01_Device
            // 
            TERAKO_DAS01_Device.Image = Properties.Resources.devive_close;
            TERAKO_DAS01_Device.Location = new Point(2, 2);
            TERAKO_DAS01_Device.Margin = new Padding(2);
            TERAKO_DAS01_Device.Name = "TERAKO_DAS01_Device";
            TERAKO_DAS01_Device.Size = new Size(74, 69);
            TERAKO_DAS01_Device.SizeMode = PictureBoxSizeMode.StretchImage;
            TERAKO_DAS01_Device.TabIndex = 2;
            TERAKO_DAS01_Device.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 44);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 6;
            label5.Text = "訂單號碼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(81, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "執行動作";
            // 
            // TERAKO_DAS01_Error
            // 
            TERAKO_DAS01_Error.AutoEllipsis = true;
            TERAKO_DAS01_Error.BackColor = Color.White;
            TERAKO_DAS01_Error.ForeColor = Color.Red;
            TERAKO_DAS01_Error.Location = new Point(2, 70);
            TERAKO_DAS01_Error.Margin = new Padding(2, 0, 2, 0);
            TERAKO_DAS01_Error.MaximumSize = new Size(300, 50);
            TERAKO_DAS01_Error.Name = "TERAKO_DAS01_Error";
            TERAKO_DAS01_Error.Size = new Size(300, 50);
            TERAKO_DAS01_Error.TabIndex = 3;
            TERAKO_DAS01_Error.Text = "TERAKO_DAS01_Error";
            // 
            // TERAKO_DAS01_Processing
            // 
            TERAKO_DAS01_Processing.AutoSize = true;
            TERAKO_DAS01_Processing.ForeColor = Color.Green;
            TERAKO_DAS01_Processing.Location = new Point(139, 7);
            TERAKO_DAS01_Processing.Margin = new Padding(2, 0, 2, 0);
            TERAKO_DAS01_Processing.Name = "TERAKO_DAS01_Processing";
            TERAKO_DAS01_Processing.Size = new Size(162, 15);
            TERAKO_DAS01_Processing.TabIndex = 2;
            TERAKO_DAS01_Processing.Text = "TERAKO_DAS01_Processing";
            // 
            // PX_WAS01_Panel
            // 
            PX_WAS01_Panel.BorderStyle = BorderStyle.FixedSingle;
            PX_WAS01_Panel.Controls.Add(PX_WAS01_EXE);
            PX_WAS01_Panel.Controls.Add(PX_WAS01_Reset);
            PX_WAS01_Panel.Controls.Add(PX_WAS01_Record);
            PX_WAS01_Panel.Controls.Add(PX_WAS01_OrderId);
            PX_WAS01_Panel.Controls.Add(PX_WAS01_Error);
            PX_WAS01_Panel.Controls.Add(PX_WAS01_Processing);
            PX_WAS01_Panel.Controls.Add(label6);
            PX_WAS01_Panel.Controls.Add(label2);
            PX_WAS01_Panel.Controls.Add(label1);
            PX_WAS01_Panel.Controls.Add(PX_WAS01_Device);
            PX_WAS01_Panel.Location = new Point(2, 128);
            PX_WAS01_Panel.Margin = new Padding(2);
            PX_WAS01_Panel.Name = "PX_WAS01_Panel";
            PX_WAS01_Panel.Size = new Size(382, 122);
            PX_WAS01_Panel.TabIndex = 1;
            PX_WAS01_Panel.Visible = false;
            // 
            // PX_WAS01_EXE
            // 
            PX_WAS01_EXE.Image = Properties.Resources.handelExe;
            PX_WAS01_EXE.Location = new Point(313, 70);
            PX_WAS01_EXE.Name = "PX_WAS01_EXE";
            PX_WAS01_EXE.Size = new Size(53, 46);
            PX_WAS01_EXE.SizeMode = PictureBoxSizeMode.StretchImage;
            PX_WAS01_EXE.TabIndex = 11;
            PX_WAS01_EXE.TabStop = false;
            PX_WAS01_EXE.Visible = false;
            // 
            // PX_WAS01_Reset
            // 
            PX_WAS01_Reset.Location = new Point(313, 41);
            PX_WAS01_Reset.Name = "PX_WAS01_Reset";
            PX_WAS01_Reset.Size = new Size(53, 23);
            PX_WAS01_Reset.TabIndex = 10;
            PX_WAS01_Reset.Tag = "WAS01";
            PX_WAS01_Reset.Text = "修復";
            PX_WAS01_Reset.UseVisualStyleBackColor = true;
            PX_WAS01_Reset.Click += HandleError_Click;
            // 
            // PX_WAS01_Record
            // 
            PX_WAS01_Record.Location = new Point(313, 7);
            PX_WAS01_Record.Margin = new Padding(2);
            PX_WAS01_Record.Name = "PX_WAS01_Record";
            PX_WAS01_Record.Size = new Size(53, 23);
            PX_WAS01_Record.TabIndex = 9;
            PX_WAS01_Record.Tag = "PX\\WAS01";
            PX_WAS01_Record.Text = "檢視";
            PX_WAS01_Record.UseVisualStyleBackColor = true;
            PX_WAS01_Record.Click += Reader_Record_Click;
            // 
            // PX_WAS01_OrderId
            // 
            PX_WAS01_OrderId.AutoSize = true;
            PX_WAS01_OrderId.Location = new Point(138, 45);
            PX_WAS01_OrderId.Margin = new Padding(2, 0, 2, 0);
            PX_WAS01_OrderId.Name = "PX_WAS01_OrderId";
            PX_WAS01_OrderId.Size = new Size(117, 15);
            PX_WAS01_OrderId.TabIndex = 9;
            PX_WAS01_OrderId.Text = "PX_WAS01_OrderId";
            // 
            // PX_WAS01_Error
            // 
            PX_WAS01_Error.AutoEllipsis = true;
            PX_WAS01_Error.BackColor = Color.White;
            PX_WAS01_Error.ForeColor = Color.Red;
            PX_WAS01_Error.Location = new Point(2, 70);
            PX_WAS01_Error.Margin = new Padding(2, 0, 2, 0);
            PX_WAS01_Error.MaximumSize = new Size(300, 50);
            PX_WAS01_Error.Name = "PX_WAS01_Error";
            PX_WAS01_Error.Size = new Size(300, 50);
            PX_WAS01_Error.TabIndex = 9;
            PX_WAS01_Error.Text = "PX_WAS01_Error";
            // 
            // PX_WAS01_Processing
            // 
            PX_WAS01_Processing.AutoSize = true;
            PX_WAS01_Processing.ForeColor = Color.Green;
            PX_WAS01_Processing.Location = new Point(139, 7);
            PX_WAS01_Processing.Margin = new Padding(2, 0, 2, 0);
            PX_WAS01_Processing.Name = "PX_WAS01_Processing";
            PX_WAS01_Processing.Size = new Size(133, 15);
            PX_WAS01_Processing.TabIndex = 9;
            PX_WAS01_Processing.Text = "PX_WAS01_Processing";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 45);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "訂單號碼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 9;
            label2.Text = "執行動作";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 9;
            label1.Text = "WAS";
            // 
            // PX_WAS01_Device
            // 
            PX_WAS01_Device.Image = Properties.Resources.devive_close;
            PX_WAS01_Device.Location = new Point(2, 2);
            PX_WAS01_Device.Margin = new Padding(2);
            PX_WAS01_Device.Name = "PX_WAS01_Device";
            PX_WAS01_Device.Size = new Size(74, 66);
            PX_WAS01_Device.SizeMode = PictureBoxSizeMode.StretchImage;
            PX_WAS01_Device.TabIndex = 9;
            PX_WAS01_Device.TabStop = false;
            // 
            // ISHIDA_PCRS01_Panel
            // 
            ISHIDA_PCRS01_Panel.BorderStyle = BorderStyle.FixedSingle;
            ISHIDA_PCRS01_Panel.Controls.Add(ISHIDA_PCRS01_EXE);
            ISHIDA_PCRS01_Panel.Controls.Add(ISHIDA_PCRS01_Reset);
            ISHIDA_PCRS01_Panel.Controls.Add(ISHIDA_PCRS01_Record);
            ISHIDA_PCRS01_Panel.Controls.Add(ISHIDA_PCRS01_OrderId);
            ISHIDA_PCRS01_Panel.Controls.Add(ISHIDA_PCRS01_Error);
            ISHIDA_PCRS01_Panel.Controls.Add(ISHIDA_PCRS01_Processing);
            ISHIDA_PCRS01_Panel.Controls.Add(label10);
            ISHIDA_PCRS01_Panel.Controls.Add(label11);
            ISHIDA_PCRS01_Panel.Controls.Add(label12);
            ISHIDA_PCRS01_Panel.Controls.Add(ISHIDA_PCRS01_Device);
            ISHIDA_PCRS01_Panel.Location = new Point(2, 254);
            ISHIDA_PCRS01_Panel.Margin = new Padding(2);
            ISHIDA_PCRS01_Panel.Name = "ISHIDA_PCRS01_Panel";
            ISHIDA_PCRS01_Panel.Size = new Size(382, 122);
            ISHIDA_PCRS01_Panel.TabIndex = 12;
            ISHIDA_PCRS01_Panel.Visible = false;
            // 
            // ISHIDA_PCRS01_EXE
            // 
            ISHIDA_PCRS01_EXE.Image = Properties.Resources.handelExe;
            ISHIDA_PCRS01_EXE.Location = new Point(313, 69);
            ISHIDA_PCRS01_EXE.Name = "ISHIDA_PCRS01_EXE";
            ISHIDA_PCRS01_EXE.Size = new Size(53, 46);
            ISHIDA_PCRS01_EXE.SizeMode = PictureBoxSizeMode.StretchImage;
            ISHIDA_PCRS01_EXE.TabIndex = 12;
            ISHIDA_PCRS01_EXE.TabStop = false;
            ISHIDA_PCRS01_EXE.Visible = false;
            // 
            // ISHIDA_PCRS01_Reset
            // 
            ISHIDA_PCRS01_Reset.Location = new Point(313, 40);
            ISHIDA_PCRS01_Reset.Name = "ISHIDA_PCRS01_Reset";
            ISHIDA_PCRS01_Reset.Size = new Size(53, 23);
            ISHIDA_PCRS01_Reset.TabIndex = 10;
            ISHIDA_PCRS01_Reset.Tag = "PCRS01";
            ISHIDA_PCRS01_Reset.Text = "修復";
            ISHIDA_PCRS01_Reset.UseVisualStyleBackColor = true;
            ISHIDA_PCRS01_Reset.Click += HandleError_Click;
            // 
            // ISHIDA_PCRS01_Record
            // 
            ISHIDA_PCRS01_Record.Location = new Point(313, 7);
            ISHIDA_PCRS01_Record.Margin = new Padding(2);
            ISHIDA_PCRS01_Record.Name = "ISHIDA_PCRS01_Record";
            ISHIDA_PCRS01_Record.Size = new Size(53, 23);
            ISHIDA_PCRS01_Record.TabIndex = 9;
            ISHIDA_PCRS01_Record.Tag = "ISHIDA\\PCRS01";
            ISHIDA_PCRS01_Record.Text = "檢視";
            ISHIDA_PCRS01_Record.UseVisualStyleBackColor = true;
            ISHIDA_PCRS01_Record.Click += Reader_Record_Click;
            // 
            // ISHIDA_PCRS01_OrderId
            // 
            ISHIDA_PCRS01_OrderId.AutoSize = true;
            ISHIDA_PCRS01_OrderId.Location = new Point(138, 44);
            ISHIDA_PCRS01_OrderId.Margin = new Padding(2, 0, 2, 0);
            ISHIDA_PCRS01_OrderId.Name = "ISHIDA_PCRS01_OrderId";
            ISHIDA_PCRS01_OrderId.Size = new Size(141, 15);
            ISHIDA_PCRS01_OrderId.TabIndex = 9;
            ISHIDA_PCRS01_OrderId.Text = "SHIDA_PCRS01_OrderId";
            // 
            // ISHIDA_PCRS01_Error
            // 
            ISHIDA_PCRS01_Error.AutoEllipsis = true;
            ISHIDA_PCRS01_Error.BackColor = Color.White;
            ISHIDA_PCRS01_Error.ForeColor = Color.Red;
            ISHIDA_PCRS01_Error.Location = new Point(2, 70);
            ISHIDA_PCRS01_Error.Margin = new Padding(2, 0, 2, 0);
            ISHIDA_PCRS01_Error.MaximumSize = new Size(300, 50);
            ISHIDA_PCRS01_Error.Name = "ISHIDA_PCRS01_Error";
            ISHIDA_PCRS01_Error.Size = new Size(300, 50);
            ISHIDA_PCRS01_Error.TabIndex = 9;
            ISHIDA_PCRS01_Error.Tag = "";
            ISHIDA_PCRS01_Error.Text = "ISHIDA_PCRS01_Error";
            // 
            // ISHIDA_PCRS01_Processing
            // 
            ISHIDA_PCRS01_Processing.AutoSize = true;
            ISHIDA_PCRS01_Processing.ForeColor = Color.Green;
            ISHIDA_PCRS01_Processing.Location = new Point(141, 7);
            ISHIDA_PCRS01_Processing.Margin = new Padding(2, 0, 2, 0);
            ISHIDA_PCRS01_Processing.Name = "ISHIDA_PCRS01_Processing";
            ISHIDA_PCRS01_Processing.Size = new Size(160, 15);
            ISHIDA_PCRS01_Processing.TabIndex = 9;
            ISHIDA_PCRS01_Processing.Text = "ISHIDA_PCRS01_Processing";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(80, 44);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 9;
            label10.Text = "訂單號碼";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(81, 7);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 9;
            label11.Text = "執行動作";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 24);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 9;
            label12.Text = "PCRS";
            // 
            // ISHIDA_PCRS01_Device
            // 
            ISHIDA_PCRS01_Device.Image = Properties.Resources.devive_close;
            ISHIDA_PCRS01_Device.Location = new Point(2, 2);
            ISHIDA_PCRS01_Device.Margin = new Padding(2);
            ISHIDA_PCRS01_Device.Name = "ISHIDA_PCRS01_Device";
            ISHIDA_PCRS01_Device.Size = new Size(74, 66);
            ISHIDA_PCRS01_Device.SizeMode = PictureBoxSizeMode.StretchImage;
            ISHIDA_PCRS01_Device.TabIndex = 9;
            ISHIDA_PCRS01_Device.TabStop = false;
            // 
            // TERAKO_LCU01_Panel
            // 
            TERAKO_LCU01_Panel.BorderStyle = BorderStyle.FixedSingle;
            TERAKO_LCU01_Panel.Controls.Add(TERAKO_LCU01_EXE);
            TERAKO_LCU01_Panel.Controls.Add(TERAKO_LCU01_Reset);
            TERAKO_LCU01_Panel.Controls.Add(TERAKO_LCU01_Record);
            TERAKO_LCU01_Panel.Controls.Add(TERAKO_LCU01_OrderId);
            TERAKO_LCU01_Panel.Controls.Add(TERAKO_LCU01_Error);
            TERAKO_LCU01_Panel.Controls.Add(TERAKO_LCU01_Processing);
            TERAKO_LCU01_Panel.Controls.Add(label13);
            TERAKO_LCU01_Panel.Controls.Add(label14);
            TERAKO_LCU01_Panel.Controls.Add(label15);
            TERAKO_LCU01_Panel.Controls.Add(TERAKO_LCU01_Device);
            TERAKO_LCU01_Panel.Location = new Point(2, 380);
            TERAKO_LCU01_Panel.Margin = new Padding(2);
            TERAKO_LCU01_Panel.Name = "TERAKO_LCU01_Panel";
            TERAKO_LCU01_Panel.Size = new Size(382, 122);
            TERAKO_LCU01_Panel.TabIndex = 13;
            TERAKO_LCU01_Panel.Visible = false;
            // 
            // TERAKO_LCU01_EXE
            // 
            TERAKO_LCU01_EXE.Image = Properties.Resources.handelExe;
            TERAKO_LCU01_EXE.Location = new Point(313, 70);
            TERAKO_LCU01_EXE.Name = "TERAKO_LCU01_EXE";
            TERAKO_LCU01_EXE.Size = new Size(53, 46);
            TERAKO_LCU01_EXE.SizeMode = PictureBoxSizeMode.StretchImage;
            TERAKO_LCU01_EXE.TabIndex = 13;
            TERAKO_LCU01_EXE.TabStop = false;
            TERAKO_LCU01_EXE.Visible = false;
            // 
            // TERAKO_LCU01_Reset
            // 
            TERAKO_LCU01_Reset.Location = new Point(313, 41);
            TERAKO_LCU01_Reset.Name = "TERAKO_LCU01_Reset";
            TERAKO_LCU01_Reset.Size = new Size(53, 23);
            TERAKO_LCU01_Reset.TabIndex = 10;
            TERAKO_LCU01_Reset.Tag = "LCU01";
            TERAKO_LCU01_Reset.Text = "修復";
            TERAKO_LCU01_Reset.UseVisualStyleBackColor = true;
            TERAKO_LCU01_Reset.Click += HandleError_Click;
            // 
            // TERAKO_LCU01_Record
            // 
            TERAKO_LCU01_Record.Location = new Point(313, 7);
            TERAKO_LCU01_Record.Margin = new Padding(2);
            TERAKO_LCU01_Record.Name = "TERAKO_LCU01_Record";
            TERAKO_LCU01_Record.Size = new Size(53, 23);
            TERAKO_LCU01_Record.TabIndex = 9;
            TERAKO_LCU01_Record.Tag = "TERAKO\\LCU01";
            TERAKO_LCU01_Record.Text = "檢視";
            TERAKO_LCU01_Record.UseVisualStyleBackColor = true;
            TERAKO_LCU01_Record.Click += Reader_Record_Click;
            // 
            // TERAKO_LCU01_OrderId
            // 
            TERAKO_LCU01_OrderId.AutoSize = true;
            TERAKO_LCU01_OrderId.Location = new Point(139, 45);
            TERAKO_LCU01_OrderId.Margin = new Padding(2, 0, 2, 0);
            TERAKO_LCU01_OrderId.Name = "TERAKO_LCU01_OrderId";
            TERAKO_LCU01_OrderId.Size = new Size(145, 15);
            TERAKO_LCU01_OrderId.TabIndex = 9;
            TERAKO_LCU01_OrderId.Text = "TERAKO_LCU01_OrderId";
            // 
            // TERAKO_LCU01_Error
            // 
            TERAKO_LCU01_Error.AutoEllipsis = true;
            TERAKO_LCU01_Error.BackColor = Color.White;
            TERAKO_LCU01_Error.ForeColor = Color.Red;
            TERAKO_LCU01_Error.Location = new Point(2, 70);
            TERAKO_LCU01_Error.Margin = new Padding(2, 0, 2, 0);
            TERAKO_LCU01_Error.MaximumSize = new Size(300, 50);
            TERAKO_LCU01_Error.Name = "TERAKO_LCU01_Error";
            TERAKO_LCU01_Error.Size = new Size(300, 50);
            TERAKO_LCU01_Error.TabIndex = 9;
            TERAKO_LCU01_Error.Tag = "";
            TERAKO_LCU01_Error.Text = "TERAKO_LCU01_Error";
            // 
            // TERAKO_LCU01_Processing
            // 
            TERAKO_LCU01_Processing.AutoSize = true;
            TERAKO_LCU01_Processing.ForeColor = Color.Green;
            TERAKO_LCU01_Processing.Location = new Point(141, 7);
            TERAKO_LCU01_Processing.Margin = new Padding(2, 0, 2, 0);
            TERAKO_LCU01_Processing.Name = "TERAKO_LCU01_Processing";
            TERAKO_LCU01_Processing.Size = new Size(161, 15);
            TERAKO_LCU01_Processing.TabIndex = 9;
            TERAKO_LCU01_Processing.Text = "TERAKO_LCU01_Processing";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(81, 45);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 9;
            label13.Text = "訂單號碼";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(81, 7);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 9;
            label14.Text = "執行動作";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 24);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 9;
            label15.Text = "LCU";
            // 
            // TERAKO_LCU01_Device
            // 
            TERAKO_LCU01_Device.Image = Properties.Resources.devive_close;
            TERAKO_LCU01_Device.Location = new Point(2, 2);
            TERAKO_LCU01_Device.Margin = new Padding(2);
            TERAKO_LCU01_Device.Name = "TERAKO_LCU01_Device";
            TERAKO_LCU01_Device.Size = new Size(74, 66);
            TERAKO_LCU01_Device.SizeMode = PictureBoxSizeMode.StretchImage;
            TERAKO_LCU01_Device.TabIndex = 9;
            TERAKO_LCU01_Device.TabStop = false;
            // 
            // assign
            // 
            assign.Enabled = true;
            assign.Interval = 8000;
            assign.Tick += assign_Tick;
            // 
            // result
            // 
            result.Enabled = true;
            result.Interval = 8000;
            result.Tick += result_Tick;
            // 
            // clearLog
            // 
            clearLog.Enabled = true;
            clearLog.Interval = 36000;
            clearLog.Tick += clearLog_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(384, 506);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "UDI ";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            TERAKO_DAS01_Panel.ResumeLayout(false);
            TERAKO_DAS01_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TERAKO_DAS01_EXE).EndInit();
            ((System.ComponentModel.ISupportInitialize)TERAKO_DAS01_Device).EndInit();
            PX_WAS01_Panel.ResumeLayout(false);
            PX_WAS01_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PX_WAS01_EXE).EndInit();
            ((System.ComponentModel.ISupportInitialize)PX_WAS01_Device).EndInit();
            ISHIDA_PCRS01_Panel.ResumeLayout(false);
            ISHIDA_PCRS01_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ISHIDA_PCRS01_EXE).EndInit();
            ((System.ComponentModel.ISupportInitialize)ISHIDA_PCRS01_Device).EndInit();
            TERAKO_LCU01_Panel.ResumeLayout(false);
            TERAKO_LCU01_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TERAKO_LCU01_EXE).EndInit();
            ((System.ComponentModel.ISupportInitialize)TERAKO_LCU01_Device).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrAgent;
        private System.Windows.Forms.Timer listen;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel TERAKO_DAS01_Panel;
        private Panel PX_WAS01_Panel;
        private Label TERAKO_DAS01_Processing;
        private Label TERAKO_DAS01_Error;
        private Label TERAKO_DAS01_ProcessTime;
        private Label label5;
        private Label label3;
        private PictureBox TERAKO_DAS01_Device;
        private Label label4;
        private Label TERAKO_DAS01_OrderId;
        private Button TERAKO_DAS01_Record;
        private PictureBox PX_WAS01_Device;
        private Label label1;
        private Label PX_WAS01_Error;
        private Button PX_WAS01_Record;
        private Label PX_WAS01_OrderId;
        private Label PX_WAS01_Processing;
        private Label label6;
        private Label label2;
        private System.Windows.Forms.Timer assign;
        private System.Windows.Forms.Timer result;
        private Button TERAKO_DAS01_Reset;
        private Button PX_WAS01_Reset;
        private Panel ISHIDA_PCRS01_Panel;
        private Button ISHIDA_PCRS01_Reset;
        private Button ISHIDA_PCRS01_Record;
        private Label ISHIDA_PCRS01_OrderId;
        private Label ISHIDA_PCRS01_Error;
        private Label ISHIDA_PCRS01_Processing;
        private Label label10;
        private Label label11;
        private Label label12;
        private PictureBox ISHIDA_PCRS01_Device;
        private Panel TERAKO_LCU01_Panel;
        private Button TERAKO_LCU01_Reset;
        private Button TERAKO_LCU01_Record;
        private Label TERAKO_LCU01_OrderId;
        private Label TERAKO_LCU01_Error;
        private Label TERAKO_LCU01_Processing;
        private Label label13;
        private Label label14;
        private Label label15;
        private PictureBox TERAKO_LCU01_Device;
        private PictureBox TERAKO_DAS01_EXE;
        private PictureBox PX_WAS01_EXE;
        private PictureBox ISHIDA_PCRS01_EXE;
        private PictureBox TERAKO_LCU01_EXE;
        private System.Windows.Forms.Timer clearLog;

        //private System.Windows.Forms.Timer listen;
    }
}
