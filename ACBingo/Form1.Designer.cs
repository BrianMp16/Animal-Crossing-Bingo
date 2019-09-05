namespace ACBingo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.bingoTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.newCard = new System.Windows.Forms.Button();
            this.listBoxGame = new System.Windows.Forms.ListBox();
            this.listBoxDifficulty = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bingoTablePanel
            // 
            this.bingoTablePanel.AutoSize = true;
            this.bingoTablePanel.ColumnCount = 5;
            this.bingoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.Location = new System.Drawing.Point(12, 12);
            this.bingoTablePanel.Name = "bingoTablePanel";
            this.bingoTablePanel.RowCount = 5;
            this.bingoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bingoTablePanel.Size = new System.Drawing.Size(510, 510);
            this.bingoTablePanel.TabIndex = 0;
            // 
            // newCard
            // 
            this.newCard.Location = new System.Drawing.Point(528, 12);
            this.newCard.Name = "newCard";
            this.newCard.Size = new System.Drawing.Size(100, 24);
            this.newCard.TabIndex = 1;
            this.newCard.Text = "New Card";
            this.newCard.UseVisualStyleBackColor = true;
            this.newCard.Click += new System.EventHandler(this.newCard_Click);
            // 
            // listBoxGame
            // 
            this.listBoxGame.FormattingEnabled = true;
            this.listBoxGame.Items.AddRange(new object[] {
            "Animal Crossing",
            "Animal Forest e+"});
            this.listBoxGame.Location = new System.Drawing.Point(528, 56);
            this.listBoxGame.Name = "listBoxGame";
            this.listBoxGame.Size = new System.Drawing.Size(99, 30);
            this.listBoxGame.TabIndex = 2;
            // 
            // listBoxDifficulty
            // 
            this.listBoxDifficulty.FormattingEnabled = true;
            this.listBoxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.listBoxDifficulty.Location = new System.Drawing.Point(528, 105);
            this.listBoxDifficulty.Name = "listBoxDifficulty";
            this.listBoxDifficulty.Size = new System.Drawing.Size(99, 43);
            this.listBoxDifficulty.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 170);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 80);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "C:/Users/Brian/Desktop/newACBingo.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 535);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxDifficulty);
            this.Controls.Add(this.listBoxGame);
            this.Controls.Add(this.newCard);
            this.Controls.Add(this.bingoTablePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel bingoTablePanel;
        private System.Windows.Forms.Button newCard;
        private System.Windows.Forms.ListBox listBoxDifficulty;
        private System.Windows.Forms.ListBox listBoxGame;
        private System.Windows.Forms.TextBox textBox1;
    }
}

