namespace PicureBox
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picbPhoto
            // 
            this.picbPhoto.AccessibleDescription = "Moje zdjęcie";
            this.picbPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.picbPhoto.Location = new System.Drawing.Point(12, 88);
            this.picbPhoto.Name = "picbPhoto";
            this.picbPhoto.Size = new System.Drawing.Size(436, 257);
            this.picbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPhoto.TabIndex = 0;
            this.picbPhoto.TabStop = false;
            this.picbPhoto.Visible = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(12, 12);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(98, 23);
            this.btnAddPhoto.TabIndex = 1;
            this.btnAddPhoto.Text = "Wczytaj zdjęcie";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.Enabled = false;
            this.btnDeletePhoto.Location = new System.Drawing.Point(163, 12);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePhoto.TabIndex = 2;
            this.btnDeletePhoto.Text = "Usuń zdjęcie";
            this.btnDeletePhoto.UseVisualStyleBackColor = true;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(12, 41);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(98, 23);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "<< Poprzednie <<";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(163, 40);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">> Następne >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Location = new System.Drawing.Point(12, 67);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(0, 13);
            this.lbFile.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 355);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.picbPhoto);
            this.Name = "Form1";
            this.Text = "Przeglądarka zdjęć";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPhoto;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Button btnDeletePhoto;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbFile;
    }
}

