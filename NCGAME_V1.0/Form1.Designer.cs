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
            this.Player1_Name_Label = new System.Windows.Forms.Label();
            this.Player2_Name_Label = new System.Windows.Forms.Label();
            this.Player1_Character_Label = new System.Windows.Forms.Label();
            this.Player2_Character_Label = new System.Windows.Forms.Label();
            this.Player1_CharacterS1_Label = new System.Windows.Forms.Label();
            this.Player2_CharacterS1_Label = new System.Windows.Forms.Label();
            this.Player1_CharacterS2_Label = new System.Windows.Forms.Label();
            this.Player2_CharacterS2_Label = new System.Windows.Forms.Label();
            this.Player1_CharacterS3_Label = new System.Windows.Forms.Label();
            this.Player2_CharacterS3_Label = new System.Windows.Forms.Label();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Player1_CharacterS1Voice_Button = new System.Windows.Forms.Button();
            this.Player2_CharacterS1Voice_Button = new System.Windows.Forms.Button();
            this.Player1_CharacterS2Voice_Button = new System.Windows.Forms.Button();
            this.Player2_CharacterS2Voice_Button = new System.Windows.Forms.Button();
            this.Player1_CharacterS3Voice_Button = new System.Windows.Forms.Button();
            this.Player2_CharacterS3Voice_Button = new System.Windows.Forms.Button();
            this.MapSize_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1_Button
            // 
            this.Player1_Button.Location = new System.Drawing.Point(147, 44);
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
            this.Map_Button.Location = new System.Drawing.Point(315, 307);
            this.Map_Button.Name = "Map_Button";
            this.Map_Button.Size = new System.Drawing.Size(162, 83);
            this.Map_Button.TabIndex = 3;
            this.Map_Button.Text = "Map";
            this.Map_Button.UseVisualStyleBackColor = true;
            this.Map_Button.Click += new System.EventHandler(this.Map_Button_Click);
            // 
            // StartGame_Button
            // 
            this.StartGame_Button.BackColor = System.Drawing.Color.Red;
            this.StartGame_Button.Location = new System.Drawing.Point(315, 476);
            this.StartGame_Button.Name = "StartGame_Button";
            this.StartGame_Button.Size = new System.Drawing.Size(162, 83);
            this.StartGame_Button.TabIndex = 4;
            this.StartGame_Button.Text = "Start Game";
            this.StartGame_Button.UseVisualStyleBackColor = false;
            this.StartGame_Button.Click += new System.EventHandler(this.StartGame_Button_Click);
            // 
            // Player1_Name_Label
            // 
            this.Player1_Name_Label.AutoSize = true;
            this.Player1_Name_Label.Location = new System.Drawing.Point(144, 143);
            this.Player1_Name_Label.Name = "Player1_Name_Label";
            this.Player1_Name_Label.Size = new System.Drawing.Size(57, 17);
            this.Player1_Name_Label.TabIndex = 6;
            this.Player1_Name_Label.Text = "Name : ";
            // 
            // Player2_Name_Label
            // 
            this.Player2_Name_Label.AutoSize = true;
            this.Player2_Name_Label.Location = new System.Drawing.Point(494, 143);
            this.Player2_Name_Label.Name = "Player2_Name_Label";
            this.Player2_Name_Label.Size = new System.Drawing.Size(57, 17);
            this.Player2_Name_Label.TabIndex = 7;
            this.Player2_Name_Label.Text = "Name : ";
            // 
            // Player1_Character_Label
            // 
            this.Player1_Character_Label.AutoSize = true;
            this.Player1_Character_Label.Location = new System.Drawing.Point(144, 174);
            this.Player1_Character_Label.Name = "Player1_Character_Label";
            this.Player1_Character_Label.Size = new System.Drawing.Size(82, 17);
            this.Player1_Character_Label.TabIndex = 8;
            this.Player1_Character_Label.Text = "Character : ";
            // 
            // Player2_Character_Label
            // 
            this.Player2_Character_Label.AutoSize = true;
            this.Player2_Character_Label.Location = new System.Drawing.Point(494, 174);
            this.Player2_Character_Label.Name = "Player2_Character_Label";
            this.Player2_Character_Label.Size = new System.Drawing.Size(82, 17);
            this.Player2_Character_Label.TabIndex = 9;
            this.Player2_Character_Label.Text = "Character : ";
            // 
            // Player1_CharacterS1_Label
            // 
            this.Player1_CharacterS1_Label.AutoSize = true;
            this.Player1_CharacterS1_Label.Location = new System.Drawing.Point(144, 206);
            this.Player1_CharacterS1_Label.Name = "Player1_CharacterS1_Label";
            this.Player1_CharacterS1_Label.Size = new System.Drawing.Size(57, 17);
            this.Player1_CharacterS1_Label.TabIndex = 10;
            this.Player1_CharacterS1_Label.Text = "Skill 1 : ";
            this.Player1_CharacterS1_Label.Click += new System.EventHandler(this.Player1_CharacterS1_Label_Click);
            // 
            // Player2_CharacterS1_Label
            // 
            this.Player2_CharacterS1_Label.AutoSize = true;
            this.Player2_CharacterS1_Label.Location = new System.Drawing.Point(494, 206);
            this.Player2_CharacterS1_Label.Name = "Player2_CharacterS1_Label";
            this.Player2_CharacterS1_Label.Size = new System.Drawing.Size(57, 17);
            this.Player2_CharacterS1_Label.TabIndex = 11;
            this.Player2_CharacterS1_Label.Text = "Skill 1 : ";
            // 
            // Player1_CharacterS2_Label
            // 
            this.Player1_CharacterS2_Label.AutoSize = true;
            this.Player1_CharacterS2_Label.Location = new System.Drawing.Point(144, 233);
            this.Player1_CharacterS2_Label.Name = "Player1_CharacterS2_Label";
            this.Player1_CharacterS2_Label.Size = new System.Drawing.Size(57, 17);
            this.Player1_CharacterS2_Label.TabIndex = 12;
            this.Player1_CharacterS2_Label.Text = "Skill 2 : ";
            // 
            // Player2_CharacterS2_Label
            // 
            this.Player2_CharacterS2_Label.AutoSize = true;
            this.Player2_CharacterS2_Label.Location = new System.Drawing.Point(494, 233);
            this.Player2_CharacterS2_Label.Name = "Player2_CharacterS2_Label";
            this.Player2_CharacterS2_Label.Size = new System.Drawing.Size(57, 17);
            this.Player2_CharacterS2_Label.TabIndex = 13;
            this.Player2_CharacterS2_Label.Text = "Skill 2 : ";
            // 
            // Player1_CharacterS3_Label
            // 
            this.Player1_CharacterS3_Label.AutoSize = true;
            this.Player1_CharacterS3_Label.Location = new System.Drawing.Point(144, 260);
            this.Player1_CharacterS3_Label.Name = "Player1_CharacterS3_Label";
            this.Player1_CharacterS3_Label.Size = new System.Drawing.Size(57, 17);
            this.Player1_CharacterS3_Label.TabIndex = 14;
            this.Player1_CharacterS3_Label.Text = "Skill 3 : ";
            // 
            // Player2_CharacterS3_Label
            // 
            this.Player2_CharacterS3_Label.AutoSize = true;
            this.Player2_CharacterS3_Label.Location = new System.Drawing.Point(494, 260);
            this.Player2_CharacterS3_Label.Name = "Player2_CharacterS3_Label";
            this.Player2_CharacterS3_Label.Size = new System.Drawing.Size(57, 17);
            this.Player2_CharacterS3_Label.TabIndex = 15;
            this.Player2_CharacterS3_Label.Text = "Skill 3 : ";
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackColor = System.Drawing.Color.Lime;
            this.Refresh_Button.Location = new System.Drawing.Point(301, 424);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(200, 23);
            this.Refresh_Button.TabIndex = 16;
            this.Refresh_Button.Text = "Check Latest Info";
            this.Refresh_Button.UseVisualStyleBackColor = false;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Player1_CharacterS1Voice_Button
            // 
            this.Player1_CharacterS1Voice_Button.Location = new System.Drawing.Point(33, 200);
            this.Player1_CharacterS1Voice_Button.Name = "Player1_CharacterS1Voice_Button";
            this.Player1_CharacterS1Voice_Button.Size = new System.Drawing.Size(75, 23);
            this.Player1_CharacterS1Voice_Button.TabIndex = 17;
            this.Player1_CharacterS1Voice_Button.Text = "Skill 1";
            this.Player1_CharacterS1Voice_Button.UseVisualStyleBackColor = true;
            this.Player1_CharacterS1Voice_Button.Click += new System.EventHandler(this.Player1_CharacterS1Voice_Button_Click);
            // 
            // Player2_CharacterS1Voice_Button
            // 
            this.Player2_CharacterS1Voice_Button.Location = new System.Drawing.Point(798, 200);
            this.Player2_CharacterS1Voice_Button.Name = "Player2_CharacterS1Voice_Button";
            this.Player2_CharacterS1Voice_Button.Size = new System.Drawing.Size(75, 23);
            this.Player2_CharacterS1Voice_Button.TabIndex = 18;
            this.Player2_CharacterS1Voice_Button.Text = "Skill 1";
            this.Player2_CharacterS1Voice_Button.UseVisualStyleBackColor = true;
            this.Player2_CharacterS1Voice_Button.Click += new System.EventHandler(this.Player2_CharacterS1Voice_Button_Click);
            // 
            // Player1_CharacterS2Voice_Button
            // 
            this.Player1_CharacterS2Voice_Button.Location = new System.Drawing.Point(33, 229);
            this.Player1_CharacterS2Voice_Button.Name = "Player1_CharacterS2Voice_Button";
            this.Player1_CharacterS2Voice_Button.Size = new System.Drawing.Size(75, 23);
            this.Player1_CharacterS2Voice_Button.TabIndex = 19;
            this.Player1_CharacterS2Voice_Button.Text = "Skill 2";
            this.Player1_CharacterS2Voice_Button.UseVisualStyleBackColor = true;
            this.Player1_CharacterS2Voice_Button.Click += new System.EventHandler(this.Player1_CharacterS2Voice_Button_Click);
            // 
            // Player2_CharacterS2Voice_Button
            // 
            this.Player2_CharacterS2Voice_Button.Location = new System.Drawing.Point(798, 233);
            this.Player2_CharacterS2Voice_Button.Name = "Player2_CharacterS2Voice_Button";
            this.Player2_CharacterS2Voice_Button.Size = new System.Drawing.Size(75, 23);
            this.Player2_CharacterS2Voice_Button.TabIndex = 20;
            this.Player2_CharacterS2Voice_Button.Text = "Skill 2";
            this.Player2_CharacterS2Voice_Button.UseVisualStyleBackColor = true;
            this.Player2_CharacterS2Voice_Button.Click += new System.EventHandler(this.Player2_CharacterS2Voice_Button_Click);
            // 
            // Player1_CharacterS3Voice_Button
            // 
            this.Player1_CharacterS3Voice_Button.Location = new System.Drawing.Point(33, 258);
            this.Player1_CharacterS3Voice_Button.Name = "Player1_CharacterS3Voice_Button";
            this.Player1_CharacterS3Voice_Button.Size = new System.Drawing.Size(75, 23);
            this.Player1_CharacterS3Voice_Button.TabIndex = 21;
            this.Player1_CharacterS3Voice_Button.Text = "Skill 3";
            this.Player1_CharacterS3Voice_Button.UseVisualStyleBackColor = true;
            this.Player1_CharacterS3Voice_Button.Click += new System.EventHandler(this.Player1_CharacterS3Voice_Button_Click);
            // 
            // Player2_CharacterS3Voice_Button
            // 
            this.Player2_CharacterS3Voice_Button.Location = new System.Drawing.Point(798, 262);
            this.Player2_CharacterS3Voice_Button.Name = "Player2_CharacterS3Voice_Button";
            this.Player2_CharacterS3Voice_Button.Size = new System.Drawing.Size(75, 23);
            this.Player2_CharacterS3Voice_Button.TabIndex = 22;
            this.Player2_CharacterS3Voice_Button.Text = "Skill 3";
            this.Player2_CharacterS3Voice_Button.UseVisualStyleBackColor = true;
            this.Player2_CharacterS3Voice_Button.Click += new System.EventHandler(this.Player2_CharacterS3Voice_Button_Click);
            // 
            // MapSize_Label
            // 
            this.MapSize_Label.AutoSize = true;
            this.MapSize_Label.Location = new System.Drawing.Point(505, 340);
            this.MapSize_Label.Name = "MapSize_Label";
            this.MapSize_Label.Size = new System.Drawing.Size(78, 17);
            this.MapSize_Label.TabIndex = 23;
            this.MapSize_Label.Text = "Map Size : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 571);
            this.Controls.Add(this.MapSize_Label);
            this.Controls.Add(this.Player2_CharacterS3Voice_Button);
            this.Controls.Add(this.Player1_CharacterS3Voice_Button);
            this.Controls.Add(this.Player2_CharacterS2Voice_Button);
            this.Controls.Add(this.Player1_CharacterS2Voice_Button);
            this.Controls.Add(this.Player2_CharacterS1Voice_Button);
            this.Controls.Add(this.Player1_CharacterS1Voice_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Player2_CharacterS3_Label);
            this.Controls.Add(this.Player1_CharacterS3_Label);
            this.Controls.Add(this.Player2_CharacterS2_Label);
            this.Controls.Add(this.Player1_CharacterS2_Label);
            this.Controls.Add(this.Player2_CharacterS1_Label);
            this.Controls.Add(this.Player1_CharacterS1_Label);
            this.Controls.Add(this.Player2_Character_Label);
            this.Controls.Add(this.Player1_Character_Label);
            this.Controls.Add(this.Player2_Name_Label);
            this.Controls.Add(this.Player1_Name_Label);
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
        private System.Windows.Forms.Label Player1_Name_Label;
        private System.Windows.Forms.Label Player2_Name_Label;
        private System.Windows.Forms.Label Player1_Character_Label;
        private System.Windows.Forms.Label Player2_Character_Label;
        private System.Windows.Forms.Label Player1_CharacterS1_Label;
        private System.Windows.Forms.Label Player2_CharacterS1_Label;
        private System.Windows.Forms.Label Player1_CharacterS2_Label;
        private System.Windows.Forms.Label Player2_CharacterS2_Label;
        private System.Windows.Forms.Label Player1_CharacterS3_Label;
        private System.Windows.Forms.Label Player2_CharacterS3_Label;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button Player1_CharacterS1Voice_Button;
        private System.Windows.Forms.Button Player2_CharacterS1Voice_Button;
        private System.Windows.Forms.Button Player1_CharacterS2Voice_Button;
        private System.Windows.Forms.Button Player2_CharacterS2Voice_Button;
        private System.Windows.Forms.Button Player1_CharacterS3Voice_Button;
        private System.Windows.Forms.Button Player2_CharacterS3Voice_Button;
        private System.Windows.Forms.Label MapSize_Label;
    }
}

