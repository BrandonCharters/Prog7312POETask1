namespace Prog7312POETask1
{
    partial class CallNumGameRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallNumGameRules));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitRulesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Linen;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(210, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 356);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // exitRulesBtn
            // 
            this.exitRulesBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exitRulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitRulesBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitRulesBtn.ForeColor = System.Drawing.Color.Black;
            this.exitRulesBtn.Location = new System.Drawing.Point(783, 12);
            this.exitRulesBtn.Name = "exitRulesBtn";
            this.exitRulesBtn.Size = new System.Drawing.Size(40, 34);
            this.exitRulesBtn.TabIndex = 8;
            this.exitRulesBtn.Text = "X";
            this.exitRulesBtn.UseVisualStyleBackColor = false;
            this.exitRulesBtn.Click += new System.EventHandler(this.exitRulesBtn_Click);
            // 
            // CallNumGameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prog7312POETask1.Properties.Resources.OpenScroll;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 504);
            this.Controls.Add(this.exitRulesBtn);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CallNumGameRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallNumGameRules";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exitRulesBtn;
    }
}