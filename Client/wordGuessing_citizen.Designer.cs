﻿namespace merge_citizen
{
    partial class wordGuessing_citizen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordGuessing_citizen));
            timeLabel = new Label();
            labelScreen = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxTime = new PictureBox();
            pictureBoxSun = new PictureBox();
            labelDie = new Label();
            pictureBoxDie = new PictureBox();
            panel1 = new Panel();
            labelJob = new Label();
            pictureBoxLine = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDie).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(1060, 34);
            timeLabel.Margin = new Padding(6, 0, 6, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(141, 50);
            timeLabel.TabIndex = 15;
            timeLabel.Text = "3:00";
            // 
            // labelScreen
            // 
            labelScreen.AutoSize = true;
            labelScreen.BackColor = Color.Transparent;
            labelScreen.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelScreen.ForeColor = Color.White;
            labelScreen.Location = new Point(124, 34);
            labelScreen.Margin = new Padding(6, 0, 6, 0);
            labelScreen.Name = "labelScreen";
            labelScreen.Size = new Size(334, 50);
            labelScreen.TabIndex = 12;
            labelScreen.Text = "제시어 맞히기";
            // 
            // pictureBoxTime
            // 
            pictureBoxTime.BackColor = Color.Transparent;
            pictureBoxTime.Image = (Image)resources.GetObject("pictureBoxTime.Image");
            pictureBoxTime.Location = new Point(996, 34);
            pictureBoxTime.Margin = new Padding(6);
            pictureBoxTime.Name = "pictureBoxTime";
            pictureBoxTime.Size = new Size(52, 54);
            pictureBoxTime.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTime.TabIndex = 23;
            pictureBoxTime.TabStop = false;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            pictureBoxSun.Image = (Image)resources.GetObject("pictureBoxSun.Image");
            pictureBoxSun.Location = new Point(60, 24);
            pictureBoxSun.Margin = new Padding(6);
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.Size = new Size(56, 70);
            pictureBoxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSun.TabIndex = 22;
            pictureBoxSun.TabStop = false;
            // 
            // labelDie
            // 
            labelDie.AutoSize = true;
            labelDie.BackColor = Color.FromArgb(15, 17, 24);
            labelDie.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelDie.ForeColor = Color.White;
            labelDie.Location = new Point(316, 260);
            labelDie.Margin = new Padding(6, 0, 6, 0);
            labelDie.Name = "labelDie";
            labelDie.Size = new Size(657, 50);
            labelDie.TabIndex = 24;
            labelDie.Text = "user1님이 처형당했습니다.";
            // 
            // pictureBoxDie
            // 
            pictureBoxDie.BackColor = Color.FromArgb(15, 17, 24);
            pictureBoxDie.Image = (Image)resources.GetObject("pictureBoxDie.Image");
            pictureBoxDie.Location = new Point(216, 222);
            pictureBoxDie.Margin = new Padding(6);
            pictureBoxDie.Name = "pictureBoxDie";
            pictureBoxDie.Size = new Size(854, 114);
            pictureBoxDie.TabIndex = 26;
            pictureBoxDie.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 17, 24);
            panel1.Controls.Add(labelJob);
            panel1.Controls.Add(pictureBoxLine);
            panel1.Location = new Point(216, 316);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 224);
            panel1.TabIndex = 25;
            // 
            // labelJob
            // 
            labelJob.AutoSize = true;
            labelJob.BackColor = Color.Transparent;
            labelJob.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelJob.ForeColor = Color.White;
            labelJob.Location = new Point(294, 44);
            labelJob.Margin = new Padding(6, 0, 6, 0);
            labelJob.Name = "labelJob";
            labelJob.Size = new Size(284, 100);
            labelJob.TabIndex = 18;
            labelJob.Text = "User1님은\r\n시민입니다.";
            // 
            // pictureBoxLine
            // 
            pictureBoxLine.BackColor = Color.FromArgb(15, 17, 24);
            pictureBoxLine.Image = (Image)resources.GetObject("pictureBoxLine.Image");
            pictureBoxLine.Location = new Point(0, 150);
            pictureBoxLine.Margin = new Padding(6);
            pictureBoxLine.Name = "pictureBoxLine";
            pictureBoxLine.Size = new Size(854, 74);
            pictureBoxLine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLine.TabIndex = 18;
            pictureBoxLine.TabStop = false;
            // 
            // wordGuessing_citizen
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 720);
            Controls.Add(labelDie);
            Controls.Add(pictureBoxDie);
            Controls.Add(panel1);
            Controls.Add(pictureBoxTime);
            Controls.Add(pictureBoxSun);
            Controls.Add(timeLabel);
            Controls.Add(labelScreen);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6);
            Name = "wordGuessing_citizen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MafiaGame";
            
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDie).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxTime;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private Label labelDie;
        private PictureBox pictureBoxDie;
        private Panel panel1;
        private Label labelJob;
        private PictureBox pictureBoxLine;
    }
}