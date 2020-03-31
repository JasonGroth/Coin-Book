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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tpAnalysis = new System.Windows.Forms.TabPage();
            this.userControlGraphs1 = new Coin_Book.Screens.userControlGraphs();
            this.tpCoins = new System.Windows.Forms.TabPage();
            this.lblMessageAnswer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblKeyDateAnswer = new System.Windows.Forms.Label();
            this.lblSilverAnswer = new System.Windows.Forms.Label();
            this.lblKeyDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSilver = new System.Windows.Forms.Label();
            this.tblCoinDataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCoinDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Coin_Book.DatabaseDataSet();
            this.gbCoinSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCoinName = new System.Windows.Forms.Label();
            this.txtCoinName = new System.Windows.Forms.TextBox();
            this.btnCoinDelete = new System.Windows.Forms.Button();
            this.btnCoinSearch = new System.Windows.Forms.Button();
            this.btnCoinAdd = new System.Windows.Forms.Button();
            this.txtCoinYear = new System.Windows.Forms.TextBox();
            this.lblCoinYear = new System.Windows.Forms.Label();
            this.lblCoinMint = new System.Windows.Forms.Label();
            this.lblCoinType = new System.Windows.Forms.Label();
            this.cmbCoinMint = new System.Windows.Forms.ComboBox();
            this.cmbCoinType = new System.Windows.Forms.ComboBox();
            this.tblCoinDataTableAdapter = new Coin_Book.DatabaseDataSetTableAdapters.tblCoinDataTableAdapter();
            this.tableAdapterManager = new Coin_Book.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.coinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coinDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userControlOverall1 = new Coin_Book.Screens.userControlOverall();
            this.tcMain.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpAnalysis.SuspendLayout();
            this.tpCoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.gbCoinSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinDataBindingSource)).BeginInit();
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
            this.tcMain.Size = new System.Drawing.Size(964, 481);
            this.tcMain.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.label1);
            this.tpHome.Controls.Add(this.lblCreator);
            this.tpHome.Controls.Add(this.lblWelcome);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(956, 455);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key Dates:\r\n\r\nDollar - Any 2019 W";
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
            this.tpAnalysis.Controls.Add(this.userControlOverall1);
            this.tpAnalysis.Controls.Add(this.userControlGraphs1);
            this.tpAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tpAnalysis.Name = "tpAnalysis";
            this.tpAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnalysis.Size = new System.Drawing.Size(956, 455);
            this.tpAnalysis.TabIndex = 1;
            this.tpAnalysis.Text = "Analysis";
            this.tpAnalysis.UseVisualStyleBackColor = true;
            // 
            // userControlGraphs1
            // 
            this.userControlGraphs1.Location = new System.Drawing.Point(348, 3);
            this.userControlGraphs1.Name = "userControlGraphs1";
            this.userControlGraphs1.Size = new System.Drawing.Size(602, 446);
            this.userControlGraphs1.TabIndex = 2;
            // 
            // tpCoins
            // 
            this.tpCoins.AutoScroll = true;
            this.tpCoins.Controls.Add(this.lblMessageAnswer);
            this.tpCoins.Controls.Add(this.lblMessage);
            this.tpCoins.Controls.Add(this.lblKeyDateAnswer);
            this.tpCoins.Controls.Add(this.lblSilverAnswer);
            this.tpCoins.Controls.Add(this.lblKeyDate);
            this.tpCoins.Controls.Add(this.label3);
            this.tpCoins.Controls.Add(this.label2);
            this.tpCoins.Controls.Add(this.lblSilver);
            this.tpCoins.Controls.Add(this.tblCoinDataDataGridView);
            this.tpCoins.Controls.Add(this.gbCoinSearch);
            this.tpCoins.Location = new System.Drawing.Point(4, 22);
            this.tpCoins.Name = "tpCoins";
            this.tpCoins.Size = new System.Drawing.Size(956, 455);
            this.tpCoins.TabIndex = 2;
            this.tpCoins.Text = " Coins";
            this.tpCoins.UseVisualStyleBackColor = true;
            // 
            // lblMessageAnswer
            // 
            this.lblMessageAnswer.AutoSize = true;
            this.lblMessageAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageAnswer.Location = new System.Drawing.Point(107, 357);
            this.lblMessageAnswer.Name = "lblMessageAnswer";
            this.lblMessageAnswer.Size = new System.Drawing.Size(0, 19);
            this.lblMessageAnswer.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(25, 357);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(76, 19);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Message:";
            // 
            // lblKeyDateAnswer
            // 
            this.lblKeyDateAnswer.AutoSize = true;
            this.lblKeyDateAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyDateAnswer.Location = new System.Drawing.Point(118, 421);
            this.lblKeyDateAnswer.Name = "lblKeyDateAnswer";
            this.lblKeyDateAnswer.Size = new System.Drawing.Size(0, 19);
            this.lblKeyDateAnswer.TabIndex = 14;
            // 
            // lblSilverAnswer
            // 
            this.lblSilverAnswer.AutoSize = true;
            this.lblSilverAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilverAnswer.Location = new System.Drawing.Point(92, 388);
            this.lblSilverAnswer.Name = "lblSilverAnswer";
            this.lblSilverAnswer.Size = new System.Drawing.Size(0, 19);
            this.lblSilverAnswer.TabIndex = 13;
            // 
            // lblKeyDate
            // 
            this.lblKeyDate.AutoSize = true;
            this.lblKeyDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyDate.Location = new System.Drawing.Point(25, 421);
            this.lblKeyDate.Name = "lblKeyDate";
            this.lblKeyDate.Size = new System.Drawing.Size(82, 19);
            this.lblKeyDate.TabIndex = 12;
            this.lblKeyDate.Text = "Key Date?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 10;
            // 
            // lblSilver
            // 
            this.lblSilver.AutoSize = true;
            this.lblSilver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilver.Location = new System.Drawing.Point(25, 388);
            this.lblSilver.Name = "lblSilver";
            this.lblSilver.Size = new System.Drawing.Size(56, 19);
            this.lblSilver.TabIndex = 9;
            this.lblSilver.Text = "Silver?";
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblCoinDataDataGridView.DataSource = this.tblCoinDataBindingSource;
            this.tblCoinDataDataGridView.Location = new System.Drawing.Point(427, 3);
            this.tblCoinDataDataGridView.Name = "tblCoinDataDataGridView";
            this.tblCoinDataDataGridView.Size = new System.Drawing.Size(526, 449);
            this.tblCoinDataDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn1.HeaderText = "Year";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
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
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 283;
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
            // gbCoinSearch
            // 
            this.gbCoinSearch.Controls.Add(this.btnClear);
            this.gbCoinSearch.Controls.Add(this.lblCoinName);
            this.gbCoinSearch.Controls.Add(this.txtCoinName);
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
            this.gbCoinSearch.Size = new System.Drawing.Size(408, 254);
            this.gbCoinSearch.TabIndex = 1;
            this.gbCoinSearch.TabStop = false;
            this.gbCoinSearch.Text = "Search";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(265, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 66);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblCoinName
            // 
            this.lblCoinName.AutoSize = true;
            this.lblCoinName.Location = new System.Drawing.Point(11, 129);
            this.lblCoinName.Name = "lblCoinName";
            this.lblCoinName.Size = new System.Drawing.Size(63, 24);
            this.lblCoinName.TabIndex = 10;
            this.lblCoinName.Text = "Name";
            // 
            // txtCoinName
            // 
            this.txtCoinName.Location = new System.Drawing.Point(80, 126);
            this.txtCoinName.Name = "txtCoinName";
            this.txtCoinName.Size = new System.Drawing.Size(167, 32);
            this.txtCoinName.TabIndex = 9;
            // 
            // btnCoinDelete
            // 
            this.btnCoinDelete.Location = new System.Drawing.Point(327, 207);
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
            this.btnCoinSearch.Size = new System.Drawing.Size(137, 66);
            this.btnCoinSearch.TabIndex = 7;
            this.btnCoinSearch.Text = "Search";
            this.btnCoinSearch.UseVisualStyleBackColor = true;
            this.btnCoinSearch.Click += new System.EventHandler(this.BtnCoinSearch_Click);
            // 
            // btnCoinAdd
            // 
            this.btnCoinAdd.Location = new System.Drawing.Point(246, 207);
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
            // userControlOverall1
            // 
            this.userControlOverall1.Location = new System.Drawing.Point(3, 5);
            this.userControlOverall1.Name = "userControlOverall1";
            this.userControlOverall1.Size = new System.Drawing.Size(339, 446);
            this.userControlOverall1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 502);
            this.Controls.Add(this.tcMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Book";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpAnalysis.ResumeLayout(false);
            this.tpCoins.ResumeLayout(false);
            this.tpCoins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoinDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.gbCoinSearch.ResumeLayout(false);
            this.gbCoinSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinDataBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnCoinDelete;
        private System.Windows.Forms.Button btnCoinSearch;
        private System.Windows.Forms.BindingSource coinDataBindingSource;
        private System.Windows.Forms.BindingSource coinsBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tblCoinDataBindingSource;
        private DatabaseDataSetTableAdapters.tblCoinDataTableAdapter tblCoinDataTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblCoinDataDataGridView;
        private System.Windows.Forms.Label lblSilver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoinName;
        private System.Windows.Forms.Label lblCoinName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKeyDate;
        private System.Windows.Forms.Label lblSilverAnswer;
        private System.Windows.Forms.Label lblKeyDateAnswer;
        private System.Windows.Forms.Label lblMessageAnswer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Screens.userControlGraphs userControlGraphs1;
        private Screens.userControlOverall userControlOverall1;
    }
}

