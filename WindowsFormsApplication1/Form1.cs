using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int[,] arr;
        private Color red = Color.Red, yellow = Color.Yellow, white=Color.White;
        private int player = 0;
        private int redScore = 0, yellowScoure = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arr = new int[4, 4];
            label2.Text = "(1 - RED)";
            this.label4.Text = this.redScore.ToString();
            this.label6.Text = this.yellowScoure.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arr[3, 0] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView1.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView1.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView9.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView9.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView13.BackgroundColor = red;
                }
                else
                {
                    dataGridView1.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView1.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView9.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView9.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView13.BackgroundColor = yellow;
                }
                arr[3, 0]++;
            }
            else if (arr[2, 0] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView1.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView1.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView9.BackgroundColor = red;
                }
                else
                {
                    dataGridView1.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView1.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView9.BackgroundColor = yellow;
                }
                arr[2, 0]++;
            }
            else if (arr[1, 0] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView1.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView1.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = red;
                }
                else
                {
                    dataGridView1.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView1.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView5.BackgroundColor = red;
                    dataGridView5.BackgroundColor = yellow;
                }
                arr[1, 0]++;
            }
            else if (arr[0, 0] == 0)
            {
                if (this.player == 0)
                    dataGridView1.BackgroundColor = red;
                else
                    dataGridView1.BackgroundColor = yellow;
                arr[0, 0]++;
            }
            else
            {
                MessageBox.Show("You can not continue in this column.");
                return;
            }
            checkWin();
            this.changePlayer();

        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (arr[3, 1] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView2.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView2.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView10.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView10.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView14.BackgroundColor = red;
                }
                else
                {
                    dataGridView2.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView2.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView10.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView10.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView14.BackgroundColor = yellow;
                }
                arr[3, 1]++;
            }
            else if (arr[2, 1] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView2.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView2.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView10.BackgroundColor = red;
                }
                else
                {
                    dataGridView2.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView2.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView10.BackgroundColor = yellow;
                }
                arr[2, 1]++;
            }
            else if (arr[1, 1] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView2.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView2.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = red;
                }
                else
                {
                    dataGridView2.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView2.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView6.BackgroundColor = yellow;
                }
                arr[1, 1]++;
            }
            else if (arr[0, 1] == 0)
            {
                if (this.player == 0)
                    dataGridView2.BackgroundColor = red;
                else
                    dataGridView2.BackgroundColor = yellow;
                arr[0, 1]++;
            }
            else
            {
                MessageBox.Show("You can not continue in this column.");
                return;
            }
            checkWin();
            this.changePlayer();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (arr[3, 2] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView3.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView3.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView11.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView11.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView15.BackgroundColor = red;
                }
                else
                {
                    dataGridView3.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView3.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView11.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView11.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView15.BackgroundColor = yellow;
                }
                arr[3, 2]++;
            }
            else if (arr[2, 2] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView3.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView3.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView11.BackgroundColor = red;
                }
                else
                {
                    dataGridView3.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView3.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView11.BackgroundColor = yellow;
                }
                arr[2, 2]++;
            }
            else if (arr[1,2] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView3.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView3.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = red;
                }
                else
                {
                    dataGridView3.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView3.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView7.BackgroundColor = yellow;
                }
                arr[1, 2]++;
            }
            else if (arr[0, 2] == 0)
            {
                if (this.player == 0)
                    dataGridView3.BackgroundColor = red;
                else
                    dataGridView3.BackgroundColor = yellow;
                arr[0, 2]++;
            }
            else
            {
                MessageBox.Show("You can not continue in this column.");
                return;
            }
            checkWin();
            this.changePlayer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr[3, 3] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView4.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView4.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView12.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView12.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView16.BackgroundColor = red;
                }
                else
                {
                    dataGridView4.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView4.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView12.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView12.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView16.BackgroundColor = yellow;
                }
                arr[3, 3]++;
            }
            else if (arr[2, 3] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView4.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView4.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView12.BackgroundColor = red;
                }
                else
                {
                    dataGridView4.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView4.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView12.BackgroundColor = yellow;
                }
                arr[2, 3]++;
            }
            else if (arr[1, 3] == 0)
            {
                if (this.player == 0)
                {
                    dataGridView4.BackgroundColor = red;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView4.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = red;
                }
                else
                {
                    dataGridView4.BackgroundColor = yellow;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView4.BackgroundColor = white;
                    System.Threading.Thread.Sleep(20);
                    Update();
                    dataGridView8.BackgroundColor = yellow;
                }
                arr[1, 3]++;
            }
            else if (arr[0, 3] == 0)
            {
                if (this.player == 0)
                    dataGridView4.BackgroundColor = red;
                else
                    dataGridView4.BackgroundColor = yellow;
                arr[0, 3]++;
            }
            else
            {
                MessageBox.Show("You can not continue in this column.");
                return;
            }
            checkWin();
            this.changePlayer();
        }

        private void checkWin()
        {
            if (dataGridView1.BackgroundColor == red)
                if (dataGridView2.BackgroundColor == red)
                    if (dataGridView3.BackgroundColor == red)
                        if (dataGridView4.BackgroundColor == red)
                            if (this.player == 0)
                                msgBox();

            if (dataGridView1.BackgroundColor == yellow)
                if (dataGridView2.BackgroundColor == yellow)
                    if (dataGridView3.BackgroundColor == yellow)
                        if (dataGridView4.BackgroundColor == yellow)
                            msgBox();
            //

            if (dataGridView5.BackgroundColor == red)
                if (dataGridView6.BackgroundColor == red)
                    if (dataGridView7.BackgroundColor == red)
                        if (dataGridView8.BackgroundColor == red)
                            msgBox();

            if (dataGridView5.BackgroundColor == yellow)
                if (dataGridView6.BackgroundColor == yellow)
                    if (dataGridView7.BackgroundColor == yellow)
                        if (dataGridView8.BackgroundColor == yellow)
                            msgBox();
            //
            if (dataGridView9.BackgroundColor == red)
                if (dataGridView10.BackgroundColor == red)
                    if (dataGridView11.BackgroundColor == red)
                        if (dataGridView12.BackgroundColor == red)
                            msgBox();

            if (dataGridView9.BackgroundColor == yellow)
                if (dataGridView10.BackgroundColor == yellow)
                    if (dataGridView11.BackgroundColor == yellow)
                        if (dataGridView12.BackgroundColor == yellow)
                            msgBox();
            //
            if (dataGridView13.BackgroundColor == red)
                if (dataGridView14.BackgroundColor == red)
                    if (dataGridView15.BackgroundColor == red)
                        if (dataGridView16.BackgroundColor == red)
                            msgBox();

            if (dataGridView13.BackgroundColor == yellow)
                if (dataGridView14.BackgroundColor == yellow)
                    if (dataGridView15.BackgroundColor == yellow)
                        if (dataGridView16.BackgroundColor == yellow)
                            msgBox();

            ///////////////////////////////////

            if (dataGridView1.BackgroundColor == red)
                if (dataGridView5.BackgroundColor == red)
                    if (dataGridView9.BackgroundColor == red)
                        if (dataGridView13.BackgroundColor == red)
                            if (this.player == 0)
                                msgBox();

            if (dataGridView1.BackgroundColor == yellow)
                if (dataGridView5.BackgroundColor == yellow)
                    if (dataGridView9.BackgroundColor == yellow)
                        if (dataGridView13.BackgroundColor == yellow)
                            msgBox();

            //
            if (dataGridView2.BackgroundColor == red)
                if (dataGridView6.BackgroundColor == red)
                    if (dataGridView10.BackgroundColor == red)
                        if (dataGridView14.BackgroundColor == red)
                            msgBox();


            if (dataGridView2.BackgroundColor == yellow)
                if (dataGridView6.BackgroundColor == yellow)
                    if (dataGridView10.BackgroundColor == yellow)
                        if (dataGridView14.BackgroundColor == yellow)
                            msgBox();
            //
            if (dataGridView3.BackgroundColor == red)
                if (dataGridView7.BackgroundColor == red)
                    if (dataGridView11.BackgroundColor == red)
                        if (dataGridView15.BackgroundColor == red)
                            msgBox();

            if (dataGridView3.BackgroundColor == yellow)
                if (dataGridView7.BackgroundColor == yellow)
                    if (dataGridView11.BackgroundColor == yellow)
                        if (dataGridView15.BackgroundColor == yellow)
                            msgBox();
            //
            if (dataGridView4.BackgroundColor == red)
                if (dataGridView8.BackgroundColor == red)
                    if (dataGridView12.BackgroundColor == red)
                        if (dataGridView16.BackgroundColor == red)
                            msgBox();

            if (dataGridView4.BackgroundColor == yellow)
                if (dataGridView8.BackgroundColor == yellow)
                    if (dataGridView12.BackgroundColor == yellow)
                        if (dataGridView16.BackgroundColor == yellow)
                            msgBox();
            //////////////////////////////////
            if (dataGridView1.BackgroundColor == red)
                if (dataGridView6.BackgroundColor == red)
                    if (dataGridView11.BackgroundColor == red)
                        if (dataGridView16.BackgroundColor == red)
                            msgBox();

            if (dataGridView1.BackgroundColor == yellow)
                if (dataGridView6.BackgroundColor == yellow)
                    if (dataGridView11.BackgroundColor == yellow)
                        if (dataGridView16.BackgroundColor == yellow)
                            msgBox();
            ///
            if (dataGridView4.BackgroundColor == red)
                if (dataGridView7.BackgroundColor == red)
                    if (dataGridView10.BackgroundColor == red)
                        if (dataGridView13.BackgroundColor == red)
                            msgBox();

            if (dataGridView4.BackgroundColor == yellow)
                if (dataGridView7.BackgroundColor == yellow)
                    if (dataGridView10.BackgroundColor == yellow)
                        if (dataGridView13.BackgroundColor == yellow)
                            msgBox();
            //////////////////////
        }
        private void msgBox()
        {
            if (this.player == 0)
            {
                MessageBox.Show("Player 1 won (RED)");
                restart(0);
            }
            else
            {
                MessageBox.Show("Player 2 won (YELLOW)");
                restart(1);
            }
        }
        private void changePlayer()
        {
            if (this.player == 0)
            {
                this.player++;
                label2.Text = "(2 - YELLOW)";
            }
            else if (this.player == 1)
            {
                this.player--;
                label2.Text = "(1 - RED)";
            }

            int count = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    count += arr[i, j];

            if (count == 16)
            {
                MessageBox.Show("תוצאת שיוון\nמשחק חדש, בהצלחה");

                colorWhite();

                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        arr[i, j] = 0;
            }
        }

        private void restart(int x)
        {
            colorWhite();

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    arr[i, j] = 0;

            if (x == 0) redScore++;
            if (x == 1) yellowScoure++;

            this.label4.Text = this.redScore.ToString();
            this.label6.Text = this.yellowScoure.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.redScore = 0;
            this.yellowScoure = 0;

            this.label4.Text = this.redScore.ToString();
            this.label6.Text = this.yellowScoure.ToString();

            colorWhite();

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    arr[i, j] = 0;

            if (this.player == 0)
                label2.Text = "(1 - RED)";
            else label2.Text = "(1 - YELLOW)";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            colorWhite();
            
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    arr[i, j] = 0;

            if (this.player == 0)
            {
                this.player++;
                this.yellowScoure++;
                this.label6.Text = this.yellowScoure.ToString();
                label2.Text = "(2 - YELLOW)";
            }
            else
            {
                this.player--;
                this.redScore++;
                this.label4.Text = this.redScore.ToString();
                label2.Text = "(1 - RED)";
            }
        }
        private void colorWhite()
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView5.BackgroundColor = Color.White;
            dataGridView6.BackgroundColor = Color.White;
            dataGridView7.BackgroundColor = Color.White;
            dataGridView8.BackgroundColor = Color.White;
            dataGridView9.BackgroundColor = Color.White;
            dataGridView10.BackgroundColor = Color.White;
            dataGridView11.BackgroundColor = Color.White;
            dataGridView12.BackgroundColor = Color.White;
            dataGridView13.BackgroundColor = Color.White;
            dataGridView14.BackgroundColor = Color.White;
            dataGridView15.BackgroundColor = Color.White;
            dataGridView16.BackgroundColor = Color.White;
        }
    }
}