using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAM
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
            lblAbout.Text = @"The game takes place on the desktop with four traps.
Each of them is assigned one possible answer. 
Participants choose the right answer by placing money on the trap of their choice. 
If they are not sure of the answer, they can divide the money into several trapdays, remembering that one trap must always be empty.
In questions 1 to 4 all four will be active and participants will have four answers to choose from. 
In questions 5 to 7, three will be active and the participants will choose the correct answer from three possible.
In the eighth question, only two will remain active and the participants bet the whole amount on one of them, leaving the other empty.
If players have placed the correct trap, it will remain closed. If it's bad, the trapdoor will open and the money on it will be lost.";
        }
    }
}
