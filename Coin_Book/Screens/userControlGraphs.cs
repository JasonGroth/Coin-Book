using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;

namespace Coin_Book.Screens
{
    public partial class userControlGraphs : UserControl
    {
        private IGraphLogic graphLogic = new GraphLogic();

        public userControlGraphs()
        {
            InitializeComponent();

            PieChartStateTerritoryQuarters();
            PieChartNationalPark();
            PieChartWashingtonQuarters();
            PieChartStandingLibertyQuarters();
            PieChartBarberQuarters();
            PieChartSeatedLibertyQuarters();
            PieChartCappedBustQuarters();
            PieChartDrapedBustQuarters();

            PieChartMemorialPennies();
            PieChartShieldPennies();
            PieChartWheatPennies();
            PieChartIndianPennies();
            PieChartFlyingPennies();

            PieChartDismeDime();
            PieChartDrapedDime();
            PieChartBarberDime();
            PieChartCappedDime();
            PieChartFDRDime();
            PieChartSeatedDime();
            PieChartWingedDime();

            PieChartBuffaloNickel();
            PieChartShieldNickel();
            PieChartVNickel();
            PieChartJefferson();

            PieChartBarberHalf();
            PieChartFlowingHalf();
            PieChartDrapedHalf();
            PieChartCappedHalf();
            PieChartSeatedHalf();
            PieChartWalkingHalf();
            PieChartFranklinHalf();
            PieChartKennedyHalf();

            PieChartSeatedDollar();
            PieChartGoldDollar();
            PieChartTradeDollar();
            PieChartMorganDollar();
            PieChartPeaceDollar();
            PieChartEisenhowerDollar();
            PieChartSusanDollar();
            PieChartSilverEagleDollar();
            PieChartSacagaweaDollar();
            PieChartPresidentialDollar();
            PieChartInnovationDollar();
        }

        Func<ChartPoint, string> labelPoint = ChartPoint => string.Format("{0} ({1:P})", ChartPoint.Y, ChartPoint.Participation);

        private SeriesCollection PieChartData(int owned, int notOwned)
        {
            SeriesCollection pieChartData = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Own",
                    Values = new ChartValues<int> {owned},
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Not Owned",
                    Values = new ChartValues<int> {notOwned},
                    LabelPoint = labelPoint
                }
            };

            return pieChartData;
        }

        #region Quarter Live Charts
        public void PieChartStateTerritoryQuarters()
        {
            int owned = graphLogic.CountCoinsOwnedNameYear("Washington", "Quarter", 1999, 2009);
            int notOwned = 112 - owned;

            pieStateTerr.Series = PieChartData(owned, notOwned);
            pieStateTerr.LegendLocation = LegendLocation.Right;
        }

        public void PieChartNationalPark()
        {
            int owned = graphLogic.CountCoinsOwnedNameYear("Washington", "Quarter", 2010, 2021);
            int notOwned = 117 - owned;

            pieNatPark.Series = PieChartData(owned, notOwned);
            pieNatPark.LegendLocation = LegendLocation.Right;
        }

        public void PieChartWashingtonQuarters()
        {
            int owned = graphLogic.CountCoinsOwnedNameYear("Washington", "Quarter", 1965, 1998);
            int notOwned = 63 - owned;

            pieWashington.Series = PieChartData(owned, notOwned);
            pieWashington.LegendLocation = LegendLocation.Right;
        }

        public void PieChartStandingLibertyQuarters()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Standing Liberty", "Quarter");
            int notOwned = 112 - owned;

            pieStanding.Series = PieChartData(owned, notOwned); ;
            pieStanding.LegendLocation = LegendLocation.Right;
        }

        public void PieChartBarberQuarters()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Barber", "Quarter");
            int notOwned = 112 - owned;

            pieBarber.Series = PieChartData(owned, notOwned);
            pieBarber.LegendLocation = LegendLocation.Right;
        }

        public void PieChartSeatedLibertyQuarters()
        {
            
            int owned = graphLogic.CountCoinsOwnedNameType("Seated Liberty", "Quarter");
            int notOwned = 112 - owned;

            pieSeated.Series = PieChartData(owned, notOwned);
            pieSeated.LegendLocation = LegendLocation.Right;
        }

        public void PieChartCappedBustQuarters()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Capped Bust", "Quarter");
            int notOwned = 112 - owned;

            pieCapped.Series = PieChartData(owned, notOwned);
            pieCapped.LegendLocation = LegendLocation.Right;
        }

        public void PieChartDrapedBustQuarters()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Draped Bust", "Quarter");
            int notOwned = 112 - owned;

            pieDraped.Series = PieChartData(owned, notOwned);
            pieDraped.LegendLocation = LegendLocation.Right;
        }
        #endregion

        #region Penny Live Charts
        public void PieChartShieldPennies()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Shield", "Penny");
            int notOwned = 22 - owned;

            pieShield.Series = PieChartData(owned, notOwned);
            pieShield.LegendLocation = LegendLocation.Right;
        }

        public void PieChartMemorialPennies()
        {
            int owned = graphLogic.CountCoinsOwnedName("Memorial");
            int notOwned = 97 - owned;

            pieMemorial.Series = PieChartData(owned, notOwned);
            pieMemorial.LegendLocation = LegendLocation.Right;
        }

        public void PieChartWheatPennies()
        {
            int owned = graphLogic.CountCoinsOwnedName("Wheat");
            int notOwned = 97 - owned;

            pieWheat.Series = PieChartData(owned, notOwned);
            pieWheat.LegendLocation = LegendLocation.Right;
        }

        public void PieChartIndianPennies()
        {
            int owned = graphLogic.CountCoinsOwnedName("Indian");
            int notOwned = 97 - owned;

            pieChartIndianHead.Series = PieChartData(owned, notOwned);
            pieChartIndianHead.LegendLocation = LegendLocation.Right;
        }

        public void PieChartFlyingPennies()
        {
            int owned = graphLogic.CountCoinsOwnedName("Flying");
            int notOwned = 97 - owned;

            pieChartPennyEagle.Series = PieChartData(owned, notOwned);
            pieChartPennyEagle.LegendLocation = LegendLocation.Right;
        }
        #endregion

        #region Dime Live Charts
        public void PieChartDismeDime()
        {
            int owned = graphLogic.CountCoinsOwnedName("Disme");
            int notOwned = 22 - owned;

            pieChartDisme.Series = PieChartData(owned, notOwned);
            pieChartDisme.LegendLocation = LegendLocation.Right;
        }

        public void PieChartDrapedDime()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Draped Bust", "Dime");
            int notOwned = 22 - owned;

            pieChartDrapedDime.Series = PieChartData(owned, notOwned);
            pieChartDrapedDime.LegendLocation = LegendLocation.Right;
        }

        public void PieChartCappedDime()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Capped Bust", "Dime");
            int notOwned = 22 - owned;

            pieChartCappedDime.Series = PieChartData(owned, notOwned);
            pieChartCappedDime.LegendLocation = LegendLocation.Right;
        }

        public void PieChartSeatedDime()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Seated Liberty", "Dime");
            int notOwned = 22 - owned;

            pieChartSeatedDime.Series = PieChartData(owned, notOwned);
            pieChartSeatedDime.LegendLocation = LegendLocation.Right;
        }

        public void PieChartBarberDime()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Barber", "Dime");
            int notOwned = 22 - owned;

            pieChartBarberDime.Series = PieChartData(owned, notOwned);
            pieChartBarberDime.LegendLocation = LegendLocation.Right;
        }

        public void PieChartWingedDime()
        {
            int owned = graphLogic.CountCoinsOwnedName("Mercury");
            int notOwned = 22 - owned;

            pieChartWingedDime.Series = PieChartData(owned, notOwned);
            pieChartWingedDime.LegendLocation = LegendLocation.Right;
        }

        public void PieChartFDRDime()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Franklin", "Dime");
            int notOwned = 22 - owned;

            pieChartFDR.Series = PieChartData(owned, notOwned);
            pieChartFDR.LegendLocation = LegendLocation.Right;
        }
        #endregion

        #region Nickel Live Charts
        public void PieChartShieldNickel()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Shield", "Nickel");
            int notOwned = 22 - owned;

            pieChartShieldNic.Series = PieChartData(owned, notOwned);
            pieChartShieldNic.LegendLocation = LegendLocation.Right;
        }

        public void PieChartVNickel()
        {
            int owned = graphLogic.CountCoinsOwnedName("Buffalo");
            int notOwned = 22 - owned;

            pieChartV.Series = PieChartData(owned, notOwned);
            pieChartV.LegendLocation = LegendLocation.Right;
        }

        public void PieChartBuffaloNickel()
        {
            int owned = graphLogic.CountCoinsOwnedName("Shield");
            int notOwned = 22 - owned;

            pieChartBuffalo.Series = PieChartData(owned, notOwned);
            pieChartBuffalo.LegendLocation = LegendLocation.Right;
        }

        public void PieChartJefferson()
        {
            int owned = graphLogic.CountCoinsOwnedName("Shield");
            int notOwned = 22 - owned;

            pieChartJeff.Series = PieChartData(owned, notOwned);
            pieChartJeff.LegendLocation = LegendLocation.Right;
        }
        #endregion

        #region Dollar Live Charts
        public void PieChartSeatedDollar()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Seated", "Dollar");
            int notOwned = 22 - owned;

            pieDollarSeated.Series = PieChartData(owned, notOwned);
            pieDollarSeated.LegendLocation = LegendLocation.Right;
        }

        public void PieChartGoldDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Gold");
            int notOwned = 22 - owned;

            pieDollarGold.Series = PieChartData(owned, notOwned);
            pieDollarGold.LegendLocation = LegendLocation.Right;
        }

        public void PieChartTradeDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Trade");
            int notOwned = 22 - owned;

            pieDollarTrade.Series = PieChartData(owned, notOwned);
            pieDollarTrade.LegendLocation = LegendLocation.Right;
        }

        public void PieChartMorganDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Morgan");
            int notOwned = 22 - owned;

            pieDollarMorgan.Series = PieChartData(owned, notOwned);
            pieDollarMorgan.LegendLocation = LegendLocation.Right;
        }

        public void PieChartPeaceDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Peace");
            int notOwned = 22 - owned;

            pieDollarPeace.Series = PieChartData(owned, notOwned);
            pieDollarPeace.LegendLocation = LegendLocation.Right;
        }

        public void PieChartEisenhowerDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Eisenhower");
            int notOwned = 22 - owned;

            pieDollarIkes.Series = PieChartData(owned, notOwned);
            pieDollarIkes.LegendLocation = LegendLocation.Right;
        }

        public void PieChartSusanDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Susan B Anthony");
            int notOwned = 22 - owned;

            pieDollarSusan.Series = PieChartData(owned, notOwned);
            pieDollarSusan.LegendLocation = LegendLocation.Right;
        }

        public void PieChartSilverEagleDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("American Silver Eagle");
            int notOwned = 22 - owned;

            pieDollarEagle.Series = PieChartData(owned, notOwned);
            pieDollarEagle.LegendLocation = LegendLocation.Right;
        }

        public void PieChartSacagaweaDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Sacagawea");
            int notOwned = 22 - owned;

            pieDollarSacagawea.Series = PieChartData(owned, notOwned);
            pieDollarSacagawea.LegendLocation = LegendLocation.Right;
        }
        public void PieChartPresidentialDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("President");
            int notOwned = 22 - owned;

            pieDollarPresidential.Series = PieChartData(owned, notOwned);
            pieDollarPresidential.LegendLocation = LegendLocation.Right;
        }

        public void PieChartInnovationDollar()
        {
            int owned = graphLogic.CountCoinsOwnedName("Innovation");
            int notOwned = 22 - owned;

            pieDollarInnovation.Series = PieChartData(owned, notOwned);
            pieDollarInnovation.LegendLocation = LegendLocation.Right;
        }
        #endregion

        #region Half-Dollar Live Charts
        public void PieChartFlowingHalf()
        {
            int owned = graphLogic.CountCoinsOwnedName("Flowing");
            int notOwned = 22 - owned;

            pieHalfFlowing.Series = PieChartData(owned, notOwned);
            pieHalfFlowing.LegendLocation = LegendLocation.Right;
        }

        public void PieChartDrapedHalf()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Draped", "Half-Dollar");
            int notOwned = 22 - owned;

            pieHalfDraped.Series = PieChartData(owned, notOwned);
            pieHalfDraped.LegendLocation = LegendLocation.Right;
        }
        public void PieChartCappedHalf()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Capped", "Half-Dollar");
            int notOwned = 22 - owned;

            pieHalfCapped.Series = PieChartData(owned, notOwned);
            pieHalfCapped.LegendLocation = LegendLocation.Right;
        }
        public void PieChartSeatedHalf()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Seated", "Half-Dollar");
            int notOwned = 22 - owned;

            pieHalfSeated.Series = PieChartData(owned, notOwned);
            pieHalfSeated.LegendLocation = LegendLocation.Right;
        }
        public void PieChartBarberHalf()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Barber", "Half-Dollar");
            int notOwned = 22 - owned;

            pieHalfBarber.Series = PieChartData(owned, notOwned);
            pieHalfBarber.LegendLocation = LegendLocation.Right;
        }
        public void PieChartWalkingHalf()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Walking", "Half-Dollar");
            int notOwned = 22 - owned;

            pieHalfWalking.Series = PieChartData(owned, notOwned);
            pieHalfWalking.LegendLocation = LegendLocation.Right;
        }
        public void PieChartFranklinHalf()
        {
            int owned = graphLogic.CountCoinsOwnedNameType("Franklin", "Half-Dollar");
            int notOwned = 22 - owned;

            pieHalfFranklin.Series = PieChartData(owned, notOwned);
            pieHalfFranklin.LegendLocation = LegendLocation.Right;
        }
        public void PieChartKennedyHalf()
        {
            int owned = graphLogic.CountCoinsOwnedName("Kennedy");
            int notOwned = 22 - owned;

            pieHalfKennedy.Series = PieChartData(owned, notOwned);
            pieHalfKennedy.LegendLocation = LegendLocation.Right;
        }
        #endregion
    }
}
