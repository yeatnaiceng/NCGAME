namespace NCGAME_V1._0
{
    partial class Teleport
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
            this.X_TextBox = new System.Windows.Forms.TextBox();
            this.Y_TextBox = new System.Windows.Forms.TextBox();
            this.X_Label = new System.Windows.Forms.Label();
            this.Y_Label = new System.Windows.Forms.Label();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // X_TextBox
            // 
            this.X_TextBox.Location = new System.Drawing.Point(387, 73);
            this.X_TextBox.Name = "X_TextBox";
            this.X_TextBox.Size = new System.Drawing.Size(100, 22);
            this.X_TextBox.TabIndex = 0;
            // 
            // Y_TextBox
            // 
            this.Y_TextBox.Location = new System.Drawing.Point(387, 120);
            this.Y_TextBox.Name = "Y_TextBox";
            this.Y_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Y_TextBox.TabIndex = 1;
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.Location = new System.Drawing.Point(331, 73);
            this.X_Label.Name = "X_Label";
            this.X_Label.Size = new System.Drawing.Size(29, 17);
            this.X_Label.TabIndex = 2;
            this.X_Label.Text = "X : ";
            // 
            // Y_Label
            // 
            this.Y_Label.AutoSize = true;
            this.Y_Label.Location = new System.Drawing.Point(331, 120);
            this.Y_Label.Name = "Y_Label";
            this.Y_Label.Size = new System.Drawing.Size(29, 17);
            this.Y_Label.TabIndex = 3;
            this.Y_Label.Text = "Y : ";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(387, 179);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(75, 23);
            this.Confirm_Button.TabIndex = 4;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Teleport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Y_Label);
            this.Controls.Add(this.X_Label);
            this.Controls.Add(this.Y_TextBox);
            this.Controls.Add(this.X_TextBox);
            this.Name = "Teleport";
            this.Text = "Teleport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox X_TextBox;
        private System.Windows.Forms.TextBox Y_TextBox;
        private System.Windows.Forms.Label X_Label;
        private System.Windows.Forms.Label Y_Label;
        private System.Windows.Forms.Button Confirm_Button;
    }
}