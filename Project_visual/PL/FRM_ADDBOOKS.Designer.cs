namespace Project_visual.PL
{
    partial class FRM_ADDBOOKS
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
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_bookPrice = new System.Windows.Forms.TextBox();
            this.txt_authorName = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bookCover = new System.Windows.Forms.PictureBox();
            this.txt_bookRate = new System.Windows.Forms.TextBox();
            this.bookDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(191, 444);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(420, 47);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "اضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_bookPrice);
            this.groupBox1.Controls.Add(this.txt_authorName);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lb_Title);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(446, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 420);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الاساسية";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(6, 292);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 29);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 39);
            this.comboBox1.TabIndex = 8;
            // 
            // txt_bookPrice
            // 
            this.txt_bookPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_bookPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_bookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookPrice.Location = new System.Drawing.Point(8, 364);
            this.txt_bookPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bookPrice.Name = "txt_bookPrice";
            this.txt_bookPrice.Size = new System.Drawing.Size(315, 34);
            this.txt_bookPrice.TabIndex = 7;
            this.txt_bookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_authorName
            // 
            this.txt_authorName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_authorName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_authorName.Location = new System.Drawing.Point(8, 172);
            this.txt_authorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_authorName.Name = "txt_authorName";
            this.txt_authorName.Size = new System.Drawing.Size(315, 34);
            this.txt_authorName.TabIndex = 7;
            this.txt_authorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_title
            // 
            this.txt_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_title.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(8, 83);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(315, 34);
            this.txt_title.TabIndex = 7;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "سعر الكتاب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "صنف الكتاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المؤلف";
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(237, 42);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(86, 27);
            this.Lb_Title.TabIndex = 2;
            this.Lb_Title.Text = "اسم الكتاب";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.bookCover);
            this.groupBox2.Controls.Add(this.txt_bookRate);
            this.groupBox2.Controls.Add(this.bookDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 420);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات الثانوية";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(106, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 29);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تحميل الغلاف";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bookCover
            // 
            this.bookCover.Location = new System.Drawing.Point(84, 237);
            this.bookCover.Name = "bookCover";
            this.bookCover.Size = new System.Drawing.Size(164, 144);
            this.bookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookCover.TabIndex = 4;
            this.bookCover.TabStop = false;
            // 
            // txt_bookRate
            // 
            this.txt_bookRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_bookRate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_bookRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookRate.Location = new System.Drawing.Point(6, 160);
            this.txt_bookRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bookRate.Name = "txt_bookRate";
            this.txt_bookRate.Size = new System.Drawing.Size(309, 34);
            this.txt_bookRate.TabIndex = 7;
            this.txt_bookRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookDate
            // 
            this.bookDate.Location = new System.Drawing.Point(6, 79);
            this.bookDate.Name = "bookDate";
            this.bookDate.Size = new System.Drawing.Size(309, 38);
            this.bookDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "غلاف الكتاب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "تقييم الكتاب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "تاريخ النشر";
            // 
            // FRM_ADDBOOKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Name = "FRM_ADDBOOKS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDBOOKS";
            this.Load += new System.EventHandler(this.FRM_ADDBOOKS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lb_Title;
        public System.Windows.Forms.TextBox txt_bookPrice;
        public System.Windows.Forms.TextBox txt_authorName;
        public System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.TextBox txt_bookRate;
        public System.Windows.Forms.PictureBox bookCover;
        public System.Windows.Forms.DateTimePicker bookDate;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}