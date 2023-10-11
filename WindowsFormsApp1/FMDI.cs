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
    public partial class FMDI : Form
    {
        public FMDI()
        {
            InitializeComponent();

        }

        private void CreateTableForm(string formTitle)
        {
            bool flag = true;
            foreach (var a in MdiChildren)
            {
                if (a.Text == formTitle)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Table t = new Table(formTitle);
                t.MdiParent = this;
                t.Show();
            }
        }


        private void зданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = (sender as ToolStripMenuItem).Text;
            CreateTableForm(str);
        }

        private void помещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = (sender as ToolStripMenuItem).Text;
            CreateTableForm(str);
        }

        private void арендаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = (sender as ToolStripMenuItem).Text;
            CreateTableForm(str);
        }

        private void арендаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = (sender as ToolStripMenuItem).Text;
            CreateTableForm(str);
        }

        private void FMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
