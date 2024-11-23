using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_act_control_0._1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void nightLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cyberButton1_Click_1(object sender, EventArgs e)
        {
            string url = "https://konect.gg/ak1ne";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }

        private void lostLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
