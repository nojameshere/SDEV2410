namespace SnackStandSecondTry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            //single line variable declarations setting a number to a parsed string.
            int drinkCount = int.Parse(drinkNumber.Text);
            int snackCount = int.Parse(snackNumber.Text);
            double snackCost = snackCount * 2.25;
            //since drinks only cost $1 we can use drinkCount instead of doing any math.
            double totalCost = snackCost + drinkCount;
            //${} for string interpolation like template strings in JS
            //the ':C' after the variable tells the compiler its to be formatted as currency
            costOutput.Text = $"Total cost: {totalCost:C}";
        }
    }
}