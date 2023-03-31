using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreTaskApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(EnterValue.Text) < Convert.ToInt32(ConditionS1.Text))
            {
                MessageBox.Show("Result = " + R1.Text);
            }
            else if (Convert.ToInt32(Condition2.Text) <= Convert.ToInt32(EnterValue.Text) && Convert.ToInt32(EnterValue.Text) <= Convert.ToInt32(ConditionS2.Text))
            {
                MessageBox.Show("Result = " + R2.Text);
            }
            else if (Convert.ToInt32(Condition3.Text) < Convert.ToInt32(EnterValue.Text) && Convert.ToInt32(EnterValue.Text) <= Convert.ToInt32(ConditionS3.Text))
            {
                MessageBox.Show("Result = " + R3.Text);
            }
            else if (Convert.ToInt32(Condition4.Text) < Convert.ToInt32(EnterValue.Text) && Convert.ToInt32(EnterValue.Text) < Convert.ToInt32(ConditionS4.Text))
            {
                MessageBox.Show("Result = " + R4.Text);
            }
            else if (Convert.ToInt32(Condition5.Text) <= Convert.ToInt32(EnterValue.Text))
            {
                MessageBox.Show("Result = " + R5.Text);
            }
        }

        private void update1_Click(object sender, EventArgs e)
        {
            //Bos deger girilince uyarı verir.
            if (ConditionEdit1.Text == "" || ConditionEditS1.Text == "")
            {
                MessageBox.Show("Blank space cannot be entered");
            }

            //Check not to overlap
            if (Convert.ToInt32(ConditionEdit2.Text) == Convert.ToInt32(ConditionEdit3.Text))
            {
                MessageBox.Show("intervals cannot be the same");
            }

            //Step 1
            Condition1.Text = ConditionEdit1.Text;
            ConditionS1.Text = ConditionEditS1.Text;
        }

        private void update2_Click(object sender, EventArgs e)
        {
            //Bos deger girilince uyarı verir.
            if (ConditionEdit2.Text == "" || ConditionEditS2.Text == "")
            {
                MessageBox.Show("Blank space cannot be entered");
            }

            //Check not to overlap
            if (Convert.ToInt32(ConditionEdit2.Text) == Convert.ToInt32(ConditionEdit3.Text));
            {
                MessageBox.Show("intervals cannot be the same");
            }

            //Step 2
            Condition2.Text = ConditionEdit2.Text;
            ConditionS2.Text = ConditionEditS2.Text;
        }

        private void update3_Click(object sender, EventArgs e)
        {
            //Bos deger girilince uyarı verir.
            if (ConditionEdit3.Text == "" || ConditionEditS3.Text == "")
            {
                MessageBox.Show("Blank space cannot be entered");
            }

            if (Convert.ToInt32(ConditionEdit3.Text) == Convert.ToInt32(ConditionEdit4.Text));
            {
                MessageBox.Show("intervals cannot be the same");
            }

            //Step 3
            Condition3.Text = ConditionEdit3.Text;
            ConditionS3.Text = ConditionEditS3.Text;
        }

        private void update4_Click(object sender, EventArgs e)
        {
            //Bos deger girilince uyarı verir.
            if (ConditionEdit4.Text == "" || ConditionEditS4.Text == "")
            {
                MessageBox.Show("Blank space cannot be entered");
            }

            //Check not to overlap
            if (Convert.ToInt32(ConditionEdit4.Text) == Convert.ToInt32(ConditionEdit5.Text));
            {
                MessageBox.Show("intervals cannot be the same");
            }

            //Step 4
            Condition4.Text = ConditionEdit4.Text;
            ConditionS4.Text = ConditionEditS4.Text;
        }

        private void update5_Click(object sender, EventArgs e)
        {
            //Bos deger girilince uyarı verir.
            if (ConditionEdit5.Text == "" || ConditionEditS5.Text == "")
            {
                MessageBox.Show("Blank space cannot be entered");
            }

            //Step 5
            Condition5.Text = ConditionEdit5.Text;
            ConditionS5.Text = ConditionEditS5.Text;
        }
    }
}
