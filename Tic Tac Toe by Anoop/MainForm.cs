/*
 * Created by SharpDevelop.
 * Developer:Anoop Kumar Sharma
 * Date: 9/3/2013
 * Time: 12:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Tic_Tac_Toe_by_Anoop
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
     public static  List<Cauhoitracnghiem> Cauhoi = new List<Cauhoitracnghiem>();
        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //

            initCauhoi();
            matran.Add(button1);
            matran.Add(button2);
            matran.Add(button3);
            matran.Add(button4);
            matran.Add(button5);
            matran.Add(button6);
            matran.Add(button7);
            matran.Add(button8);
            matran.Add(button9);

        }
        public static List<Button> matran = new List<Button>();
        public static int vitri = -1;



	 public static	int turn=1;
		public static int click1=0,click2=0,click3=0,click4=0,click5=0,click6=0,click7=0,click8=0,click9=0;
		int player1=0,player2=0;

        public void checkwin()
        {
            checkit();
        }
        private void initCauhoi()
        {
            Cauhoitracnghiem cau1 = new Cauhoitracnghiem();
            cau1.cauhoi = "Công ty quản lý Quỹ tại Việt Nam hiện đang quản lý các quỹ nào sau đây ? ";
            cau1.DapAnA = "A. Quỹ Tiền Tệ, Quỹ Cổ Phiếu, Quỹ Cân Bằng.";
            cau1.DapAnB = "B. Quỹ Cổ Phiếu, Quỹ Cân Bằng, Quỹ Trái Phiếu.";
            cau1.DapAnC = "C. Quỹ Tiền Tệ, Quỹ Cổ Phiếu, Quỹ Đóng.";
            cau1.DapAnD = "D. Quỹ Cổ Phiếu, Quỹ Đóng, Quỹ Mở.";
            cau1.DapAnTl = 1;          
            Cauhoi.Add(cau1);
            Cauhoitracnghiem cau2 = new Cauhoitracnghiem();
            cau2.cauhoi = "Theo các bé, thì số đông sẽ lựa chọn một trong những yếu tố thuận lợi nào sau đây cho quỹ mở phát triển và đáng để các nhà đầu tư tham gia ? ";
            cau2.DapAnA = "A. Chính sách Thuế được Ưu Đãi đối với NĐT khi tham gia công ty.";
            cau2.DapAnB = "B. Lãi suất của công ty quỹ luôn luôn hấp dẫn hơn lãi suất của Ngân Hàng.";
            cau2.DapAnC = "C. Lợi nhuận của kênh đầu tư cá nhân không hấp dẫn bằng lợi nhuận của công ty quỹ.";
            cau2.DapAnD = "D. Chi trả khoản phí không đáng kể để tham gia vào một công ty quỹ.";
            cau2.DapAnTl = 1;
            Cauhoi.Add(cau2);
            Cauhoitracnghiem cau3 = new Cauhoitracnghiem();
            cau3.cauhoi = "Tại Châu Á, Quỹ mở ở các nước nào sau đây là phát triển nhất ?";
            cau3.DapAnA = "A. Nhật Bản, Trung Quốc và Hàn Quốc.";
            cau3.DapAnB = "B. Nhật Bản, Trung Quốc và Ấn Độ.";
            cau3.DapAnC = "C. Nhật Bản, Trung Quốc và Nga.";
            cau3.DapAnD = "D. Nhật Bản, Trung Quốc - Đài Loan và Thái Lan.";
            cau3.DapAnTl = 0;
            Cauhoi.Add(cau3);
            Cauhoitracnghiem cau4 = new Cauhoitracnghiem();
            cau4.cauhoi = "Đố các bé, các Ngân Hàng nào ở Việt Nam đã tham gia vào lĩnh vực quản lý quỹ : ";
            cau4.DapAnA = "A. MB, BIDV, VCB, ACB, Sacombank, NH TMCP Công Thương VN, Đông Á,Osean bank.";
            cau4.DapAnB = "B. MB, BIDV, VCB, ACB, Bảo Việt Bank, Ocean Bank, Đông Á, TP Bank, VP Bank.";
            cau4.DapAnC = "C. MB, BIDV, VCB, ACB, Sacombank, NH TMCP Công Thương VN, Đông Á,Eximbank.";
            cau4.DapAnD = "D. MB, BIDV, VCB, ACB, Bảo Việt Bank, NH TMCP Công Thương VN, Đông Á, Techcombank, Vietinbank.";
            cau4.DapAnTl = 3;
            Cauhoi.Add(cau4);
            Cauhoitracnghiem cau5 = new Cauhoitracnghiem();
            cau5.cauhoi = "Chọn câu sai : Đố các bé, tại Việt Nam công ty quản lý quỹ nào có mặt lâu đời thứ nhì, câu nào sau đây là đúng ?";
            cau5.DapAnA = "A. Mekong Capital";
            cau5.DapAnB = "B. Vina Capital";
            cau5.DapAnC = "C. Trong Hai câu trên có một câu Đúng.";
            cau5.DapAnD = "D. Trong Ba câu trên có hai câu Đúng.";
            cau5.DapAnTl = 1;
            Cauhoi.Add(cau5);
            Cauhoitracnghiem cau6 = new Cauhoitracnghiem();
            cau6.cauhoi = "Tại Việt Nam, Dragon Capital là công ty quản lý quỹ lâu đời nhất, vậy đố các bé nó có mặt tại VN từ năm nào ?";
            cau6.DapAnA = "A. 1994";
            cau6.DapAnB = "B. 1995";
            cau6.DapAnC = "C. 1996";
            cau6.DapAnD = "D. 1997";
            cau6.DapAnTl = 0;
            Cauhoi.Add(cau6);
            Cauhoitracnghiem cau7 = new Cauhoitracnghiem();
            cau7.cauhoi = "Theo các bé, ETFs là gì ? ";
            cau7.DapAnA = "A. ETFs là một xu hướng đầu tư mới phát triển mạnh mẽ dần thay thế cách đầu tư truyền thống của nhà đầu tư vào một cổ phiếu hoặc quỹ thông thường.";
            cau7.DapAnB = "B. ETFs là một thuật toán chuyển lệnh điện tử từ một nhà đầu tư cá nhân này đến bên trong một tổ chức tài chính quản lý quỹ yêu cầu được tham gia việc lập quỹ qua hệ thống máy tính và không có sự can thiệp trực tiếp của con người.";
            cau7.DapAnC = "C. ETFs là một biện pháp khiến khích nhà đầu tư, đầu tư vào một loại quỹ qua chính sách Thuế Ưu đãi của Chính phủ.";
            cau7.DapAnD = "D. Ở 3 câu trên có 2 câu đúng.";
            cau7.DapAnTl = 0;
            Cauhoi.Add(cau7);

            Cauhoitracnghiem cau8 = new Cauhoitracnghiem();
            cau8.cauhoi = "Tại Việt Nam, Dragon Capital là công ty quản lý quỹ lâu đời nhất, vậy đố các bé nó có mặt tại VN từ năm nào ?";
            cau8.DapAnA = "A. VIEL";
            cau8.DapAnB = "B. VOF";
            cau8.DapAnC = "C. VF1";
            cau8.DapAnD = "D. VF4";
            cau8.DapAnTl = 0;
            Cauhoi.Add(cau8);
            Cauhoitracnghiem cau9 = new Cauhoitracnghiem();
            cau9.cauhoi = "Quy chế tổ chức và hoạt động của công ty quản lý quỹ do Cơ quan nào ban hành và ban hành tại thời điểm nào ? ";
            cau9.DapAnA = "A. Bộ Tài Chính, 15/05/2007";
            cau9.DapAnB = "B. Ủy ban chứng khoán nhà nước, 19/08/2007";
            cau9.DapAnC = "C. Trung tâm lưu ký chứng khoán, 26/11/2007";
            cau9.DapAnD = "D. Bộ Công Thương, 16/08/2007";
            cau9.DapAnTl = 0;
            Cauhoi.Add(cau9);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Question a = new Question();
            a.UIParent = this;
            a.Show();
            timer1.Enabled = false;
        }

        void Button1Click(object sender, EventArgs e)
		{
            vitri = 0;
			if(click1==0)
			{
                button1.Text = "?";
                timer1.Enabled = true;			
			}
			else
			{
				button1.Text=button1.Text;
			}
			display();
			checkit();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
            vitri = 1;
            if (click2 == 0)
            {
                button2.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button2.Text = button2.Text;
            }
            display();
            checkit();
        }
		
		void Button3Click(object sender, EventArgs e)
		{
            vitri = 2;
            if (click3 == 0)
            {
                button3.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button3.Text = button3.Text;
            }
            display();
            checkit();
        }
		
		void Button4Click(object sender, EventArgs e)
		{
            vitri = 3;
            if (click4 == 0)
            {
                button4.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button4.Text = button4.Text;
            }
            display();
            checkit();
        }
		
		void Button5Click(object sender, EventArgs e)
		{
            vitri = 4;
            if (click5 == 0)
            {
                button5.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button5.Text = button5.Text;
            }
            display();
            checkit();
        }

       

        void Button6Click(object sender, EventArgs e)
        {
            vitri = 5;
            if (click6 == 0)
            {
                button6.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button6.Text = button6.Text;
            }
            display();
            checkit();
        }
		
		void Button7Click(object sender, EventArgs e)
		{
            vitri = 6;
            if (click7 == 0)
            {
                button7.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button7.Text = button7.Text;
            }
            display();
            checkit();
        }
		
		void Button8Click(object sender, EventArgs e)
		{
            vitri = 7;
            if (click8 == 0)
            {
                button8.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button8.Text = button8.Text;
            }
            display();
            checkit();
        }
		
		void Button9Click(object sender, EventArgs e)
		{
            vitri = 8;
            if (click9 == 0)
            {
                button9.Text = "?";
                timer1.Enabled = true;
            }
            else
            {
                button9.Text = button9.Text;
            }
            display();
            checkit();
        }
		public void display()
		{
			if(turn%2!=0)
			{
				displayturn.Text="TEAM X";
			}
			else
			{
				displayturn.Text="TEAM Y";
			}
		}
		public void checkit()
		{
			if(button1.Text!="" && button2.Text!="" && button3.Text!="")
			{
				if(button1.Text==button2.Text && button1.Text==button3.Text)
				{
					button1.BackColor=Color.Green;
					button1.ForeColor=Color.White;
					button2.BackColor=Color.Green;
					button2.ForeColor=Color.White;
					button3.BackColor=Color.Green;
					button3.ForeColor=Color.White;
					if(button1.Text=="X")
					{
						MessageBox.Show("Player X Wins!");
						player1++;
						player1score.Text=player1.ToString();
					}
					else
					{
						MessageBox.Show("Player Y Wins!");
						player2++;
						player2score.Text=player2.ToString();
					}
					//cleargame();
			
				}
			}
			if(button4.Text!="" && button5.Text!="" && button6.Text!="")
			{
				if(button4.Text==button5.Text && button4.Text==button6.Text)
				{
					button4.BackColor=Color.Green;
					button4.ForeColor=Color.White;
					button5.BackColor=Color.Green;
					button5.ForeColor=Color.White;
					button6.BackColor=Color.Green;
					button6.ForeColor=Color.White;
					if(button4.Text=="X")
					{
						MessageBox.Show("TEAM X WIN!");
						player1++;
						player1score.Text=player1.ToString();
						
					}
					else
					{
						MessageBox.Show("TEAM Y WIN!!");
						player2++;
						player2score.Text=player2.ToString();
						
					}
					//cleargame();
				}
			}
			if(button7.Text!="" && button8.Text!="" && button9.Text!="")
			{
				if(button7.Text==button8.Text && button7.Text==button9.Text)
				{
					button7.BackColor=Color.Green;
					button7.ForeColor=Color.White;
					button8.BackColor=Color.Green;
					button8.ForeColor=Color.White;
					button9.BackColor=Color.Green;
					button9.ForeColor=Color.White;
					if(button7.Text=="X")
					{
						MessageBox.Show("Player X Wins!");
						player1++;
						player1score.Text=player1.ToString();
						
					}
					else
					{
						MessageBox.Show("Player Y Wins!");
						player2++;
						player2score.Text=player2.ToString();
						
					}
					//cleargame();
				}
			}
			if(button1.Text!="" && button4.Text!="" && button7.Text!="")
			{
				if(button1.Text==button4.Text && button1.Text==button7.Text)
				{
					button1.BackColor=Color.Green;
					button1.ForeColor=Color.White;
					button4.BackColor=Color.Green;
					button4.ForeColor=Color.White;
					button7.BackColor=Color.Green;
					button7.ForeColor=Color.White;
					if(button1.Text=="X")
					{
						MessageBox.Show("Player X Wins!");
						player1++;
						player1score.Text=player1.ToString();
						
					}
					else
					{
						MessageBox.Show("Player Y Wins!");
						player2++;
						player2score.Text=player2.ToString();
						
					}
					//cleargame();
				}
			}
			if(button2.Text!="" && button5.Text!="" && button8.Text!="")
			{
				if(button2.Text==button5.Text && button2.Text==button8.Text)
				{
					button2.BackColor=Color.Green;
					button2.ForeColor=Color.White;
					button5.BackColor=Color.Green;
					button5.ForeColor=Color.White;
					button8.BackColor=Color.Green;
					button8.ForeColor=Color.White;
					if(button2.Text=="X")
					{
						MessageBox.Show("Player X Wins!");
						player1++;
						player1score.Text=player1.ToString();
						
					}
					else
					{
						MessageBox.Show("Player Y Wins!");
						player2++;
						player2score.Text=player2.ToString();
						
					}
					//cleargame();
				}
			}
			if(button3.Text!="" && button6.Text!="" && button9.Text!="")
			{
				if(button3.Text==button6.Text && button3.Text==button9.Text)
				{
					button3.BackColor=Color.Green;
					button3.ForeColor=Color.White;
					button6.BackColor=Color.Green;
					button6.ForeColor=Color.White;
					button9.BackColor=Color.Green;
					button9.ForeColor=Color.White;
					if(button3.Text=="X")
					{
						MessageBox.Show("Player X Wins!");
						player1++;
						player1score.Text=player1.ToString();
						
					}
					else
					{
						MessageBox.Show("Player Y Wins!");
						player2++;
						player2score.Text=player2.ToString();
						
					}
					//cleargame();
				}
			}
			if(button1.Text!="" && button5.Text!="" && button9.Text!="")
			{
				if(button1.Text==button5.Text && button1.Text==button9.Text)
				{
					button1.BackColor=Color.Green;
					button1.ForeColor=Color.White;
					button5.BackColor=Color.Green;
					button5.ForeColor=Color.White;
					button9.BackColor=Color.Green;
					button9.ForeColor=Color.White;
					if(button1.Text=="X")
					{
						MessageBox.Show("Player X Wins!");
						player1++;
						player1score.Text=player1.ToString();
						
					}
					else
					{
						MessageBox.Show("Player Y Wins!");
						player2++;
						player2score.Text=player2.ToString();
						
					}
					//cleargame();
				}
			}
			if(button3.Text!="" && button5.Text!="" && button7.Text!="")
			{
				if(button3.Text==button5.Text && button3.Text==button7.Text)
				{
					button3.BackColor=Color.Green;
					button3.ForeColor=Color.White;
					button5.BackColor=Color.Green;
					button5.ForeColor=Color.White;
					button7.BackColor=Color.Green;
					button7.ForeColor=Color.White;
					if(button3.Text=="X")
					{
						MessageBox.Show("Player X Wins!");
						player1++;
						player1score.Text=player1.ToString();
						
					}
					else
					{
						MessageBox.Show("Player Y Wins!");
						player2++;
						player2score.Text=player2.ToString();
						
					}
					//cleargame();
				}
			}
		}
		public void cleargame()
		{
			displayturn.Text="";
			turn=1;
			click1=0;click2=0;click3=0;click4=0;click5=0;click6=0;click7=0;click8=0;click9=0;
			button1.Text="";
			button2.Text="";
			button3.Text="";
			button4.Text="";
			button5.Text="";
			button6.Text="";
			button7.Text="";
			button8.Text="";
			button9.Text="";
			button1.BackColor=Color.Empty;
			button1.ForeColor=Color.Black;
			button1.UseVisualStyleBackColor=true;
			button2.BackColor=Color.Empty;
			button2.ForeColor=Color.Black;
			button2.UseVisualStyleBackColor=true;
			button3.BackColor=Color.Empty;
			button3.ForeColor=Color.Black;
			button3.UseVisualStyleBackColor=true;
			button4.BackColor=Color.Empty;
			button4.ForeColor=Color.Black;
			button4.UseVisualStyleBackColor=true;
			button5.BackColor=Color.Empty;
			button5.ForeColor=Color.Black;
			button5.UseVisualStyleBackColor=true;
			button6.BackColor=Color.Empty;
			button6.ForeColor=Color.Black;
			button6.UseVisualStyleBackColor=true;
			button7.BackColor=Color.Empty;
			button7.ForeColor=Color.Black;
			button7.UseVisualStyleBackColor=true;
			button8.BackColor=Color.Empty;
			button8.ForeColor=Color.Black;
			button8.UseVisualStyleBackColor=true;
			button9.BackColor=Color.Empty;
			button9.ForeColor=Color.Black;
			button9.UseVisualStyleBackColor=true;
		}
		
		void PlayagainClick(object sender, EventArgs e)
		{
			cleargame();
		}
		
		void ResetClick(object sender, EventArgs e)
		{
			player1score.Text="";
			player2score.Text="";
			player1=0;
			player2=0;
			cleargame();
		}
	}
}
