using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        int CurrentLocX, CurrentLocY;
        int xLocation = 0;
        int yLocation = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen myPen1;
            myPen1 = new System.Drawing.Pen(System.Drawing.Color.Black);
            e.Graphics.DrawLine(myPen1, 50, 250, 170, 170);
            e.Graphics.DrawLine(myPen1, 60, 250, 170, 350);
            e.Graphics.DrawLine(myPen1, 50, 250, 450, 250);

            Rectangle rect = new Rectangle(150, 340, 40, 50);
            e.Graphics.DrawArc(myPen1, rect, -45, 300);

            Rectangle rect1 = new Rectangle(265, 250, 30, 50);
            e.Graphics.DrawArc(myPen1, rect1, -45, 300);

            Rectangle rect2 = new Rectangle(170,150, 50, 50);
            e.Graphics.DrawArc(myPen1, rect2, 140, -280);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 9);
            if (pictureBox1.Location.Y + pictureBox1.Height > this.Height)
            {
                timer1.Stop();
               // timer3.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 3);

            if (pictureBox1.Location.Y < 30)
            {
             
                timer2.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///------------------ORIGINAL WORK----------
            string input = textBox1.Text;
            int length = input.Length;
            if (textBox1.Text =="")
            {
                pictureBox7.ImageLocation = @"F:\7thSemesterWork\Automaita\Project\w.png";
                label6.Text = "Word Rejected ";
            }
            else
            {
                char temp = input[0];
                foreach (char c in input)
                {
                    if (c == 'a' || c == 'b')
                    {
                    }
                    else
                    {
                        MessageBox.Show("Not belogs to this language");
                        // Console.WriteLine("Not belogs to this language");
                        break;
                    }

                }

                if (temp == input[1] || input[length - 1] == input[length - 2])
                {

                    pictureBox7.ImageLocation = @"F:\7thSemesterWork\Automaita\Project\tt.png";
                    label6.Text = "Word Accepted ";
                    //MessageBox.Show("Word Accepted");
                    // Console.WriteLine("Word Accepted");
                }
                else
                {
                    pictureBox7.ImageLocation = @"F:\7thSemesterWork\Automaita\Project\w.png";
                    label6.Text = "Word Rejected ";
                    // MessageBox.Show("Word Rejected");
                    //   Console.WriteLine("Word Rejected");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] statearray = new string[] { "q0", "q1", "q2", "q3", "q4" };
            if (textBox1.Text == "")
            {
                MessageBox.Show("Word Rejected Invalid Word");
               // this.label14.Text = "lambda";
            }
            else
            {
                string getText = textBox1.Text;
                button3.Enabled = false;
                string k = textBox1.Text;
                //lenth work
                int lengt = k.Length;
                char[] a = k.ToCharArray();
                int i = 0;
                int Radius = 30;
                bool check = true;
                foreach (char c in getText)
                {
                    if (c == 'a' || c == 'b')
                    {
                        //check = false;
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    if (a[i] == 'a' && a[i + 1] == 'a')
                    {
                        CurrentLocX = label14.Location.X;
                        CurrentLocY = label14.Location.Y;
                        label14.Text = "aa".ToString();

                        this.label14.Refresh();
                        
                        
                        for (int j = 0; j < 60; j += 1)
                        {

                            this.label14.Location = new System.Drawing.Point(label14.Location.X + 1, label14.Location.Y - 1);
                            Thread.Sleep(50);
                        }
                        listBox1.Items.Add(statearray[0] + "--->" + "aa" + "---->" + statearray[1]);

                        string input = textBox1.Text;
                        int length = input.Length;
                        for (int j = 2; j < length; j++)
                        {
                            
                            label14.Text = input[j].ToString();
                            this.label14.Refresh();
                            for (int z = 130; z < 490; z++)
                            {

                                this.label14.Location = new System.Drawing.Point(pictureBox2.Location.X + 10 + (int)(Radius * (Math.Cos(z * Math.PI / 180))), pictureBox2.Location.Y + 8 + (int)(Radius * (Math.Sin(z * Math.PI / 180))));
                                //
                                Thread.Sleep(10);
                            }

                            listBox1.Items.Add(statearray[1] + "--->" + input[j] + "--->" + statearray[1]);
                        }

                    }
                    else if (a[i] == 'b' && a[i + 1] == 'b')
                    {
                        CurrentLocX = label14.Location.X;
                        CurrentLocY = label14.Location.Y;
                        this.label14.Text = "bb".ToString();
                        this.label14.Refresh();

                        for (int j = 0; j < 60; j += 1)
                        {
                            this.label14.Location = new System.Drawing.Point(label14.Location.X + 1, label14.Location.Y + 1);
                            Thread.Sleep(50);
                        }

                        listBox1.Items.Add(statearray[0] + "--->" + "bb" + "---->" + statearray[2]);

                        string input = textBox1.Text;
                        int length = input.Length;
                        for (int j = 2; j < length; j++)
                        {
                            label14.Text = input[j].ToString();
                            this.label14.Refresh();

                            for (int z = 250; z < 610; z++)
                            {

                                this.label14.Location = new System.Drawing.Point(pictureBox3.Location.X + 10 + (int)(Radius * (Math.Cos(z * Math.PI / 180))), pictureBox3.Location.Y + 8 + (int)(Radius * (Math.Sin(z * Math.PI / 180))));

                                Thread.Sleep(10);
                            }

                            listBox1.Items.Add(statearray[2] + "--->" + input[j] + "--->" + statearray[2]);
                        }

                    }

                    else if (a[i] != a[i + 1] && a[lengt - 1] == a[lengt - 2])
                    {
                        CurrentLocX = label14.Location.X;
                        CurrentLocY = label14.Location.Y;
                        label14.Text = a[i].ToString();
                        this.label14.Refresh();
                        for (int j = 0; j < 140; j += 1)
                        {

                            this.label14.Location = new System.Drawing.Point(label14.Location.X + 1, label14.Location.Y);
                            Thread.Sleep(10);
                        }

                        listBox1.Items.Add(statearray[0] + "--->" + a[i] + "--->" + statearray[3]);

                        string input = textBox1.Text;
                        int length = input.Length - 2;
                        for (int j = 1; j < length; j++)
                        {
                            label14.Text = input[j].ToString();
                            this.label14.Refresh();
                            for (int z = 160; z < 520; z++)
                            {

                                this.label14.Location = new System.Drawing.Point(pictureBox4.Location.X + 10 + (int)(Radius * (Math.Cos(z * Math.PI / 180))), pictureBox4.Location.Y + 8 + (int)(Radius * (Math.Sin(z * Math.PI / 180))));

                                Thread.Sleep(10);
                            }

                            listBox1.Items.Add(statearray[3] + "--->" + a[j] + "--->" + statearray[3]);
                        }
                        int getLength = input.Length;
                        string lastWord = input[getLength - 1] + "" + input[getLength - 2];
                        int lenghtlast = lastWord.Length;
                        label14.Text = lastWord;
                        this.label14.Refresh();
                        for (int j = 0; j < 160; j += 1)
                        {

                            this.label14.Location = new System.Drawing.Point(label14.Location.X + 1, label14.Location.Y);
                            Thread.Sleep(10);
                        }
                        listBox1.Items.Add(statearray[3] + "--->" + lastWord + "--->" + statearray[4]);

                    }
                    else
                    {
                        MessageBox.Show("Not Belong to given Language");
                    }
                }
                else
                {
                    MessageBox.Show("Not Belong to given Language");
                }


            }
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = true;
            string getText = textBox1.Text;
            listBox1.Items.Clear();
            foreach (char c in getText)
            {
                if (c == 'a' || c == 'b')
                {
                }
                else
                {
                    check = false;
                }
            }
            if (check == true)
            {
                textBox1.Clear();
                
                this.label14.Text = "temp";
                this.label14.Refresh();
              
                this.label14.Location = new System.Drawing.Point(CurrentLocX, CurrentLocY);
                button3.Enabled = true;

            }
            else
            {
                textBox1.Clear();
                this.label14.Text = "temp";
                this.label14.Refresh();
                button3.Enabled = true;
            }

        }

       
     
    }
}

