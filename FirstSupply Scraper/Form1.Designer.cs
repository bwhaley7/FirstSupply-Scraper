namespace FirstSupply_Scraper
{
    partial class Form1
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
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.productNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadExcel = new System.Windows.Forms.Button();
            this.scrapePage = new System.Windows.Forms.Button();
            this.xPathToScrape = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exportFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productGrid
            // 
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumber,
            this.modelNumber,
            this.cat1,
            this.cat2,
            this.cat3,
            this.cat4,
            this.cat5});
            this.productGrid.Location = new System.Drawing.Point(12, 12);
            this.productGrid.Name = "productGrid";
            this.productGrid.RowTemplate.Height = 25;
            this.productGrid.Size = new System.Drawing.Size(730, 218);
            this.productGrid.TabIndex = 0;
            // 
            // productNumber
            // 
            this.productNumber.HeaderText = "Product Number";
            this.productNumber.Name = "productNumber";
            // 
            // modelNumber
            // 
            this.modelNumber.HeaderText = "Model Number";
            this.modelNumber.Name = "modelNumber";
            // 
            // cat1
            // 
            this.cat1.HeaderText = "Category 1";
            this.cat1.Name = "cat1";
            // 
            // cat2
            // 
            this.cat2.HeaderText = "Category 2";
            this.cat2.Name = "cat2";
            // 
            // cat3
            // 
            this.cat3.HeaderText = "Category 3";
            this.cat3.Name = "cat3";
            // 
            // cat4
            // 
            this.cat4.HeaderText = "Category 4";
            this.cat4.Name = "cat4";
            // 
            // cat5
            // 
            this.cat5.HeaderText = "Category 5";
            this.cat5.Name = "cat5";
            // 
            // loadExcel
            // 
            this.loadExcel.Location = new System.Drawing.Point(12, 236);
            this.loadExcel.Name = "loadExcel";
            this.loadExcel.Size = new System.Drawing.Size(75, 23);
            this.loadExcel.TabIndex = 1;
            this.loadExcel.Text = "Load";
            this.loadExcel.UseVisualStyleBackColor = true;
            this.loadExcel.Click += new System.EventHandler(this.loadExcel_Click);
            // 
            // scrapePage
            // 
            this.scrapePage.Location = new System.Drawing.Point(93, 236);
            this.scrapePage.Name = "scrapePage";
            this.scrapePage.Size = new System.Drawing.Size(75, 23);
            this.scrapePage.TabIndex = 2;
            this.scrapePage.Text = "Scrape";
            this.scrapePage.UseVisualStyleBackColor = true;
            this.scrapePage.Click += new System.EventHandler(this.scrapePage_Click);
            // 
            // xPathToScrape
            // 
            this.xPathToScrape.Location = new System.Drawing.Point(58, 265);
            this.xPathToScrape.Name = "xPathToScrape";
            this.xPathToScrape.Size = new System.Drawing.Size(110, 23);
            this.xPathToScrape.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "xPath:";
            // 
            // exportFile
            // 
            this.exportFile.Location = new System.Drawing.Point(174, 236);
            this.exportFile.Name = "exportFile";
            this.exportFile.Size = new System.Drawing.Size(75, 23);
            this.exportFile.TabIndex = 5;
            this.exportFile.Text = "Export";
            this.exportFile.UseVisualStyleBackColor = true;
            this.exportFile.Click += new System.EventHandler(this.exportFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 299);
            this.Controls.Add(this.exportFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xPathToScrape);
            this.Controls.Add(this.scrapePage);
            this.Controls.Add(this.loadExcel);
            this.Controls.Add(this.productGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView productGrid;
        private Button loadExcel;
        private DataGridViewTextBoxColumn productNumber;
        private DataGridViewTextBoxColumn modelNumber;
        private Button scrapePage;
        private TextBox xPathToScrape;
        private Label label1;
        private DataGridViewTextBoxColumn cat1;
        private DataGridViewTextBoxColumn cat2;
        private DataGridViewTextBoxColumn cat3;
        private DataGridViewTextBoxColumn cat4;
        private DataGridViewTextBoxColumn cat5;
        private Button exportFile;
    }
}