namespace winform2
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
            this.components = new System.ComponentModel.Container();
            this.ck3 = new System.Windows.Forms.CheckBox();
            this.ck2 = new System.Windows.Forms.CheckBox();
            this.ck1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.l4 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gb1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ck3
            // 
            this.ck3.AutoSize = true;
            this.ck3.Location = new System.Drawing.Point(645, 146);
            this.ck3.Name = "ck3";
            this.ck3.Size = new System.Drawing.Size(69, 20);
            this.ck3.TabIndex = 0;
            this.ck3.Text = "Du lịch";
            this.ck3.UseVisualStyleBackColor = true;
            // 
            // ck2
            // 
            this.ck2.AutoSize = true;
            this.ck2.Location = new System.Drawing.Point(433, 146);
            this.ck2.Name = "ck2";
            this.ck2.Size = new System.Drawing.Size(82, 20);
            this.ck2.TabIndex = 1;
            this.ck2.Text = "Thể thao";
            this.ck2.UseVisualStyleBackColor = true;
            // 
            // ck1
            // 
            this.ck1.AutoSize = true;
            this.ck1.Location = new System.Drawing.Point(539, 146);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(84, 20);
            this.ck1.TabIndex = 2;
            this.ck1.Text = "Phim ảnh";
            this.ck1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(140, 142);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(57, 20);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "Nam";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(227, 142);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(45, 20);
            this.rb2.TabIndex = 4;
            this.rb2.TabStop = true;
            this.rb2.Text = "Nữ";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(56, 142);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(54, 16);
            this.l1.TabIndex = 5;
            this.l1.Text = "Giới tính";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(353, 146);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(54, 16);
            this.l2.TabIndex = 6;
            this.l2.Text = "Sở thích";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(56, 81);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(46, 16);
            this.l3.TabIndex = 7;
            this.l3.Text = "Họ tên";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(120, 78);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(193, 22);
            this.txthoten.TabIndex = 8;       
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(433, 84);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(290, 22);
            this.dtp1.TabIndex = 9;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(353, 84);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(67, 16);
            this.l4.TabIndex = 10;
            this.l4.Text = "Ngày sinh";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(601, 217);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(151, 32);
            this.b1.TabIndex = 11;
            this.b1.Text = "Xuất thông tin";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // gb1
            // 
            this.gb1.Location = new System.Drawing.Point(41, 31);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(695, 180);
            this.gb1.TabIndex = 12;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.ck1);
            this.Controls.Add(this.ck2);
            this.Controls.Add(this.ck3);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Demo Myclass";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ck3;
        private System.Windows.Forms.CheckBox ck2;
        private System.Windows.Forms.CheckBox ck1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox gb1;
    }
}

