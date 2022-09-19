namespace Prog7312POETask1
{
    partial class ReplacingBooks
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GenerateNumbersBtn = new System.Windows.Forms.Button();
            this.CheckOrderBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.viewRulesBtn = new System.Windows.Forms.Button();
            this.restartGamebtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.RadioButton();
            this.mediumBtn = new System.Windows.Forms.RadioButton();
            this.hardBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultPanel = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLbl = new System.Windows.Forms.Label();
            this.difficultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Tan;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(49, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 287);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // GenerateNumbersBtn
            // 
            this.GenerateNumbersBtn.BackColor = System.Drawing.Color.Transparent;
            this.GenerateNumbersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateNumbersBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateNumbersBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.GenerateNumbersBtn.Location = new System.Drawing.Point(362, 163);
            this.GenerateNumbersBtn.Name = "GenerateNumbersBtn";
            this.GenerateNumbersBtn.Size = new System.Drawing.Size(115, 34);
            this.GenerateNumbersBtn.TabIndex = 1;
            this.GenerateNumbersBtn.Text = "Start Game";
            this.GenerateNumbersBtn.UseVisualStyleBackColor = false;
            this.GenerateNumbersBtn.Click += new System.EventHandler(this.GenerateNumbersBtn_Click);
            // 
            // CheckOrderBtn
            // 
            this.CheckOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOrderBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOrderBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.CheckOrderBtn.Location = new System.Drawing.Point(570, 606);
            this.CheckOrderBtn.Name = "CheckOrderBtn";
            this.CheckOrderBtn.Size = new System.Drawing.Size(115, 34);
            this.CheckOrderBtn.TabIndex = 2;
            this.CheckOrderBtn.Text = "Done";
            this.CheckOrderBtn.UseVisualStyleBackColor = false;
            this.CheckOrderBtn.Click += new System.EventHandler(this.CheckOrderBtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Tan;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(570, 175);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(236, 287);
            this.listBox2.TabIndex = 3;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.backBtn.Location = new System.Drawing.Point(49, 621);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(115, 34);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.exitAppBtn.Location = new System.Drawing.Point(791, 12);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(40, 34);
            this.exitAppBtn.TabIndex = 5;
            this.exitAppBtn.Text = "X";
            this.exitAppBtn.UseVisualStyleBackColor = false;
            this.exitAppBtn.Click += new System.EventHandler(this.exitAppBtn_Click);
            // 
            // viewRulesBtn
            // 
            this.viewRulesBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewRulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRulesBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRulesBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.viewRulesBtn.Location = new System.Drawing.Point(49, 12);
            this.viewRulesBtn.Name = "viewRulesBtn";
            this.viewRulesBtn.Size = new System.Drawing.Size(115, 34);
            this.viewRulesBtn.TabIndex = 6;
            this.viewRulesBtn.Text = "Game Rules";
            this.viewRulesBtn.UseVisualStyleBackColor = false;
            this.viewRulesBtn.Click += new System.EventHandler(this.viewRulesBtn_Click);
            // 
            // restartGamebtn
            // 
            this.restartGamebtn.BackColor = System.Drawing.Color.Transparent;
            this.restartGamebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartGamebtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGamebtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.restartGamebtn.Location = new System.Drawing.Point(691, 606);
            this.restartGamebtn.Name = "restartGamebtn";
            this.restartGamebtn.Size = new System.Drawing.Size(115, 34);
            this.restartGamebtn.TabIndex = 7;
            this.restartGamebtn.Text = "Restart";
            this.restartGamebtn.UseVisualStyleBackColor = false;
            this.restartGamebtn.Click += new System.EventHandler(this.restartGamebtn_Click);
            // 
            // easyBtn
            // 
            this.easyBtn.AutoSize = true;
            this.easyBtn.BackColor = System.Drawing.Color.Transparent;
            this.easyBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.easyBtn.Location = new System.Drawing.Point(90, 43);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(59, 23);
            this.easyBtn.TabIndex = 8;
            this.easyBtn.TabStop = true;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = false;
            // 
            // mediumBtn
            // 
            this.mediumBtn.AutoSize = true;
            this.mediumBtn.BackColor = System.Drawing.Color.Transparent;
            this.mediumBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.mediumBtn.Location = new System.Drawing.Point(90, 72);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(86, 23);
            this.mediumBtn.TabIndex = 9;
            this.mediumBtn.TabStop = true;
            this.mediumBtn.Text = "Medium";
            this.mediumBtn.UseVisualStyleBackColor = false;
            // 
            // hardBtn
            // 
            this.hardBtn.AutoSize = true;
            this.hardBtn.BackColor = System.Drawing.Color.Transparent;
            this.hardBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.hardBtn.Location = new System.Drawing.Point(90, 101);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(63, 23);
            this.hardBtn.TabIndex = 10;
            this.hardBtn.TabStop = true;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select a difficulty level:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficultPanel
            // 
            this.difficultPanel.BackColor = System.Drawing.Color.Transparent;
            this.difficultPanel.Controls.Add(this.label1);
            this.difficultPanel.Controls.Add(this.hardBtn);
            this.difficultPanel.Controls.Add(this.easyBtn);
            this.difficultPanel.Controls.Add(this.mediumBtn);
            this.difficultPanel.Location = new System.Drawing.Point(291, 12);
            this.difficultPanel.Name = "difficultPanel";
            this.difficultPanel.Size = new System.Drawing.Size(273, 145);
            this.difficultPanel.TabIndex = 12;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.BackColor = System.Drawing.Color.Transparent;
            this.timerLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerLbl.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLbl.ForeColor = System.Drawing.Color.Aqua;
            this.timerLbl.Location = new System.Drawing.Point(401, 606);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(81, 32);
            this.timerLbl.TabIndex = 13;
            this.timerLbl.Text = "timer";
            this.timerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerLbl.Visible = false;
            // 
            // ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prog7312POETask1.Properties.Resources.Pixel_Art_bookshelf_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 680);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.difficultPanel);
            this.Controls.Add(this.restartGamebtn);
            this.Controls.Add(this.viewRulesBtn);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.CheckOrderBtn);
            this.Controls.Add(this.GenerateNumbersBtn);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReplacingBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplacingBooks";
            this.difficultPanel.ResumeLayout(false);
            this.difficultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button GenerateNumbersBtn;
        private System.Windows.Forms.Button CheckOrderBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Button viewRulesBtn;
        private System.Windows.Forms.Button restartGamebtn;
        private System.Windows.Forms.RadioButton easyBtn;
        private System.Windows.Forms.RadioButton mediumBtn;
        private System.Windows.Forms.RadioButton hardBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel difficultPanel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timerLbl;
    }
}