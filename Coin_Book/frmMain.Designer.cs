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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tpAnalysis = new System.Windows.Forms.TabPage();
            this.tpCoins = new System.Windows.Forms.TabPage();
            this.gbCoinSearch = new System.Windows.Forms.GroupBox();
            this.btnCoinSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCoinYear = new System.Windows.Forms.Label();
            this.lblCoinMint = new System.Windows.Forms.Label();
            this.lblCoinType = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvCoins = new System.Windows.Forms.DataGridView();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart3 = new LiveCharts.WinForms.PieChart();
            this.pieChart4 = new LiveCharts.WinForms.PieChart();
            this.pieChart5 = new LiveCharts.WinForms.PieChart();
            this.pieChart6 = new LiveCharts.WinForms.PieChart();
            this.lblAnalysisPenny = new System.Windows.Forms.Label();
            this.lblAnalysisNickel = new System.Windows.Forms.Label();
            this.lblAnalysisDime = new System.Windows.Forms.Label();
            this.lblAnalysisQuarter = new System.Windows.Forms.Label();
            this.lblAnalysisHalf = new System.Windows.Forms.Label();
            this.lblAnalysisDollar = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpAnalysis.SuspendLayout();
            this.tpCoins.SuspendLayout();
            this.gbCoinSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).BeginInit();
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
            this.tcMain.Size = new System.Drawing.Size(776, 426);
            this.tcMain.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.lblCreator);
            this.tpHome.Controls.Add(this.lblWelcome);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(768, 400);
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
            this.tpAnalysis.Size = new System.Drawing.Size(768, 400);
            this.tpAnalysis.TabIndex = 1;
            this.tpAnalysis.Text = "Analysis";
            this.tpAnalysis.UseVisualStyleBackColor = true;
            // 
            // tpCoins
            // 
            this.tpCoins.Controls.Add(this.gbCoinSearch);
            this.tpCoins.Controls.Add(this.dgvCoins);
            this.tpCoins.Location = new System.Drawing.Point(4, 22);
            this.tpCoins.Name = "tpCoins";
            this.tpCoins.Size = new System.Drawing.Size(768, 400);
            this.tpCoins.TabIndex = 2;
            this.tpCoins.Text = "Coins";
            this.tpCoins.UseVisualStyleBackColor = true;
            // 
            // gbCoinSearch
            // 
            this.gbCoinSearch.Controls.Add(this.btnCoinSearch);
            this.gbCoinSearch.Controls.Add(this.textBox1);
            this.gbCoinSearch.Controls.Add(this.lblCoinYear);
            this.gbCoinSearch.Controls.Add(this.lblCoinMint);
            this.gbCoinSearch.Controls.Add(this.lblCoinType);
            this.gbCoinSearch.Controls.Add(this.comboBox2);
            this.gbCoinSearch.Controls.Add(this.comboBox1);
            this.gbCoinSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCoinSearch.Location = new System.Drawing.Point(19, 16);
            this.gbCoinSearch.Name = "gbCoinSearch";
            this.gbCoinSearch.Size = new System.Drawing.Size(408, 139);
            this.gbCoinSearch.TabIndex = 1;
            this.gbCoinSearch.TabStop = false;
            this.gbCoinSearch.Text = "Search";
            // 
            // btnCoinSearch
            // 
            this.btnCoinSearch.Location = new System.Drawing.Point(300, 52);
            this.btnCoinSearch.Name = "btnCoinSearch";
            this.btnCoinSearch.Size = new System.Drawing.Size(75, 35);
            this.btnCoinSearch.TabIndex = 6;
            this.btnCoinSearch.Text = "Search";
            this.btnCoinSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 5;
            // 
            // lblCoinYear
            // 
            this.lblCoinYear.AutoSize = true;
            this.lblCoinYear.Location = new System.Drawing.Point(22, 93);
            this.lblCoinYear.Name = "lblCoinYear";
            this.lblCoinYear.Size = new System.Drawing.Size(43, 20);
            this.lblCoinYear.TabIndex = 4;
            this.lblCoinYear.Text = "Year";
            // 
            // lblCoinMint
            // 
            this.lblCoinMint.AutoSize = true;
            this.lblCoinMint.Location = new System.Drawing.Point(22, 59);
            this.lblCoinMint.Name = "lblCoinMint";
            this.lblCoinMint.Size = new System.Drawing.Size(39, 20);
            this.lblCoinMint.TabIndex = 3;
            this.lblCoinMint.Text = "Mint";
            // 
            // lblCoinType
            // 
            this.lblCoinType.AutoSize = true;
            this.lblCoinType.Location = new System.Drawing.Point(22, 25);
            this.lblCoinType.Name = "lblCoinType";
            this.lblCoinType.Size = new System.Drawing.Size(43, 20);
            this.lblCoinType.TabIndex = 2;
            this.lblCoinType.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "P",
            "D",
            "S",
            "W"});
            this.comboBox2.Location = new System.Drawing.Point(126, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Penny",
            "Nickel",
            "Dime",
            "Quarter",
            "Half-Dollar",
            "Dollar"});
            this.comboBox1.Location = new System.Drawing.Point(126, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // dgvCoins
            // 
            this.dgvCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoins.Location = new System.Drawing.Point(445, 3);
            this.dgvCoins.Name = "dgvCoins";
            this.dgvCoins.Size = new System.Drawing.Size(320, 394);
            this.dgvCoins.TabIndex = 0;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(155, 6);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(200, 100);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(155, 151);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(200, 100);
            this.pieChart2.TabIndex = 1;
            this.pieChart2.Text = "pieChart2";
            // 
            // pieChart3
            // 
            this.pieChart3.Location = new System.Drawing.Point(565, 6);
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(200, 100);
            this.pieChart3.TabIndex = 2;
            this.pieChart3.Text = "pieChart3";
            // 
            // pieChart4
            // 
            this.pieChart4.Location = new System.Drawing.Point(562, 151);
            this.pieChart4.Name = "pieChart4";
            this.pieChart4.Size = new System.Drawing.Size(200, 100);
            this.pieChart4.TabIndex = 3;
            this.pieChart4.Text = "pieChart4";
            // 
            // pieChart5
            // 
            this.pieChart5.Location = new System.Drawing.Point(562, 294);
            this.pieChart5.Name = "pieChart5";
            this.pieChart5.Size = new System.Drawing.Size(200, 100);
            this.pieChart5.TabIndex = 4;
            this.pieChart5.Text = "pieChart5";
            // 
            // pieChart6
            // 
            this.pieChart6.Location = new System.Drawing.Point(155, 294);
            this.pieChart6.Name = "pieChart6";
            this.pieChart6.Size = new System.Drawing.Size(200, 100);
            this.pieChart6.TabIndex = 5;
            this.pieChart6.Text = "pieChart6";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcMain);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tcMain.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpAnalysis.ResumeLayout(false);
            this.tpAnalysis.PerformLayout();
            this.tpCoins.ResumeLayout(false);
            this.gbCoinSearch.ResumeLayout(false);
            this.gbCoinSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpAnalysis;
        private System.Windows.Forms.TabPage tpCoins;
        private System.Windows.Forms.DataGridView dgvCoins;
        private System.Windows.Forms.GroupBox gbCoinSearch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCoinSearch;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

