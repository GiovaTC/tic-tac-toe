using System;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        private bool isPlayerX = true;
        private Button[,] buttons = new Button[3, 3];
        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard();
        }
        private void InitializeGameBoard()
        {
            for (int i = 0; i < 3; i++)
            {
               for (int j = 0; j < 3; j++)
               {
                buttons[i, j] = new Button();
                buttons[i, j].SetBounds(50 + 100 * j, 50 + 100 * i, 100, 100);
                buttons[i, j].Font = new System.Drawing.Font("Arial", 24);
                buttons[i, j].Click += new EventHandler(Button_Click);
                this.Controls.Add(buttons[i, j]);
               }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == "")
            {
                button.Text = isPlayerX ? "X" : "O";
                isPlayerX = !isPlayerX;
                CheckForWinner();
            }
        }

        private void CheckForWinner()
        {
            // Implementar la lógica para verificar ganador o empate
            string winner = GetWinner();
            if (winner != null)
            {
                MessageBox.Show($"{winner} gana!");
                ResetGame();
            }
            else if (IsDraw())
            {
                MessageBox.Show("Empate!");
                ResetGame();
            }
        }

        private string GetWinner()
        {
            // Verificar filas, columnas y diagonales para determinar el ganador
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text && buttons[i, 0].Text != "")
                   return buttons[i, 0].Text;

                if (buttons[0, i].Text == buttons[1, i].Text && buttons[1, i].Text == buttons[2, i].Text && buttons[0, i].Text != "")
                   return buttons[0, i].Text;
            }

            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text && buttons[0, 0].Text != "")
                return buttons[0, 0].Text;

            if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text && buttons[0, 2].Text != "")
                return buttons[0, 2].Text;

            return null;
        }

    private bool IsDraw()
    {
        foreach (Button button in buttons)
        {
            if (button.Text == "")
                return false;
        }
        return true;
    }

    private void ResetGame()
    {
        foreach (Button button in buttons)
        {
            button.Text = "";
        }
        isPlayerX = true;
    }
  }
}
