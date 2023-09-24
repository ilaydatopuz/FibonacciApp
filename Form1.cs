namespace FibonacciMasaUstu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            int depth = int.Parse(textBox1.Text);
            int num1 = 0, num2 = 1;
            double sum = 1.0;

            //  Console.Write("Fibonacci Series: " + num1 + ", " + num2 + ", ");

            for (int i = 2; i < depth; i++)
            {

                int nextNum = num1 + num2;
                //   Console.Write(nextNum + ", ");
                sum = sum + nextNum;
                num1 = num2;
                num2 = nextNum;


            }
            //Console.Write("sum:" + sum);
            double avr = sum / depth;
            Console.Write("average is:" + avr);


            label2.Text+= sum / depth;
        }
    }
}