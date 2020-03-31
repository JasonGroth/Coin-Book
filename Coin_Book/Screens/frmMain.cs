using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coin_Book.Screens;

namespace Coin_Book
{
    public partial class frmMain : Form
    {
        private ICoinLogic coinLogic = new BusinessLogicCoins();
        CommonCoin commonCoin = new CommonCoin("", "", 0, "");

        public frmMain()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tblCoinData' table. You can move, or remove it, as needed.
            this.tblCoinDataTableAdapter.Fill(this.databaseDataSet.tblCoinData);
        }

        private void BtnCoinAdd_Click(object sender, EventArgs e)
        {        
            try
            {
                commonCoin.Type = cmbCoinType.Text;
                commonCoin.Mint = cmbCoinMint.Text;
                commonCoin.Year = Int32.Parse(txtCoinYear.Text);
                commonCoin.Name = txtCoinName.Text;

                int blnAddResult = coinLogic.AddCoin(commonCoin);
                bool blnIsItKeyDate = coinLogic.IsCoinKeyDate(commonCoin).Item1;
                string strMessageKeyDate = coinLogic.IsCoinKeyDate(commonCoin).Item2;

                if (coinLogic.DoesCoinHaveSilver(commonCoin))
                {
                    lblSilverAnswer.Text = "Does contain Silver!";
                }
                else
                {
                    lblSilverAnswer.Text = "No, Sorry!";
                }

                if (blnIsItKeyDate)
                {
                    lblKeyDateAnswer.Text = strMessageKeyDate;
                }
                else
                {
                    lblKeyDateAnswer.Text = "No, Sorry!";
                }

                if (blnAddResult == 1)
                {
                    lblMessageAnswer.Text = "Coin was added!";
                    PopulateGrid();
                }
                else if (blnAddResult == 2)
                {
                    lblMessageAnswer.Text = "Coin has an invlaid type";
                }
                else
                {
                    lblMessageAnswer.Text = "Coin already exists!";
                }
            }
            catch (Exception ex)
            {
                lblMessageAnswer.Text = ex.Message;
            }
            
        }

        private void PopulateGrid()
        {
            var ds = coinLogic.GetData();
            tblCoinDataDataGridView.DataSource = ds;
        }

        private void BtnCoinDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCoinYear.Text) || String.IsNullOrEmpty(txtCoinName.Text))
            {
                lblMessageAnswer.Text = "Name or Year does not have a value assigned!";
            }
            else
            {
                try
                {
                    commonCoin.Type = cmbCoinType.Text;
                    commonCoin.Mint = cmbCoinMint.Text;
                    commonCoin.Year = Int32.Parse(txtCoinYear.Text);
                    commonCoin.Name = txtCoinName.Text;

                    int blnDeleteResult = coinLogic.DeleteCoin(commonCoin);
                    if (blnDeleteResult == 0)
                    {
                        lblMessageAnswer.Text = "Coin was deleted!";
                        PopulateGrid();
                    }
                    else
                    {
                        lblMessageAnswer.Text = "Can't delete a coin that doesn't exist!";
                    }
                }
                catch (Exception ex)
                {
                    lblMessageAnswer.Text = ex.Message;
                }
            }
        }

        private void BtnCoinSearch_Click(object sender, EventArgs e)
        {
            try
            {
                commonCoin.Type = cmbCoinType.Text;
                commonCoin.Mint = cmbCoinMint.Text;
                commonCoin.Year = Int32.Parse(txtCoinYear.Text);
                commonCoin.Name = txtCoinName.Text;

                var ds = coinLogic.SearchData(commonCoin);
                tblCoinDataDataGridView.DataSource = ds;
            }
            catch (Exception ex)
            {
                lblMessageAnswer.Text = ex.Message;
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
