using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udraw
{
    public partial class MenuForm : Form
    {
        private List<Board> boards;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<Shape> emptyDrawingData = new List<Shape>();
            Board emptyBoard = new Board(0, "", emptyDrawingData);
            PaintingCanvas paintingCanvas = new PaintingCanvas(emptyBoard);
            paintingCanvas.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection(DatabaseConfig.Instance.GetConnectionString());
            boards = DatabaseHelper.GetAllBoards(connection);

            foreach (var board in boards)
            {
                Console.WriteLine($"Board ID: {board.Id}, Name: {board.Name}");
            }

            GenerateBoardButtons();
        }

        private void GenerateBoardButtons()
        {
            int buttonWidth = 150;
            int buttonHeight = 50;
            int spacing = 10;
            int x = 10;
            int y = 10;

            foreach (Board board in boards)
            {
                Button boardButton = new Button
                {
                    Text = board.Name,
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new Point(x, y),
                    Tag = board
                };

                
                Random random = new Random();
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                boardButton.BackColor = randomColor;

                boardButton.Click += BoardButton_Click;

                panelBoards.Controls.Add(boardButton);

                y += buttonHeight + spacing;
            }
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            // Handle the click event for the board button
            Button clickedButton = (Button)sender;
            Board selectedBoard = (Board)clickedButton.Tag;

            // Now you can use the selectedBoard object to access the information of the clicked board
            // For example, you can open a new form with the drawing data of the selected board
            OpenDrawingForm(selectedBoard);
        }

        private void OpenDrawingForm(Board selectedBoard)
        {
            // Implement the logic to open a new form with the drawing data of the selected board
            // You can pass the selectedBoard object to the new form
            // For example, you can create a new instance of the DrawingForm and pass the selectedBoard to its constructor
            PaintingCanvas paintingCanvas = new PaintingCanvas(selectedBoard);
            paintingCanvas.Show();
        }

        private void buttonBoards_Click(object sender, EventArgs e)
        {
            GenerateBoardButtons();
        }
    }
}
