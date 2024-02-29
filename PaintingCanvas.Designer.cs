namespace Udraw
{
    partial class PaintingCanvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintingCanvas));
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFill = new System.Windows.Forms.PictureBox();
            this.pictureBoxPencil = new System.Windows.Forms.PictureBox();
            this.panelTopbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.Tan;
            this.panelTopbar.Controls.Add(this.pictureBox3);
            this.panelTopbar.Controls.Add(this.pictureBoxFill);
            this.panelTopbar.Controls.Add(this.pictureBoxPencil);
            this.panelTopbar.Controls.Add(this.buttonClear);
            this.panelTopbar.Controls.Add(this.buttonSave);
            this.panelTopbar.Controls.Add(this.panel2);
            this.panelTopbar.Controls.Add(this.panel1);
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(1378, 163);
            this.panelTopbar.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Tan;
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 163);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(206, 728);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelDrawing
            // 
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(206, 163);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(1172, 728);
            this.panelDrawing.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 163);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(487, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 163);
            this.panel2.TabIndex = 1;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(169, 135);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(87, 20);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "COLOUR";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1131, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(235, 47);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(1131, 73);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(235, 67);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(956, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 59);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxFill
            // 
            this.pictureBoxFill.Image = global::Udraw.Properties.Resources.fill;
            this.pictureBoxFill.Location = new System.Drawing.Point(782, 54);
            this.pictureBoxFill.Name = "pictureBoxFill";
            this.pictureBoxFill.Size = new System.Drawing.Size(93, 86);
            this.pictureBoxFill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFill.TabIndex = 8;
            this.pictureBoxFill.TabStop = false;
            // 
            // pictureBoxPencil
            // 
            this.pictureBoxPencil.Image = global::Udraw.Properties.Resources.pencil_modified;
            this.pictureBoxPencil.Location = new System.Drawing.Point(669, 54);
            this.pictureBoxPencil.Name = "pictureBoxPencil";
            this.pictureBoxPencil.Size = new System.Drawing.Size(91, 86);
            this.pictureBoxPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPencil.TabIndex = 7;
            this.pictureBoxPencil.TabStop = false;
            // 
            // PaintingCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1378, 891);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintingCanvas";
            this.Text = "udraw";
            this.panelTopbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxFill;
        private System.Windows.Forms.PictureBox pictureBoxPencil;
    }
}