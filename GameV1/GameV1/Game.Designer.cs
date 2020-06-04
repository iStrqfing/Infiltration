namespace GameV1
{
    partial class Game
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
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlCharacter = new System.Windows.Forms.Panel();
            this.tmrLeftMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrRightMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrJump = new System.Windows.Forms.Timer(this.components);
            this.tmrGravity = new System.Windows.Forms.Timer(this.components);
            this.pnlBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.Controls.Add(this.pnlCharacter);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(800, 450);
            this.pnlBG.TabIndex = 0;
            // 
            // pnlCharacter
            // 
            this.pnlCharacter.BackColor = System.Drawing.Color.Black;
            this.pnlCharacter.Location = new System.Drawing.Point(48, 301);
            this.pnlCharacter.Name = "pnlCharacter";
            this.pnlCharacter.Size = new System.Drawing.Size(50, 50);
            this.pnlCharacter.TabIndex = 0;
            // 
            // tmrLeftMovement
            // 
            this.tmrLeftMovement.Interval = 10;
            this.tmrLeftMovement.Tick += new System.EventHandler(this.tmrLeftMovement_Tick);
            // 
            // tmrRightMovement
            // 
            this.tmrRightMovement.Interval = 10;
            this.tmrRightMovement.Tick += new System.EventHandler(this.tmrRightMovement_Tick);
            // 
            // tmrJump
            // 
            this.tmrJump.Interval = 10;
            this.tmrJump.Tick += new System.EventHandler(this.tmrJump_Tick);
            // 
            // tmrGravity
            // 
            this.tmrGravity.Interval = 10;
            this.tmrGravity.Tick += new System.EventHandler(this.tmrGravity_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBG);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.pnlBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlCharacter;
        private System.Windows.Forms.Timer tmrLeftMovement;
        private System.Windows.Forms.Timer tmrRightMovement;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.Timer tmrGravity;
    }
}