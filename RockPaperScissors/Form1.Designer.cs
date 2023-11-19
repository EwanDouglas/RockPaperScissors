namespace RockPaperScissors
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            btnExit = new Button();
            lblRand = new Label();
            lblComp = new Label();
            lblUser = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.BackColor = SystemColors.ButtonShadow;
            btnRock.Location = new Point(242, 416);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(222, 80);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = false;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(519, 416);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(222, 80);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.BackColor = Color.FromArgb(255, 255, 192);
            btnScissors.Location = new Point(811, 416);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(222, 80);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = false;
            btnScissors.Click += btnScissors_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1115, 587);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(222, 80);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblRand
            // 
            lblRand.AutoSize = true;
            lblRand.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRand.Location = new Point(736, 218);
            lblRand.Name = "lblRand";
            lblRand.Size = new Size(0, 30);
            lblRand.TabIndex = 4;
            lblRand.Visible = false;
            // 
            // lblComp
            // 
            lblComp.AutoSize = true;
            lblComp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblComp.Location = new Point(519, 216);
            lblComp.Name = "lblComp";
            lblComp.Size = new Size(195, 32);
            lblComp.TabIndex = 5;
            lblComp.Text = "Computer chose:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblUser.Location = new Point(531, 344);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(183, 30);
            lblUser.TabIndex = 6;
            lblUser.Text = "Make your choice!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 710);
            Controls.Add(lblUser);
            Controls.Add(lblComp);
            Controls.Add(lblRand);
            Controls.Add(btnExit);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnExit;
        private Label lblRand;
        private Label lblComp;
        private Label lblUser;
    }
}