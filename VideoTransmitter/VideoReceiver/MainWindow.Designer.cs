namespace VideoReceiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button_Receive = new System.Windows.Forms.Button();
            this.pictureBox_TV = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel_Info.Text = "Готов";
            // 
            // panel_Controls
            // 
            this.panel_Controls.Controls.Add(this.button_Receive);
            this.panel_Controls.Controls.Add(this.textBox_Port);
            this.panel_Controls.Controls.Add(this.label2);
            this.panel_Controls.Controls.Add(this.textBox_IP);
            this.panel_Controls.Controls.Add(this.label1);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Controls.Location = new System.Drawing.Point(0, 24);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(800, 50);
            this.panel_Controls.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adress";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_IP.Location = new System.Drawing.Point(125, 9);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(212, 32);
            this.textBox_IP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Port.Location = new System.Drawing.Point(405, 9);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(90, 32);
            this.textBox_Port.TabIndex = 3;
            // 
            // button_Receive
            // 
            this.button_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Receive.Location = new System.Drawing.Point(502, 9);
            this.button_Receive.Name = "button_Receive";
            this.button_Receive.Size = new System.Drawing.Size(127, 32);
            this.button_Receive.TabIndex = 4;
            this.button_Receive.Text = "Receive";
            this.button_Receive.UseVisualStyleBackColor = true;
            this.button_Receive.Click += new System.EventHandler(this.button_Receive_Click);
            // 
            // pictureBox_TV
            // 
            this.pictureBox_TV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_TV.BackgroundImage")));
            this.pictureBox_TV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_TV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_TV.Location = new System.Drawing.Point(0, 74);
            this.pictureBox_TV.Name = "pictureBox_TV";
            this.pictureBox_TV.Size = new System.Drawing.Size(800, 354);
            this.pictureBox_TV.TabIndex = 3;
            this.pictureBox_TV.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_TV);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
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
        private System.Windows.Forms.Button button_Receive;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_TV;
    }
}

