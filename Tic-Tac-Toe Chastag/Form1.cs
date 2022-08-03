namespace Tic_Tac_Toe_Chastag
{
    public partial class Form1 : Form
    {
        List<Button> field = new List<Button>();
        EndingScreen idk = new EndingScreen();
        int draw = 0;


        public Random rnd = new Random();
        public int bot = 0;
        public Form1()
        {
            InitializeComponent();
            field.Add(btn1);
            field.Add(btn2);
            field.Add(btn3);
            field.Add(btn4);
            field.Add(btn5);
            field.Add(btn6);
            field.Add(btn7);
            field.Add(btn8);
            field.Add(btn9);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text.Length == 0)
            {
                btn1.Text = "X";
                btn1.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text.Length == 0)
            {
                btn2.Text = "X";
                btn2.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text.Length == 0)
            {
                btn3.Text = "X";
                btn3.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text.Length == 0)
            {
                btn4.Text = "X";
                btn4.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text.Length == 0)
            {
                btn5.Text = "X";
                btn5.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text.Length == 0)
            {
                btn6.Text = "X";
                btn6.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text.Length == 0)
            {
                btn7.Text = "X";
                btn7.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text.Length == 0)
            {
                btn8.Text = "X";
                btn8.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text.Length == 0)
            {
                btn9.Text = "X";
                btn9.Enabled = false;
                Bot();
                GameStatus();
            }
        }

        void Bot()
        {
            int index = rnd.Next(0, field.Count);
            if (field[index].Text.Length == 0)
            {
                bot = 0;
                field[index].Text = "O";
                field[index].Enabled = false;
            }
            else
            {
                bot++;
                if (bot == 4)
                {
                    CheckingIndexes();
                }
                else
                {
                    Bot();
                }
            }

        }

        void CheckingIndexes()
        {
            draw = 0;
            bot = 0;
            for (int i = 0; i < field.Count; i++)
            {
                if (field[i].Text.Length == 0)
                {
                    field[i].Text = "O";
                    field[i].Enabled = false;
                    break;
                }
                else
                {
                    draw++;
                    GameStatus();
                }
            }
        }
        void GameStatus()
        {
            if (field[0].Text == "X" && field[1].Text == "X" && field[2].Text == "X" || field[3].Text == "X" && field[4].Text == "X" && field[5].Text == "X" || field[6].Text == "X" && field[7].Text == "X" && field[8].Text == "X" ||
                field[0].Text == "X" && field[3].Text == "X" && field[6].Text == "X" || field[1].Text == "X" && field[4].Text == "X" && field[7].Text == "X" || field[2].Text == "X" && field[5].Text == "X" && field[8].Text == "X" ||
                field[0].Text == "X" && field[4].Text == "X" && field[8].Text == "X" || field[2].Text == "X" && field[4].Text == "X" && field[6].Text == "X")
            {
                //Won
                idk.Won();
                this.Hide();
                idk.ShowDialog();
            }
            else if(field[0].Text == "O" && field[1].Text == "O" && field[2].Text == "O" || field[3].Text == "O" && field[4].Text == "O" && field[5].Text == "O" || field[6].Text == "O" && field[7].Text == "O" && field[8].Text == "O" ||
                    field[0].Text == "O" && field[3].Text == "O" && field[6].Text == "O" || field[1].Text == "O" && field[4].Text == "O" && field[7].Text == "O" || field[2].Text == "O" && field[5].Text == "O" && field[8].Text == "O" ||
                    field[0].Text == "O" && field[4].Text == "O" && field[8].Text == "O" || field[2].Text == "O" && field[4].Text == "O" && field[6].Text == "O") 
            {
                //Lost
                idk.Lost();
                this.Hide();
                idk.ShowDialog();
            }
            else if (draw == 9)
            {
                //Draw
                idk.Draw();
                this.Hide();
                idk.ShowDialog();
            }
        }

    }
}