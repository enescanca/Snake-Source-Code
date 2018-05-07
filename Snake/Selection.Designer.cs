namespace Snake
{
    partial class Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection));
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.btnO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Minion Pro", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(78, 28);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(92, 49);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "HIZ:";
            this.lblSpeed.Click += new System.EventHandler(this.lblSpeed_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(21, 94);
            this.tbSpeed.Multiline = true;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(211, 46);
            this.tbSpeed.TabIndex = 1;
            this.tbSpeed.TextChanged += new System.EventHandler(this.tbHiz_TextChanged);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnO.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnO.Location = new System.Drawing.Point(21, 146);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(211, 54);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "Onayla";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(255, 226);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OyunAyarlari";
            this.Load += new System.EventHandler(this.OyunAyarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Button btnO;
        // private System.Windows.Forms.ImageList ımageList2;
    }
}