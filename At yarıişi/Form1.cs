using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarıişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birsol, ikisol, ucunsol,birsag,ikisag,ucsag;
        int birgen;
        int ikigen;
        int ucgen;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birsol = pictureBox1.Left;
            ikisol = pictureBox2.Left;
            ucunsol = pictureBox3.Left;
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            
            
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button1.BackColor = Color.Red;
            button2.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birgen = pictureBox1.Width;
            int ikigen = pictureBox2.Width;
            int ucgen = pictureBox3.Width;
            int bitis = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(8,20);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(8, 20);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(8, 20);

            if (pictureBox1.Left>pictureBox2.Left+5&&pictureBox1.Left>pictureBox3.Left+5)
            {
                label6.Text = "Umut Önde";
            }
            if (pictureBox2.Left >pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Ahmet Önde";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = "Emin Önde";
            }
            if (birgen+pictureBox1.Left>=bitis)
            {
                button2.Enabled = true;
                button2.BackColor = Color.Cyan;
                timer1.Enabled = false;
                MessageBox.Show("Yarışı Umut Kazandı");
                label6.Text = "";
            }
            if (ikigen+pictureBox2.Left>=bitis)
            {
                button2.Enabled = true;
                button2.BackColor = Color.Cyan;
                timer1.Enabled = false;
                MessageBox.Show("Yarışı Ahmet Kazandı");
                label6.Text = "";
            }
            if (ucgen+pictureBox3.Left>=bitis)
            {
                button2.Enabled = true;
                button2.BackColor = Color.Cyan;
                timer1.Enabled = false;
                MessageBox.Show("Yarışı Emin Kazandı");
                label6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
            birsag = pictureBox1.Left;
            ikisag = pictureBox2.Left;
            ucsag = pictureBox3.Left;
            button1.Enabled = true;
            button2.BackColor = Color.Red;
            button1.BackColor = Color.Cyan;
            button2.Enabled = false;
            
           
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left - rastgele.Next(25, 30);
            int baslangıc = lblbasla.Left;
            if (birgen + pictureBox1.Left <= baslangıc)
            {
                button2.Enabled = true;
                timer4.Enabled = false;
            }
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left - rastgele.Next(25, 30);
            int baslangıc = lblbasla.Left;
            if (ikigen + pictureBox2.Left <= baslangıc)
            {
                button2.Enabled = true;
                timer5.Enabled = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left - rastgele.Next(25, 30);
            int baslangıc = lblbasla.Left;
            if (ucgen + pictureBox3.Left <= baslangıc)
            {
                button2.Enabled = true;
                timer6.Enabled = false;
            }

        }
    }
}
