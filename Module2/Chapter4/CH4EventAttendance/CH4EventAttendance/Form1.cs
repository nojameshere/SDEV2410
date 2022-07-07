namespace CH4EventAttendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //using the AND operator to check two conditions at once
            //we can check if the entered number is between 100 and 999
            int empID = int.Parse(empNum.Text);
            if (empID > 99 && empID <1000)
            {
                //print 'Employee {empID}, you get a $50 gift card as a gift!'
                output.Text = $"Employee {empID}, you get a $50 gift card as a gift!";
            }
            else
            {
                //print 'That number is invalid, try again.
                output.Text = "That number is invalid, try again.";
            }
        }
    }
}