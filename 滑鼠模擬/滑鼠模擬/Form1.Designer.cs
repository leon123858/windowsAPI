namespace 滑鼠模擬
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mouse_y = new System.Windows.Forms.TextBox();
            this.mouse_x = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.script = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.BackColor = System.Drawing.SystemColors.Control;
            this.click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.click.Font = new System.Drawing.Font("標楷體", 20F);
            this.click.Location = new System.Drawing.Point(14, 223);
            this.click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(507, 72);
            this.click.TabIndex = 1;
            this.click.TabStop = false;
            this.click.Text = "虛擬左右鍵 開始";
            this.click.UseVisualStyleBackColor = false;
            this.click.Click += new System.EventHandler(this.Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(124, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "方向上:滑鼠中鍵點擊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(116, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "左鍵點擊";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(291, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "右鍵點擊";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(124, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "方向下:滑鼠左鍵壓下";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(26, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "(只需輕點一下,用方想左一下解除)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(72, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "W,A,S,D 滑鼠移動(目前關)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.textBox1.Location = new System.Drawing.Point(244, 379);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 43);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(26, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "滑鼠移動速度:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(439, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mouse_y
            // 
            this.mouse_y.Font = new System.Drawing.Font("新細明體", 15F);
            this.mouse_y.Location = new System.Drawing.Point(726, 70);
            this.mouse_y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mouse_y.Name = "mouse_y";
            this.mouse_y.Size = new System.Drawing.Size(107, 43);
            this.mouse_y.TabIndex = 11;
            this.mouse_y.Text = "50";
            // 
            // mouse_x
            // 
            this.mouse_x.Font = new System.Drawing.Font("新細明體", 15F);
            this.mouse_x.Location = new System.Drawing.Point(604, 70);
            this.mouse_x.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mouse_x.Name = "mouse_x";
            this.mouse_x.Size = new System.Drawing.Size(81, 43);
            this.mouse_x.TabIndex = 12;
            this.mouse_x.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(640, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "滑鼠座標";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(691, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(569, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "X";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // script
            // 
            this.script.Location = new System.Drawing.Point(555, 158);
            this.script.Multiline = true;
            this.script.Name = "script";
            this.script.Size = new System.Drawing.Size(320, 264);
            this.script.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F);
            this.button2.Location = new System.Drawing.Point(586, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "run script";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.script);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mouse_x);
            this.Controls.Add(this.mouse_y);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.click);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "虛擬左右鍵";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mouse_y;
        private System.Windows.Forms.TextBox mouse_x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox script;
        private System.Windows.Forms.Button button2;
    }
}

