using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6Practice2 {
		public partial class Form1:Form {
				public Form1() {
						InitializeComponent();
				}
				private void Form1_Load(object sender,EventArgs e) {
						groupBox1.Text = "Room";
						groupBox2.Text = "Time";
						groupBox3.Text = "Extra";
						radioButton1.Text = "Double";
						radioButton1.Checked = true;
						radioButton2.Text = "Triple";
						radioButton3.Text = "Quadruple";
						radioButton4.Text = "Holiday";
						radioButton4.Checked = true;
						radioButton5.Text = "Non-Holiday";
						checkBox1.Text = "Dinner";
						checkBox2.Text = "Eco-friendly Room";
						label1.Text = "TotalCredit : 3000";
				}

				private void radioButton1_CheckedChanged(object sender,EventArgs e) {
						double total = 0, n=0;
						if(radioButton2.Checked) {
								total+=3500;
								n = 3;
						}
						else if(radioButton3.Checked) {
								total+=4000;
								n = 4;
						}
						else{ 
								total += 3000;
								n = 2;
						}
						if(radioButton4.Checked) {
								total *= 1;
						}
						else if( radioButton5.Checked) { 
								total *= 0.8;	
						}
						if(checkBox1.Checked) {
								total+=n*500;
						}
						if(checkBox2.Checked) {
								total-=n*50;
						}
						label1.Text = $"TotalCredit : {total}";
				}

				private void radioButton2_CheckedChanged(object sender,EventArgs e) {
						radioButton1_CheckedChanged(sender,e);
				}

				private void radioButton3_CheckedChanged(object sender,EventArgs e) {
						radioButton1_CheckedChanged(sender,e);
				}

				private void radioButton4_CheckedChanged(object sender,EventArgs e) {
						radioButton1_CheckedChanged(sender,e);
				}

				private void radioButton5_CheckedChanged(object sender,EventArgs e) {
						radioButton1_CheckedChanged(sender,e);
				}

				private void checkBox1_CheckedChanged(object sender,EventArgs e) {
						radioButton1_CheckedChanged(sender,e);
				}

				private void checkBox2_CheckedChanged(object sender,EventArgs e) {
						radioButton1_CheckedChanged(sender,e);
				}
		}
}
