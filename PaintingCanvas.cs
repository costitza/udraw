using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udraw.Shapes;
using YamlDotNet.Serialization.BufferedDeserialization;

namespace Udraw
{
    public partial class PaintingCanvas : Form
    {
        //DECLARARE
        private Point? startPoint = null;
        private Point? endPoint = null;


        private List<Shape> drawnShapes = new List<Shape>();
        private List<Point> currentFreehandPoints = new List<Point>();
        private List<Button> colorButtons = new List<Button>();
        private Color currentLineColor = Color.Black;
        private int currentLineWidth = 2;
        private SelectedShape currentShape = SelectedShape.None;

        private enum SelectedShape
        {
            None,
            Rectangle,
            Square,
            Triangle,
            Circle,
            Ellipse,
            Line,
            Freehand
        }

        public PaintingCanvas(Board board)
        {
            InitializeComponent();

            if(board != null)
            {
                drawnShapes = board.DrawingData;
            }

            panelDrawing.Paint += panelDrawing_Paint;
            panelDrawing.MouseDown += panelDrawing_MouseDown;
            panelDrawing.MouseMove += panelDrawing_MouseMove;
            panelDrawing.MouseUp += panelDrawing_MouseUp;


            pictureBoxRectangle.Click += (sender, e) => { 
                resetVariables();
                currentShape = SelectedShape.Rectangle;
                pictureBoxCurrentShape.Image = Image.FromFile(Application.StartupPath + @"\shapes\rectangle.png");
            };
            pictureBoxCircle.Click += (sender, e) => {
                resetVariables();
                currentShape = SelectedShape.Circle;
                pictureBoxCurrentShape.Image = Image.FromFile(Application.StartupPath + @"\shapes\circle.png");
            };
            pictureBoxSquare.Click += (sender, e) => {
                resetVariables();
                currentShape = SelectedShape.Square;
                pictureBoxCurrentShape.Image = Image.FromFile(Application.StartupPath + @"\shapes\square.png");
            };
            pictureBoxTriangle.Click += (sender, e) => {
                resetVariables();
                currentShape = SelectedShape.Triangle;
                pictureBoxCurrentShape.Image = Image.FromFile(Application.StartupPath + @"\shapes\triangle.png");
            };
            pictureBoxEllipse.Click += (sender, e) => {
                resetVariables();
                currentShape = SelectedShape.Ellipse;
                pictureBoxCurrentShape.Image = Image.FromFile(Application.StartupPath + @"\shapes\ellipse.png");
            };
            pictureBoxLine.Click += (sender, e) => {
                resetVariables();
                currentShape = SelectedShape.Line;
                pictureBoxCurrentShape.Image = Image.FromFile(Application.StartupPath + @"\shapes\line.png");
            };
        }

        private void PaintingCanvas_Load(object sender, EventArgs e)
        {
            pictureBoxCurrentColour.BackColor = currentLineColor;
            GenerateColorButtons();
            pictureBoxCurrentLine.Image = Image.FromFile(Application.StartupPath + @"\thinline.jpeg");
        }
        
        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            if(drawnShapes != null)
            {
                foreach (var shape in drawnShapes)
                {
                    shape.Draw(e.Graphics);
                }
            }
            
        }
        
        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == SelectedShape.Freehand)
            {
                currentFreehandPoints.Clear();
                currentFreehandPoints.Add(e.Location);
            }
            else if (currentShape != SelectedShape.None)
            {
                startPoint = e.Location;
                endPoint = e.Location;
            }
        }

        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (currentShape == SelectedShape.Freehand)
                {
                    currentFreehandPoints.Add(e.Location);
                }
                else
                {
                    endPoint = e.Location;
                    panelDrawing.Invalidate();
                }
            }
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentShape == SelectedShape.Freehand)
            {
                
                drawnShapes.Add(new FreehandShape(new List<Point>(currentFreehandPoints), currentLineColor, currentLineWidth));

                currentFreehandPoints.Clear();
                panelDrawing.Invalidate();
            }
            else if (currentShape != SelectedShape.None)
            {
                drawnShapes.Add(CreateCurrentShape());
                startPoint = null; endPoint = null;
                panelDrawing.Invalidate();
            }
        }

        private void panelColourSection_Paint(object sender, PaintEventArgs e)
        {

        }


        ///  MOD DE DESENARE - INITIALIZARE
        private void pictureBoxPencil_Click(object sender, EventArgs e)
        {
            resetVariables();
            currentShape = SelectedShape.Freehand;
            pictureBoxCurrentShape.Image = Image.FromFile(Application.StartupPath + @"\pencil modified.jpg");
        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }

        /// CREERE SHAPE-URI
        private Shape CreateCurrentShape()
        {
            switch (currentShape)
            {
                case SelectedShape.Rectangle:
                    return new RectangleShape(startPoint.Value, endPoint.Value, currentLineColor, currentLineWidth);
                case SelectedShape.Triangle:
                    return new TriangleShape(startPoint.Value, endPoint.Value, currentLineColor, currentLineWidth);
                case SelectedShape.Circle:
                    return new CircleShape(startPoint.Value, endPoint.Value, currentLineColor, currentLineWidth);
                case SelectedShape.Ellipse:
                    return new EllipseShape(startPoint.Value, endPoint.Value, currentLineColor, currentLineWidth);
                case SelectedShape.Line:
                    return new LineShape(startPoint.Value, endPoint.Value, currentLineColor, currentLineWidth);
                case SelectedShape.Square:
                    return new SquareShape(startPoint.Value, endPoint.Value, currentLineColor, currentLineWidth);
                default:
                    return null;
            }
        }


        /// IAU CULOAREA SELECTATA
        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Tag is Color selectedColor)
            {

                currentLineColor = selectedColor;
            }
            pictureBoxCurrentColour.BackColor = currentLineColor;
        }


        /// GENERARE DE CULORI
        private void GenerateColorButtons()
        {
            List<Color> colors = new List<Color> {Color.Black, Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Magenta,
                Color.Cyan, Color.Orange, Color.Olive, Color.DarkTurquoise, Color.Gold, Color.DarkKhaki, Color.Lime, Color.White,
                Color.OrangeRed, Color.Navy, Color.Moccasin, Color.MediumVioletRed};

            int buttonWidth = 30;
            int buttonHeight = 30;
            int spacing = 5;

            int x = 10;
            int y = 10;

            int count = 1;

            foreach (Color color in colors)
            {
                Button colorButton = new Button
                {
                    BackColor = color,
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new Point(x, y),
                    Tag = color
                };

                colorButton.Click += ColorButton_Click;

                colorButtons.Add(colorButton);
                panelColourSection.Controls.Add(colorButton);

                x += buttonWidth + spacing;

                if (count % 6 == 0)
                {
                    y += buttonHeight + spacing;
                    x = 10;
                }
                count++;
                
            }
        }


        /// GROSIMEA LINII
        private void pictureBoxThinline_Click(object sender, EventArgs e)
        {
            pictureBoxCurrentLine.Image = Image.FromFile(Application.StartupPath + @"\thinline.jpeg");
            currentLineWidth = 2;
        }

        private void pictureBoxMidline_Click(object sender, EventArgs e)
        {
            pictureBoxCurrentLine.Image = Image.FromFile(Application.StartupPath + @"\midline.jpeg");
            currentLineWidth = 3;
        }

        private void pictureBoxThickline_Click(object sender, EventArgs e)
        {
            pictureBoxCurrentLine.Image = Image.FromFile(Application.StartupPath + @"\thickline.jpeg");
            currentLineWidth = 5;
        }

        /// RESETARE
        private void resetVariables()
        {
            startPoint = null;
            endPoint = null;
            currentShape = SelectedShape.None;
        }

        /// CANVAS CLEARENCE
        private void buttonClear_Click(object sender, EventArgs e)
        {
            drawnShapes.Clear();
            resetVariables();
            panelDrawing.Invalidate();
        }

        // SALVARE IN BAZA DE DATE
        private void buttonSave_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection(DatabaseConfig.Instance.GetConnectionString());

            Console.WriteLine(drawnShapes.ToArray());
            SaveForm saveForm = new SaveForm(connection, drawnShapes);

            saveForm.ShowDialog();
        }
    }
}
