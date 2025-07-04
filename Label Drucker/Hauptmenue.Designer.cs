namespace Label_Drucker
{
    partial class Hauptmenue
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.auftragsNummerLabel = new System.Windows.Forms.Label();
            this.auftragsNummerBox = new System.Windows.Forms.TextBox();
            this.tasteHoch = new System.Windows.Forms.Button();
            this.tasteRunter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configurationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasCharacteristicsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.masterDeliveryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterPositionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ettiketPanel = new System.Windows.Forms.Panel();
            this.druckButton = new System.Windows.Forms.Button();
            this.showAuftrag = new System.Windows.Forms.Button();
            this.positionsNummernBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tempTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mengeBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spracheinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptmenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etikettToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MengePrintButton = new System.Windows.Forms.Button();
            this.showAktuellePosition = new System.Windows.Forms.Button();
            this.printAktuellePosition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDPositionBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // auftragsNummerLabel
            // 
            this.auftragsNummerLabel.AutoSize = true;
            this.auftragsNummerLabel.Location = new System.Drawing.Point(12, 29);
            this.auftragsNummerLabel.Name = "auftragsNummerLabel";
            this.auftragsNummerLabel.Size = new System.Drawing.Size(86, 13);
            this.auftragsNummerLabel.TabIndex = 0;
            this.auftragsNummerLabel.Text = "Auftragsnummer:";
            // 
            // auftragsNummerBox
            // 
            this.auftragsNummerBox.Location = new System.Drawing.Point(12, 45);
            this.auftragsNummerBox.Name = "auftragsNummerBox";
            this.auftragsNummerBox.Size = new System.Drawing.Size(97, 20);
            this.auftragsNummerBox.TabIndex = 1;
            // 
            // tasteHoch
            // 
            this.tasteHoch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tasteHoch.Location = new System.Drawing.Point(15, 240);
            this.tasteHoch.Name = "tasteHoch";
            this.tasteHoch.Size = new System.Drawing.Size(94, 26);
            this.tasteHoch.TabIndex = 2;
            this.tasteHoch.Text = "Hoch";
            this.tasteHoch.UseVisualStyleBackColor = true;
            this.tasteHoch.Click += new System.EventHandler(this.tasteHoch_Click);
            // 
            // tasteRunter
            // 
            this.tasteRunter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tasteRunter.Location = new System.Drawing.Point(15, 272);
            this.tasteRunter.Name = "tasteRunter";
            this.tasteRunter.Size = new System.Drawing.Size(94, 26);
            this.tasteRunter.TabIndex = 3;
            this.tasteRunter.Text = "Runter";
            this.tasteRunter.UseVisualStyleBackColor = true;
            this.tasteRunter.Click += new System.EventHandler(this.tasteRunter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.articleDescriptionDataGridViewTextBoxColumn,
            this.configurationIdDataGridViewTextBoxColumn,
            this.deliveryNumberDataGridViewTextBoxColumn,
            this.hasCharacteristicsDataGridViewCheckBoxColumn,
            this.masterDeliveryNumberDataGridViewTextBoxColumn,
            this.masterOrderNumberDataGridViewTextBoxColumn,
            this.masterPositionNumberDataGridViewTextBoxColumn,
            this.masterSiteDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.positionNumberDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oRDPositionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(130, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 162);
            this.dataGridView1.TabIndex = 4;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // articleDescriptionDataGridViewTextBoxColumn
            // 
            this.articleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ArticleDescription";
            this.articleDescriptionDataGridViewTextBoxColumn.HeaderText = "ArticleDescription";
            this.articleDescriptionDataGridViewTextBoxColumn.Name = "articleDescriptionDataGridViewTextBoxColumn";
            // 
            // configurationIdDataGridViewTextBoxColumn
            // 
            this.configurationIdDataGridViewTextBoxColumn.DataPropertyName = "ConfigurationId";
            this.configurationIdDataGridViewTextBoxColumn.HeaderText = "ConfigurationId";
            this.configurationIdDataGridViewTextBoxColumn.Name = "configurationIdDataGridViewTextBoxColumn";
            // 
            // deliveryNumberDataGridViewTextBoxColumn
            // 
            this.deliveryNumberDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNumber";
            this.deliveryNumberDataGridViewTextBoxColumn.HeaderText = "DeliveryNumber";
            this.deliveryNumberDataGridViewTextBoxColumn.Name = "deliveryNumberDataGridViewTextBoxColumn";
            // 
            // hasCharacteristicsDataGridViewCheckBoxColumn
            // 
            this.hasCharacteristicsDataGridViewCheckBoxColumn.DataPropertyName = "HasCharacteristics";
            this.hasCharacteristicsDataGridViewCheckBoxColumn.HeaderText = "HasCharacteristics";
            this.hasCharacteristicsDataGridViewCheckBoxColumn.Name = "hasCharacteristicsDataGridViewCheckBoxColumn";
            // 
            // masterDeliveryNumberDataGridViewTextBoxColumn
            // 
            this.masterDeliveryNumberDataGridViewTextBoxColumn.DataPropertyName = "MasterDeliveryNumber";
            this.masterDeliveryNumberDataGridViewTextBoxColumn.HeaderText = "MasterDeliveryNumber";
            this.masterDeliveryNumberDataGridViewTextBoxColumn.Name = "masterDeliveryNumberDataGridViewTextBoxColumn";
            // 
            // masterOrderNumberDataGridViewTextBoxColumn
            // 
            this.masterOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "MasterOrderNumber";
            this.masterOrderNumberDataGridViewTextBoxColumn.HeaderText = "MasterOrderNumber";
            this.masterOrderNumberDataGridViewTextBoxColumn.Name = "masterOrderNumberDataGridViewTextBoxColumn";
            // 
            // masterPositionNumberDataGridViewTextBoxColumn
            // 
            this.masterPositionNumberDataGridViewTextBoxColumn.DataPropertyName = "MasterPositionNumber";
            this.masterPositionNumberDataGridViewTextBoxColumn.HeaderText = "MasterPositionNumber";
            this.masterPositionNumberDataGridViewTextBoxColumn.Name = "masterPositionNumberDataGridViewTextBoxColumn";
            // 
            // masterSiteDataGridViewTextBoxColumn
            // 
            this.masterSiteDataGridViewTextBoxColumn.DataPropertyName = "MasterSite";
            this.masterSiteDataGridViewTextBoxColumn.HeaderText = "MasterSite";
            this.masterSiteDataGridViewTextBoxColumn.Name = "masterSiteDataGridViewTextBoxColumn";
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // positionNumberDataGridViewTextBoxColumn
            // 
            this.positionNumberDataGridViewTextBoxColumn.DataPropertyName = "PositionNumber";
            this.positionNumberDataGridViewTextBoxColumn.HeaderText = "PositionNumber";
            this.positionNumberDataGridViewTextBoxColumn.Name = "positionNumberDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // oRDPositionBindingSource
            // 
            this.oRDPositionBindingSource.DataSource = typeof(Label_Drucker.SAMsphereServer.ORD_Position);
            // 
            // ettiketPanel
            // 
            this.ettiketPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ettiketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ettiketPanel.Location = new System.Drawing.Point(130, 189);
            this.ettiketPanel.Name = "ettiketPanel";
            this.ettiketPanel.Size = new System.Drawing.Size(300, 230);
            this.ettiketPanel.TabIndex = 5;
            // 
            // druckButton
            // 
            this.druckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.druckButton.Location = new System.Drawing.Point(451, 272);
            this.druckButton.Name = "druckButton";
            this.druckButton.Size = new System.Drawing.Size(94, 23);
            this.druckButton.TabIndex = 6;
            this.druckButton.Text = "Drucken";
            this.druckButton.UseVisualStyleBackColor = true;
            this.druckButton.Click += new System.EventHandler(this.druckButton_Click);
            // 
            // showAuftrag
            // 
            this.showAuftrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAuftrag.Location = new System.Drawing.Point(451, 347);
            this.showAuftrag.Name = "showAuftrag";
            this.showAuftrag.Size = new System.Drawing.Size(94, 40);
            this.showAuftrag.TabIndex = 7;
            this.showAuftrag.Text = "Auftrag anzeigen";
            this.showAuftrag.UseVisualStyleBackColor = true;
            this.showAuftrag.Click += new System.EventHandler(this.AuftragLaden_Click);
            // 
            // positionsNummernBox
            // 
            this.positionsNummernBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.positionsNummernBox.Location = new System.Drawing.Point(451, 246);
            this.positionsNummernBox.Name = "positionsNummernBox";
            this.positionsNummernBox.Size = new System.Drawing.Size(94, 20);
            this.positionsNummernBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Positions auswahl:";
            // 
            // tempTest
            // 
            this.tempTest.Location = new System.Drawing.Point(12, 80);
            this.tempTest.Name = "tempTest";
            this.tempTest.Size = new System.Drawing.Size(97, 48);
            this.tempTest.TabIndex = 10;
            this.tempTest.Text = "Auftrag Suchen";
            this.tempTest.UseVisualStyleBackColor = true;
            this.tempTest.Click += new System.EventHandler(this.tempTest_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Menge:";
            // 
            // mengeBox
            // 
            this.mengeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mengeBox.Location = new System.Drawing.Point(568, 246);
            this.mengeBox.Name = "mengeBox";
            this.mengeBox.Size = new System.Drawing.Size(94, 20);
            this.mengeBox.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spracheinstellungenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // spracheinstellungenToolStripMenuItem
            // 
            this.spracheinstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hauptmenüToolStripMenuItem,
            this.etikettToolStripMenuItem});
            this.spracheinstellungenToolStripMenuItem.Name = "spracheinstellungenToolStripMenuItem";
            this.spracheinstellungenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.spracheinstellungenToolStripMenuItem.Text = "Spracheinstellungen";
            // 
            // hauptmenüToolStripMenuItem
            // 
            this.hauptmenüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englischToolStripMenuItem});
            this.hauptmenüToolStripMenuItem.Name = "hauptmenüToolStripMenuItem";
            this.hauptmenüToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.hauptmenüToolStripMenuItem.Text = "Hauptmenü";
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            // 
            // englischToolStripMenuItem
            // 
            this.englischToolStripMenuItem.Name = "englischToolStripMenuItem";
            this.englischToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.englischToolStripMenuItem.Text = "Englisch";
            // 
            // etikettToolStripMenuItem
            // 
            this.etikettToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem1,
            this.englischToolStripMenuItem1});
            this.etikettToolStripMenuItem.Name = "etikettToolStripMenuItem";
            this.etikettToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.etikettToolStripMenuItem.Text = "Etikett";
            // 
            // deutschToolStripMenuItem1
            // 
            this.deutschToolStripMenuItem1.Name = "deutschToolStripMenuItem1";
            this.deutschToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.deutschToolStripMenuItem1.Text = "Deutsch";
            // 
            // englischToolStripMenuItem1
            // 
            this.englischToolStripMenuItem1.Name = "englischToolStripMenuItem1";
            this.englischToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.englischToolStripMenuItem1.Text = "Englisch";
            // 
            // MengePrintButton
            // 
            this.MengePrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MengePrintButton.Location = new System.Drawing.Point(568, 272);
            this.MengePrintButton.Name = "MengePrintButton";
            this.MengePrintButton.Size = new System.Drawing.Size(94, 23);
            this.MengePrintButton.TabIndex = 14;
            this.MengePrintButton.Text = "Übernehmen";
            this.MengePrintButton.UseVisualStyleBackColor = true;
            this.MengePrintButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // showAktuellePosition
            // 
            this.showAktuellePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAktuellePosition.Location = new System.Drawing.Point(565, 347);
            this.showAktuellePosition.Name = "showAktuellePosition";
            this.showAktuellePosition.Size = new System.Drawing.Size(97, 40);
            this.showAktuellePosition.TabIndex = 15;
            this.showAktuellePosition.Text = "Aktuelle Pos. anzeigen";
            this.showAktuellePosition.UseVisualStyleBackColor = true;
            this.showAktuellePosition.Click += new System.EventHandler(this.showAktuellePosition_Click);
            // 
            // printAktuellePosition
            // 
            this.printAktuellePosition.Location = new System.Drawing.Point(15, 347);
            this.printAktuellePosition.Name = "printAktuellePosition";
            this.printAktuellePosition.Size = new System.Drawing.Size(94, 40);
            this.printAktuellePosition.TabIndex = 17;
            this.printAktuellePosition.Text = "Druck aktuelle Anzeige";
            this.printAktuellePosition.UseVisualStyleBackColor = true;
            this.printAktuellePosition.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Hauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 431);
            this.Controls.Add(this.printAktuellePosition);
            this.Controls.Add(this.showAktuellePosition);
            this.Controls.Add(this.MengePrintButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mengeBox);
            this.Controls.Add(this.tempTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.positionsNummernBox);
            this.Controls.Add(this.showAuftrag);
            this.Controls.Add(this.druckButton);
            this.Controls.Add(this.ettiketPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tasteRunter);
            this.Controls.Add(this.tasteHoch);
            this.Controls.Add(this.auftragsNummerBox);
            this.Controls.Add(this.auftragsNummerLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 470);
            this.Name = "Hauptmenue";
            this.Text = "Hauptmenü";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDPositionBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auftragsNummerLabel;
        private System.Windows.Forms.TextBox auftragsNummerBox;
        private System.Windows.Forms.Button tasteHoch;
        private System.Windows.Forms.Button tasteRunter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configurationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasCharacteristicsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterDeliveryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterPositionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oRDPositionBindingSource;
        private System.Windows.Forms.Panel ettiketPanel;
        private System.Windows.Forms.Button druckButton;
        private System.Windows.Forms.Button showAuftrag;
        private System.Windows.Forms.TextBox positionsNummernBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tempTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mengeBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spracheinstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptmenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etikettToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem1;
        private System.Windows.Forms.Button MengePrintButton;
        private System.Windows.Forms.Button showAktuellePosition;
        private System.Windows.Forms.Button printAktuellePosition;
    }
}

