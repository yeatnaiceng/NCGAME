namespace NCGAME_V1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player1_Button = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Player2_Button = new System.Windows.Forms.Button();
            this.Map_Button = new System.Windows.Forms.Button();
            this.StartGame_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1_Button
            // 
            this.Player1_Button.Location = new System.Drawing.Point(144, 44);
            this.Player1_Button.Name = "Player1_Button";
            this.Player1_Button.Size = new System.Drawing.Size(162, 83);
            this.Player1_Button.TabIndex = 0;
            this.Player1_Button.Text = "Player1";
            this.Player1_Button.UseVisualStyleBackColor = true;
            this.Player1_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(660, 376);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(128, 62);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Player2_Button
            // 
            this.Player2_Button.Location = new System.Drawing.Point(497, 44);
            this.Player2_Button.Name = "Player2_Button";
            this.Player2_Button.Size = new System.Drawing.Size(162, 83);
            this.Player2_Button.TabIndex = 2;
            this.Player2_Button.Text = "Player2";
            this.Player2_Button.UseVisualStyleBackColor = true;
            this.Player2_Button.Click += new System.EventHandler(this.Player2_Button_Click);
            // 
            // Map_Button
            // 
            this.Map_Button.Location = new System.Drawing.Point(323, 162);
            this.Map_Button.Name = "Map_Button";
            this.Map_Button.Size = new System.Drawing.Size(162, 83);
            this.Map_Button.TabIndex = 3;
            this.Map_Button.Text = "Map";
            this.Map_Button.UseVisualStyleBackColor = true;
            this.Map_Button.Click += new System.EventHandler(this.Map_Button_Click);
            // 
            // StartGame_Button
            // 
            this.StartGame_Button.Location = new System.Drawing.Point(323, 316);
            this.StartGame_Button.Name = "StartGame_Button";
            this.StartGame_Button.Size = new System.Drawing.Size(162, 83);
            this.StartGame_Button.TabIndex = 4;
            this.StartGame_Button.Text = "Start Game";
            this.StartGame_Button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartGame_Button);
            this.Controls.Add(this.Map_Button);
            this.Controls.Add(this.Player2_Button);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Player1_Button);
            this.Name = "Form1";
            this.Text = "RPG Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Player1_Button;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Player2_Button;
        private System.Windows.Forms.Button Map_Button;
        private System.Windows.Forms.Button StartGame_Button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

