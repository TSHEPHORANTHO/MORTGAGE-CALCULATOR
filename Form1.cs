namespace MORTGAGE_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
            double InterestRate = 0.000;
            double DownPayment = 0.0;
            double MonthlyPayment = 0.0;
            int Terms = 0;

            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);
            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                DownPayment = Convert.ToDouble(txtDownPayment.Text);
            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                InterestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTerms.Text))
                Terms = Convert.ToInt32(txtTerms.Text);

            // CALCULATION
            int termsInMonths = Terms * 12;
            double monthlyInterestRate = InterestRate / 12;
            MonthlyPayment = (loanAmount - DownPayment) * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, termsInMonths)) / (Math.Pow(1 + monthlyInterestRate, termsInMonths) - 1);
            MonthlyPayment = Math.Round(MonthlyPayment, 2);

            // Display the result 
            lblAmount.Text = String.Format("Monthly Payment: R {0}", MonthlyPayment.ToString());



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create some local variables                        
            double loanAmount = 0.0;
            double InterestRate = 0.000;
            double DownPayment = 0.0;
            double MonthlyPayment = 0.0;
            int Terms = 0;

            // Do some validation 
            if (!String.IsNullOrEmpty(txtLoanAmount.Text)) loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text)) DownPayment = Convert.ToDouble(txtDownPayment.Text);

            if (!String.IsNullOrEmpty(txtInterestRate.Text)) InterestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTerms.Text)) Terms = Convert.ToInt32(txtTerms.Text);

            // Mortgage Payment calculation logic 
            // Formula: Payment = (Loan Amount * Interest Rate) / (1-(1 + Interest Rate)^Terms
            int termsinMonths = Terms * 12;             
            InterestRate /= 12;
            MonthlyPayment = (loanAmount - DownPayment) * (Math.Pow((1 + InterestRate / 12), termsinMonths) * InterestRate) / (12 * (Math.Pow((1 + InterestRate / 12), termsinMonths) - 1)); MonthlyPayment = Math.Round(MonthlyPayment, 2);



            // Display the result 
            lblAmount.Text = String.Format("R {0}", MonthlyPayment.ToString());

        }
    }
}