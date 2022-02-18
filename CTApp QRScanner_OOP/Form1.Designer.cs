
namespace CTApp_QRScanner_OOP
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
            this.BtnStrt = new System.Windows.Forms.Button();
            this.CmbBxDevice = new System.Windows.Forms.ComboBox();
            this.CamBx = new System.Windows.Forms.PictureBox();
            this.Timer_tck = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnStrt
            // 
            this.BtnStrt.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnStrt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStrt.ForeColor = System.Drawing.Color.White;
            this.BtnStrt.Location = new System.Drawing.Point(95, 287);
            this.BtnStrt.Name = "BtnStrt";
            this.BtnStrt.Size = new System.Drawing.Size(103, 39);
            this.BtnStrt.TabIndex = 1;
            this.BtnStrt.Text = "Start";
            this.BtnStrt.UseVisualStyleBackColor = false;
            this.BtnStrt.Click += new System.EventHandler(this.BtnStrt_Click);
            // 
            // CmbBxDevice
            // 
            this.CmbBxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxDevice.FormattingEnabled = true;
            this.CmbBxDevice.Location = new System.Drawing.Point(75, 11);
            this.CmbBxDevice.Name = "CmbBxDevice";
            this.CmbBxDevice.Size = new System.Drawing.Size(202, 21);
            this.CmbBxDevice.TabIndex = 2;
            // 
            // CamBx
            // 
            this.CamBx.BackColor = System.Drawing.Color.PaleGreen;
            this.CamBx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CamBx.Location = new System.Drawing.Point(15, 65);
            this.CamBx.Name = "CamBx";
            this.CamBx.Size = new System.Drawing.Size(262, 216);
            this.CamBx.TabIndex = 3;
            this.CamBx.TabStop = false;
            // 
            // Timer_tck
            // 
            this.Timer_tck.Interval = 1000;
            this.Timer_tck.Tick += new System.EventHandler(this.Timer_tck_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scan QR Code here:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTApp_QRScanner_OOP.Properties.Resources.IMG_1466;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(291, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CamBx);
            this.Controls.Add(this.CmbBxDevice);
            this.Controls.Add(this.BtnStrt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CTApp QRs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStrt;
        private System.Windows.Forms.ComboBox CmbBxDevice;
        private System.Windows.Forms.PictureBox CamBx;
        private System.Windows.Forms.Timer Timer_tck;
        private System.Windows.Forms.Label label2;
    }
}

