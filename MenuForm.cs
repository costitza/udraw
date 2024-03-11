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
        private Timer doubleClickTimer = new Timer();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<Shape> emptyDrawingData = new List<Shape>();
            List<FreehandShape> emptyFreehandData = new List<FreehandShape>();
            Board emptyBoard = new Board(0, "", emptyDrawingData, emptyFreehandData);
            PaintingCanvas paintingCanvas = new PaintingCanvas(emptyBoard);
            paintingCanvas.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            buttonDrawings.Visible = false;
            GenerateBoardButtons();
        }


        private void GenerateBoardButtons()
        {
            if(boards != null)
            {
                boards.Clear();
            }
            
            NpgsqlConnection connection = new NpgsqlConnection(DatabaseConfig.Instance.GetConnectionString());
            boards = DatabaseHelper.GetAllBoards(connection);


            int buttonWidth = 150;
            int buttonHeight = 60;
            int spacing = 10;
            int x = 10;
            int y = 10;
            Font buttonFont = new Font("Rockwell", 10, FontStyle.Bold);

            foreach (Board board in boards)
            {
                DoubleClickButton boardButton = new DoubleClickButton
                {
                    Text = board.Name,
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new Point(x, y),
                    Tag = board
                };

                
                boardButton.BackColor = Color.Peru;
                boardButton.Font = buttonFont;
                boardButton.DoubleClick += BoardButton_DoubleClick;

                panelBoards.Controls.Add(boardButton);

                y += buttonHeight + spacing;
            }
        }

        private void BoardButton_DoubleClick(object sender, EventArgs e)
        {
            //Console.WriteLine("Double-click event triggered!");

            Button clickedButton = (Button)sender;
            Board selectedBoard = (Board)clickedButton.Tag;

            OpenDrawingForm(selectedBoard);
        }

        private void OpenDrawingForm(Board selectedBoard)
        {

            PaintingCanvas paintingCanvas = new PaintingCanvas(selectedBoard);
            paintingCanvas.Show();
        }

        private void buttonBoards_Click(object sender, EventArgs e)
        {
            panelBoards.Controls.Clear();
            GenerateBoardButtons();
        }
    }
}
