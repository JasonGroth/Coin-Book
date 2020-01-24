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
        CommonCoin theCoin;

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
            if (String.IsNullOrEmpty(txtCoinYear.Text))
            {
                lblMessage.Text = "Year does not have a value assigned!";
                return;
            }
            else
            {
                try
                {
                    theCoin.Type = cmbCoinType.Text;
                    theCoin.Mint = cmbCoinMint.Text;
                    theCoin.Year = Int32.Parse(txtCoinYear.Text);

                    bool blnAddResult = coinLogic.AddCoin(theCoin);
                    if (blnAddResult)
                    {
                        lblMessage.Text = "Coin was added!";
                        PopulateGrid();
                    }
                    else
                    {
                        lblMessage.Text = "Coin already exists";
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
                    theCoin.Type = cmbCoinType.Text;
                    theCoin.Mint = cmbCoinMint.Text;
                    theCoin.Year = Int32.Parse(txtCoinYear.Text);

                    bool blnDeleteResult = coinLogic.DeleteCoin(theCoin);
                    if (blnDeleteResult)
                    {
                        lblMessage.Text = "Coin was added!";
                        PopulateGrid();
                    }
                    else
                    {
                        lblMessage.Text = "Coin already exists";
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
