namespace Giyotin
{
    partial class Giyotin
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.tmrCalıstır = new System.Windows.Forms.Timer(this.components);
            this.btnGiotin = new System.Windows.Forms.Button();
            this.tmrSil = new System.Windows.Forms.Timer(this.components);
            this.tmrGoster = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 12);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(168, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(12, 67);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(240, 381);
            this.lstListe.TabIndex = 2;
            // 
            // tmrCalıstır
            // 
            this.tmrCalıstır.Interval = 250;
            this.tmrCalıstır.Tick += new System.EventHandler(this.tmrCalıstır_Tick);
            // 
            // btnGiotin
            // 
            this.btnGiotin.Location = new System.Drawing.Point(338, 67);
            this.btnGiotin.Name = "btnGiotin";
            this.btnGiotin.Size = new System.Drawing.Size(258, 41);
            this.btnGiotin.TabIndex = 3;
            this.btnGiotin.Text = "Giyotin Baslat";
            this.btnGiotin.UseVisualStyleBackColor = true;
            this.btnGiotin.Click += new System.EventHandler(this.btnGiotin_Click);
            // 
            // tmrSil
            // 
            this.tmrSil.Interval = 500;
            this.tmrSil.Tick += new System.EventHandler(this.tmrSil_Tick);
            // 
            // tmrGoster
            // 
            this.tmrGoster.Interval = 200;
            this.tmrGoster.Tick += new System.EventHandler(this.tmrGoster_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1017, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Giyotin
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1118, 519);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGiotin);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsim);
            this.Name = "Giyotin";
            this.Text = "Giyotin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Timer tmrCalıstır;
        private System.Windows.Forms.Button btnGiotin;
        private System.Windows.Forms.Timer tmrSil;
        private System.Windows.Forms.Timer tmrGoster;
        private System.Windows.Forms.Button btnReset;
    }
}

