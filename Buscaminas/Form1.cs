using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            lblTiempo.Visible = false;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text =   "Hora:    " + DateTime.Now.ToString("hh:mm:ss");
            TimeSpan duration = DateTime.Now - dateTimeInit;
            lblTiempo.Text = "Tiempo: " + duration.ToString(@"hh\:mm\:ss");
        }

        const int CTE_MINE = 999;
        int[,] matrix = null;
        int numMinas = 10;
        int numDificultad = 10;
        Timer timer = new Timer();
        DateTime dateTimeInit = DateTime.Now;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayNewGame();
            lblTiempo.Visible = true;
        }

        private void PlayNewGame()
        {
            timer.Start();
            dateTimeInit = DateTime.Now;
            System.Media.SystemSounds.Asterisk.Play();
            numMinas = int.Parse(txtMinas.Text);
            numDificultad = int.Parse(txtDificultad.Text);

            DataTable dt = new DataTable();
            for (int i = 0; i < numDificultad; i++)
                dt.Columns.Add();
            for (int i = 0; i < numDificultad; i++)
                dt.Rows.Add(dt.NewRow());

            dgvMinas.DataSource = dt;
            dgvMinas.ColumnHeadersVisible = false;
            dgvMinas.RowHeadersVisible = false;
            dgvMinas.AllowUserToAddRows = false;
            dgvMinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMinas.ReadOnly = true;
            dgvMinas.CellClick -= new DataGridViewCellEventHandler(dgvMinas_CellClick);
            dgvMinas.CellClick += new DataGridViewCellEventHandler(dgvMinas_CellClick);
            dgvMinas.MouseClick -= new MouseEventHandler(dgvMinas_MouseClick);
            dgvMinas.MouseClick += new MouseEventHandler(dgvMinas_MouseClick);

            for (int i = 0; i < numDificultad; i++)
                for (int j = 0; j < numDificultad; j++)
                {
                    DataGridViewButtonCell b = new DataGridViewButtonCell();
                    dgvMinas[i, j] = b;
                }

            matrix = new int[numDificultad, numDificultad];
            Random r = new Random();
            for (int n = 0; n < numMinas; n++)
            {
                int i = r.Next(numDificultad);
                int j = r.Next(numDificultad);
                if (matrix[i, j] == CTE_MINE)
                    n--;
                else
                    matrix[i, j] = CTE_MINE;
            }
        }

        void dgvMinas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                System.Windows.Forms.DataGridView.HitTestInfo info = dgvMinas.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0 && info.ColumnIndex >= 0) 
                {
                    DataGridViewCell cell = dgvMinas[info.ColumnIndex, info.RowIndex];
                    if (cell is DataGridViewButtonCell) 
                    {
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)cell;
                        if (buttonCell.Value.ToString() == string.Empty)
                            buttonCell.Value = "F";
                        else if (buttonCell.Value.ToString() == "F")
                            buttonCell.Value = "?";
                        else if (buttonCell.Value.ToString() == "?")
                            buttonCell.Value = "";
                    }
                }
            }
        }

        void dgvMinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvMinas.CurrentCell == null)
                return;
            dgvMinas[e.ColumnIndex, e.RowIndex] = new DataGridViewTextBoxCell();
            if (matrix[e.ColumnIndex, e.RowIndex] == CTE_MINE)
            {
                dgvMinas[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                dgvMinas.ClearSelection();
                timer.Stop();
                MessageBox.Show("Game Over");
                PlayNewGame();
            }
            else
            {
                int n = GetNumMinasAlrededorCelda(e.ColumnIndex, e.RowIndex);
                dgvMinas[e.ColumnIndex, e.RowIndex].Value = n;
                if (n == 0)
                {
                    DespejarCeldasAlrededor(e.ColumnIndex, e.RowIndex);
                }
            }


            int numButtons = GetNumButtons();
            if (numButtons == numMinas)
            {
                timer.Stop();
                MessageBox.Show("You Win");                
                PlayNewGame();
            }

            dgvMinas.ClearSelection();

        }

        private int GetNumButtons()
        {
            int n = 0;
            for (int i = 0; i < numDificultad; i++)
                for (int j = 0; j < numDificultad; j++)
                    if (dgvMinas[i, j] is DataGridViewButtonCell)
                    {
                        n++;
                    }
            return n;
        }

        private void DespejarCeldasAlrededor(int i, int j)
        {
            if (i >= 0 && i < numDificultad && j >= 0 && j < numDificultad)
            {
                DespejarCeldasAlrededor_Pos(i-1, j-1);
                DespejarCeldasAlrededor_Pos(i-1, j);
                DespejarCeldasAlrededor_Pos(i - 1, j+1);
                DespejarCeldasAlrededor_Pos(i, j - 1);
                DespejarCeldasAlrededor_Pos(i, j + 1);
                DespejarCeldasAlrededor_Pos(i + 1, j - 1);
                DespejarCeldasAlrededor_Pos(i + 1, j);
                DespejarCeldasAlrededor_Pos(i + 1, j + 1);
            }
        }

        private void DespejarCeldasAlrededor_Pos(int a, int b)
        {
            int n1 = GetNumMinasAlrededorCelda(a, b);

            if (a >= 0 && a < numDificultad && b >= 0 && b < numDificultad && (dgvMinas[a, b].Value.ToString() == string.Empty))
            {
                dgvMinas[a, b].Value = n1;
                dgvMinas[a, b] = new DataGridViewTextBoxCell();

                if (n1 == 0)
                {
                    DespejarCeldasAlrededor(a, b);
                }
            }
            
            
        }

        private int GetNumMinasAlrededorCelda(int i, int j)
        {
            bool b1 = ExisteMinaEnCelda(i - 1, j - 1);
            bool b2 = ExisteMinaEnCelda(i - 1, j);
            bool b3 = ExisteMinaEnCelda(i - 1, j + 1);
            bool b4 = ExisteMinaEnCelda(i, j - 1);
            bool b5 = ExisteMinaEnCelda(i, j + 1);
            bool b6 = ExisteMinaEnCelda(i + 1, j - 1);
            bool b7 = ExisteMinaEnCelda(i + 1, j );
            bool b8 = ExisteMinaEnCelda(i + 1, j + 1);

            int n = 0;
            if (b1) n++;
            if (b2) n++;
            if (b3) n++;
            if (b4) n++;
            if (b5) n++;
            if (b6) n++;
            if (b7) n++;
            if (b8) n++;
            return n;
        }

        private bool ExisteMinaEnCelda(int i, int j)
        {
            if (i >= 0 && i < numDificultad && j >= 0 && j < numDificultad)
                return matrix[i, j] == CTE_MINE;
            return false;
        }
    }
}
