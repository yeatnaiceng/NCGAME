namespace NCGAME_V1._0
{
    partial class CharacterSelectionForm
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
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Warrior_RadioButton = new System.Windows.Forms.RadioButton();
            this.Magician_RadioButton = new System.Windows.Forms.RadioButton();
            this.Ninja_RadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Done_Button = new System.Windows.Forms.Button();
            this.PlayerNo_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(173, 34);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(184, 22);
            this.Name_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // Warrior_RadioButton
            // 
            this.Warrior_RadioButton.AutoSize = true;
            this.Warrior_RadioButton.Location = new System.Drawing.Point(103, 127);
            this.Warrior_RadioButton.Name = "Warrior_RadioButton";
            this.Warrior_RadioButton.Size = new System.Drawing.Size(76, 21);
            this.Warrior_RadioButton.TabIndex = 2;
            this.Warrior_RadioButton.TabStop = true;
            this.Warrior_RadioButton.Text = "Warrior";
            this.Warrior_RadioButton.UseVisualStyleBackColor = true;
            this.Warrior_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Magician_RadioButton
            // 
            this.Magician_RadioButton.AutoSize = true;
            this.Magician_RadioButton.Location = new System.Drawing.Point(291, 127);
            this.Magician_RadioButton.Name = "Magician_RadioButton";
            this.Magician_RadioButton.Size = new System.Drawing.Size(85, 21);
            this.Magician_RadioButton.TabIndex = 3;
            this.Magician_RadioButton.TabStop = true;
            this.Magician_RadioButton.Text = "Magician";
            this.Magician_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Ninja_RadioButton
            // 
            this.Ninja_RadioButton.AutoSize = true;
            this.Ninja_RadioButton.Location = new System.Drawing.Point(502, 127);
            this.Ninja_RadioButton.Name = "Ninja_RadioButton";
            this.Ninja_RadioButton.Size = new System.Drawing.Size(61, 21);
            this.Ninja_RadioButton.TabIndex = 4;
            this.Ninja_RadioButton.TabStop = true;
            this.Ninja_RadioButton.Text = "Ninja";
            this.Ninja_RadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Character";
            // 
            // Done_Button
            // 
            this.Done_Button.Location = new System.Drawing.Point(103, 318);
            this.Done_Button.Name = "Done_Button";
            this.Done_Button.Size = new System.Drawing.Size(311, 58);
            this.Done_Button.TabIndex = 6;
            this.Done_Button.Text = "Done";
            this.Done_Button.UseVisualStyleBackColor = true;
            this.Done_Button.Click += new System.EventHandler(this.Done_Button_Click);
            // 
            // PlayerNo_Label
            // 
            this.PlayerNo_Label.AutoSize = true;
            this.PlayerNo_Label.Location = new System.Drawing.Point(100, 9);
            this.PlayerNo_Label.Name = "PlayerNo_Label";
            this.PlayerNo_Label.Size = new System.Drawing.Size(66, 17);
            this.PlayerNo_Label.TabIndex = 7;
            this.PlayerNo_Label.Text = "PlayerNo";
            // 
            // CharacterSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerNo_Label);
            this.Controls.Add(this.Done_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ninja_RadioButton);
            this.Controls.Add(this.Magician_RadioButton);
            this.Controls.Add(this.Warrior_RadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_TextBox);
            this.Name = "CharacterSelectionForm";
            this.Text = "CharacterSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Warrior_RadioButton;
        private System.Windows.Forms.RadioButton Magician_RadioButton;
        private System.Windows.Forms.RadioButton Ninja_RadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Done_Button;
        private System.Windows.Forms.Label PlayerNo_Label;
    }
}