using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Udraw.Shapes;
using static System.Windows.Forms.LinkLabel;

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

                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        List<int> boardIds = new List<int>();
                        List<string> boardNames = new List<string>();

                        // Step 1: Fetch boards
                        using (NpgsqlCommand command = new NpgsqlCommand("SELECT id, name FROM boards", connection, transaction))
                        {
                            using (NpgsqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    boardIds.Add(Convert.ToInt32(reader["id"]));
                                    boardNames.Add(reader["name"].ToString());
                                }
                            }
                        }

                        // Step 2: Fetch regular shapes for each board
                        for (int i = 0; i < boardIds.Count; i++)
                        {
                            int boardId = boardIds[i];
                            string boardName = boardNames[i];

                            List<Shape> drawingDataShapes = GetRegularShapesForBoard(connection, boardId);
                            List<FreehandShape> drawingDataFreehand = GetFreehandShapesForBoard(connection, boardId);

                            Board board = new Board(boardId, boardName, drawingDataShapes, drawingDataFreehand);
                            boards.Add(board);
                        }

                        // Commit the transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error during transaction: {ex.Message}");

                        // Rollback the transaction in case of an exception
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening connection: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return boards;
        }


        private static List<Shape> GetRegularShapesForBoard(NpgsqlConnection connection, int boardId)
        {
            List<Shape> regularShapes = new List<Shape>();

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT type, linewidth, color, startpoint_x, startpoint_y, endpoint_x, endpoint_y FROM regular_shapes WHERE board_id = @boardId", connection))
                {
                    command.Parameters.AddWithValue("@boardId", boardId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            string shapeType = reader["type"].ToString();
                            int lineWidth = Convert.ToInt32(reader["linewidth"]);
                            Color color = Color.FromArgb(Convert.ToInt32(reader["color"]));
                            Point startPoint = new Point(Convert.ToInt32(reader["startpoint_x"]), Convert.ToInt32(reader["startpoint_y"]));
                            Point endPoint = new Point(Convert.ToInt32(reader["endpoint_x"]), Convert.ToInt32(reader["endpoint_y"]));

                            
                            Shape shape = CreateShape(shapeType, lineWidth, color, startPoint, endPoint);
                            regularShapes.Add(shape);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving regular shapes: {ex.Message}");
            }

            return regularShapes;
        }

        private static List<FreehandShape> GetFreehandShapesForBoard(NpgsqlConnection connection, int boardId)
        {
            List<FreehandShape> freehandShapes = new List<FreehandShape>();

            try
            {
                List<int> freehandShapeIds = new List<int>();
                List<int> linewidths = new List<int>();
                List<Color> colors = new List<Color>();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT id, linewidth, color FROM freehand_shapes WHERE board_id = @boardId", connection))
                {
                    command.Parameters.AddWithValue("@boardId", boardId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            freehandShapeIds.Add(Convert.ToInt32(reader["id"]));
                            linewidths.Add(Convert.ToInt32(reader["linewidth"]));
                            colors.Add(Color.FromArgb(Convert.ToInt32(reader["color"])));
 
                        }
                    }
                }

                for (int i = 0; i < freehandShapeIds.Count; i++)
                {
                    int freehandShapeId = freehandShapeIds[i];
                    int lineWidth = linewidths[i];
                    Color color = colors[i];

                    List<Point> freehandPoints = GetFreehandPointsForShape(connection, freehandShapeId);

                    FreehandShape freehandShape = new FreehandShape(freehandPoints, color, lineWidth);
                    freehandShapes.Add(freehandShape);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving freehand shapes: {ex.Message}");
            }

            return freehandShapes;
        }

        private static List<Point> GetFreehandPointsForShape(NpgsqlConnection connection, int freehandShapeId)
        {
            List<Point> freehandPoints = new List<Point>();

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT point_x, point_y FROM points WHERE freehandshape_id = @freehandShapeId", connection))
                {
                    command.Parameters.AddWithValue("@freehandShapeId", freehandShapeId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pointX = Convert.ToInt32(reader["point_x"]);
                            int pointY = Convert.ToInt32(reader["point_y"]);

                            Point point = new Point(pointX, pointY);
                            freehandPoints.Add(point);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving freehand points: {ex.Message}");
            }

            return freehandPoints;
        }

        private static Shape CreateShape(string shapeType, int lineWidth, Color color, Point startPoint, Point endPoint)
        {
            switch (shapeType)
            {
                case "TriangleShape":
                    return new TriangleShape(startPoint, endPoint, color, lineWidth);

                case "SquareShape":
                    return new SquareShape(startPoint, endPoint, color, lineWidth);

                case "RectangleShape":
                    return new RectangleShape(startPoint, endPoint, color, lineWidth);

                case "LineShape":
                    return new LineShape(startPoint, endPoint, color, lineWidth);

                case "EllipseShape":
                    return new EllipseShape(startPoint, endPoint, color, lineWidth);

                case "CircleShape":
                    return new CircleShape(startPoint, endPoint, color, lineWidth);

                default:
                    Console.WriteLine($"Unknown shape type: {shapeType}");
                    return null;
            }
        }



        public static int AddNewBoard(NpgsqlConnection connection, Board board)
        {
            try
            {
                connection.Open();

                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Step 1: salvez board
                        using (NpgsqlCommand boardCommand = new NpgsqlCommand("INSERT INTO boards (name) VALUES (@name) RETURNING id", connection))
                        {
                            boardCommand.Parameters.AddWithValue("@name", board.Name);
                            int boardId = (int)boardCommand.ExecuteScalar();
                            Console.WriteLine($"Board saved with ID: {boardId}");

                            // Step 2: salvez shapeurile regulare
                            foreach (Shape regularShape in board.DrawingDataShapes)
                            {
                                using (NpgsqlCommand regularShapeCommand = new NpgsqlCommand("INSERT INTO regular_shapes (board_id, type, linewidth, color, startpoint_x, startpoint_y, endpoint_x, endpoint_y) VALUES (@boardId, @type, @linewidth, @color, @startpoint_x, @startpoint_y, @endpoint_x, @endpoint_y)", connection))
                                {
                                    regularShapeCommand.Parameters.AddWithValue("@boardId", boardId);

                                    Console.WriteLine(regularShape.width);

                                    switch (regularShape)
                                    {
                                        case TriangleShape triangleShape:
                                            regularShapeCommand.Parameters.AddWithValue("@type", "TriangleShape");
                                            break;
                                        case SquareShape squareShape:
                                            regularShapeCommand.Parameters.AddWithValue("@type", "SquareShape");
                                            break;
                                        case RectangleShape rectangleShape:
                                            regularShapeCommand.Parameters.AddWithValue("@type", "RectangleShape");
                                            break;
                                        case LineShape lineShape:
                                            regularShapeCommand.Parameters.AddWithValue("@type", "LineShape");
                                            break;
                                        case EllipseShape ellipseShape:
                                            regularShapeCommand.Parameters.AddWithValue("@type", "EllipseShape");
                                            break;
                                        case CircleShape circleShape:
                                            regularShapeCommand.Parameters.AddWithValue("@type", "CircleShape");
                                            break;
                                        default:
                                            break;
                                    }

                                    regularShapeCommand.Parameters.AddWithValue("@linewidth", regularShape.width);
                                    regularShapeCommand.Parameters.AddWithValue("@color", regularShape.color.ToArgb());
                                    regularShapeCommand.Parameters.AddWithValue("@startpoint_x", regularShape.startPoint.X);
                                    regularShapeCommand.Parameters.AddWithValue("@startpoint_y", regularShape.startPoint.Y);
                                    regularShapeCommand.Parameters.AddWithValue("@endpoint_x", regularShape.endPoint.X);
                                    regularShapeCommand.Parameters.AddWithValue("@endpoint_y", regularShape.endPoint.Y);
                                    regularShapeCommand.ExecuteNonQuery();
                                }
                            }

                            // Step 3: salvez shapeuri freehand
                            foreach (FreehandShape freehandShape in board.DrawingFreehandShapes)
                            {
                                using (NpgsqlCommand freehandShapeCommand = new NpgsqlCommand("INSERT INTO freehand_shapes (board_id, linewidth, color) VALUES (@boardId, @linewidth, @color) RETURNING id", connection))
                                {
                                    freehandShapeCommand.Parameters.AddWithValue("@boardId", boardId);
                                    freehandShapeCommand.Parameters.AddWithValue("@linewidth", freehandShape.width);
                                    freehandShapeCommand.Parameters.AddWithValue("@color", freehandShape.color.ToArgb());
                                    int freehandShapeId = (int)freehandShapeCommand.ExecuteScalar();

                                    // Step 4: salvez fiecare punct din lista de puncte
                                    foreach (Point point in freehandShape.freehandPoints)
                                    {
                                        using (NpgsqlCommand lineCommand = new NpgsqlCommand("INSERT INTO points (freehandshape_id, point_x, point_y) VALUES (@freehandShapeId, @point_x, @point_y)", connection))
                                        {
                                            lineCommand.Parameters.AddWithValue("@freehandShapeId", freehandShapeId);
                                            lineCommand.Parameters.AddWithValue("@point_x", point.X);
                                            lineCommand.Parameters.AddWithValue("@point_y", point.Y);
                                            lineCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }

                            transaction.Commit();
                            return boardId;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error during transaction: {ex.Message}");

                        transaction.Rollback();
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening connection: {ex.Message}");
                return -1;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public static bool DeleteBoard(NpgsqlConnection connection, int boardId)
        {
            try
            {
                connection.Open();

                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete regular shapes
                        using (NpgsqlCommand deleteRegularShapesCommand = new NpgsqlCommand("DELETE FROM regular_shapes WHERE board_id = @boardId", connection))
                        {
                            deleteRegularShapesCommand.Parameters.AddWithValue("@boardId", boardId);
                            deleteRegularShapesCommand.ExecuteNonQuery();
                        }

                        List <int> freehandShapeIds = new List<int>();

                        using (NpgsqlCommand getFreehandShapesCommand = new NpgsqlCommand("SELECT id FROM freehand_shapes WHERE board_id = @boardId", connection))
                        {
                            getFreehandShapesCommand.Parameters.AddWithValue("@boardId", boardId);

                            using (NpgsqlDataReader freehandShapesReader = getFreehandShapesCommand.ExecuteReader())
                            {
                                while (freehandShapesReader.Read())
                                {
                                    int freehandShapeId = Convert.ToInt32(freehandShapesReader["id"]);
                                    freehandShapeIds.Add(freehandShapeId);

                                }
                            }
                        }

                        // Delete freehand points
                        for(int i = 0;i < freehandShapeIds.Count(); i++)
                        {
                            int freehandShapeId = freehandShapeIds[i];


                            using (NpgsqlCommand deleteFreehandPointsCommand = new NpgsqlCommand("DELETE FROM points WHERE freehandshape_id = @freehandShapeId", connection))
                            {
                                deleteFreehandPointsCommand.Parameters.AddWithValue("@freehandShapeId", freehandShapeId);
                                deleteFreehandPointsCommand.ExecuteNonQuery();
                            }
                        }


                        // Delete freehand shapes
                        using (NpgsqlCommand deleteFreehandShapesCommand = new NpgsqlCommand("DELETE FROM freehand_shapes WHERE board_id = @boardId", connection))
                        {
                            deleteFreehandShapesCommand.Parameters.AddWithValue("@boardId", boardId);
                            deleteFreehandShapesCommand.ExecuteNonQuery();
                        }

                        // Delete the board
                        using (NpgsqlCommand deleteBoardCommand = new NpgsqlCommand("DELETE FROM boards WHERE id = @boardId", connection))
                        {
                            deleteBoardCommand.Parameters.AddWithValue("@boardId", boardId);
                            deleteBoardCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error during transaction: {ex.Message}");

                        transaction.Rollback();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening connection: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }




    }

}

