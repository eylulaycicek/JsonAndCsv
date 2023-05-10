namespace JSONveCSVDosyalar
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
            this.btn_json_olustur = new System.Windows.Forms.Button();
            this.btn_json_oku = new System.Windows.Forms.Button();
            this.lst_personeller = new System.Windows.Forms.ListBox();
            this.btn_csvolustur = new System.Windows.Forms.Button();
            this.btn_csvoku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_json_olustur
            // 
            this.btn_json_olustur.Location = new System.Drawing.Point(39, 25);
            this.btn_json_olustur.Name = "btn_json_olustur";
            this.btn_json_olustur.Size = new System.Drawing.Size(184, 62);
            this.btn_json_olustur.TabIndex = 0;
            this.btn_json_olustur.Text = "JSON Dosya Oluştur";
            this.btn_json_olustur.UseVisualStyleBackColor = true;
            this.btn_json_olustur.Click += new System.EventHandler(this.btn_json_olustur_Click);
            // 
            // btn_json_oku
            // 
            this.btn_json_oku.Location = new System.Drawing.Point(327, 25);
            this.btn_json_oku.Name = "btn_json_oku";
            this.btn_json_oku.Size = new System.Drawing.Size(188, 62);
            this.btn_json_oku.TabIndex = 1;
            this.btn_json_oku.Text = "JSON Dosya Oku";
            this.btn_json_oku.UseVisualStyleBackColor = true;
            this.btn_json_oku.Click += new System.EventHandler(this.btn_json_oku_Click);
            // 
            // lst_personeller
            // 
            this.lst_personeller.FormattingEnabled = true;
            this.lst_personeller.ItemHeight = 20;
            this.lst_personeller.Location = new System.Drawing.Point(39, 93);
            this.lst_personeller.Name = "lst_personeller";
            this.lst_personeller.Size = new System.Drawing.Size(493, 464);
            this.lst_personeller.TabIndex = 2;
            // 
            // btn_csvolustur
            // 
            this.btn_csvolustur.Location = new System.Drawing.Point(39, 582);
            this.btn_csvolustur.Name = "btn_csvolustur";
            this.btn_csvolustur.Size = new System.Drawing.Size(184, 62);
            this.btn_csvolustur.TabIndex = 0;
            this.btn_csvolustur.Text = "CSVDosya Oluştur";
            this.btn_csvolustur.UseVisualStyleBackColor = true;
            this.btn_csvolustur.Click += new System.EventHandler(this.btn_csvolustur_Click);
            // 
            // btn_csvoku
            // 
            this.btn_csvoku.Location = new System.Drawing.Point(327, 582);
            this.btn_csvoku.Name = "btn_csvoku";
            this.btn_csvoku.Size = new System.Drawing.Size(188, 62);
            this.btn_csvoku.TabIndex = 1;
            this.btn_csvoku.Text = "csv Dosya Oku";
            this.btn_csvoku.UseVisualStyleBackColor = true;
            this.btn_csvoku.Click += new System.EventHandler(this.btn_csvoku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 656);
            this.Controls.Add(this.lst_personeller);
            this.Controls.Add(this.btn_csvoku);
            this.Controls.Add(this.btn_csvolustur);
            this.Controls.Add(this.btn_json_oku);
            this.Controls.Add(this.btn_json_olustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_json_olustur;
        private System.Windows.Forms.Button btn_json_oku;
        private System.Windows.Forms.ListBox lst_personeller;
        private System.Windows.Forms.Button btn_csvolustur;
        private System.Windows.Forms.Button btn_csvoku;
    }
}

