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
    
    public partial class Form1 : Form
    {
        private Grid grid;
        public Form1(String filename)
        {
            grid = Grid.readFile(filename);
            if (grid != null)
            {
                Cell[] cells = grid.getCellsSorted();
                InitializeComponent();
                creatTextboxAsync(cells);
            }
            else
            {
                DialogResult d1 = new DialogResult();
                d1 = MessageBox.Show("File is not correct", "run", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (d1 == DialogResult.OK)
                {
                    this.Hide();
                    textMOD m = new textMOD();
                    m.ShowDialog();
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            if (Parallel.Checked == true)
            {
                d = MessageBox.Show("Parallel run", "run", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    
                    Grid solvedGrid = Grid.solveParallel(grid);
                    grid.printGrid();
                    Cell[] newCells = solvedGrid.getCellsSorted();
                        
                    solvedGrid.printGrid();
                    if (solvedGrid.isSolved())
                    {
                        Initializenumber(grid.getCellsSorted());
                        Console.WriteLine(solvedGrid.getParallelTime());
                        solve_textboxAsync(newCells, solvedGrid.getParallelTime());
                    }
                    else
                    {
                        DialogResult d1 = new DialogResult();
                        d1 = MessageBox.Show("Problem can't solve ", "run", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (d1 == DialogResult.OK)
                        {
                            this.Hide();
                            textMOD m = new textMOD();
                            m.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                if (Sequence.Checked == true)
                {
                    d = MessageBox.Show("Sequence run", "run", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        Grid solvedGrid = Grid.solveSerial(grid);
                        Cell[] newCells = solvedGrid.getCellsSorted();
                        if (solvedGrid.isSolved())
                        {
                            Initializenumber(grid.getCellsSorted());
                            Console.WriteLine(solvedGrid.getSerialTime());
                            solve_textboxAsync(newCells, solvedGrid.getSerialTime());
                        }
                        else
                        {
                            DialogResult d1 = new DialogResult();
                            d1 = MessageBox.Show("Problem can't solve ", "run", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (d1 == DialogResult.OK)
                            {
                                this.Hide();
                                textMOD m = new textMOD();
                                m.ShowDialog();
                            }
                        }
                    }
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            textMOD m = new textMOD();
            m.ShowDialog();
        }
    }
}
