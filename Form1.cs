namespace Git_pract
{
    public partial class Form1 : Form
    {
        int number_1, number_2, result;

        private void but_Add_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToInt32(tB_1.Text);
            number_2 = Convert.ToInt32(tB_2.Text);
            result = number_1 + number_2;
            tB_result.Text = result.ToString();
        }

        private void but_Sub_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToInt32(tB_1.Text);
            number_2 = Convert.ToInt32(tB_2.Text);
            result = number_1 - number_2;
            tB_result.Text = result.ToString();
        }

<<<<<<< HEAD
        private void but_Mul_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToInt32(tB_1.Text);
            number_2 = Convert.ToInt32(tB_2.Text);
            result = number_1 * number_2;
=======
        private void but_Div_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToInt32(tB_1.Text);
            number_2 = Convert.ToInt32(tB_2.Text);
            result = number_1 / number_2;
>>>>>>> session2
            tB_result.Text = result.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}