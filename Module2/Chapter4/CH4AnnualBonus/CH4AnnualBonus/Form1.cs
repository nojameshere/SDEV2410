namespace CH4AnnualBonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBonusButton_Click(object sender, EventArgs e)
        {
            //get values from entered fields
            int years = int.Parse(yearsServed.Text);
            int sales = int.Parse(yearlySales.Text);

            //checks if either of the bonus categories qualify for 5%
            if (years > 9 || sales > 249999)
            {
                bonusOutput.Text = "5%";
            }
            //run this second to check for lower bonuses
            else if (years > 4 && years < 10 || sales > 124999 && sales < 250000)
            {
                bonusOutput.Text = "2.5%";
            }
            //default if no bonus category meets criteria
            else
            {
                bonusOutput.Text = "$100";
            }
        }
    }
}