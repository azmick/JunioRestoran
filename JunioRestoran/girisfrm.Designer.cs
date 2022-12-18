namespace JunioRestoran
{
    partial class girisfrm
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
            this.kullanicicb = new System.Windows.Forms.ComboBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.girisbtn = new System.Windows.Forms.Button();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.logobox = new System.Windows.Forms.PictureBox();
            this.kullanicilbl = new System.Windows.Forms.Label();
            this.sifrelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanicicb
            // 
            this.kullanicicb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullanicicb.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kullanicicb.FormattingEnabled = true;
            this.kullanicicb.Location = new System.Drawing.Point(403, 243);
            this.kullanicicb.Name = "kullanicicb";
            this.kullanicicb.Size = new System.Drawing.Size(276, 29);
            this.kullanicicb.TabIndex = 0;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(403, 278);
            this.sifretxt.Multiline = true;
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(276, 31);
            this.sifretxt.TabIndex = 1;
            // 
            // girisbtn
            // 
            this.girisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisbtn.Image = global::JunioRestoran.Properties.Resources.giris;
            this.girisbtn.Location = new System.Drawing.Point(403, 315);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(129, 129);
            this.girisbtn.TabIndex = 2;
            this.girisbtn.UseVisualStyleBackColor = true;
            this.kullanicilbl.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // cikisbtn
            // 
            this.cikisbtn.BackgroundImage = global::JunioRestoran.Properties.Resources.cikis;
            this.cikisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisbtn.Location = new System.Drawing.Point(550, 315);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(129, 129);
            this.cikisbtn.TabIndex = 3;
            this.cikisbtn.UseVisualStyleBackColor = true;
            // 
            // logobox
            // 
            this.logobox.BackgroundImage = global::JunioRestoran.Properties.Resources.zyro_image;
            this.logobox.Location = new System.Drawing.Point(437, 12);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(211, 225);
            this.logobox.TabIndex = 4;
            this.logobox.TabStop = false;
            // 
            // kullanicilbl
            // 
            this.kullanicilbl.AutoSize = true;
            this.kullanicilbl.BackColor = System.Drawing.Color.Transparent;
            this.kullanicilbl.Location = new System.Drawing.Point(299, 246);
            this.kullanicilbl.Name = "kullanicilbl";
            this.kullanicilbl.Size = new System.Drawing.Size(98, 21);
            this.kullanicilbl.TabIndex = 5;
            this.kullanicilbl.Text = "Kullanıcı Adı";
            this.kullanicilbl.Click += new System.EventHandler(this.kullanicilbl_Click);
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.BackColor = System.Drawing.Color.Transparent;
            this.sifrelbl.Location = new System.Drawing.Point(345, 281);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(47, 21);
            this.sifrelbl.TabIndex = 6;
            this.sifrelbl.Text = "Şifre";
            // 
            // girisfrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JunioRestoran.Properties.Resources.giriskebap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.kullanicilbl);
            this.Controls.Add(this.logobox);
            this.Controls.Add(this.cikisbtn);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullanicicb);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox kullanicicb;
        private TextBox sifretxt;
        private Button girisbtn;
        private Button cikisbtn;
        private PictureBox logobox;
        private Label kullanicilbl;
        private Label sifrelbl;
    }
}