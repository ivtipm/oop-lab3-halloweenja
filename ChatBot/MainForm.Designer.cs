namespace ChatBot
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendText = new System.Windows.Forms.TextBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.ChatText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SendButton);
            this.panel1.Controls.Add(this.SendText);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.ChatText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 470);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.SendButton.Location = new System.Drawing.Point(647, 430);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(137, 33);
            this.SendButton.TabIndex = 69;
            this.SendButton.Text = "Сказать";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SendButton_MouseUp);
            // 
            // SendText
            // 
            this.SendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.SendText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SendText.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.SendText.Location = new System.Drawing.Point(8, 430);
            this.SendText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SendText.Multiline = true;
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(631, 33);
            this.SendText.TabIndex = 68;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Georgia", 18F);
            this.labelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.labelClose.Location = new System.Drawing.Point(740, 7);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(36, 35);
            this.labelClose.TabIndex = 67;
            this.labelClose.Text = "X";
            this.labelClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelClose_MouseDown);
            this.labelClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelClose_MouseUp);
            // 
            // ChatText
            // 
            this.ChatText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.ChatText.Font = new System.Drawing.Font("Georgia", 18F);
            this.ChatText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.ChatText.Location = new System.Drawing.Point(0, 55);
            this.ChatText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChatText.Multiline = true;
            this.ChatText.Name = "ChatText";
            this.ChatText.ReadOnly = true;
            this.ChatText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatText.Size = new System.Drawing.Size(780, 364);
            this.ChatText.TabIndex = 65;
            this.ChatText.TabStop = false;
            this.ChatText.TextChanged += new System.EventHandler(this.ChatText_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatBot.Properties.Resources.BOT;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Angry bot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose;
        public System.Windows.Forms.TextBox ChatText;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

