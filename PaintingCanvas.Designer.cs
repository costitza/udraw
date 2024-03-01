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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelCurrentColour = new System.Windows.Forms.Panel();
            this.panelColourSection = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.labelCurrentLine = new System.Windows.Forms.Label();
            this.labelCurrentShape = new System.Windows.Forms.Label();
            this.pictureBoxCurrentShape = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxEllipse = new System.Windows.Forms.PictureBox();
            this.pictureBoxCircle = new System.Windows.Forms.PictureBox();
            this.pictureBoxSquare = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrentLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxThickline = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrentColour = new System.Windows.Forms.PictureBox();
            this.pictureBoxFill = new System.Windows.Forms.PictureBox();
            this.pictureBoxPencil = new System.Windows.Forms.PictureBox();
            this.pictureBoxMidline = new System.Windows.Forms.PictureBox();
            this.pictureBoxThinline = new System.Windows.Forms.PictureBox();
            this.panelTopbar.SuspendLayout();
            this.panelCurrentColour.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThickline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMidline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThinline)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.Tan;
            this.panelTopbar.Controls.Add(this.labelCurrentLine);
            this.panelTopbar.Controls.Add(this.pictureBoxCurrentLine);
            this.panelTopbar.Controls.Add(this.labelColor);
            this.panelTopbar.Controls.Add(this.buttonClear);
            this.panelTopbar.Controls.Add(this.buttonSave);
            this.panelTopbar.Controls.Add(this.pictureBoxThickline);
            this.panelTopbar.Controls.Add(this.panelCurrentColour);
            this.panelTopbar.Controls.Add(this.pictureBoxFill);
            this.panelTopbar.Controls.Add(this.pictureBoxPencil);
            this.panelTopbar.Controls.Add(this.panelColourSection);
            this.panelTopbar.Controls.Add(this.pictureBoxMidline);
            this.panelTopbar.Controls.Add(this.pictureBoxThinline);
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(1010, 180);
            this.panelTopbar.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.Peru;
            this.buttonClear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(791, 87);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(207, 67);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.BackColor = System.Drawing.Color.Peru;
            this.buttonSave.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(791, 23);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(207, 47);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // panelCurrentColour
            // 
            this.panelCurrentColour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCurrentColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentColour.Controls.Add(this.pictureBoxCurrentColour);
            this.panelCurrentColour.Location = new System.Drawing.Point(298, 3);
            this.panelCurrentColour.Name = "panelCurrentColour";
            this.panelCurrentColour.Size = new System.Drawing.Size(94, 174);
            this.panelCurrentColour.TabIndex = 1;
            // 
            // panelColourSection
            // 
            this.panelColourSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelColourSection.Location = new System.Drawing.Point(3, 3);
            this.panelColourSection.Name = "panelColourSection";
            this.panelColourSection.Size = new System.Drawing.Size(289, 151);
            this.panelColourSection.TabIndex = 0;
            this.panelColourSection.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColourSection_Paint);
            // 
            // labelColor
            // 
            this.labelColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(100, 157);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(87, 20);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "COLOUR";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Tan;
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.labelCurrentShape);
            this.panelSidebar.Controls.Add(this.pictureBoxCurrentShape);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.pictureBoxTriangle);
            this.panelSidebar.Controls.Add(this.pictureBoxEllipse);
            this.panelSidebar.Controls.Add(this.pictureBoxCircle);
            this.panelSidebar.Controls.Add(this.pictureBoxSquare);
            this.panelSidebar.Controls.Add(this.pictureBoxRectangle);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 180);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(206, 412);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelDrawing
            // 
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(206, 180);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(804, 412);
            this.panelDrawing.TabIndex = 2;
            // 
            // labelCurrentLine
            // 
            this.labelCurrentLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentLine.AutoSize = true;
            this.labelCurrentLine.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentLine.Location = new System.Drawing.Point(420, 141);
            this.labelCurrentLine.Name = "labelCurrentLine";
            this.labelCurrentLine.Size = new System.Drawing.Size(206, 20);
            this.labelCurrentLine.TabIndex = 13;
            this.labelCurrentLine.Text = "Current line thickness:";
            // 
            // labelCurrentShape
            // 
            this.labelCurrentShape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentShape.AutoSize = true;
            this.labelCurrentShape.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentShape.Location = new System.Drawing.Point(35, 288);
            this.labelCurrentShape.Name = "labelCurrentShape";
            this.labelCurrentShape.Size = new System.Drawing.Size(137, 20);
            this.labelCurrentShape.TabIndex = 14;
            this.labelCurrentShape.Text = "Current shape:";
            // 
            // pictureBoxCurrentShape
            // 
            this.pictureBoxCurrentShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxCurrentShape.BackColor = System.Drawing.Color.White;
            this.pictureBoxCurrentShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurrentShape.Image = global::Udraw.Properties.Resources.none;
            this.pictureBoxCurrentShape.Location = new System.Drawing.Point(69, 320);
            this.pictureBoxCurrentShape.Name = "pictureBoxCurrentShape";
            this.pictureBoxCurrentShape.Size = new System.Drawing.Size(58, 56);
            this.pictureBoxCurrentShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCurrentShape.TabIndex = 6;
            this.pictureBoxCurrentShape.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Udraw.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(118, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxTriangle
            // 
            this.pictureBoxTriangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxTriangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTriangle.Image = global::Udraw.Properties.Resources.triangle;
            this.pictureBoxTriangle.Location = new System.Drawing.Point(25, 197);
            this.pictureBoxTriangle.Name = "pictureBoxTriangle";
            this.pictureBoxTriangle.Size = new System.Drawing.Size(58, 56);
            this.pictureBoxTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTriangle.TabIndex = 4;
            this.pictureBoxTriangle.TabStop = false;
            // 
            // pictureBoxEllipse
            // 
            this.pictureBoxEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxEllipse.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxEllipse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEllipse.Image = global::Udraw.Properties.Resources.ellipse;
            this.pictureBoxEllipse.Location = new System.Drawing.Point(118, 115);
            this.pictureBoxEllipse.Name = "pictureBoxEllipse";
            this.pictureBoxEllipse.Size = new System.Drawing.Size(58, 56);
            this.pictureBoxEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEllipse.TabIndex = 3;
            this.pictureBoxEllipse.TabStop = false;
            // 
            // pictureBoxCircle
            // 
            this.pictureBoxCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxCircle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCircle.Image = global::Udraw.Properties.Resources.circle;
            this.pictureBoxCircle.Location = new System.Drawing.Point(25, 115);
            this.pictureBoxCircle.Name = "pictureBoxCircle";
            this.pictureBoxCircle.Size = new System.Drawing.Size(58, 56);
            this.pictureBoxCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCircle.TabIndex = 2;
            this.pictureBoxCircle.TabStop = false;
            // 
            // pictureBoxSquare
            // 
            this.pictureBoxSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSquare.Image = global::Udraw.Properties.Resources.square;
            this.pictureBoxSquare.Location = new System.Drawing.Point(118, 25);
            this.pictureBoxSquare.Name = "pictureBoxSquare";
            this.pictureBoxSquare.Size = new System.Drawing.Size(58, 56);
            this.pictureBoxSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSquare.TabIndex = 1;
            this.pictureBoxSquare.TabStop = false;
            // 
            // pictureBoxRectangle
            // 
            this.pictureBoxRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxRectangle.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxRectangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRectangle.Image = global::Udraw.Properties.Resources.rectangle;
            this.pictureBoxRectangle.Location = new System.Drawing.Point(25, 25);
            this.pictureBoxRectangle.Name = "pictureBoxRectangle";
            this.pictureBoxRectangle.Size = new System.Drawing.Size(58, 56);
            this.pictureBoxRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRectangle.TabIndex = 0;
            this.pictureBoxRectangle.TabStop = false;
            // 
            // pictureBoxCurrentLine
            // 
            this.pictureBoxCurrentLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCurrentLine.Location = new System.Drawing.Point(650, 141);
            this.pictureBoxCurrentLine.Name = "pictureBoxCurrentLine";
            this.pictureBoxCurrentLine.Size = new System.Drawing.Size(104, 24);
            this.pictureBoxCurrentLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCurrentLine.TabIndex = 12;
            this.pictureBoxCurrentLine.TabStop = false;
            // 
            // pictureBoxThickline
            // 
            this.pictureBoxThickline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxThickline.BackColor = System.Drawing.Color.White;
            this.pictureBoxThickline.Image = global::Udraw.Properties.Resources.thickline;
            this.pictureBoxThickline.Location = new System.Drawing.Point(614, 79);
            this.pictureBoxThickline.Name = "pictureBoxThickline";
            this.pictureBoxThickline.Size = new System.Drawing.Size(104, 21);
            this.pictureBoxThickline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxThickline.TabIndex = 11;
            this.pictureBoxThickline.TabStop = false;
            this.pictureBoxThickline.Click += new System.EventHandler(this.pictureBoxThickline_Click);
            // 
            // pictureBoxCurrentColour
            // 
            this.pictureBoxCurrentColour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCurrentColour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxCurrentColour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCurrentColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurrentColour.Location = new System.Drawing.Point(23, 72);
            this.pictureBoxCurrentColour.Name = "pictureBoxCurrentColour";
            this.pictureBoxCurrentColour.Size = new System.Drawing.Size(46, 41);
            this.pictureBoxCurrentColour.TabIndex = 9;
            this.pictureBoxCurrentColour.TabStop = false;
            // 
            // pictureBoxFill
            // 
            this.pictureBoxFill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxFill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFill.Image = global::Udraw.Properties.Resources.fill;
            this.pictureBoxFill.Location = new System.Drawing.Point(516, 25);
            this.pictureBoxFill.Name = "pictureBoxFill";
            this.pictureBoxFill.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxFill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFill.TabIndex = 8;
            this.pictureBoxFill.TabStop = false;
            // 
            // pictureBoxPencil
            // 
            this.pictureBoxPencil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPencil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxPencil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPencil.Image = global::Udraw.Properties.Resources.pencil_modified;
            this.pictureBoxPencil.Location = new System.Drawing.Point(414, 25);
            this.pictureBoxPencil.Name = "pictureBoxPencil";
            this.pictureBoxPencil.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPencil.TabIndex = 7;
            this.pictureBoxPencil.TabStop = false;
            this.pictureBoxPencil.Click += new System.EventHandler(this.pictureBoxPencil_Click);
            // 
            // pictureBoxMidline
            // 
            this.pictureBoxMidline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxMidline.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxMidline.Image = global::Udraw.Properties.Resources.midline;
            this.pictureBoxMidline.Location = new System.Drawing.Point(614, 52);
            this.pictureBoxMidline.Name = "pictureBoxMidline";
            this.pictureBoxMidline.Size = new System.Drawing.Size(104, 21);
            this.pictureBoxMidline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMidline.TabIndex = 10;
            this.pictureBoxMidline.TabStop = false;
            this.pictureBoxMidline.Click += new System.EventHandler(this.pictureBoxMidline_Click);
            // 
            // pictureBoxThinline
            // 
            this.pictureBoxThinline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxThinline.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxThinline.Image = global::Udraw.Properties.Resources.thinline;
            this.pictureBoxThinline.Location = new System.Drawing.Point(614, 25);
            this.pictureBoxThinline.Name = "pictureBoxThinline";
            this.pictureBoxThinline.Size = new System.Drawing.Size(104, 21);
            this.pictureBoxThinline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxThinline.TabIndex = 9;
            this.pictureBoxThinline.TabStop = false;
            this.pictureBoxThinline.Click += new System.EventHandler(this.pictureBoxThinline_Click);
            // 
            // PaintingCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1010, 592);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintingCanvas";
            this.Text = "udraw";
            this.Load += new System.EventHandler(this.PaintingCanvas_Load);
            this.panelTopbar.ResumeLayout(false);
            this.panelTopbar.PerformLayout();
            this.panelCurrentColour.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThickline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMidline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThinline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Panel panelCurrentColour;
        private System.Windows.Forms.Panel panelColourSection;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxCurrentColour;
        private System.Windows.Forms.PictureBox pictureBoxFill;
        private System.Windows.Forms.PictureBox pictureBoxPencil;
        private System.Windows.Forms.PictureBox pictureBoxThickline;
        private System.Windows.Forms.PictureBox pictureBoxMidline;
        private System.Windows.Forms.PictureBox pictureBoxThinline;
        private System.Windows.Forms.PictureBox pictureBoxTriangle;
        private System.Windows.Forms.PictureBox pictureBoxEllipse;
        private System.Windows.Forms.PictureBox pictureBoxCircle;
        private System.Windows.Forms.PictureBox pictureBoxSquare;
        private System.Windows.Forms.PictureBox pictureBoxRectangle;
        private System.Windows.Forms.Label labelCurrentLine;
        private System.Windows.Forms.PictureBox pictureBoxCurrentLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCurrentShape;
        private System.Windows.Forms.PictureBox pictureBoxCurrentShape;
    }
}