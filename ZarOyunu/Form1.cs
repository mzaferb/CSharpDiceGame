using System.Windows.Forms.VisualStyles;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int sum1 = 0;
        int sum2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = rnd.Next(1, 7);
            int b = rnd.Next(1, 7);
            sum1 = sum1 + a + b;
            label4.Text = sum1.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\6.png";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\6.png";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            int c = rnd.Next(1, 7);
            int d = rnd.Next(1, 7);
            sum2 = sum2 + c + d;
            label5.Text = sum2.ToString();

            if (c == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\1.png";
            }
            if (c == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\2.png";
            }
            if (c == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\3.png";
            }
            if (c == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\4.png";
            }
            if (c == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\5.png";
            }
            if (c == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\6.png";
            }

            if (d == 1)
            {
                pictureBox4.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\1.png";
            }
            if (d == 2)
            {
                pictureBox4.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\2.png";
            }
            if (d == 3)
            {
                pictureBox4.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\3.png";
            }
            if (d == 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\4.png";
            }
            if (d == 5)
            {
                pictureBox4.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\5.png";
            }
            if (d == 6)
            {
                pictureBox4.ImageLocation = "C:\\Users\\LenovoNB\\source\\repos\\ZarOyunu\\ZarOyunu\\obj\\Zarlar\\6.png";
            }

            if (sum1 > 49 || sum2 > 49)
            {
                if (sum1 > sum2)
                {
                    label7.Text = "PLAYER 1";
                    button3.Visible = true;
                    button1.Enabled = false;
                }
                if (sum2 > sum1)
                {
                    label7.Text = "PLAYER 2";
                    button3.Visible = true;
                    button1.Enabled = false;
                }
                if (sum1 == sum2)
                {
                    label7.Text = "EQUALITY";
                    button3.Visible = true;
                    button1.Enabled = false;
                    label6.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Enabled = true;

            sum1 = 0;
            sum2 = 0;
            label4.Text = sum1.ToString();
            label5.Text = sum2.ToString();

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;

            label6.Visible = true;

            label7.Text = null;
        }
    }
}