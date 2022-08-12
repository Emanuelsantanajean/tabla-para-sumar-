using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabla_sumadera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void suma(object sender, DataGridViewCellCancelEventArgs e)
        {
           //double total1 = 0;
           //double total2 = 0;
           //double total3 = 0;
           // foreach (DataGridViewRow row in dataGridView1.Rows)
           // {
           //     total1 += Convert.ToDouble(row.Cells[0].Value);
           //     total2 += Convert.ToDouble(row.Cells[1].Value);
           //     total3 += Convert.ToDouble(row.Cells[2].Value);
           // }
           // txt_resultado1.Text = Convert.ToString(total1);
           // txt_resultado2.Text = Convert.ToString(total2);
           // txt_resultado3.Text = Convert.ToString(total3);
        }

        private void suma(object sender, DataGridViewCellEventArgs e)
        {
            double total1 = 0;
            double total2 = 0;
            double total3 = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total1 += Convert.ToDouble(row.Cells[0].Value);
                total2 += Convert.ToDouble(row.Cells[1].Value);
                total3 += Convert.ToDouble(row.Cells[2].Value);
            }
            txt_resultado1.Text = Convert.ToString(total1);
            txt_resultado2.Text = Convert.ToString(total2);
            txt_resultado3.Text = Convert.ToString(total3);
        }
    }
}
