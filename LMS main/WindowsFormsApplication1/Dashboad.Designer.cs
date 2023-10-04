namespace WindowsFormsApplication1
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.PanelAddBook = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnelviewbooks = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Panelviewstudent = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelIssuebook = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelReturnbooks = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelAddstuduent = new System.Windows.Forms.Panel();
            this.PanelAddBook.SuspendLayout();
            this.Pnelviewbooks.SuspendLayout();
            this.Panelviewstudent.SuspendLayout();
            this.PanelIssuebook.SuspendLayout();
            this.PanelReturnbooks.SuspendLayout();
            this.PanelAddstuduent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAddBook
            // 
            this.PanelAddBook.BackColor = System.Drawing.SystemColors.Window;
            this.PanelAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelAddBook.BackgroundImage")));
            this.PanelAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAddBook.Controls.Add(this.label1);
            this.PanelAddBook.Location = new System.Drawing.Point(145, 84);
            this.PanelAddBook.Name = "PanelAddBook";
            this.PanelAddBook.Size = new System.Drawing.Size(137, 153);
            this.PanelAddBook.TabIndex = 0;
            this.PanelAddBook.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelAddBook_Paint);
            this.PanelAddBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelAddBook_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Books";
            // 
            // Pnelviewbooks
            // 
            this.Pnelviewbooks.BackColor = System.Drawing.SystemColors.Window;
            this.Pnelviewbooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnelviewbooks.BackgroundImage")));
            this.Pnelviewbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnelviewbooks.Controls.Add(this.label3);
            this.Pnelviewbooks.Location = new System.Drawing.Point(734, 84);
            this.Pnelviewbooks.Name = "Pnelviewbooks";
            this.Pnelviewbooks.Size = new System.Drawing.Size(140, 153);
            this.Pnelviewbooks.TabIndex = 1;
            this.Pnelviewbooks.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnelviewbooks_Paint);
            this.Pnelviewbooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pnelviewbooks_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "View Books";
            // 
            // Panelviewstudent
            // 
            this.Panelviewstudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panelviewstudent.BackgroundImage")));
            this.Panelviewstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panelviewstudent.Controls.Add(this.label4);
            this.Panelviewstudent.Location = new System.Drawing.Point(145, 275);
            this.Panelviewstudent.Name = "Panelviewstudent";
            this.Panelviewstudent.Size = new System.Drawing.Size(137, 153);
            this.Panelviewstudent.TabIndex = 1;
            this.Panelviewstudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panelviewstudent_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "View Students Info";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PanelIssuebook
            // 
            this.PanelIssuebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelIssuebook.BackgroundImage")));
            this.PanelIssuebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelIssuebook.Controls.Add(this.label5);
            this.PanelIssuebook.Location = new System.Drawing.Point(445, 275);
            this.PanelIssuebook.Name = "PanelIssuebook";
            this.PanelIssuebook.Size = new System.Drawing.Size(139, 153);
            this.PanelIssuebook.TabIndex = 1;
            this.PanelIssuebook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelIssuebook_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Issue Books";
            // 
            // PanelReturnbooks
            // 
            this.PanelReturnbooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelReturnbooks.BackgroundImage")));
            this.PanelReturnbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelReturnbooks.Controls.Add(this.label6);
            this.PanelReturnbooks.Location = new System.Drawing.Point(734, 275);
            this.PanelReturnbooks.Name = "PanelReturnbooks";
            this.PanelReturnbooks.Size = new System.Drawing.Size(140, 153);
            this.PanelReturnbooks.TabIndex = 1;
            this.PanelReturnbooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelReturnbooks_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Return Books";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(814, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "NATIONAL LIBRARY";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Complete Book Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Students";
            // 
            // PanelAddstuduent
            // 
            this.PanelAddstuduent.BackColor = System.Drawing.SystemColors.Window;
            this.PanelAddstuduent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelAddstuduent.BackgroundImage")));
            this.PanelAddstuduent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAddstuduent.Controls.Add(this.label2);
            this.PanelAddstuduent.Location = new System.Drawing.Point(445, 84);
            this.PanelAddstuduent.Name = "PanelAddstuduent";
            this.PanelAddstuduent.Size = new System.Drawing.Size(139, 153);
            this.PanelAddstuduent.TabIndex = 1;
            this.PanelAddstuduent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelAddstuduent_MouseClick);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PanelReturnbooks);
            this.Controls.Add(this.PanelIssuebook);
            this.Controls.Add(this.Panelviewstudent);
            this.Controls.Add(this.Pnelviewbooks);
            this.Controls.Add(this.PanelAddstuduent);
            this.Controls.Add(this.PanelAddBook);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.PanelAddBook.ResumeLayout(false);
            this.PanelAddBook.PerformLayout();
            this.Pnelviewbooks.ResumeLayout(false);
            this.Pnelviewbooks.PerformLayout();
            this.Panelviewstudent.ResumeLayout(false);
            this.Panelviewstudent.PerformLayout();
            this.PanelIssuebook.ResumeLayout(false);
            this.PanelIssuebook.PerformLayout();
            this.PanelReturnbooks.ResumeLayout(false);
            this.PanelReturnbooks.PerformLayout();
            this.PanelAddstuduent.ResumeLayout(false);
            this.PanelAddstuduent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnelviewbooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Panelviewstudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelIssuebook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelReturnbooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelAddstuduent;
    }
}

