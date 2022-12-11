namespace ornekaraba
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtbxMarka = new System.Windows.Forms.TextBox();
            this.txtbxModel = new System.Windows.Forms.TextBox();
            this.txtbxRenk = new System.Windows.Forms.TextBox();
            this.txtListele = new System.Windows.Forms.TextBox();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(192, 170);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(181, 37);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(57, 233);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(353, 39);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(129, 46);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(57, 20);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(129, 94);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 20);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model:";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(129, 135);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(51, 20);
            this.lblRenk.TabIndex = 4;
            this.lblRenk.Text = "Renk:";
            // 
            // txtbxMarka
            // 
            this.txtbxMarka.Location = new System.Drawing.Point(192, 46);
            this.txtbxMarka.Name = "txtbxMarka";
            this.txtbxMarka.Size = new System.Drawing.Size(181, 26);
            this.txtbxMarka.TabIndex = 5;
            // 
            // txtbxModel
            // 
            this.txtbxModel.Location = new System.Drawing.Point(192, 94);
            this.txtbxModel.Name = "txtbxModel";
            this.txtbxModel.Size = new System.Drawing.Size(181, 26);
            this.txtbxModel.TabIndex = 6;
            // 
            // txtbxRenk
            // 
            this.txtbxRenk.Location = new System.Drawing.Point(192, 138);
            this.txtbxRenk.Name = "txtbxRenk";
            this.txtbxRenk.Size = new System.Drawing.Size(181, 26);
            this.txtbxRenk.TabIndex = 7;
            // 
            // txtListele
            // 
            this.txtListele.Location = new System.Drawing.Point(57, 278);
            this.txtListele.Multiline = true;
            this.txtListele.Name = "txtListele";
            this.txtListele.Size = new System.Drawing.Size(353, 150);
            this.txtListele.TabIndex = 9;
            // 
            // dgwListe
            // 
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(438, 278);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.RowHeadersWidth = 62;
            this.dgwListe.RowTemplate.Height = 28;
            this.dgwListe.Size = new System.Drawing.Size(240, 150);
            this.dgwListe.TabIndex = 10;
            this.dgwListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListe_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.txtListele);
            this.Controls.Add(this.txtbxRenk);
            this.Controls.Add(this.txtbxModel);
            this.Controls.Add(this.txtbxMarka);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.TextBox txtbxMarka;
        private System.Windows.Forms.TextBox txtbxModel;
        private System.Windows.Forms.TextBox txtbxRenk;
        private System.Windows.Forms.TextBox txtListele;
        private System.Windows.Forms.DataGridView dgwListe;
    }
}

