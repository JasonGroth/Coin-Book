namespace Coin_Book
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tpAnalysis = new System.Windows.Forms.TabPage();
            this.lblAnalysisDollar = new System.Windows.Forms.Label();
            this.lblAnalysisHalf = new System.Windows.Forms.Label();
            this.lblAnalysisQuarter = new System.Windows.Forms.Label();
            this.lblAnalysisDime = new System.Windows.Forms.Label();
            this.lblAnalysisNickel = new System.Windows.Forms.Label();
            this.lblAnalysisPenny = new System.Windows.Forms.Label();
            this.pieChart6 = new LiveCharts.WinForms.PieChart();
            this.pieChart5 = new LiveCharts.WinForms.PieChart();
            this.pieChart4 = new LiveCharts.WinForms.PieChart();
            this.pieChart3 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tpCoins = new System.Windows.Forms.TabPage();
            this.gbCoinSearch = new System.Windows.Forms.GroupBox();
            this.btnCoinDelete = new System.Windows.Forms.Button();
            this.btnCoinSearch = new System.Windows.Forms.Button();
            this.btnCoinAdd = new System.Windows.Forms.Button();
            this.txtCoinYear = new System.Windows.Forms.TextBox();
            this.lblCoinYear = new System.Windows.Forms.Label();
            this.lblCoinMint = new System.Windows.Forms.Label();
            this.lblCoinType = new System.Windows.Forms.Label();
            this.cmbCoinMint = new System.Windows.Forms.ComboBox();
            this.cmbCoinType = new System.Windows.Forms.ComboBox();
            this.coinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coinDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCoinDataDataGridView = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCoinDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Coin_Book.DatabaseDataSet();
            this.tblCoinDataTableAdapter = new Coin_Book.DatabaseDataSetTableAdapters.tblCoinDataTableAdapter();
            this.tableAdapterManager = new Coin_Book.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tcMain.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpAnalysis.SuspendLayout();
            this.tpCoins.SuspendLayout();
            this.gbCoinSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpHome);
            this.tcMain.Controls.Add(this.tpAnalysis);
            this.tcMain.Controls.Add(this.tpCoins);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(776, 481);
            this.tcMain.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.lblCreator);
            this.tpHome.Controls.Add(this.lblWelcome);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(768, 455);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(248, 65);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(230, 24);
            this.lblCreator.TabIndex = 1;
            this.lblCreator.Text = "Created by: Jason Groth";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(220, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(283, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Coin Book";
            // 
            // tpAnalysis
            // 
            this.tpAnalysis.Controls.Add(this.lblAnalysisDollar);
            this.tpAnalysis.Controls.Add(this.lblAnalysisHalf);
            this.tpAnalysis.Controls.Add(this.lblAnalysisQuarter);
            this.tpAnalysis.Controls.Add(this.lblAnalysisDime);
            this.tpAnalysis.Controls.Add(this.lblAnalysisNickel);
            this.tpAnalysis.Controls.Add(this.lblAnalysisPenny);
            this.tpAnalysis.Controls.Add(this.pieChart6);
            this.tpAnalysis.Controls.Add(this.pieChart5);
            this.tpAnalysis.Controls.Add(this.pieChart4);
            this.tpAnalysis.Controls.Add(this.pieChart3);
            this.tpAnalysis.Controls.Add(this.pieChart2);
            this.tpAnalysis.Controls.Add(this.pieChart1);
            this.tpAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tpAnalysis.Name = "tpAnalysis";
            this.tpAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnalysis.Size = new System.Drawing.Size(768, 455);
            this.tpAnalysis.TabIndex = 1;
            this.tpAnalysis.Text = "Analysis";
            this.tpAnalysis.UseVisualStyleBackColor = true;
            // 
            // lblAnalysisDollar
            // 
            this.lblAnalysisDollar.AutoSize = true;
            this.lblAnalysisDollar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisDollar.Location = new System.Drawing.Point(524, 339);
            this.lblAnalysisDollar.Name = "lblAnalysisDollar";
            this.lblAnalysisDollar.Size = new System.Drawing.Size(51, 19);
            this.lblAnalysisDollar.TabIndex = 11;
            this.lblAnalysisDollar.Text = "Dollar";
            // 
            // lblAnalysisHalf
            // 
            this.lblAnalysisHalf.AutoSize = true;
            this.lblAnalysisHalf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisHalf.Location = new System.Drawing.Point(524, 202);
            this.lblAnalysisHalf.Name = "lblAnalysisHalf";
            this.lblAnalysisHalf.Size = new System.Drawing.Size(85, 19);
            this.lblAnalysisHalf.TabIndex = 10;
            this.lblAnalysisHalf.Text = "Half-Dollar";
            // 
            // lblAnalysisQuarter
            // 
            this.lblAnalysisQuarter.AutoSize = true;
            this.lblAnalysisQuarter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisQuarter.Location = new System.Drawing.Point(524, 47);
            this.lblAnalysisQuarter.Name = "lblAnalysisQuarter";
            this.lblAnalysisQuarter.Size = new System.Drawing.Size(62, 19);
            this.lblAnalysisQuarter.TabIndex = 9;
            this.lblAnalysisQuarter.Text = "Quarter";
            // 
            // lblAnalysisDime
            // 
            this.lblAnalysisDime.AutoSize = true;
            this.lblAnalysisDime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisDime.Location = new System.Drawing.Point(114, 339);
            this.lblAnalysisDime.Name = "lblAnalysisDime";
            this.lblAnalysisDime.Size = new System.Drawing.Size(45, 19);
            this.lblAnalysisDime.TabIndex = 8;
            this.lblAnalysisDime.Text = "Dime";
            // 
            // lblAnalysisNickel
            // 
            this.lblAnalysisNickel.AutoSize = true;
            this.lblAnalysisNickel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisNickel.Location = new System.Drawing.Point(114, 202);
            this.lblAnalysisNickel.Name = "lblAnalysisNickel";
            this.lblAnalysisNickel.Size = new System.Drawing.Size(53, 19);
            this.lblAnalysisNickel.TabIndex = 7;
            this.lblAnalysisNickel.Text = "Nickel";
            // 
            // lblAnalysisPenny
            // 
            this.lblAnalysisPenny.AutoSize = true;
            this.lblAnalysisPenny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisPenny.Location = new System.Drawing.Point(114, 47);
            this.lblAnalysisPenny.Name = "lblAnalysisPenny";
            this.lblAnalysisPenny.Size = new System.Drawing.Size(50, 19);
            this.lblAnalysisPenny.TabIndex = 6;
            this.lblAnalysisPenny.Text = "Penny";
            // 
            // pieChart6
            // 
            this.pieChart6.Location = new System.Drawing.Point(155, 294);
            this.pieChart6.Name = "pieChart6";
            this.pieChart6.Size = new System.Drawing.Size(200, 100);
            this.pieChart6.TabIndex = 5;
            this.pieChart6.Text = "pieChart6";
            // 
            // pieChart5
            // 
            this.pieChart5.Location = new System.Drawing.Point(562, 294);
            this.pieChart5.Name = "pieChart5";
            this.pieChart5.Size = new System.Drawing.Size(200, 100);
            this.pieChart5.TabIndex = 4;
            this.pieChart5.Text = "pieChart5";
            // 
            // pieChart4
            // 
            this.pieChart4.Location = new System.Drawing.Point(562, 151);
            this.pieChart4.Name = "pieChart4";
            this.pieChart4.Size = new System.Drawing.Size(200, 100);
            this.pieChart4.TabIndex = 3;
            this.pieChart4.Text = "pieChart4";
            // 
            // pieChart3
            // 
            this.pieChart3.Location = new System.Drawing.Point(565, 6);
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(200, 100);
            this.pieChart3.TabIndex = 2;
            this.pieChart3.Text = "pieChart3";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(155, 151);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(200, 100);
            this.pieChart2.TabIndex = 1;
            this.pieChart2.Text = "pieChart2";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(155, 6);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(200, 100);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // tpCoins
            // 
            this.tpCoins.AutoScroll = true;
            this.tpCoins.Controls.Add(this.tblCoinDataDataGridView);
            this.tpCoins.Controls.Add(this.gbCoinSearch);
            this.tpCoins.Location = new System.Drawing.Point(4, 22);
            this.tpCoins.Name = "tpCoins";
            this.tpCoins.Size = new System.Drawing.Size(768, 455);
            this.tpCoins.TabIndex = 2;
            this.tpCoins.Text = "Coins";
            this.tpCoins.UseVisualStyleBackColor = true;
            // 
            // gbCoinSearch
            // 
            this.gbCoinSearch.Controls.Add(this.lblMessage);
            this.gbCoinSearch.Controls.Add(this.btnCoinDelete);
            this.gbCoinSearch.Controls.Add(this.btnCoinSearch);
            this.gbCoinSearch.Controls.Add(this.btnCoinAdd);
            this.gbCoinSearch.Controls.Add(this.txtCoinYear);
            this.gbCoinSearch.Controls.Add(this.lblCoinYear);
            this.gbCoinSearch.Controls.Add(this.lblCoinMint);
            this.gbCoinSearch.Controls.Add(this.lblCoinType);
            this.gbCoinSearch.Controls.Add(this.cmbCoinMint);
            this.gbCoinSearch.Controls.Add(this.cmbCoinType);
            this.gbCoinSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCoinSearch.Location = new System.Drawing.Point(19, 16);
            this.gbCoinSearch.Name = "gbCoinSearch";
            this.gbCoinSearch.Size = new System.Drawing.Size(408, 193);
            this.gbCoinSearch.TabIndex = 1;
            this.gbCoinSearch.TabStop = false;
            this.gbCoinSearch.Text = "Search";
            // 
            // btnCoinDelete
            // 
            this.btnCoinDelete.Location = new System.Drawing.Point(327, 152);
            this.btnCoinDelete.Name = "btnCoinDelete";
            this.btnCoinDelete.Size = new System.Drawing.Size(75, 35);
            this.btnCoinDelete.TabIndex = 8;
            this.btnCoinDelete.Text = "Delete";
            this.btnCoinDelete.UseVisualStyleBackColor = true;
            this.btnCoinDelete.Click += new System.EventHandler(this.BtnCoinDelete_Click);
            // 
            // btnCoinSearch
            // 
            this.btnCoinSearch.Location = new System.Drawing.Point(265, 25);
            this.btnCoinSearch.Name = "btnCoinSearch";
            this.btnCoinSearch.Size = new System.Drawing.Size(137, 94);
            this.btnCoinSearch.TabIndex = 7;
            this.btnCoinSearch.Text = "Search";
            this.btnCoinSearch.UseVisualStyleBackColor = true;
            // 
            // btnCoinAdd
            // 
            this.btnCoinAdd.Location = new System.Drawing.Point(246, 152);
            this.btnCoinAdd.Name = "btnCoinAdd";
            this.btnCoinAdd.Size = new System.Drawing.Size(75, 35);
            this.btnCoinAdd.TabIndex = 6;
            this.btnCoinAdd.Text = "Add";
            this.btnCoinAdd.UseVisualStyleBackColor = true;
            this.btnCoinAdd.Click += new System.EventHandler(this.BtnCoinAdd_Click);
            // 
            // txtCoinYear
            // 
            this.txtCoinYear.Location = new System.Drawing.Point(80, 93);
            this.txtCoinYear.Name = "txtCoinYear";
            this.txtCoinYear.Size = new System.Drawing.Size(167, 32);
            this.txtCoinYear.TabIndex = 5;
            // 
            // lblCoinYear
            // 
            this.lblCoinYear.AutoSize = true;
            this.lblCoinYear.Location = new System.Drawing.Point(22, 93);
            this.lblCoinYear.Name = "lblCoinYear";
            this.lblCoinYear.Size = new System.Drawing.Size(52, 24);
            this.lblCoinYear.TabIndex = 4;
            this.lblCoinYear.Text = "Year";
            // 
            // lblCoinMint
            // 
            this.lblCoinMint.AutoSize = true;
            this.lblCoinMint.Location = new System.Drawing.Point(22, 59);
            this.lblCoinMint.Name = "lblCoinMint";
            this.lblCoinMint.Size = new System.Drawing.Size(52, 24);
            this.lblCoinMint.TabIndex = 3;
            this.lblCoinMint.Text = "Mint";
            // 
            // lblCoinType
            // 
            this.lblCoinType.AutoSize = true;
            this.lblCoinType.Location = new System.Drawing.Point(22, 25);
            this.lblCoinType.Name = "lblCoinType";
            this.lblCoinType.Size = new System.Drawing.Size(52, 24);
            this.lblCoinType.TabIndex = 2;
            this.lblCoinType.Text = "Type";
            // 
            // cmbCoinMint
            // 
            this.cmbCoinMint.FormattingEnabled = true;
            this.cmbCoinMint.Items.AddRange(new object[] {
            "P",
            "D",
            "S",
            "W"});
            this.cmbCoinMint.Location = new System.Drawing.Point(80, 59);
            this.cmbCoinMint.Name = "cmbCoinMint";
            this.cmbCoinMint.Size = new System.Drawing.Size(167, 32);
            this.cmbCoinMint.TabIndex = 1;
            // 
            // cmbCoinType
            // 
            this.cmbCoinType.FormattingEnabled = true;
            this.cmbCoinType.Items.AddRange(new object[] {
            "Penny",
            "Nickel",
            "Dime",
            "Quarter",
            "Half-Dollar",
            "Dollar"});
            this.cmbCoinType.Location = new System.Drawing.Point(80, 25);
            this.cmbCoinType.Name = "cmbCoinType";
            this.cmbCoinType.Size = new System.Drawing.Size(167, 32);
            this.cmbCoinType.TabIndex = 0;
            // 
            // tblCoinDataDataGridView
            // 
            this.tblCoinDataDataGridView.AllowUserToAddRows = false;
            this.tblCoinDataDataGridView.AllowUserToDeleteRows = false;
            this.tblCoinDataDataGridView.AllowUserToResizeColumns = false;
            this.tblCoinDataDataGridView.AutoGenerateColumns = false;
            this.tblCoinDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCoinDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tblCoinDataDataGridView.DataSource = this.tblCoinDataBindingSource;
            this.tblCoinDataDataGridView.Location = new System.Drawing.Point(465, 3);
            this.tblCoinDataDataGridView.Name = "tblCoinDataDataGridView";
            this.tblCoinDataDataGridView.Size = new System.Drawing.Size(300, 449);
            this.tblCoinDataDataGridView.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(26, 152);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 24);
            this.lblMessage.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn1.HeaderText = "Year";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mint";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mint";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tblCoinDataBindingSource
            // 
            this.tblCoinDataBindingSource.DataMember = "tblCoinData";
            this.tblCoinDataBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCoinDataTableAdapter
            // 
            this.tblCoinDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCoinDataTableAdapter = this.tblCoinDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = Coin_Book.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.tcMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Book";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpAnalysis.ResumeLayout(false);
            this.tpAnalysis.PerformLayout();
            this.tpCoins.ResumeLayout(false);
            this.gbCoinSearch.ResumeLayout(false);
            this.gbCoinSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpAnalysis;
        private System.Windows.Forms.TabPage tpCoins;
        private System.Windows.Forms.GroupBox gbCoinSearch;
        private System.Windows.Forms.ComboBox cmbCoinMint;
        private System.Windows.Forms.ComboBox cmbCoinType;
        private System.Windows.Forms.Button btnCoinAdd;
        private System.Windows.Forms.TextBox txtCoinYear;
        private System.Windows.Forms.Label lblCoinYear;
        private System.Windows.Forms.Label lblCoinMint;
        private System.Windows.Forms.Label lblCoinType;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblAnalysisPenny;
        private LiveCharts.WinForms.PieChart pieChart6;
        private LiveCharts.WinForms.PieChart pieChart5;
        private LiveCharts.WinForms.PieChart pieChart4;
        private LiveCharts.WinForms.PieChart pieChart3;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label lblAnalysisDollar;
        private System.Windows.Forms.Label lblAnalysisHalf;
        private System.Windows.Forms.Label lblAnalysisQuarter;
        private System.Windows.Forms.Label lblAnalysisDime;
        private System.Windows.Forms.Label lblAnalysisNickel;
        private System.Windows.Forms.Button btnCoinDelete;
        private System.Windows.Forms.Button btnCoinSearch;
        private System.Windows.Forms.BindingSource coinDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource coinsBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tblCoinDataBindingSource;
        private DatabaseDataSetTableAdapters.tblCoinDataTableAdapter tblCoinDataTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblCoinDataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblMessage;
    }
}

