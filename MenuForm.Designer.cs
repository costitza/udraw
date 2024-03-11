namespace Udraw
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panelAction = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDrawings = new System.Windows.Forms.Button();
            this.buttonBoards = new System.Windows.Forms.Button();
            this.panelBoards = new System.Windows.Forms.TableLayoutPanel();
            this.panelAction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.Tan;
            this.panelAction.Controls.Add(this.panel1);
            this.panelAction.Controls.Add(this.buttonDrawings);
            this.panelAction.Controls.Add(this.buttonBoards);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAction.Location = new System.Drawing.Point(0, 0);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(235, 511);
            this.panelAction.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 188);
            this.panel1.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(34, 106);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 44);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete Board";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(34, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 44);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "New board";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDrawings
            // 
            this.buttonDrawings.BackColor = System.Drawing.Color.Peru;
            this.buttonDrawings.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawings.Location = new System.Drawing.Point(44, 125);
            this.buttonDrawings.Name = "buttonDrawings";
            this.buttonDrawings.Size = new System.Drawing.Size(135, 63);
            this.buttonDrawings.TabIndex = 1;
            this.buttonDrawings.Text = "Drawing models";
            this.buttonDrawings.UseVisualStyleBackColor = false;
            // 
            // buttonBoards
            // 
            this.buttonBoards.BackColor = System.Drawing.Color.Peru;
            this.buttonBoards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBoards.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoards.Location = new System.Drawing.Point(44, 40);
            this.buttonBoards.Name = "buttonBoards";
            this.buttonBoards.Size = new System.Drawing.Size(135, 63);
            this.buttonBoards.TabIndex = 0;
            this.buttonBoards.Text = "Your recent boards";
            this.buttonBoards.UseVisualStyleBackColor = false;
            this.buttonBoards.Click += new System.EventHandler(this.buttonBoards_Click);
            // 
            // panelBoards
            // 
            this.panelBoards.BackColor = System.Drawing.Color.Bisque;
            this.panelBoards.ColumnCount = 4;
            this.panelBoards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelBoards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelBoards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelBoards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelBoards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoards.Location = new System.Drawing.Point(235, 0);
            this.panelBoards.Name = "panelBoards";
            this.panelBoards.RowCount = 3;
            this.panelBoards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelBoards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelBoards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelBoards.Size = new System.Drawing.Size(640, 511);
            this.panelBoards.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 511);
            this.Controls.Add(this.panelBoards);
            this.Controls.Add(this.panelAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "Udraw";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panelAction.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDrawings;
        private System.Windows.Forms.Button buttonBoards;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel panelBoards;
    }
}