namespace ZarOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player 1";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(102, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(11, 106);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 0;
            button1.Text = "Roll The Dice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(12, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(175, 141);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player 2";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(11, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(102, 40);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(11, 106);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 0;
            button2.Text = "Roll The Dice";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 61);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "Skor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 93);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "Player 1 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 136);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Player 2 :";
            // 
            // label5
            // 
            label5.Location = new Point(287, 136);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(25, 20);
            label5.TabIndex = 6;
            label5.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 208);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 7;
            label6.Text = "Winner";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(256, 232);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(287, 93);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(25, 20);
            label4.TabIndex = 9;
            label4.Text = "00";
            // 
            // button3
            // 
            button3.Location = new Point(258, 274);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 321);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private GroupBox groupBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Button button3;
    }
}