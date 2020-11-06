using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.exit = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.textB = new TextBox[9, 9];
            this.Parallel = new System.Windows.Forms.RadioButton();
            this.Sequence = new System.Windows.Forms.RadioButton();
            this.Time = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.ColumnCount = 9;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 9;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel.Size = new System.Drawing.Size(615, 366);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panal_paint);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Location = new System.Drawing.Point(542, 411);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.SystemColors.Highlight;
            this.solve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.solve.Location = new System.Drawing.Point(441, 411);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 2;
            this.solve.Text = "Solve ";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.button2_Click);
            // 
            // Parallel
            // 
            this.Parallel.AutoSize = true;
            this.Parallel.Checked = true;
            this.Parallel.Location = new System.Drawing.Point(12, 395);
            this.Parallel.Name = "Parallel";
            this.Parallel.Size = new System.Drawing.Size(59, 17);
            this.Parallel.TabIndex = 1;
            this.Parallel.TabStop = true;
            this.Parallel.Text = "Parallel";
            // 
            // Sequence
            // 
            this.Sequence.AutoSize = true;
            this.Sequence.Location = new System.Drawing.Point(12, 418);
            this.Sequence.Name = "Sequence";
            this.Sequence.Size = new System.Drawing.Size(72, 17);
            this.Sequence.TabIndex = 0;
            this.Sequence.Text = "Sequence";
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Time.Location = new System.Drawing.Point(124, 411);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(200, 24);
            this.Time.TabIndex = 0;
            this.Time.Text = "Time:";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "solve new one";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Sequence);
            this.Controls.Add(this.Parallel);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async Task creatTextboxAsync(Cell[] c)
        {
            for (int row =0; row < Panel.RowCount; row++)
            {
                for(int col =0;col < Panel.ColumnCount; col++)
                {


                    textB[row,col] = new System.Windows.Forms.TextBox
                    {
                        TextAlign = System.Windows.Forms.HorizontalAlignment.Center,
                        Width = 50,
                        Font = new System.Drawing.Font("Arial", 14f, System.Drawing.FontStyle.Bold)

                    };
                  
                    if (row <= 2 && col <= 2)
                    {
                        textB[row, col].BackColor = Color.AntiqueWhite;
                    }
                    else
                    {
                        if (row <= 2 && col <= 5)
                        {
                            textB[row, col].BackColor = Color.Aqua;
                        }
                        else
                        {
                            if (row <= 2 && col <= 8)
                            {
                                textB[row, col].BackColor = Color.AntiqueWhite;
                            }

                            else
                            {
                                if (row <= 5 && col <= 2)
                                {
                                    textB[row, col].BackColor = Color.Aqua;
                                }
                                else
                                {
                                   if (row <= 8 && col <= 2)
                                   {
                                        textB[row, col].BackColor = Color.AntiqueWhite;
                                   }
                                    else
                                    {
                                        if (row <= 5 && col <= 5)
                                        {
                                            textB[row, col].BackColor = Color.AntiqueWhite;
                                        }
                                        else
                                        {
                                            if (row <= 5 && col <= 8)
                                            {
                                                textB[row, col].BackColor = Color.Aqua;
                                            }
                                            else
                                            {
                                                if (row <= 8 && col <= 5)
                                                {
                                                    textB[row, col].BackColor = Color.Aqua;
                                                }
                                                else
                                                {
                                                    if (row <= 8 && col <= 8)
                                                    {
                                                        textB[row, col].BackColor = Color.AntiqueWhite;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                   
                    textB[row, col].KeyPress += textbox_keypress;
                    Panel.Controls.Add(textB[row, col], row, col);
                    textB[row, col].ReadOnly = true;
                }
            }
            await Task.Delay(500);
            Initializenumber(c);
        }

        private async Task Initializenumber(Cell[] c)
        {
            for(int i = 0; i < 81; i++)
            {
                if (c[i].getTime() == 0)
                {
                    textB[c[i].getY(), c[i].getX()].Text = c[i].getValue().ToString();
                }
                else
                {
                    textB[c[i].getY(), c[i].getX()].Text ="";
                }
            }
            
        }

        private async Task solve_textboxAsync(Cell[] c, long time)
        {
            for (int i = 0; i < 81; i++)
            {
                if (c[i].getTime() != 0)
                {
                    textB[c[i].getY(), c[i].getX()].Text = c[i].getValue().ToString();
                }
                if (i == 80)
                    Time.Text = "Time : " + time + " milli sec";
                if (c[i].getValue() == -1)
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Problem can't solve ", "run", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (d == DialogResult.OK)
                    {
                        this.Hide();
                        textMOD m = new textMOD();
                        m.ShowDialog();
                    }
                }
                await Task.Delay(200);
            }



        }
        static void textbox_keypress(object sender ,KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
                switch (e.KeyChar)
                {
                    case ' ':
                        e.Handled = false;
                        break;
                    case (char)Keys.Back:
                        e.Handled = false;
                        break;
                    default:
                        e.Handled = true;
                        break;
                           
                }
            else
            {
                e.Handled = false;
            }
            if (!(e.KeyChar == ' ' | e.KeyChar == '0')) return;
            e.KeyChar = (char)Keys.Back;

        }

        private void panal_paint(object sender, PaintEventArgs e)
        {
           
            e.Graphics.FillRectangle(Brushes.Blue,0, 118, Panel.Width, 2);
            e.Graphics.FillRectangle(Brushes.Blue, 0,237, Panel.Width, 2);

            e.Graphics.FillRectangle(Brushes.Green, 198, 0, 2, Panel.Height);
            e.Graphics.FillRectangle(Brushes.Green, 400, 0, 2, Panel.Height);
            //e.Graphics.FillRectangle(Brushes.Blue,,)


        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.Button exit;
        private Button solve;
        private TextBox[,] textB;
        private RadioButton Parallel;
        private RadioButton Sequence;
        private Label Time;
        private Button button1;
    }
}

