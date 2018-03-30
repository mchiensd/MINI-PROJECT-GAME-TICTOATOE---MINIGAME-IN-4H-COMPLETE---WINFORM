using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe_by_Anoop
{
    public partial class Question : Form
    {
        List<Button> btn = new List<Button>();
        int check = -1;
        public Question()
        {
            InitializeComponent();
            label1.Text = "Câu hỏi số "+MainForm.turn.ToString() +":";
            textBox1.Text =  MainForm.Cauhoi[MainForm.turn - 1].cauhoi.ToString();
            button1.Text = MainForm.Cauhoi[MainForm.turn - 1].DapAnA.ToString();
            button2.Text = MainForm.Cauhoi[MainForm.turn - 1].DapAnB.ToString();
            button3.Text = MainForm.Cauhoi[MainForm.turn - 1].DapAnC.ToString();
            button4.Text = MainForm.Cauhoi[MainForm.turn - 1].DapAnD.ToString();
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            btn.Add(button1);
            btn.Add(button2);
            btn.Add(button3);
            btn.Add(button4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check = 0;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check = 1;
            button2.BackColor = Color.Red;
            button1.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check = 2;
            button3.BackColor = Color.Red;
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check = 3;
            button4.BackColor = Color.Red;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button1.BackColor = Color.LightGray;
        }
        int flag = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (check == -1)
                {
                    label2.Text = "LỖI !!!";
                }
                if (check == MainForm.Cauhoi[MainForm.turn - 1].DapAnTl)
                {
                    btn[MainForm.Cauhoi[MainForm.turn - 1].DapAnTl].BackColor = Color.Green;
                    label2.ForeColor = Color.Green;
                    label2.Text = "ĐÚNG";

                    //check qua form kia
                    if (MainForm.turn % 2 != 0)
                    {
                        MainForm.matran[MainForm.vitri].Text = "X";
                       MainForm.click1++;
                    }
                    else
                    {
                        MainForm.matran[MainForm.vitri].Text = "O";
                        MainForm.click1++;
                    }
                    //turn++;



                    // hết
                }
                else
                {
                    btn[MainForm.Cauhoi[MainForm.turn - 1].DapAnTl].BackColor = Color.Green;
                    label2.ForeColor = Color.Red;
                    MainForm.matran[MainForm.vitri].Text = "";
                    label2.Text = "SAI";
                }
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                flag = 1;
                button5.Text = "ĐÓNG";
                timer1.Enabled = true;
                MainForm.turn++;





               

            }
            else
            if(flag==1)
            {
                this.Close();
            }


        }
        int second = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            button5.Text = "ĐÓNG ["+second+"]";
           
            if (second == 0)
            {
                this.Close();
            }
            second--;
        }

        private void Question_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }

        public object UIParent
        {
            set;
            get;
        }

        private void Question_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UIParent is MainForm)
            {
                MainForm frm = UIParent as MainForm;
                frm.checkwin();
            }
        }
    }
}
