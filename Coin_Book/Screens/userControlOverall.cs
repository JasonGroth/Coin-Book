using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Book.Screens
{

    public partial class userControlOverall : UserControl
    {
        private ICoinLogic coinLogic = new BusinessLogicCoins();
        public userControlOverall()
        {
            InitializeComponent();

            ShowValues();
        }

        private void ShowValues()
        {
            int pen = coinLogic.AllPennies();
            int nick = coinLogic.AllNickel();
            int dime = coinLogic.AllDime();
            int quart = coinLogic.AllQuarter();
            int half = coinLogic.AllHalf();
            int dollar = coinLogic.AllDollar();
            int total = pen + nick + dime + quart + half + dollar;


            double pennyValue = pen * .01;
            double nickelValue = nick * .05;
            double dimeValue = dime * .1;
            double quarterValue = quart * .25;
            double halfValue = half * .5;
            int dollarValue = dollar * 1;
            double totalMoney = pennyValue + nickelValue + dimeValue + quarterValue + halfValue + dollarValue;

            lblpennies.Text = pen.ToString();
            lblMoneyPenny.Text = "$" + pennyValue.ToString();
            lblNickels.Text = nick.ToString();
            lblMoneyNickel.Text = "$" + nickelValue.ToString();
            lblDimes.Text = dime.ToString();
            lblDimeMoney.Text = "$" + dimeValue.ToString();
            lblQuarters.Text = quart.ToString();
            lblMoneyQuarter.Text = "$" + quarterValue.ToString();
            lblHalf.Text = half.ToString();
            lblHalfMoney.Text = "$" + halfValue.ToString();
            lblDollar.Text = dollar.ToString();
            lblDollarMoney.Text = "$" + dollarValue.ToString();

            lblTotal.Text = total.ToString();
            lblTotalMoney.Text = "$" + totalMoney;
        }
    }
}
