namespace Snake
{
    partial class UnFramed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnFramed));
            this.pbFrame = new System.Windows.Forms.PictureBox();
            this.lblS = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblgg = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFrame
            // 
            this.pbFrame.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pbFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFrame.BackgroundImage")));
            this.pbFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFrame.Location = new System.Drawing.Point(110, 137);
            this.pbFrame.Name = "pbFrame";
            this.pbFrame.Size = new System.Drawing.Size(745, 463);
            this.pbFrame.TabIndex = 0;
            this.pbFrame.TabStop = false;
            this.pbFrame.Click += new System.EventHandler(this.pbFrame_Click);
            this.pbFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFramePaint);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.BackColor = System.Drawing.Color.Orange;
            this.lblS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblS.Location = new System.Drawing.Point(12, 125);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(76, 27);
            this.lblS.TabIndex = 1;
            this.lblS.Text = "Skor :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Orange;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(12, 168);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(2, 27);
            this.lblScore.TabIndex = 2;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblgg
            // 
            this.lblgg.AutoSize = true;
            this.lblgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgg.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblgg.Location = new System.Drawing.Point(105, 26);
            this.lblgg.Name = "lblgg";
            this.lblgg.Size = new System.Drawing.Size(58, 25);
            this.lblgg.TabIndex = 3;
            this.lblgg.Text = "Bilgi";
            this.lblgg.Visible = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Orange;
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLevel.Location = new System.Drawing.Point(883, 168);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(2, 27);
            this.lblLevel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(883, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seviye :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(205, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Durdurmak için \"P\" tuşunu kullanabilirsiniz.";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Font = new System.Drawing.Font("Cooper Std Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.DarkOrange;
            this.menu.Location = new System.Drawing.Point(210, 516);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(533, 84);
            this.menu.TabIndex = 7;
            this.menu.Text = "Ana Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Visible = false;
            this.menu.Click += new System.EventHandler(this.menu_click);
            // 
            // Çerçevesiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblgg);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.pbFrame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Çerçevesiz";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblgg;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFrame;
        private System.Windows.Forms.Button menu;
    }
}