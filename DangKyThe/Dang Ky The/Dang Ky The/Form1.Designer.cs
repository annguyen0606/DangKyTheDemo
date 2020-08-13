namespace Dang_Ky_The
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbComPort = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnConnectComPort = new DevComponents.DotNetBar.ButtonX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.txbUIDTag = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txbNameCustomer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txbDateOfBirth = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDangKy = new DevComponents.DotNetBar.ButtonX();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnDangKy);
            this.panelEx1.Controls.Add(this.txbDateOfBirth);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.txbNameCustomer);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.txbUIDTag);
            this.panelEx1.Controls.Add(this.progressBarX1);
            this.panelEx1.Controls.Add(this.btnConnectComPort);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.cbComPort);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(822, 254);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // cbComPort
            // 
            this.cbComPort.DisplayMember = "Text";
            this.cbComPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.ItemHeight = 14;
            this.cbComPort.Location = new System.Drawing.Point(93, 67);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 20);
            this.cbComPort.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbComPort.TabIndex = 5;
            this.cbComPort.DropDown += new System.EventHandler(this.CbComPort_DropDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(251, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(277, 58);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Đăng ký thẻ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 64);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Cổng kết nối";
            // 
            // btnConnectComPort
            // 
            this.btnConnectComPort.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnectComPort.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnectComPort.Location = new System.Drawing.Point(229, 64);
            this.btnConnectComPort.Name = "btnConnectComPort";
            this.btnConnectComPort.Size = new System.Drawing.Size(75, 23);
            this.btnConnectComPort.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConnectComPort.TabIndex = 8;
            this.btnConnectComPort.Text = "Kết nối";
            this.btnConnectComPort.Click += new System.EventHandler(this.BtnConnectComPort_Click);
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(12, 93);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(292, 23);
            this.progressBarX1.TabIndex = 9;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // txbUIDTag
            // 
            // 
            // 
            // 
            this.txbUIDTag.Border.Class = "TextBoxBorder";
            this.txbUIDTag.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbUIDTag.Location = new System.Drawing.Point(412, 67);
            this.txbUIDTag.Name = "txbUIDTag";
            this.txbUIDTag.PreventEnterBeep = true;
            this.txbUIDTag.ReadOnly = true;
            this.txbUIDTag.Size = new System.Drawing.Size(211, 20);
            this.txbUIDTag.TabIndex = 2;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(324, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(41, 23);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Mã thẻ";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(324, 93);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(28, 23);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "Tên";
            // 
            // txbNameCustomer
            // 
            // 
            // 
            // 
            this.txbNameCustomer.Border.Class = "TextBoxBorder";
            this.txbNameCustomer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbNameCustomer.Location = new System.Drawing.Point(412, 93);
            this.txbNameCustomer.Name = "txbNameCustomer";
            this.txbNameCustomer.PreventEnterBeep = true;
            this.txbNameCustomer.Size = new System.Drawing.Size(211, 20);
            this.txbNameCustomer.TabIndex = 3;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(324, 119);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(56, 23);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Ngày sinh";
            // 
            // txbDateOfBirth
            // 
            // 
            // 
            // 
            this.txbDateOfBirth.Border.Class = "TextBoxBorder";
            this.txbDateOfBirth.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbDateOfBirth.Location = new System.Drawing.Point(412, 119);
            this.txbDateOfBirth.Name = "txbDateOfBirth";
            this.txbDateOfBirth.PreventEnterBeep = true;
            this.txbDateOfBirth.Size = new System.Drawing.Size(211, 20);
            this.txbDateOfBirth.TabIndex = 4;
            // 
            // btnDangKy
            // 
            this.btnDangKy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangKy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDangKy.Location = new System.Drawing.Point(453, 145);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 254);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký thẻ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnConnectComPort;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbComPort;
        private DevComponents.DotNetBar.ButtonX btnDangKy;
        private DevComponents.DotNetBar.Controls.TextBoxX txbDateOfBirth;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txbNameCustomer;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUIDTag;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

