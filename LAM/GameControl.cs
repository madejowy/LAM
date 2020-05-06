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

    public partial class GameControl : UserControl
    {
        public GameControl()
        {
            InitializeComponent();
        }
        public int Money { get; set; }
        public int Trap1 { get; set; }
        public int Trap2 { get; set; }
        public int Trap3 { get; set; }
        public int Trap4 { get; set; }
        public int Correct { get; set; }
        public int CurrentRound { get; set; }
        public List<Question> AllQuestions { get; set; }
        public void Round()
        {
            Money = int.Parse(lblMoney.Text);
            if (Money != 0)
            {
                LamData database = new LamData();
                Question ask;
                CurrentRound = int.Parse(lblRound.Text);
                CurrentRound++;
                lblRound.Text = CurrentRound.ToString();

                switch (CurrentRound)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        ask = database.getSingleQuestion(AllQuestions, 4);
                        lblQue.Text = ask.Question1.ToString();
                        lblAns1.Text = ask.Answer1.ToString();
                        lblAns2.Text = ask.Answer2.ToString();
                        lblAns3.Text = ask.Answer3.ToString();
                        lblAns4.Text = ask.Answer4.ToString();
                        Correct = ask.Correct;
                        database.usedQuestion(AllQuestions, ask);
                        break;
                    case 5:
                    case 6:
                    case 7:
                        DisableElement(4);
                        ask = database.getSingleQuestion(AllQuestions, 3);
                        lblQue.Text = ask.Question1.ToString();
                        lblAns1.Text = ask.Answer1.ToString();
                        lblAns2.Text = ask.Answer2.ToString();
                        lblAns3.Text = ask.Answer3.ToString();
                        Correct = ask.Correct;
                        database.usedQuestion(AllQuestions, ask);
                        break;
                    case 8:
                        DisableElement(3);
                        ask = database.getSingleQuestion(AllQuestions, 2);
                        lblQue.Text = ask.Question1.ToString();
                        lblAns1.Text = ask.Answer1.ToString();
                        lblAns2.Text = ask.Answer2.ToString();
                        Correct = ask.Correct;
                        database.usedQuestion(AllQuestions, ask);
                        break;
                    case 9:
                        MessageBox.Show("You won:  " + Money, "GG");
                        Visible = false;
                        break;
                }
            }
            else
            {
                Visible = false;
                DialogResult dialogResult = MessageBox.Show("Do you want start a new game?", "You lose a milion. Congrats!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Reset();
                    Visible = true;
                }
            }
        }
        public void Reset()
        {
            lblAns4.Visible = true;
            btnSub4.Visible = true;
            btnAdd4.Visible = true;
            lblTrap4.Visible = true;
            btnClear4.Visible = true;
            btnMax4.Visible = true;
            lblAns3.Visible = true;
            btnSub3.Visible = true;
            btnAdd3.Visible = true;
            lblTrap3.Visible = true;
            btnClear3.Visible = true;
            btnMax3.Visible = true;
            lblRound.Text = 0.ToString();
            lblMoney.Text = 1000000.ToString();
            LamData database = new LamData();
            AllQuestions = database.getAllQuestions();
            Round();
        }
        public void DisableElement(int number)
        {
            if (number == 3)
            {
                lblAns3.Visible = false;
                btnSub3.Visible = false;
                btnAdd3.Visible = false;
                lblTrap3.Visible = false;
                btnClear3.Visible = false;
                btnMax3.Visible = false;
            }
            else
            {
                lblAns4.Visible = false;
                btnSub4.Visible = false;
                btnAdd4.Visible = false;
                lblTrap4.Visible = false;
                btnClear4.Visible = false;
                btnMax4.Visible = false;
            }
        }
        public void PropertyHelper()
        {
            Money = int.Parse(lblMoney.Text);
            Trap1 = int.Parse(lblTrap1.Text);
            Trap2 = int.Parse(lblTrap2.Text);
            Trap3 = int.Parse(lblTrap3.Text);
            Trap4 = int.Parse(lblTrap4.Text);
        }
        public void LabelToString()
        {
            lblMoney.Text = Money.ToString();
            lblTrap1.Text = Trap1.ToString();
            lblTrap2.Text = Trap2.ToString();
            lblTrap3.Text = Trap3.ToString();
            lblTrap4.Text = Trap4.ToString();
        }
        private void btnAnswerAdd_Click(object sender, EventArgs e)
        {
            var tag = int.Parse((sender as Control).Tag.ToString());
            PropertyHelper();
            switch (CurrentRound)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    if (Money > 0)
                    {
                        switch (tag)
                        {
                            case 1:
                                if (Trap2 == 0 || Trap3 == 0 || Trap4 == 0)
                                {
                                    Money -= 25000;
                                    Trap1 += 25000;
                                }
                                break;
                            case 2:
                                if (Trap1 == 0 || Trap3 == 0 || Trap4 == 0)
                                {
                                    Money -= 25000;
                                    Trap2 += 25000;
                                }
                                break;
                            case 3:
                                if (Trap2 == 0 || Trap1 == 0 || Trap4 == 0)
                                {
                                    Money -= 25000;
                                    Trap3 += 25000;
                                }
                                break;
                            case 4:
                                if (Trap2 == 0 || Trap3 == 0 || Trap1 == 0)
                                {
                                    Money -= 25000;
                                    Trap4 += 25000;
                                }
                                break;
                        }
                    }
                    break;
                case 5:
                case 6:
                case 7:
                    if (Money > 0)
                    {
                        switch (tag)
                        {
                            case 1:
                                if (Trap2 == 0 || Trap3 == 0)
                                {
                                    Money -= 25000;
                                    Trap1 += 25000;
                                }
                                break;
                            case 2:
                                if (Trap1 == 0 || Trap3 == 0)
                                {
                                    Money -= 25000;
                                    Trap2 += 25000;
                                }
                                break;
                            case 3:
                                if (Trap1 == 0 || Trap2 == 0)
                                {
                                    Money -= 25000;
                                    Trap3 += 25000;
                                }
                                break;
                        }
                    }
                    break;
                case 8:
                    if (Money > 0)
                    {
                        switch (tag)
                        {
                            case 1:
                                if (Trap2 == 0)
                                {
                                    Money -= 25000;
                                    Trap1 += 25000;
                                }
                                break;
                            case 2:
                                if (Trap1 == 0)
                                {
                                    Money -= 25000;
                                    Trap2 += 25000;
                                }
                                break;
                        }
                    }
                    break;
            }

            LabelToString();
        }
        private void btnAnswerSub_Click(object sender, EventArgs e)
        {
            var tag = int.Parse((sender as Control).Tag.ToString());
            PropertyHelper();
            switch (tag)
            {
                case 1:
                    if (Trap1 > 0)
                    {
                        Money += 25000;
                        Trap1 -= 25000;
                    }
                    break;
                case 2:
                    if (Trap2 > 0)
                    {
                        Money += 25000;
                        Trap2 -= 25000;
                    }
                    break;
                case 3:
                    if (Trap3 > 0)
                    {
                        Money += 25000;
                        Trap3 -= 25000;
                    }
                    break;
                case 4:
                    if (Trap4 > 0)
                    {
                        Money += 25000;
                        Trap4 -= 25000;
                    }
                    break;
            }
            LabelToString();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            var tag = int.Parse((sender as Control).Tag.ToString());
            PropertyHelper();
            if (int.Parse(lblMoney.Text) > 0)
            {
                switch (tag)
                {
                    case 1:
                        if (Trap2 == 0 || Trap3 == 0 || Trap4 == 0)
                        {
                            Trap1 += Money;
                            Money = 0;
                        }
                        break;
                    case 2:
                        if (Trap1 == 0 || Trap3 == 0 || Trap4 == 0)
                        {
                            Trap2 += Money;
                            Money = 0;
                        }
                        break;
                    case 3:
                        if (Trap2 == 0 || Trap1 == 0 || Trap4 == 0)
                        {
                            Trap3 += Money;
                            Money = 0;
                        }
                        break;
                    case 4:
                        if (Trap2 == 0 || Trap3 == 0 || Trap1 == 0)
                        {
                            Trap4 += Money;
                            Money = 0;
                        }
                        break;
                }
            }
            LabelToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            var tag = int.Parse((sender as Control).Tag.ToString());
            PropertyHelper();
            switch (tag)
            {
                case 1:
                    if (Trap1 > 0)
                    {
                        Money += Trap1;
                        Trap1 = 0;
                    }
                    break;
                case 2:
                    if (Trap2 > 0)
                    {
                        Money += Trap2;
                        Trap2 = 0;
                    }
                    break;
                case 3:
                    if (Trap3 > 0)
                    {
                        Money += Trap3;
                        Trap3 = 0;
                    }
                    break;
                case 4:
                    if (Trap4 > 0)
                    {
                        Money += Trap4;
                        Trap4 = 0;
                    }
                    break;
            }
            LabelToString();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            PropertyHelper();
            if (Money == 0)
            {
                var cor = Correct;
                switch (cor)
                {
                    case 1:
                        Money = Trap1;
                        Trap1 = 0;
                        Trap2 = 0;
                        Trap3 = 0;
                        Trap4 = 0;
                        break;
                    case 2:
                        Money = Trap2;
                        Trap1 = 0;
                        Trap2 = 0;
                        Trap3 = 0;
                        Trap4 = 0;
                        break;
                    case 3:
                        Money = Trap3;
                        Trap1 = 0;
                        Trap2 = 0;
                        Trap3 = 0;
                        Trap4 = 0;
                        break;
                    case 4:
                        Money = Trap4;
                        Trap1 = 0;
                        Trap2 = 0;
                        Trap3 = 0;
                        Trap4 = 0;
                        break;
                }
                LabelToString();
                Round();
            }
            else
            {
                MessageBox.Show("All money must me used");
            }

        }
    }
}
