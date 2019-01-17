namespace PomodoroTimer
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
            this.components = new System.ComponentModel.Container();
            this.TimerCount = new System.Windows.Forms.Label();
            this.pauseCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerCount
            // 
            this.TimerCount.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerCount.ForeColor = System.Drawing.Color.White;
            this.TimerCount.Location = new System.Drawing.Point(38, 47);
            this.TimerCount.Name = "TimerCount";
            this.TimerCount.Size = new System.Drawing.Size(287, 115);
            this.TimerCount.TabIndex = 0;
            this.TimerCount.Text = "00:00";
            this.TimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pauseCount
            // 
            this.pauseCount.AutoSize = true;
            this.pauseCount.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseCount.ForeColor = System.Drawing.Color.White;
            this.pauseCount.Location = new System.Drawing.Point(86, 162);
            this.pauseCount.Name = "pauseCount";
            this.pauseCount.Size = new System.Drawing.Size(191, 78);
            this.pauseCount.TabIndex = 1;
            this.pauseCount.Text = "00:00";
            // 
            // startBtn
            // 
            this.startBtn.AutoSize = true;
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.Coral;
            this.startBtn.Location = new System.Drawing.Point(67, 254);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(104, 36);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pauseCount);
            this.Controls.Add(this.TimerCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerCount;
        private System.Windows.Forms.Label pauseCount;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startBtn;
    }
}

