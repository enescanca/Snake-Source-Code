namespace Snake
{
    partial class First
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            this.btnGame = new System.Windows.Forms.Button();
            this.btnObject = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.MintCream;
            this.btnGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGame.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGame.ForeColor = System.Drawing.Color.Olive;
            this.btnGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.ImageKey = "(none)";
            this.btnGame.Location = new System.Drawing.Point(27, 28);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(150, 50);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Oyna";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_click);
            // 
            // btnObject
            // 
            this.btnObject.BackColor = System.Drawing.Color.MintCream;
            this.btnObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObject.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnObject.ForeColor = System.Drawing.Color.Olive;
            this.btnObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObject.ImageKey = "(none)";
            this.btnObject.Location = new System.Drawing.Point(27, 96);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(150, 50);
            this.btnObject.TabIndex = 1;
            this.btnObject.Text = "Ayarlar";
            this.btnObject.UseVisualStyleBackColor = false;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.MintCream;
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContact.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContact.ForeColor = System.Drawing.Color.Olive;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.ImageKey = "(none)";
            this.btnContact.Location = new System.Drawing.Point(27, 161);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(150, 50);
            this.btnContact.TabIndex = 2;
            this.btnContact.Text = "İletişim";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(27, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Müzik";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(502, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 322);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnObject);
            this.Controls.Add(this.btnGame);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "First";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan";
            this.Load += new System.EventHandler(this.First_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnObject;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.ImageList ımageList1;
    }
}
