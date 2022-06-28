using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace StrFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(String.Compare(strA,strB).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.ToUpper().EndsWith(strB.ToUpper()).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.IndexOf(strB).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.ToLower()+"  "+strB.ToUpper());
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.Insert(strA.IndexOf('l'),strB).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.Length.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.Remove(strA.IndexOf(' ')).ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.Replace('c', 'ç').ToString());
            MessageBox.Show(strA.Replace("eh","ak").ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] strArray = textBox3.Text.Split('.');
            //for(int i=0;i<strArray.Length;i++)
            //{
            //    listBox1.Items.Add(strArray[i]);
            //}
            
            listBox1.Items.AddRange(strArray);
            //textBox3.Text = textBox3.Text.ToUpper();
            MessageBox.Show(listBox1.Items.Count.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.ToUpper().StartsWith(strB.ToUpper()).ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            MessageBox.Show(strA.Substring(3,2));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            textBox2.Text = strA.Trim();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            textBox3.Text = String.Concat(strA, strB, "Bülent", "Alper");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string Soyad = "";
            string Ad = "";
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            // 1.metod split
            string[] strArray;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items[i] = myTI.ToTitleCase(listBox1.Items[i].ToString());
                strArray=listBox1.Items[i].ToString().Split(' ');
                Soyad = strArray[1].ToString();
                Ad = listBox1.Items[i].ToString().Substring(0, 1);
                listBox2.Items.Add(String.Concat(Soyad, " ", Ad, "."));
            }
            //-------------------------------------

            //// 2.metod split strArray kullanmadan
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    listBox1.Items[i] = myTI.ToTitleCase(listBox1.Items[i].ToString());
            //    Soyad = listBox1.Items[i].ToString().Split(' ')[1].ToString();
            //    Ad = listBox1.Items[i].ToString().Substring(0, 1).ToUpper();
            //    listBox2.Items.Add(String.Concat(Soyad, " ", Ad, "."));
            //}
            ////--------------------

            //// 3.metod indexof
            //int strIndex = 0;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    listBox1.Items[i] = myTI.ToTitleCase(listBox1.Items[i].ToString());
            //    strIndex = listBox1.Items[i].ToString().IndexOf(" ");
            //    Soyad = listBox1.Items[i].ToString().Substring(strIndex);
            //    Ad = listBox1.Items[i].ToString().Substring(0, 1).ToUpper();
            //    listBox2.Items.Add(String.Concat(Soyad, " ", Ad, "."));
            //}
            ////---------------------------
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            MessageBox.Show(myTI.ToTitleCase(strA));
        }
    }
}
