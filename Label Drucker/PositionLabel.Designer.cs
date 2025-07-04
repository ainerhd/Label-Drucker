namespace Label_Drucker
{
    partial class PositionLabel
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
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.artikelBeschreibungBoxed = new System.Windows.Forms.TextBox();
            this.artikelBeschreibungsLabel = new System.Windows.Forms.Label();
            this.mengenLabel = new System.Windows.Forms.Label();
            this.positionsLabel = new System.Windows.Forms.Label();
            this.datumsLabel = new System.Windows.Forms.Label();
            this.auftragsNummer = new System.Windows.Forms.Label();
            this.afutragsNummerLabel = new System.Windows.Forms.Label();
            this.positionsNummer = new System.Windows.Forms.TextBox();
            this.mengenNummer = new System.Windows.Forms.TextBox();
            this.serienNummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.Font = new System.Drawing.Font("3 of 9 Barcode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.barcodeLabel.Location = new System.Drawing.Point(8, 116);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(248, 25);
            this.barcodeLabel.TabIndex = 21;
            this.barcodeLabel.Text = "label1";
            this.barcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artikelBeschreibungBoxed
            // 
            this.artikelBeschreibungBoxed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artikelBeschreibungBoxed.Location = new System.Drawing.Point(11, 141);
            this.artikelBeschreibungBoxed.Multiline = true;
            this.artikelBeschreibungBoxed.Name = "artikelBeschreibungBoxed";
            this.artikelBeschreibungBoxed.Size = new System.Drawing.Size(249, 48);
            this.artikelBeschreibungBoxed.TabIndex = 20;
            // 
            // artikelBeschreibungsLabel
            // 
            this.artikelBeschreibungsLabel.AutoSize = true;
            this.artikelBeschreibungsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artikelBeschreibungsLabel.Location = new System.Drawing.Point(12, 99);
            this.artikelBeschreibungsLabel.Name = "artikelBeschreibungsLabel";
            this.artikelBeschreibungsLabel.Size = new System.Drawing.Size(62, 17);
            this.artikelBeschreibungsLabel.TabIndex = 19;
            this.artikelBeschreibungsLabel.Text = "ArtBesch";
            this.artikelBeschreibungsLabel.Click += new System.EventHandler(this.artikelBeschreibungsLabel_Click);
            // 
            // mengenLabel
            // 
            this.mengenLabel.AutoSize = true;
            this.mengenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mengenLabel.Location = new System.Drawing.Point(161, 80);
            this.mengenLabel.Name = "mengenLabel";
            this.mengenLabel.Size = new System.Drawing.Size(49, 15);
            this.mengenLabel.TabIndex = 16;
            this.mengenLabel.Text = "Menge:";
            // 
            // positionsLabel
            // 
            this.positionsLabel.AutoSize = true;
            this.positionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionsLabel.Location = new System.Drawing.Point(161, 65);
            this.positionsLabel.Name = "positionsLabel";
            this.positionsLabel.Size = new System.Drawing.Size(54, 15);
            this.positionsLabel.TabIndex = 15;
            this.positionsLabel.Text = "Position:";
            // 
            // datumsLabel
            // 
            this.datumsLabel.AutoSize = true;
            this.datumsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumsLabel.Location = new System.Drawing.Point(161, 44);
            this.datumsLabel.Name = "datumsLabel";
            this.datumsLabel.Size = new System.Drawing.Size(45, 15);
            this.datumsLabel.TabIndex = 14;
            this.datumsLabel.Text = "Datum";
            // 
            // auftragsNummer
            // 
            this.auftragsNummer.AutoSize = true;
            this.auftragsNummer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auftragsNummer.Location = new System.Drawing.Point(12, 39);
            this.auftragsNummer.Name = "auftragsNummer";
            this.auftragsNummer.Size = new System.Drawing.Size(81, 20);
            this.auftragsNummer.TabIndex = 12;
            this.auftragsNummer.Text = "12345678";
            // 
            // afutragsNummerLabel
            // 
            this.afutragsNummerLabel.AutoSize = true;
            this.afutragsNummerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afutragsNummerLabel.Location = new System.Drawing.Point(12, 24);
            this.afutragsNummerLabel.Name = "afutragsNummerLabel";
            this.afutragsNummerLabel.Size = new System.Drawing.Size(103, 15);
            this.afutragsNummerLabel.TabIndex = 11;
            this.afutragsNummerLabel.Text = "Auftragsnummer";
            // 
            // positionsNummer
            // 
            this.positionsNummer.BackColor = System.Drawing.SystemColors.Control;
            this.positionsNummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.positionsNummer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.positionsNummer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.positionsNummer.Location = new System.Drawing.Point(216, 65);
            this.positionsNummer.Name = "positionsNummer";
            this.positionsNummer.Size = new System.Drawing.Size(44, 16);
            this.positionsNummer.TabIndex = 22;
            this.positionsNummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mengenNummer
            // 
            this.mengenNummer.BackColor = System.Drawing.SystemColors.Control;
            this.mengenNummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mengenNummer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mengenNummer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mengenNummer.Location = new System.Drawing.Point(208, 80);
            this.mengenNummer.Name = "mengenNummer";
            this.mengenNummer.Size = new System.Drawing.Size(52, 16);
            this.mengenNummer.TabIndex = 23;
            this.mengenNummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // serienNummer
            // 
            this.serienNummer.BackColor = System.Drawing.SystemColors.Control;
            this.serienNummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serienNummer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serienNummer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serienNummer.Location = new System.Drawing.Point(16, 65);
            this.serienNummer.Multiline = true;
            this.serienNummer.Name = "serienNummer";
            this.serienNummer.Size = new System.Drawing.Size(139, 31);
            this.serienNummer.TabIndex = 25;
            this.serienNummer.TextChanged += new System.EventHandler(this.serienNummer_TextChanged);
            // 
            // PositionLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.serienNummer);
            this.Controls.Add(this.mengenNummer);
            this.Controls.Add(this.positionsNummer);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.artikelBeschreibungBoxed);
            this.Controls.Add(this.artikelBeschreibungsLabel);
            this.Controls.Add(this.mengenLabel);
            this.Controls.Add(this.positionsLabel);
            this.Controls.Add(this.datumsLabel);
            this.Controls.Add(this.auftragsNummer);
            this.Controls.Add(this.afutragsNummerLabel);
            this.MaximumSize = new System.Drawing.Size(300, 240);
            this.MinimumSize = new System.Drawing.Size(300, 240);
            this.Name = "PositionLabel";
            this.Text = "PositionLabel";
            this.Load += new System.EventHandler(this.PositionLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.TextBox artikelBeschreibungBoxed;
        private System.Windows.Forms.Label artikelBeschreibungsLabel;
        private System.Windows.Forms.Label mengenLabel;
        private System.Windows.Forms.Label positionsLabel;
        private System.Windows.Forms.Label datumsLabel;
        private System.Windows.Forms.Label auftragsNummer;
        private System.Windows.Forms.Label afutragsNummerLabel;
        private System.Windows.Forms.TextBox positionsNummer;
        private System.Windows.Forms.TextBox mengenNummer;
        private System.Windows.Forms.TextBox serienNummer;
    }
}