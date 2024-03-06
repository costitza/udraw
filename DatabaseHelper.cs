using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Udraw.Shapes;

namespace Udraw
{
    public class DatabaseHelper
    {
        public static List<Board> GetAllBoards(NpgsqlConnection connection)
        {
            List<Board> boards = new List<Board>();

            try
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT id, name, drawing_data_shapes, drawing_data_freehand FROM boards", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int boardId = Convert.ToInt32(reader["id"]);
                            string boardName = reader["name"].ToString();
                            string drawingDataShapesJson = reader["drawing_data_shapes"].ToString();
                            string drawingDataFreehandJson = reader["drawing_data_freehand"].ToString();

                            List<Shape> drawingDataShapes = DeserializeShapesFromJson(drawingDataShapesJson);
                            List<FreehandShape> drawingDataFreehand = DeserializeFreehandShapesFromJson(drawingDataFreehandJson);

                            Board board = new Board(boardId, boardName, drawingDataShapes, drawingDataFreehand);
                            boards.Add(board);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving boards: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return boards;
        }

        private static List<Shape> DeserializeShapesFromJson(string json)
        {
            List<Shape> shapes = new List<Shape>();
            try
            {
                

                Console.WriteLine($"Raw JSON Data (Shapes): {json}");

                // Deserialize the JSON array into a list of dictionaries
                List<Dictionary<string, object>> shapeDataList = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json);

                // Iterate through each dictionary and create the corresponding shape
                foreach (var shapeData in shapeDataList)
                {
                    // Determine the shape type based on the data
                    if (shapeData.TryGetValue("Type", out object shapeType))
                    {
                        switch (shapeType.ToString())
                        {
                            case "RectangleShape":
                                shapes.Add(RectangleShape.FromJson(shapeData["Data"].ToString()));
                                break;
                            case "CircleShape":
                                shapes.Add(CircleShape.FromJson(shapeData["Data"].ToString()));
                                break;
                            case "EllipseShape":
                                shapes.Add(EllipseShape.FromJson(shapeData["Data"].ToString()));
                                break;
                            case "LineShape":
                                shapes.Add(LineShape.FromJson(shapeData["Data"].ToString()));
                                break;
                            case "SquareShape":
                                shapes.Add(SquareShape.FromJson(shapeData["Data"].ToString()));
                                break;
                            case "TriangleShape":
                                shapes.Add(TriangleShape.FromJson(shapeData["Data"].ToString()));
                                break;
                            default:
                                Console.WriteLine($"Unknown shape type: {shapeType}");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deserialization (Shapes): {ex.Message}");
            }


            return shapes;
        }

        private static List<FreehandShape> DeserializeFreehandShapesFromJson(string json)
        {
            List<FreehandShape> freehandShapes = new List<FreehandShape>();

            try
            {
                Console.WriteLine($"Raw JSON Data (Freehand): {json}");

                // Deserialize the JSON array into a list of dictionaries
                List<Dictionary<string, object>> shapeDataList = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json);

                // Iterate through each dictionary and create the corresponding freehand shape
                foreach (var shapeData in shapeDataList)
                {
                    // Determine the shape type based on the data
                    if (shapeData.TryGetValue("Type", out object shapeType) && shapeType.ToString() == "FreehandShape")
                    {
                        freehandShapes.Add(FreehandShape.FromJson(shapeData["Data"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deserialization (Freehand): {ex.Message}");
            }


            return freehandShapes;
        }





        public static int AddNewBoard(NpgsqlConnection connection, Board board)
        {
            try
            {
                connection.Open();

                // Serialize each list independently
                var drawingDataJson = JsonSerializer.Serialize(board.DrawingDataShapes.Select(shape => shape.ToJson()));
                var freehandDataJson = JsonSerializer.Serialize(board.DrawingFreehandShapes.Select(shape => shape.ToJson()));

                using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO boards (name, drawing_data_shapes, drawing_data_freehand) VALUES (@name, @drawingDataShapes::jsonb, @drawingDataFreehand::jsonb) RETURNING id", connection))
                {
                    command.Parameters.AddWithValue("@name", board.Name);
                    command.Parameters.AddWithValue("@drawingDataShapes", drawingDataJson);
                    command.Parameters.AddWithValue("@drawingDataFreehand", freehandDataJson);

                    // ExecuteScalar returns the id of the newly inserted record
                    int boardId = (int)command.ExecuteScalar();
                    Console.WriteLine($"Board saved with ID: {boardId}");
                    return boardId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding new board to the database: {ex.Message}");
                return -1; // Indicate failure
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }




    }

}
