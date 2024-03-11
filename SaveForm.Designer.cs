namespace Udraw
{
    partial class SaveForm
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
            this.textBoxBoardName = new System.Windows.Forms.TextBox();
            this.labelSave = new System.Windows.Forms.Label();
            this.buttonSaveBoard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBoardName
            // 
            this.textBoxBoardName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxBoardName.Font = new System.Drawing.Font("Rockwell", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBoardName.Location = new System.Drawing.Point(88, 140);
            this.textBoxBoardName.Name = "textBoxBoardName";
            this.textBoxBoardName.Size = new System.Drawing.Size(138, 27);
            this.textBoxBoardName.TabIndex = 0;
            // 
            // labelSave
            // 
            this.labelSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.Location = new System.Drawing.Point(56, 106);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(218, 20);
            this.labelSave.TabIndex = 1;
            this.labelSave.Text = "Provide the board name:\r\n";
            // 
            // buttonSaveBoard
            // 
            this.buttonSaveBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSaveBoard.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSaveBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveBoard.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveBoard.Location = new System.Drawing.Point(104, 76);
            this.buttonSaveBoard.Name = "buttonSaveBoard";
            this.buttonSaveBoard.Size = new System.Drawing.Size(105, 42);
            this.buttonSaveBoard.TabIndex = 2;
            this.buttonSaveBoard.Text = "SAVE";
            this.buttonSaveBoard.UseVisualStyleBackColor = false;
            this.buttonSaveBoard.Click += new System.EventHandler(this.buttonSaveBoard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSave);
            this.panel1.Controls.Add(this.textBoxBoardName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 199);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSaveBoard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 183);
            this.panel2.TabIndex = 4;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(324, 382);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBoardName;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Button buttonSaveBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}