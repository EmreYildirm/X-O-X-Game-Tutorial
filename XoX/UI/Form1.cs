using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private Game xoxgame;
        GroupBox game_field;
        Button btn_start;
        Button btn_cancel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            game_field = new GroupBox();
            game_field.Size = new Size(325, 325);
            game_field.Location = new Point(50, 100);
            game_field.Name = string.Empty;
            this.Controls.Add(game_field);

            btn_start = new Button();
            btn_start.Size = new Size(70, 40);
            btn_start.Text = "Start";
            btn_start.Location = new Point(100, 5);
            btn_start.Click += new EventHandler(btn_Start);
            this.Controls.Add(btn_start);

            btn_cancel = new Button();
            btn_cancel.Size = new Size(70, 40);
            btn_cancel.Text = "Exit";
            btn_cancel.Location = new Point(180, 5);
            btn_cancel.Click += new EventHandler(btn_Cancel);
            this.Controls.Add(btn_cancel);
        }
        private void btn_Start(object sender, EventArgs e)
        {
            xoxgame = new Game();
            xoxgame.GameStart += new xoxGameHandler(game_Started);
            xoxgame.StartGame();
            btn_start.Visible = false;
        }

        private void game_Started(Game xoxgame)
        {
            p1name.Text = xoxgame.Player1.Name;
            p2name.Text = xoxgame.Player2.Name;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 100);
                    btn.Location = new Point(105 * j + 10, 105 * i + 10);
                    btn.Tag = 3 * i + j;
                    btn.Click += new EventHandler(Btn_Click);
                    this.game_field.Controls.Add(btn);
                }
            }
            changeActiveLabel();
            xoxgame.GameOver += new xoxGameOverHandler(game_Over);
        }
        private void changeActiveLabel()
        {
            if (xoxgame.ActivePlayer)
            {
                p1name.Font = new Font("", 15);
                p2name.Font = default(Font);
            }
            else
            {
                p1name.Font = default(Font);
                p2name.Font = new Font("", 15);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var fieldindex = Convert.ToInt32(btn.Tag);
            if (xoxgame.ActivePlayer)
            {
                btn.Text = xoxgame.Player1.Symbol;
            }
            else
            {
                btn.Text = xoxgame.Player2.Symbol;
            }
            changeActiveLabel();
            xoxgame.PlayTurn(fieldindex);
        }

        private void btn_Cancel(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void game_Over(Game game, List<List<int>> winningConditions)
        {
            string result = null;
            foreach (var condition in winningConditions)
            {
                game_field.Controls[condition[0]].BackColor = Color.GreenYellow;
                game_field.Controls[condition[1]].BackColor = Color.GreenYellow;
                game_field.Controls[condition[2]].BackColor = Color.GreenYellow;
            }
            if (xoxgame.ısOver)
            {
                DisableButtons();
                if (xoxgame.ısDraw == true)
                    result = "Berabere";
                else if (xoxgame.ActivePlayer)
                    result = "Winner = X";
                else if (!xoxgame.ActivePlayer)
                    result = "Winner = O";
            }
            WantPlayAgain(result);
        }
        private void DisableButtons()
        {
            foreach (var item in game_field.Controls)
            {
                Button btn = item as Button;
                if (btn != null)
                    btn.Enabled = false;
            }
        }
        private void RestardGame()
        {
            game_field.Controls.Clear();
            game_Started(xoxgame);
        }
        private void WantPlayAgain(string result)
        {
            var msg = MessageBox.Show($"Game over. {result}", " Make your choice ", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                Application.Restart();
                btn_start.Enabled = true;
                RestardGame();
            }
            else if (msg == DialogResult.No)
                Environment.Exit(1);
        }

    }
}