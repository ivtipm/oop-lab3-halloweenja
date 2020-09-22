namespace ChatBot
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.buttLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LoginText);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.buttLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 162);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.LoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginText.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.LoginText.Location = new System.Drawing.Point(16, 60);
            this.LoginText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(317, 41);
            this.LoginText.TabIndex = 63;
            this.LoginText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginText.Enter += new System.EventHandler(this.LoginText_Enter);
            this.LoginText.Leave += new System.EventHandler(this.LoginText_Leave);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Georgia", 18F);
            this.labelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.labelClose.Location = new System.Drawing.Point(301, 6);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(36, 35);
            this.labelClose.TabIndex = 62;
            this.labelClose.Text = "X";
            this.labelClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelClose_MouseDown_1);
            this.labelClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelClose_MouseUp);
            // 
            // buttLogin
            // 
            this.buttLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.buttLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttLogin.FlatAppearance.BorderSize = 0;
            this.buttLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.buttLogin.Location = new System.Drawing.Point(117, 111);
            this.buttLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttLogin.Name = "buttLogin";
            this.buttLogin.Size = new System.Drawing.Size(112, 41);
            this.buttLogin.TabIndex = 61;
            this.buttLogin.Text = "Вход";
            this.buttLogin.UseVisualStyleBackColor = false;
            this.buttLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttLogin_MouseDown);
            this.buttLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttLogin_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatBot.Properties.Resources.BOT;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(349, 162);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button buttLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}