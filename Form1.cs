using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6Practice3 {
		public partial class Form1:Form {
				public Form1() {
						InitializeComponent();
				}
				static public int move = 5;
				private void Form1_Load(object sender,EventArgs e) {
						label2.AutoSize=true;
						//label2.BackColor=Color.Black;
						label2.ForeColor=Color.Yellow;
						label2.TextAlign= ContentAlignment.MiddleLeft;
						//label2.Dock=DockStyle.Fill;
						label2.Font = new Font(new FontFamily("標楷體"), 20, FontStyle.Bold);
						label2.TextAlign=ContentAlignment.MiddleCenter;
						panel1.BackColor=Color.Black;
						panel1.Size=new Size(485, 80);
						//panel1.Font = new Font(new FontFamily("標楷體"),20,FontStyle.Bold);
						timer1.Enabled=true;
						button1.Text="MoveLeft";
						button2.Text="MoveRight";
						button3.Text="Pause";
						button4.Text="SpeedUp";
						button5.Text="SlowDown";
						button1.AutoSize=true;
						button2.AutoSize=true;
						button3.AutoSize=true;
						button4.AutoSize=true;
						button5.AutoSize=true;
						label1.Text="EnterTheMarqueeText : ";
						label2.Text="Testing...";
						timer1.Interval=100;
				}
				private void timer1_Tick(object sender,EventArgs e) {
						this.Refresh();
						label2.Left +=move;
						if(label2.Left >= panel1.Width) {
								label2.Left = label2.Width * -1;
						}
						else if(label2.Left + label2.Width <= 0) {
								label2.Left = panel1.Width;
						}
				}

				private void textBox1_TextChanged(object sender,EventArgs e) {
						label2.Text=textBox1.Text;
				}

				private void button1_Click(object sender,EventArgs e) {
						move=-5;
				}

				private void button2_Click(object sender,EventArgs e) {
						move=5;
				}

				private void button3_Click(object sender,EventArgs e) {
						move=0;
				}

				private void button4_Click(object sender,EventArgs e) {
						if(timer1.Interval > 10) {
								timer1.Interval -= 10;
								button5.Enabled = true;
						}
						if(timer1.Interval == 10) {
								button4.Enabled=false;
						}
				}

				private void button5_Click(object sender,EventArgs e) {
						if(timer1.Interval < 200) {
								timer1.Interval += 10;
								button4.Enabled = true;
						}
						if(timer1.Interval == 200) {
								button5.Enabled=false;
						}
				}
		}
}
