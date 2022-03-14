using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevAsal00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button_check_Click(object sender, EventArgs e)
        {
            int number = Decimal.ToInt32(numericUpDown.Value);
            label_number.Text = number.ToString();

            if (check(number))
            {
                label_result.Text = "ASAL";

            }
            else
            {
                label_result.Text = "ASAL DEĞİL";

            }

        }

        public bool check(int number)
        {

            for (int i = 2; i < number / 2; i++)
                if (number % i == 0)
                {
                    return false;
                }

            return true;



        }


    }
}
