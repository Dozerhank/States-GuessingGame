using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace States_CardGame
{
    public partial class Form1 : Form
    {
        Context context = new Context(new ConcreteStateLevel1());

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new Context(new ConcreteStateLevel1(this));
        }

        private string answer = " ";
        public int level;

        public void updateCard(int slot, int card, string suit)
        {
            if (card == 0)
            {
                if (slot == 0)
                {
                    pb_leftCard.Image = Image.FromFile(Application.StartupPath + "\\" + "BackCovers" + "\\" + "Peter River.png");
                }
                else if (slot == 1)
                {
                    pb_rightCard.Image = Image.FromFile(Application.StartupPath + "\\" + "BackCovers" + "\\" + "Peter River.png");
                }
            }
            else
            {
                if (slot == 0)
                {
                    pb_leftCard.Image = Image.FromFile(Application.StartupPath + "\\" + suit + "\\" + Convert.ToString(card) + ".png");
                }
                else if (slot == 1)
                {
                    pb_rightCard.Image = Image.FromFile(Application.StartupPath + "\\" + suit + "\\" + Convert.ToString(card) + ".png");
                }
            }
        }

        public void updateGUI()
        {
            switch(this.level)
            {
                //Level 1
                case 1:
                    tb_leftCard.Text = "Prediction Card";
                    tb_rightCard.Text = " ";
                    tb_Prediction2.SendToBack();
                    btn_p2c1.SendToBack();
                    btn_p2c2.SendToBack();
                    tb_Prediction3.SendToBack();
                    btn_p3c1.SendToBack();
                    btn_p3c2.SendToBack();
                    btn_Reveal.SendToBack();
                    progressBar.Value = 0;
                    break;
                //Level 2
                case 2:
                    tb_leftCard.Text = "Previous Card";
                    tb_rightCard.Text = "Prediction Card";
                    tb_Prediction2.BringToFront();
                    btn_p2c1.BringToFront();
                    btn_p2c2.BringToFront();
                    tb_Prediction3.SendToBack();
                    btn_p3c1.SendToBack();
                    btn_p3c2.SendToBack();
                    btn_Reveal.SendToBack();
                    progressBar.Value = 1;
                    break;
                //Level 3
                case 3:
                    tb_leftCard.Text = "Previous Card";
                    tb_rightCard.Text = "Prediction Card";
                    tb_Prediction2.BringToFront();
                    btn_p2c1.BringToFront();
                    btn_p2c2.BringToFront();
                    tb_Prediction3.BringToFront();
                    btn_p3c1.BringToFront();
                    btn_p3c2.BringToFront();
                    btn_Reveal.SendToBack();
                    progressBar.Value = 2;
                    break;
                case 4:
                    progressBar.Value = 3;
                    break;
            }

            Button[] buttons = { btn_p1c1, btn_p1c2, btn_p2c1, btn_p2c2, btn_p3c1, btn_p3c2 };
            foreach(Button x in buttons)
            {
                x.BackColor = Color.Turquoise;
            }
        }

        public void updateChoices(string[] choices)
        {
            switch(this.level)
            {
                case 1:
                    btn_p1c1.Text = choices[0];
                    btn_p1c2.Text = choices[1];
                    return;
                case 2:
                    btn_p2c1.Text = choices[0];
                    btn_p2c2.Text = choices[1];
                    return;
                case 3:
                    btn_p3c1.Text = choices[0];
                    btn_p3c2.Text = choices[1];
                    return;
            }
        }

        public void updateReveal(string text)
        {
            this.btn_Reveal.Text = text;
        }

        //Check Answer Button
        private void btn_Reveal_Click(object sender, EventArgs e)
        {
            if (this.btn_Reveal.Text == "Check Prediction")
            {
                this.context.checkanswer(answer);
            }
            else if (this.btn_Reveal.Text == "Continue")
            {
                this.context.incrementlevel();
            }
            else
            {
                this.context.resetgame();
            }
        }

        //Reset Button
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.context.resetgame();
        }

        //Choice options for user - Format: Prediction # Choice #
        private void btn_p1c1_Click(object sender, EventArgs e)
        {
            if (this.level == 1)
            {
                this.answer = btn_p1c1.Text;
                btn_p1c1.BackColor = Color.LightSeaGreen;
                btn_p1c2.BackColor = Color.Turquoise;
                btn_Reveal.BringToFront();
            }
        }

        private void btn_p1c2_Click(object sender, EventArgs e)
        {
            if (this.level == 1)
            {
                this.answer = btn_p1c2.Text;
                btn_p1c1.BackColor = Color.Turquoise;
                btn_p1c2.BackColor = Color.LightSeaGreen;
                btn_Reveal.BringToFront();
            }
        }

        private void btn_p2c1_Click(object sender, EventArgs e)
        {
            if (this.level == 2)
            {
                this.answer = btn_p2c1.Text;
                btn_p2c1.BackColor = Color.LightSeaGreen;
                btn_p2c2.BackColor = Color.Turquoise;
                btn_Reveal.BringToFront();
            }
        }

        private void btn_p2c2_Click(object sender, EventArgs e)
        {
            if (this.level == 2)
            {
                this.answer = btn_p2c2.Text;
                btn_p2c1.BackColor = Color.Turquoise;
                btn_p2c2.BackColor = Color.LightSeaGreen;
                btn_Reveal.BringToFront();
            }
        }

        private void btn_p3c1_Click(object sender, EventArgs e)
        {
            if (this.level == 3)
            {
                this.answer = btn_p3c1.Text;
                btn_p3c1.BackColor = Color.LightSeaGreen;
                btn_p3c2.BackColor = Color.Turquoise;
                btn_Reveal.BringToFront();
            }
        }

        private void btn_p3c2_Click(object sender, EventArgs e)
        {
            if (this.level == 3)
            {
                this.answer = btn_p3c2.Text;
                btn_p3c1.BackColor = Color.Turquoise;
                btn_p3c2.BackColor = Color.LightSeaGreen;
                btn_Reveal.BringToFront();
            }
        }

        private void pb_leftCard_Click(object sender, EventArgs e)
        {

        }

        private void pb_rightCard_Click(object sender, EventArgs e)
        {

        }
    }
}