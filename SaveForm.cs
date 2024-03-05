using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udraw
{
    public partial class SaveForm : Form
    {
        private NpgsqlConnection databaseConnection;
        private List<Shape> drawingData;


        public SaveForm(NpgsqlConnection connection, List<Shape> drawingData)
        {
            InitializeComponent();
            this.databaseConnection = connection;
            this.drawingData = drawingData;
        }
        private void SaveBoardToDatabase(string boardName, List<Shape> drawingData)
        {
            try
            {

                Board board = new Board { Name = boardName, DrawingData = drawingData };

                int boardId = DatabaseHelper.AddNewBoard(databaseConnection, board);

                if (boardId != -1)
                {
                    Console.WriteLine($"Board saved with ID: {boardId}");
                }
                else
                {
                    Console.WriteLine("Error saving board to the database.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving board to the database: {ex.Message}");
            }
        }


        private void buttonSaveBoard_Click(object sender, EventArgs e)
        {
            if(textBoxBoardName.Text != null)
            {
                SaveBoardToDatabase((string)textBoxBoardName.Text, drawingData);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please provide a name for the board.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
