using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            // int number1 = Convert.ToInt32(((maskedTextBox1)sender).Text);
            int number2 = Convert.ToInt32((sender as maskedTextBox2));
            int number1 = Convert.ToInt32((sender as maskedTextBox1));

            char pickedOperator = Convert.ToChar(groupBoxoperatör.Text);

            if (pickedOperator == '-')
            {
                result = number1 - number2;
            }

            else if (pickedOperator == '+')
            {
                result = number1 + number2;
            }

            else if (pickedOperator == '/')
            {
                result = number1 / number2;
            }

            else if (pickedOperator == '*')
            {
                result = number1 * number2;
            }

            else
            {
                MessageBox.Show("Lütfen bir operatör seçiniz", "hata");
            }

            listBox1.Items.Add(result.ToString());
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
