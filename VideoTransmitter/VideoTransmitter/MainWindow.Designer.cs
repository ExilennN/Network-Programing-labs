namespace VideoTransmitter
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.button_AudioDevice = new System.Windows.Forms.Button();
            this.button_VideoDevice = new System.Windows.Forms.Button();
            this.comboBox_AudioDevices = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_VideoDevices = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_ServerConfig = new System.Windows.Forms.GroupBox();
            this.button_StartTransmitt = new System.Windows.Forms.Button();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IpAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_TV = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            this.groupBox_ServerConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Info});
            this.statusStrip.Location = new System.Drawing.Point(0, 499);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel_Info.Text = "Готово";
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Controls.Controls.Add(this.button_AudioDevice);
            this.panel_Controls.Controls.Add(this.button_VideoDevice);
            this.panel_Controls.Controls.Add(this.comboBox_AudioDevices);
            this.panel_Controls.Controls.Add(this.label4);
            this.panel_Controls.Controls.Add(this.comboBox_VideoDevices);
            this.panel_Controls.Controls.Add(this.label3);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Controls.Location = new System.Drawing.Point(0, 24);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1008, 100);
            this.panel_Controls.TabIndex = 2;
            // 
            // button_AudioDevice
            // 
            this.button_AudioDevice.BackColor = System.Drawing.SystemColors.Control;
            this.button_AudioDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AudioDevice.Location = new System.Drawing.Point(862, 57);
            this.button_AudioDevice.Name = "button_AudioDevice";
            this.button_AudioDevice.Size = new System.Drawing.Size(128, 32);
            this.button_AudioDevice.TabIndex = 10;
            this.button_AudioDevice.Text = "Start";
            this.button_AudioDevice.UseVisualStyleBackColor = false;
            // 
            // button_VideoDevice
            // 
            this.button_VideoDevice.BackColor = System.Drawing.SystemColors.Control;
            this.button_VideoDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_VideoDevice.Location = new System.Drawing.Point(862, 10);
            this.button_VideoDevice.Name = "button_VideoDevice";
            this.button_VideoDevice.Size = new System.Drawing.Size(128, 32);
            this.button_VideoDevice.TabIndex = 9;
            this.button_VideoDevice.Text = "Start";
            this.button_VideoDevice.UseVisualStyleBackColor = false;
            this.button_VideoDevice.Click += new System.EventHandler(this.button_VideoDevice_Click);
            // 
            // comboBox_AudioDevices
            // 
            this.comboBox_AudioDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AudioDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_AudioDevices.FormattingEnabled = true;
            this.comboBox_AudioDevices.Location = new System.Drawing.Point(171, 57);
            this.comboBox_AudioDevices.Name = "comboBox_AudioDevices";
            this.comboBox_AudioDevices.Size = new System.Drawing.Size(684, 32);
            this.comboBox_AudioDevices.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Audio Devices";
            // 
            // comboBox_VideoDevices
            // 
            this.comboBox_VideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VideoDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_VideoDevices.FormattingEnabled = true;
            this.comboBox_VideoDevices.Location = new System.Drawing.Point(171, 10);
            this.comboBox_VideoDevices.Name = "comboBox_VideoDevices";
            this.comboBox_VideoDevices.Size = new System.Drawing.Size(684, 32);
            this.comboBox_VideoDevices.TabIndex = 6;
            this.comboBox_VideoDevices.SelectedIndexChanged += new System.EventHandler(this.comboBox_VideoDevices_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Devices";
            // 
            // groupBox_ServerConfig
            // 
            this.groupBox_ServerConfig.Controls.Add(this.button_StartTransmitt);
            this.groupBox_ServerConfig.Controls.Add(this.textBox_Port);
            this.groupBox_ServerConfig.Controls.Add(this.label2);
            this.groupBox_ServerConfig.Controls.Add(this.textBox_IpAdress);
            this.groupBox_ServerConfig.Controls.Add(this.label1);
            this.groupBox_ServerConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_ServerConfig.Location = new System.Drawing.Point(796, 131);
            this.groupBox_ServerConfig.Name = "groupBox_ServerConfig";
            this.groupBox_ServerConfig.Size = new System.Drawing.Size(200, 365);
            this.groupBox_ServerConfig.TabIndex = 3;
            this.groupBox_ServerConfig.TabStop = false;
            this.groupBox_ServerConfig.Text = "Настройки Сервера";
            // 
            // button_StartTransmitt
            // 
            this.button_StartTransmitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartTransmitt.Location = new System.Drawing.Point(7, 156);
            this.button_StartTransmitt.Name = "button_StartTransmitt";
            this.button_StartTransmitt.Size = new System.Drawing.Size(187, 41);
            this.button_StartTransmitt.TabIndex = 4;
            this.button_StartTransmitt.Text = "Transmit";
            this.button_StartTransmitt.UseVisualStyleBackColor = true;
            this.button_StartTransmitt.Click += new System.EventHandler(this.button_StartTransmitt_Click);
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Port.Location = new System.Drawing.Point(7, 120);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(187, 29);
            this.textBox_Port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // textBox_IpAdress
            // 
            this.textBox_IpAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_IpAdress.Location = new System.Drawing.Point(7, 50);
            this.textBox_IpAdress.Name = "textBox_IpAdress";
            this.textBox_IpAdress.Size = new System.Drawing.Size(187, 29);
            this.textBox_IpAdress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adress";
            // 
            // pictureBox_TV
            // 
            this.pictureBox_TV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_TV.BackgroundImage = global::VideoTransmitter.Resource.background;
            this.pictureBox_TV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_TV.Location = new System.Drawing.Point(0, 131);
            this.pictureBox_TV.Name = "pictureBox_TV";
            this.pictureBox_TV.Size = new System.Drawing.Size(790, 365);
            this.pictureBox_TV.TabIndex = 4;
            this.pictureBox_TV.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 521);
            this.Controls.Add(this.pictureBox_TV);
            this.Controls.Add(this.groupBox_ServerConfig);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Transmitter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
            this.groupBox_ServerConfig.ResumeLayout(false);
            this.groupBox_ServerConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.GroupBox groupBox_ServerConfig;
        private System.Windows.Forms.TextBox textBox_IpAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_StartTransmitt;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AudioDevice;
        private System.Windows.Forms.Button button_VideoDevice;
        private System.Windows.Forms.ComboBox comboBox_AudioDevices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_VideoDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_TV;
    }
}

