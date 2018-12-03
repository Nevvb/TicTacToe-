namespace TicTacToe
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
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.Score_Label = new System.Windows.Forms.Label();
            this.s_O = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.s_X = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(65, 47);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(171, 155);
            this.b0.TabIndex = 0;
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(240, 46);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(171, 155);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(417, 46);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(171, 155);
            this.b2.TabIndex = 2;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(63, 207);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(171, 155);
            this.b3.TabIndex = 3;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(240, 207);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(171, 155);
            this.b4.TabIndex = 4;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(417, 207);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(171, 155);
            this.b5.TabIndex = 5;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(63, 368);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(171, 155);
            this.b6.TabIndex = 6;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(240, 368);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(171, 155);
            this.b7.TabIndex = 7;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(417, 368);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(171, 155);
            this.b8.TabIndex = 8;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_Click);
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Label.Location = new System.Drawing.Point(610, 47);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(109, 37);
            this.Score_Label.TabIndex = 9;
            this.Score_Label.Text = "Score:";
            // 
            // s_O
            // 
            this.s_O.AutoSize = true;
            this.s_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_O.Location = new System.Drawing.Point(762, 47);
            this.s_O.Name = "s_O";
            this.s_O.Size = new System.Drawing.Size(0, 37);
            this.s_O.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(716, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Player O";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(835, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Player X";
            // 
            // s_X
            // 
            this.s_X.AutoSize = true;
            this.s_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_X.Location = new System.Drawing.Point(882, 47);
            this.s_X.Name = "s_X";
            this.s_X.Size = new System.Drawing.Size(0, 37);
            this.s_X.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 558);
            this.Controls.Add(this.s_X);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.s_O);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.Label s_O;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label s_X;
    }
}

