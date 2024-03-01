using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization.BufferedDeserialization;

namespace Udraw
{
    public partial class PaintingCanvas : Form
    {
        private List<Button> colorButtons = new List<Button>();
        private Color currentLineColor = Color.Black;
        public PaintingCanvas()
        {
            InitializeComponent();
            
        }

        private void PaintingCanvas_Load(object sender, EventArgs e)
        {
            pictureBoxCurrentColour.BackColor = currentLineColor;
            GenerateColorButtons();
        }

        private void pictureBoxPencil_Click(object sender, EventArgs e)
        {

        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }

        private void panelColourSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Tag is Color selectedColor)
            {

                currentLineColor = selectedColor;
            }
            pictureBoxCurrentColour.BackColor = currentLineColor;
        }

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
    }
}
