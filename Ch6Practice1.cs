using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH6Practice1 {
		public partial class Form1:Form {
				public Form1() {
						InitializeComponent();
				}
				static public float total, ob1, ob2, ob3, ob4, ob5=0;
				private void Form1_Load(object sender,EventArgs e) {
						groupBox1.Text = "Object";
						radioButton1.Text = "(1)流蘇";
						radioButton2.Text = "(2)苦楝";
						radioButton3.Text = "(3)茄苳";
						radioButton4.Text = "(4)樟樹";
						radioButton5.Text = "(5)鳳凰木";
						groupBox2.Text = "VotingRate";
						label1.Text = "0.00%";
						label2.Text = "0.00%";
						label3.Text = "0.00%";
						label4.Text = "0.00%";
						label5.Text = "0.00%";
						button1.Text = "Vote";
						label6.Text = "TotalVote : 0";
				}

				private void button1_Click(object sender,EventArgs e) {
						if(radioButton1.Checked==true) { 
								total++;
								ob1++;
						}
						else if(radioButton2.Checked == true) {
								total++;
								ob2++;
						}
						else if(radioButton3.Checked == true) {
								total++;
								ob3++;
						}
						else if(radioButton4.Checked == true) {
								total++;
								ob4++;
						}
						else if(radioButton5.Checked == true) {
								total++;
								ob5++;
						}
						label1.Text = ((ob1 / total)*100).ToString("0.00")+" %";
						label2.Text = ((ob2 / total)*100).ToString("0.00")+" %";
						label3.Text = ((ob3 / total)*100).ToString("0.00")+" %";
						label4.Text = ((ob4 / total)*100).ToString("0.00")+" %";
						label5.Text = ((ob5 / total)*100).ToString("0.00")+" %";
						label6.Text = $"TotalVote : {total}";
				}
		}
}
