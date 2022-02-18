
namespace HeadHunterGame.RockScissorsPaper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.txtCountdown = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(44, 393);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(173, 393);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 1;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(309, 393);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(44, 26);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::HeadHunterGame.RockScissorsPaper.Properties.Resources.Empty;
            this.picPlayer.Location = new System.Drawing.Point(44, 131);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(100, 132);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 4;
            this.picPlayer.TabStop = false;
            // 
            // picCPU
            // 
            this.picCPU.Image = global::HeadHunterGame.RockScissorsPaper.Properties.Resources.Empty;
            this.picCPU.Location = new System.Drawing.Point(284, 131);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(100, 132);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 5;
            this.picCPU.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPU";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(459, 131);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(97, 15);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Player: 0 - CPU: 0";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.Location = new System.Drawing.Point(459, 248);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(54, 15);
            this.txtRounds.TabIndex = 9;
            this.txtRounds.Text = "Round: 3";
            // 
            // txtCountdown
            // 
            this.txtCountdown.AutoSize = true;
            this.txtCountdown.Location = new System.Drawing.Point(600, 190);
            this.txtCountdown.Name = "txtCountdown";
            this.txtCountdown.Size = new System.Drawing.Size(13, 15);
            this.txtCountdown.TabIndex = 10;
            this.txtCountdown.Text = "5";
            this.txtCountdown.Click += new System.EventHandler(this.txtCountdown_Click);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCountdown);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "RockScissorsPaper Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Label txtCountdown;
        private System.Windows.Forms.Timer countDownTimer;
    }
}

