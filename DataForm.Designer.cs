﻿namespace SnakeGame
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.PlayerID = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.PlayerIDtxt = new System.Windows.Forms.Label();
            this.PlayerNametxt = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerID
            // 
            this.PlayerID.BackColor = System.Drawing.SystemColors.Info;
            this.PlayerID.Location = new System.Drawing.Point(319, 94);
            this.PlayerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerID.Multiline = true;
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.Size = new System.Drawing.Size(209, 25);
            this.PlayerID.TabIndex = 0;
            // 
            // PlayerName
            // 
            this.PlayerName.BackColor = System.Drawing.SystemColors.Info;
            this.PlayerName.Location = new System.Drawing.Point(319, 162);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerName.Multiline = true;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(209, 25);
            this.PlayerName.TabIndex = 0;
            // 
            // PlayerIDtxt
            // 
            this.PlayerIDtxt.AutoSize = true;
            this.PlayerIDtxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIDtxt.Location = new System.Drawing.Point(116, 94);
            this.PlayerIDtxt.Name = "PlayerIDtxt";
            this.PlayerIDtxt.Size = new System.Drawing.Size(138, 25);
            this.PlayerIDtxt.TabIndex = 1;
            this.PlayerIDtxt.Text = "Nhập PlayerID";
            // 
            // PlayerNametxt
            // 
            this.PlayerNametxt.AutoSize = true;
            this.PlayerNametxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNametxt.Location = new System.Drawing.Point(83, 159);
            this.PlayerNametxt.Name = "PlayerNametxt";
            this.PlayerNametxt.Size = new System.Drawing.Size(171, 25);
            this.PlayerNametxt.TabIndex = 1;
            this.PlayerNametxt.Text = "Nhập PlayerName";
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.Salmon;
            this.OKbutton.BackgroundImage = global::SnakeGame.Properties.Resources.Pixel_art_grass_image;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OKbutton.Image = global::SnakeGame.Properties.Resources.Pixel_art_grass_image;
            this.OKbutton.Location = new System.Drawing.Point(319, 220);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(101, 34);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.PlayerIDtxt);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.OKbutton);
            this.panel1.Controls.Add(this.PlayerNametxt);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Controls.Add(this.PlayerID);
            this.panel1.Location = new System.Drawing.Point(83, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 341);
            this.panel1.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.BackgroundImage = global::SnakeGame.Properties.Resources.Pixel_art_grass_image;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Image = global::SnakeGame.Properties.Resources.Pixel_art_grass_image;
            this.exitButton.Location = new System.Drawing.Point(429, 220);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataForm";
            this.Text = "Player Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerID;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label PlayerIDtxt;
        private System.Windows.Forms.Label PlayerNametxt;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
    }
}