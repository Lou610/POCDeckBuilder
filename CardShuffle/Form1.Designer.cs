namespace CardShuffle
{
    partial class MyForm
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
            DrawCard = new Button();
            ReShuffle = new Button();
            lstCards = new ListBox();
            label1 = new Label();
            lblCardCount = new Label();
            SuspendLayout();
            // 
            // DrawCard
            // 
            DrawCard.Enabled = false;
            DrawCard.Location = new Point(615, 62);
            DrawCard.Name = "DrawCard";
            DrawCard.Size = new Size(75, 23);
            DrawCard.TabIndex = 0;
            DrawCard.Text = "Draw";
            DrawCard.UseVisualStyleBackColor = true;
            DrawCard.Click += button1_Click;
            // 
            // ReShuffle
            // 
            ReShuffle.Location = new Point(615, 110);
            ReShuffle.Name = "ReShuffle";
            ReShuffle.Size = new Size(75, 23);
            ReShuffle.TabIndex = 1;
            ReShuffle.Text = "Use Card";
            ReShuffle.UseVisualStyleBackColor = true;
            ReShuffle.Click += ReShuffle_Click;
            // 
            // lstCards
            // 
            lstCards.FormattingEnabled = true;
            lstCards.ItemHeight = 15;
            lstCards.Location = new Point(12, 62);
            lstCards.Name = "lstCards";
            lstCards.Size = new Size(572, 199);
            lstCards.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Cards Left:";
            // 
            // lblCardCount
            // 
            lblCardCount.AutoSize = true;
            lblCardCount.Location = new Point(87, 40);
            lblCardCount.Name = "lblCardCount";
            lblCardCount.Size = new Size(38, 15);
            lblCardCount.TabIndex = 4;
            lblCardCount.Text = "label2";
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 271);
            Controls.Add(lblCardCount);
            Controls.Add(label1);
            Controls.Add(lstCards);
            Controls.Add(ReShuffle);
            Controls.Add(DrawCard);
            Name = "MyForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DrawCard;
        private Button ReShuffle;
        private ListBox lstCards;
        private Label label1;
        private Label lblCardCount;
    }
}
