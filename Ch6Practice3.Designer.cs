﻿namespace Ch6Practice3 {
		partial class Form1 {
				/// <summary>
				/// 設計工具所需的變數。
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// 清除任何使用中的資源。
				/// </summary>
				/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
				protected override void Dispose(bool disposing) {
						if(disposing && (components != null)) {
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form 設計工具產生的程式碼

				/// <summary>
				/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
				/// 這個方法的內容。
				/// </summary>
				private void InitializeComponent() {
						this.components = new System.ComponentModel.Container();
						this.label1 = new System.Windows.Forms.Label();
						this.textBox1 = new System.Windows.Forms.TextBox();
						this.button1 = new System.Windows.Forms.Button();
						this.button2 = new System.Windows.Forms.Button();
						this.button3 = new System.Windows.Forms.Button();
						this.button4 = new System.Windows.Forms.Button();
						this.button5 = new System.Windows.Forms.Button();
						this.timer1 = new System.Windows.Forms.Timer(this.components);
						this.label2 = new System.Windows.Forms.Label();
						this.panel1 = new System.Windows.Forms.Panel();
						this.label3 = new System.Windows.Forms.Label();
						this.panel1.SuspendLayout();
						this.SuspendLayout();
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(99, 72);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(41, 15);
						this.label1.TabIndex = 0;
						this.label1.Text = "label1";
						// 
						// textBox1
						// 
						this.textBox1.Location = new System.Drawing.Point(278, 62);
						this.textBox1.Name = "textBox1";
						this.textBox1.Size = new System.Drawing.Size(287, 25);
						this.textBox1.TabIndex = 1;
						this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
						// 
						// button1
						// 
						this.button1.Location = new System.Drawing.Point(76, 333);
						this.button1.Name = "button1";
						this.button1.Size = new System.Drawing.Size(75, 23);
						this.button1.TabIndex = 2;
						this.button1.Text = "button1";
						this.button1.UseVisualStyleBackColor = true;
						this.button1.Click += new System.EventHandler(this.button1_Click);
						// 
						// button2
						// 
						this.button2.Location = new System.Drawing.Point(220, 332);
						this.button2.Name = "button2";
						this.button2.Size = new System.Drawing.Size(75, 23);
						this.button2.TabIndex = 3;
						this.button2.Text = "button2";
						this.button2.UseVisualStyleBackColor = true;
						this.button2.Click += new System.EventHandler(this.button2_Click);
						// 
						// button3
						// 
						this.button3.Location = new System.Drawing.Point(373, 332);
						this.button3.Name = "button3";
						this.button3.Size = new System.Drawing.Size(75, 23);
						this.button3.TabIndex = 4;
						this.button3.Text = "button3";
						this.button3.UseVisualStyleBackColor = true;
						this.button3.Click += new System.EventHandler(this.button3_Click);
						// 
						// button4
						// 
						this.button4.Location = new System.Drawing.Point(521, 333);
						this.button4.Name = "button4";
						this.button4.Size = new System.Drawing.Size(75, 23);
						this.button4.TabIndex = 5;
						this.button4.Text = "button4";
						this.button4.UseVisualStyleBackColor = true;
						this.button4.Click += new System.EventHandler(this.button4_Click);
						// 
						// button5
						// 
						this.button5.Location = new System.Drawing.Point(644, 333);
						this.button5.Name = "button5";
						this.button5.Size = new System.Drawing.Size(75, 23);
						this.button5.TabIndex = 6;
						this.button5.Text = "button5";
						this.button5.UseVisualStyleBackColor = true;
						this.button5.Click += new System.EventHandler(this.button5_Click);
						// 
						// timer1
						// 
						this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
						// 
						// label2
						// 
						this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
						this.label2.Location = new System.Drawing.Point(51, 39);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(84, 26);
						this.label2.TabIndex = 7;
						this.label2.Text = "label2";
						// 
						// panel1
						// 
						this.panel1.BackColor = System.Drawing.SystemColors.Control;
						this.panel1.Controls.Add(this.label2);
						this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
						this.panel1.Location = new System.Drawing.Point(76, 195);
						this.panel1.Name = "panel1";
						this.panel1.Size = new System.Drawing.Size(200, 100);
						this.panel1.TabIndex = 8;
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(234, 400);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(41, 15);
						this.label3.TabIndex = 9;
						this.label3.Text = "label3";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(800, 450);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.panel1);
						this.Controls.Add(this.button5);
						this.Controls.Add(this.button4);
						this.Controls.Add(this.button3);
						this.Controls.Add(this.button2);
						this.Controls.Add(this.button1);
						this.Controls.Add(this.textBox1);
						this.Controls.Add(this.label1);
						this.Name = "Form1";
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.Form1_Load);
						this.panel1.ResumeLayout(false);
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.Button button1;
				private System.Windows.Forms.Button button2;
				private System.Windows.Forms.Button button3;
				private System.Windows.Forms.Button button4;
				private System.Windows.Forms.Button button5;
				private System.Windows.Forms.Timer timer1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Panel panel1;
				private System.Windows.Forms.Label label3;
		}
}

