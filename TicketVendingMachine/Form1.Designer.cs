namespace TicketVendingMachine
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cmbSelect = new GroupBox();
            cmbDes = new ComboBox();
            cmbTransport = new ComboBox();
            groupBox3 = new GroupBox();
            chkPay = new CheckedListBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            chkType = new CheckedListBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox5 = new GroupBox();
            button1 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            cmbSelect.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 23);
            label1.Name = "label1";
            label1.Size = new Size(610, 52);
            label1.TabIndex = 0;
            label1.Text = "Transport Ticket Vending Machine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Transports";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 63);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 2;
            label3.Text = "Destinations";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 95);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // cmbSelect
            // 
            cmbSelect.BackColor = SystemColors.InactiveCaption;
            cmbSelect.Controls.Add(cmbDes);
            cmbSelect.Controls.Add(cmbTransport);
            cmbSelect.Controls.Add(label2);
            cmbSelect.Controls.Add(label3);
            cmbSelect.Location = new Point(12, 101);
            cmbSelect.Name = "cmbSelect";
            cmbSelect.Size = new Size(439, 99);
            cmbSelect.TabIndex = 4;
            cmbSelect.TabStop = false;
            // 
            // cmbDes
            // 
            cmbDes.FormattingEnabled = true;
            cmbDes.Items.AddRange(new object[] { "Ha Noi", "HCM City", "Binh Duong", "Hai Phong", "Ca Mau", "Vung Tau", "Vinh Long" });
            cmbDes.Location = new Point(144, 62);
            cmbDes.Name = "cmbDes";
            cmbDes.Size = new Size(267, 28);
            cmbDes.TabIndex = 4;
            // 
            // cmbTransport
            // 
            cmbTransport.FormattingEnabled = true;
            cmbTransport.Items.AddRange(new object[] { "Bus", "Train", "Ferry", "Plane", "Taxi" });
            cmbTransport.Location = new Point(144, 20);
            cmbTransport.Name = "cmbTransport";
            cmbTransport.Size = new Size(267, 28);
            cmbTransport.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.InactiveCaption;
            groupBox3.Controls.Add(chkPay);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(439, 95);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // chkPay
            // 
            chkPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkPay.FormattingEnabled = true;
            chkPay.Items.AddRange(new object[] { "Credit Card", "QR Code" });
            chkPay.Location = new Point(18, 23);
            chkPay.Name = "chkPay";
            chkPay.Size = new Size(393, 54);
            chkPay.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 23);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.InactiveCaption;
            groupBox4.Controls.Add(chkType);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(12, 307);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(439, 178);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            // 
            // chkType
            // 
            chkType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkType.FormattingEnabled = true;
            chkType.Items.AddRange(new object[] { "One Way", "Two Way", "Standard", "Premium", "Economic" });
            chkType.Location = new Point(18, 26);
            chkType.Name = "chkType";
            chkType.Size = new Size(393, 129);
            chkType.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 23);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.travel_tourism_booking_app_equipment_luggage_mobile_touch_screen_smartphone_117383979;
            pictureBox1.Location = new Point(457, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.InactiveCaption;
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(label6);
            groupBox5.Location = new Point(457, 402);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(439, 83);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(141, 23);
            button1.Name = "button1";
            button1.Size = new Size(184, 48);
            button1.TabIndex = 2;
            button1.Text = "Confirm booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 23);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 497);
            Controls.Add(groupBox5);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(cmbSelect);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            cmbSelect.ResumeLayout(false);
            cmbSelect.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox cmbSelect;
        private GroupBox groupBox3;
        private CheckedListBox chkPay;
        private Label label4;
        private GroupBox groupBox4;
        private CheckedListBox chkType;
        private Label label5;
        private PictureBox pictureBox1;
        private ComboBox cmbDes;
        private ComboBox cmbTransport;
        private GroupBox groupBox5;
        private Button button1;
        private Label label6;
    }
}