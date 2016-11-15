namespace Funds
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.grpBoxCommands = new System.Windows.Forms.GroupBox();
            this.rbBond = new System.Windows.Forms.RadioButton();
            this.rbEquity = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nrPrice = new System.Windows.Forms.NumericUpDown();
            this.nrQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.grpBoxSummary = new System.Windows.Forms.GroupBox();
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.gridFunds = new System.Windows.Forms.DataGridView();
            this.grpBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnlCommands.SuspendLayout();
            this.grpBoxCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantity)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.grpBoxSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunds)).BeginInit();
            this.grpBoxDataGrid.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCommands
            // 
            this.pnlCommands.Controls.Add(this.grpBoxCommands);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommands.Location = new System.Drawing.Point(0, 0);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlCommands.Size = new System.Drawing.Size(858, 77);
            this.pnlCommands.TabIndex = 0;
            // 
            // grpBoxCommands
            // 
            this.grpBoxCommands.Controls.Add(this.rbBond);
            this.grpBoxCommands.Controls.Add(this.rbEquity);
            this.grpBoxCommands.Controls.Add(this.btnAdd);
            this.grpBoxCommands.Controls.Add(this.lblPrice);
            this.grpBoxCommands.Controls.Add(this.lblQuantity);
            this.grpBoxCommands.Controls.Add(this.nrPrice);
            this.grpBoxCommands.Controls.Add(this.nrQuantity);
            this.grpBoxCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCommands.Location = new System.Drawing.Point(3, 0);
            this.grpBoxCommands.Name = "grpBoxCommands";
            this.grpBoxCommands.Size = new System.Drawing.Size(852, 74);
            this.grpBoxCommands.TabIndex = 4;
            this.grpBoxCommands.TabStop = false;
            this.grpBoxCommands.Text = "Manage";
            // 
            // rbBond
            // 
            this.rbBond.AutoSize = true;
            this.rbBond.Location = new System.Drawing.Point(13, 44);
            this.rbBond.Name = "rbBond";
            this.rbBond.Size = new System.Drawing.Size(50, 17);
            this.rbBond.TabIndex = 2;
            this.rbBond.TabStop = true;
            this.rbBond.Text = "Bond";
            this.rbBond.UseVisualStyleBackColor = true;
            // 
            // rbEquity
            // 
            this.rbEquity.AutoSize = true;
            this.rbEquity.Checked = true;
            this.rbEquity.Location = new System.Drawing.Point(13, 18);
            this.rbEquity.Name = "rbEquity";
            this.rbEquity.Size = new System.Drawing.Size(54, 17);
            this.rbEquity.TabIndex = 1;
            this.rbEquity.TabStop = true;
            this.rbEquity.Text = "Equity";
            this.rbEquity.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(246, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(98, 46);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(83, 20);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // nrPrice
            // 
            this.nrPrice.DecimalPlaces = 2;
            this.nrPrice.Location = new System.Drawing.Point(135, 44);
            this.nrPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrPrice.Name = "nrPrice";
            this.nrPrice.Size = new System.Drawing.Size(82, 20);
            this.nrPrice.TabIndex = 4;
            this.nrPrice.Validating += new System.ComponentModel.CancelEventHandler(this.nrPrice_Validating);
            // 
            // nrQuantity
            // 
            this.nrQuantity.Location = new System.Drawing.Point(135, 18);
            this.nrQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrQuantity.Name = "nrQuantity";
            this.nrQuantity.Size = new System.Drawing.Size(82, 20);
            this.nrQuantity.TabIndex = 3;
            this.nrQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.nrQuantity_Validating);
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.grpBoxSummary);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSummary.Location = new System.Drawing.Point(603, 77);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pnlSummary.Size = new System.Drawing.Size(255, 313);
            this.pnlSummary.TabIndex = 6;
            // 
            // grpBoxSummary
            // 
            this.grpBoxSummary.Controls.Add(this.gridSummary);
            this.grpBoxSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxSummary.Location = new System.Drawing.Point(0, 0);
            this.grpBoxSummary.Name = "grpBoxSummary";
            this.grpBoxSummary.Size = new System.Drawing.Size(252, 310);
            this.grpBoxSummary.TabIndex = 0;
            this.grpBoxSummary.TabStop = false;
            this.grpBoxSummary.Text = "Summary";
            // 
            // gridSummary
            // 
            this.gridSummary.AllowUserToAddRows = false;
            this.gridSummary.AllowUserToDeleteRows = false;
            this.gridSummary.AllowUserToResizeRows = false;
            this.gridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSummary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSummary.Location = new System.Drawing.Point(3, 16);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.ReadOnly = true;
            this.gridSummary.RowHeadersVisible = false;
            this.gridSummary.Size = new System.Drawing.Size(246, 291);
            this.gridSummary.TabIndex = 0;
            this.gridSummary.TabStop = false;
            // 
            // gridFunds
            // 
            this.gridFunds.AllowUserToAddRows = false;
            this.gridFunds.AllowUserToDeleteRows = false;
            this.gridFunds.AllowUserToResizeRows = false;
            this.gridFunds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridFunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFunds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFunds.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridFunds.Location = new System.Drawing.Point(3, 16);
            this.gridFunds.Name = "gridFunds";
            this.gridFunds.ReadOnly = true;
            this.gridFunds.Size = new System.Drawing.Size(591, 291);
            this.gridFunds.TabIndex = 0;
            this.gridFunds.TabStop = false;
            this.gridFunds.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridFunds_RowsAdded);
            // 
            // grpBoxDataGrid
            // 
            this.grpBoxDataGrid.Controls.Add(this.gridFunds);
            this.grpBoxDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDataGrid.Location = new System.Drawing.Point(3, 0);
            this.grpBoxDataGrid.Name = "grpBoxDataGrid";
            this.grpBoxDataGrid.Size = new System.Drawing.Size(597, 310);
            this.grpBoxDataGrid.TabIndex = 0;
            this.grpBoxDataGrid.TabStop = false;
            this.grpBoxDataGrid.Text = "Funds";
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.Controls.Add(this.grpBoxDataGrid);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 77);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlDataGrid.Size = new System.Drawing.Size(603, 313);
            this.pnlDataGrid.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(600, 77);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 313);
            this.splitter.TabIndex = 7;
            this.splitter.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(858, 390);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlCommands);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(874, 428);
            this.Name = "frmMain";
            this.Text = "Funds";
            this.pnlCommands.ResumeLayout(false);
            this.grpBoxCommands.ResumeLayout(false);
            this.grpBoxCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantity)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.grpBoxSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunds)).EndInit();
            this.grpBoxDataGrid.ResumeLayout(false);
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCommands;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.DataGridView gridFunds;
        private System.Windows.Forms.GroupBox grpBoxCommands;
        private System.Windows.Forms.RadioButton rbBond;
        private System.Windows.Forms.RadioButton rbEquity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nrPrice;
        private System.Windows.Forms.NumericUpDown nrQuantity;
        private System.Windows.Forms.GroupBox grpBoxSummary;
        private System.Windows.Forms.GroupBox grpBoxDataGrid;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView gridSummary;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Splitter splitter;
    }
}

