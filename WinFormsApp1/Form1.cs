namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textNumberA.Text = Properties.Settings.Default.numberA.ToString();
            textNumberB.Text = Properties.Settings.Default.numberB.ToString();
            textNumberC.Text = Properties.Settings.Default.numberC.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numberA, numberB, numberC;

            try
            {
                numberA = double.Parse(this.textNumberA.Text);
                numberB = double.Parse(this.textNumberB.Text);
                numberC = double.Parse(this.textNumberC.Text);
            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.numberA = numberA;
            Properties.Settings.Default.numberB = numberB;
            Properties.Settings.Default.numberC = numberC;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Check(numberA, numberB, numberC));
        }
    }

    public class Logic
    {
        public static string Check(double numberA, double numberB, double numberC)
        {
            string result;
            if (numberA > 0 && numberB > 0 && numberC > 0 && numberA + numberB > numberC && numberA + numberC > numberB && numberB + numberC > numberA)
            {
                if (Math.Pow(numberA, 2) + Math.Pow(numberB, 2) == Math.Pow(numberC, 2) || Math.Pow(numberA, 2) + Math.Pow(numberC, 2) == Math.Pow(numberB, 2) || Math.Pow(numberB, 2) + Math.Pow(numberC, 2) == Math.Pow(numberA, 2))
                {
                    result = "Треугольник с такими сторонами существует и является прямоугольным";
                }
                else
                {
                    result = "Треугольник с такими сторонами существует, но не является прямоугольным";
                }
            }
            else
            {
                result = "Треугольник с такими сторонами не существует";
            }
            return result;
        }
    }

}
