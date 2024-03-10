using System.Threading.Tasks;
using System.Windows.Forms;





namespace ParkingApp
{
    public partial class Form1 : Form
    {
        string username = "admin", password = "admin";
        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = this.MaximumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.AutoScaleMode = AutoScaleMode.Dpi; // Enable DPI scaling
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            float dpiX, dpiY;
            using (Graphics graphics = this.CreateGraphics())
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(dpiX, dpiY);

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void customTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void customTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void customTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if ((userTextBox.Text != username || userTextBox.Text == null) && (textBox1.Text != password || textBox1.Text == null)) {label2.Text = "Invalid Username"; label3.Text = "Invalid Password";}
            else if (userTextBox.Text != username || userTextBox.Text == null) {label2.Text = "Invalid Username";}
            else if (textBox1.Text != password || textBox1.Text == null) {label3.Text = "Invalid Password";}
            else
            {
                Form2 form2 = new Form2();
                form2.FormClosed += Form2_FormClosed!;
                form2.Show();
                this.Hide();
            }
        }

        public void label1_Click_3(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

