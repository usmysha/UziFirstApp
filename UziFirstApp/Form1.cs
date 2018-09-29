using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UziFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyFirstButon_Click(object sender, EventArgs e)
        {

            try
            {
                MyDataTypes();
                MyTypeconversion();


                textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;

            }

        }


        public void MyDataTypes()
        {
            //https://www.tutorialspoint.com/csharp/csharp_data_types.htm
            string someVarible = "This is My first Program 123";
            int someVarible2 = 1;
            bool someVarible4 = true;    //false
            double someVarible3 = 1.1;
        }

        public void MyTypeconversion()
        {
            //https://www.tutorialspoint.com/csharp/csharp_data_types.htm
            string someVarible1 = "123";
            int someVarible2 = 52;

            bool someVarible4 = true;    //false
            double someVarible3 = 1.1;

            try
            {
                int uziTypeCov1 = Convert.ToInt32(someVarible1);
                string uziTypeCov2 = Convert.ToString(someVarible2);
                string uziTypeCov3 = someVarible2.ToString();
            }
            catch (Exception ex)
            {
                //label1.Text = ex.Message; ;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            //textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            string valueFromTextBoxA = textBox1.Text;
            string valueFromTextBoxB = textBox2.Text;

            string valueFromTextBoxC = textBox3.Text;

            int x = Convert.ToInt32(valueFromTextBoxA);
            int y = Convert.ToInt32(valueFromTextBoxB);

            int r = x + y;

            textBox3.Text = r.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            string valueFromTextBoxA = textBox1.Text;
            string valueFromTextBoxB = textBox2.Text;

            string valueFromTextBoxC = textBox3.Text;

            int x = Convert.ToInt32(valueFromTextBoxA);
            int y = Convert.ToInt32(valueFromTextBoxB);

            int r = x - y;

            textBox3.Text = r.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            string valueFromTextBoxA = textBox1.Text;
            string valueFromTextBoxB = textBox2.Text;

            //string valueFromTextBoxC = textBox3.Text;

            int x = Convert.ToInt32(valueFromTextBoxA);
            int y = Convert.ToInt32(valueFromTextBoxB);

            int r = x * y;

            textBox3.Text = r.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            string valuefromtextboxu = textBox1.Text;
            string valuefromtextboxs = textBox2.Text;
           // string valuefromtextboxm = textBox3.Text;

            int p = Convert.ToInt32(valuefromtextboxu);
            int q = Convert.ToInt32(valuefromtextboxs);
            int r = p / q;

            textBox3.Text = r.ToString();

            
        }
    }
}

