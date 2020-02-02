using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lblMessage.Text = String.Empty;

            if (String.IsNullOrEmpty(txtCoinYear.Text))
            {
                lblMessage.Text = "Year does not have a value assigned!";
                return;
            }
            else
            {
                try
                {
                    commonCoin.Type = cmbCoinType.Text;
                    commonCoin.Mint = cmbCoinMint.Text;
                    commonCoin.Year = Int32.Parse(txtCoinYear.Text);

                    int blnAddResult = coinLogic.AddCoin(commonCoin);
                    bool blnIsItKeyDate = coinLogic.IsCoinKeyDate(commonCoin).Item1;
                    string strMessageKeyDate = coinLogic.IsCoinKeyDate(commonCoin).Item2;

                    if (coinLogic.DoesCoinHaveSilver(commonCoin))
                    {
                        MessageBox.Show("This contains silver!", "Contains Silver", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No silver, sorry!", "No Silver", MessageBoxButtons.OK);
                    }

                    if (blnIsItKeyDate)
                    {
                        MessageBox.Show(strMessageKeyDate, "Key Date", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Not a key date, sorry!", "Not Key Date", MessageBoxButtons.OK);
                    }

                    if (blnAddResult == 1)
                    {
                        lblMessage.Text = "Coin was added!";
                        PopulateGrid();
                    }
                    else if (blnAddResult == 2)
                    {
                        lblMessage.Text = "Coin has an invlaid type";
                    }
                    else
                    {
                        lblMessage.Text = "Coin already exists!";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }
            }
        }

        private void PopulateGrid()
        {
            var ds = coinLogic.GetData();
            tblCoinDataDataGridView.DataSource = ds;
        }

        private void BtnCoinDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCoinYear.Text))
            {
                lblMessage.Text = "Year does not have a value assigned!";
            }
            else
            {
                try
                {
                    commonCoin.Type = cmbCoinType.Text;
                    commonCoin.Mint = cmbCoinMint.Text;
                    commonCoin.Year = Int32.Parse(txtCoinYear.Text);

                    int blnDeleteResult = coinLogic.DeleteCoin(commonCoin);
                    if (blnDeleteResult == 0)
                    {
                        lblMessage.Text = "Coin was deleted!";
                        PopulateGrid();
                    }
                    else
                    {
                        lblMessage.Text = "Can't delete a coin that doesn't exist!";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }
            }
        }
    }
}
