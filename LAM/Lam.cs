using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAM
{
    public partial class Lam : Form
    { 
        public Lam()
        {
            InitializeComponent();
        }
        string mess1 = "Do you want start a new game? All progress will be canceled";
        string mess2 = "Are you sure? All progress will be canceled";

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (gameControl1.Visible == false)
            {
                aboutControl1.Visible = false;
                gameControl1.Visible = true;
                gameControl1.Reset();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(mess1, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    gameControl1.Reset();
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (gameControl1.Visible == false)
            {
                aboutControl1.Visible = true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(mess2, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    aboutControl1.Visible = true;
                    gameControl1.Visible = false;
                    gameControl1.Reset();
                }
            }
        }


    }
}
