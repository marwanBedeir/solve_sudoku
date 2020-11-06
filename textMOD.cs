using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class textMOD : Form
    {
        public textMOD()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            String text = fileName.Text.ToString();
            text = text + ".txt";
            DialogResult d = new DialogResult();
            d = MessageBox.Show(text, "run", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1(text);
                f.ShowDialog();
            }
            
        }
    }
}
