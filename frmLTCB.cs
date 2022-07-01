using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopPTUD2022_sang
{
    public partial class frmLTCB : Form
    {
        int i, n, T;
        public frmLTCB()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
            }
            LBLKQ.Text = "Kết quả tính theo FOR là: " + Convert.ToString(T);
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            i = 1;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    T = T + i;

                }
                i++;
            }
            LBLKQ.Text = "Kết quả tính theo WHILE là: " + Convert.ToString(T);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            while (i <= n);
            LBLKQ.Text = "Kết quả tính theo DO WHILE là: " + Convert.ToString(T);
        }
    }
}
