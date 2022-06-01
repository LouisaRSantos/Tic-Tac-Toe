namespace Tic_Tac_Toe_Program
{
    partial class TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNewG = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreatorAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreatorGame = new System.Windows.Forms.ToolStripMenuItem();
            this.TicTacbtn1 = new System.Windows.Forms.Button();
            this.TicTacbtn2 = new System.Windows.Forms.Button();
            this.TicTacbtn3 = new System.Windows.Forms.Button();
            this.TicTacbtn4 = new System.Windows.Forms.Button();
            this.TicTacbtn5 = new System.Windows.Forms.Button();
            this.TicTacbtn6 = new System.Windows.Forms.Button();
            this.TicTacbtn7 = new System.Windows.Forms.Button();
            this.TicTacbtn8 = new System.Windows.Forms.Button();
            this.TicTacbtn9 = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp,
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileNewG,
            this.MenuFileExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // MenuFileNewG
            // 
            this.MenuFileNewG.Name = "MenuFileNewG";
            this.MenuFileNewG.Size = new System.Drawing.Size(152, 22);
            this.MenuFileNewG.Text = "New Game";
            this.MenuFileNewG.Click += new System.EventHandler(this.MenuFileNewG_Click);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(152, 22);
            this.MenuFileExit.Text = "Exit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpProcedure});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "Help";
            // 
            // MenuHelpProcedure
            // 
            this.MenuHelpProcedure.Name = "MenuHelpProcedure";
            this.MenuHelpProcedure.Size = new System.Drawing.Size(128, 22);
            this.MenuHelpProcedure.Text = "Procedure";
            this.MenuHelpProcedure.Click += new System.EventHandler(this.MenuHelpProcedure_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreatorAbout,
            this.MenuCreatorGame});
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
            // 
            // MenuCreatorAbout
            // 
            this.MenuCreatorAbout.Name = "MenuCreatorAbout";
            this.MenuCreatorAbout.Size = new System.Drawing.Size(113, 22);
            this.MenuCreatorAbout.Text = "Creator";
            this.MenuCreatorAbout.Click += new System.EventHandler(this.MenuCreatorAbout_Click);
            // 
            // MenuCreatorGame
            // 
            this.MenuCreatorGame.Name = "MenuCreatorGame";
            this.MenuCreatorGame.Size = new System.Drawing.Size(113, 22);
            this.MenuCreatorGame.Text = "Game";
            this.MenuCreatorGame.Click += new System.EventHandler(this.MenuCreatorGame_Click);
            // 
            // TicTacbtn1
            // 
            this.TicTacbtn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn1.Location = new System.Drawing.Point(13, 28);
            this.TicTacbtn1.Name = "TicTacbtn1";
            this.TicTacbtn1.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn1.TabIndex = 1;
            this.TicTacbtn1.Text = " ";
            this.TicTacbtn1.UseVisualStyleBackColor = true;
            this.TicTacbtn1.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn2
            // 
            this.TicTacbtn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn2.Location = new System.Drawing.Point(129, 28);
            this.TicTacbtn2.Name = "TicTacbtn2";
            this.TicTacbtn2.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn2.TabIndex = 2;
            this.TicTacbtn2.UseVisualStyleBackColor = true;
            this.TicTacbtn2.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn3
            // 
            this.TicTacbtn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn3.Location = new System.Drawing.Point(246, 28);
            this.TicTacbtn3.Name = "TicTacbtn3";
            this.TicTacbtn3.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn3.TabIndex = 3;
            this.TicTacbtn3.UseVisualStyleBackColor = true;
            this.TicTacbtn3.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn4
            // 
            this.TicTacbtn4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn4.Location = new System.Drawing.Point(13, 125);
            this.TicTacbtn4.Name = "TicTacbtn4";
            this.TicTacbtn4.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn4.TabIndex = 6;
            this.TicTacbtn4.UseVisualStyleBackColor = true;
            this.TicTacbtn4.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn5
            // 
            this.TicTacbtn5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn5.Location = new System.Drawing.Point(129, 125);
            this.TicTacbtn5.Name = "TicTacbtn5";
            this.TicTacbtn5.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn5.TabIndex = 5;
            this.TicTacbtn5.UseVisualStyleBackColor = true;
            this.TicTacbtn5.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn6
            // 
            this.TicTacbtn6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn6.Location = new System.Drawing.Point(246, 125);
            this.TicTacbtn6.Name = "TicTacbtn6";
            this.TicTacbtn6.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn6.TabIndex = 4;
            this.TicTacbtn6.UseVisualStyleBackColor = true;
            this.TicTacbtn6.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn7
            // 
            this.TicTacbtn7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn7.Location = new System.Drawing.Point(13, 222);
            this.TicTacbtn7.Name = "TicTacbtn7";
            this.TicTacbtn7.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn7.TabIndex = 9;
            this.TicTacbtn7.UseVisualStyleBackColor = true;
            this.TicTacbtn7.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn8
            // 
            this.TicTacbtn8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn8.Location = new System.Drawing.Point(129, 222);
            this.TicTacbtn8.Name = "TicTacbtn8";
            this.TicTacbtn8.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn8.TabIndex = 8;
            this.TicTacbtn8.UseVisualStyleBackColor = true;
            this.TicTacbtn8.Click += new System.EventHandler(this.btnclick);
            // 
            // TicTacbtn9
            // 
            this.TicTacbtn9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacbtn9.Location = new System.Drawing.Point(246, 222);
            this.TicTacbtn9.Name = "TicTacbtn9";
            this.TicTacbtn9.Size = new System.Drawing.Size(102, 91);
            this.TicTacbtn9.TabIndex = 7;
            this.TicTacbtn9.UseVisualStyleBackColor = true;
            this.TicTacbtn9.Click += new System.EventHandler(this.btnclick);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(118, 319);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(122, 26);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(362, 351);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.TicTacbtn7);
            this.Controls.Add(this.TicTacbtn8);
            this.Controls.Add(this.TicTacbtn9);
            this.Controls.Add(this.TicTacbtn4);
            this.Controls.Add(this.TicTacbtn5);
            this.Controls.Add(this.TicTacbtn6);
            this.Controls.Add(this.TicTacbtn3);
            this.Controls.Add(this.TicTacbtn2);
            this.Controls.Add(this.TicTacbtn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuFileNewG;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpProcedure;
        private System.Windows.Forms.ToolStripMenuItem MenuCreatorAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuCreatorGame;
        private System.Windows.Forms.Button TicTacbtn1;
        private System.Windows.Forms.Button TicTacbtn2;
        private System.Windows.Forms.Button TicTacbtn3;
        private System.Windows.Forms.Button TicTacbtn4;
        private System.Windows.Forms.Button TicTacbtn5;
        private System.Windows.Forms.Button TicTacbtn6;
        private System.Windows.Forms.Button TicTacbtn7;
        private System.Windows.Forms.Button TicTacbtn8;
        private System.Windows.Forms.Button TicTacbtn9;
        private System.Windows.Forms.Button btnreset;
    }
}

