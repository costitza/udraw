using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

namespace Udraw.Shapes
{
    class CircleShape : Shape
    {
        public override Point startPoint { get; set; }
        public override Point endPoint { get; set; }
        public override Color color { get; set; }
        public override int width { get; set; }

        public CircleShape(Point startPoint, Point endPoint, Color color, int width)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.color = color;
            this.width = width;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, width))
            {
                int radius = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y)) / 2;
                int centerX = startPoint.X + (endPoint.X - startPoint.X) / 2;
                int centerY = startPoint.Y + (endPoint.Y - startPoint.Y) / 2;
                g.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }
        }

        public override string ToJson()
        {
            // Create a dictionary to represent the shape properties
            var shapeProperties = new Dictionary<string, object>
            {
                { "Type", "CircleShape" },
                { "StartPoint", new { X = startPoint.X, Y = startPoint.Y } },
                { "EndPoint", new { X = endPoint.X, Y = endPoint.Y } },
                { "Color", color.ToArgb() },
                { "Width", width }
            };

            // Serialize the dictionary to JSON
            return JsonSerializer.Serialize(shapeProperties);
        }

        public static CircleShape FromJson(string json)
        {
            try
            {
                // Deserialize the JSON string into a dictionary
                Dictionary<string, object> shapeProperties = JsonSerializer.Deserialize<Dictionary<string, object>>(json);

                // Extract values from the dictionary
                int x = Convert.ToInt32(((JsonElement)shapeProperties["StartPoint"]).GetProperty("X").GetInt32());
                int y = Convert.ToInt32(((JsonElement)shapeProperties["StartPoint"]).GetProperty("Y").GetInt32());
                Point startPoint = new Point(x, y);

                x = Convert.ToInt32(((JsonElement)shapeProperties["EndPoint"]).GetProperty("X").GetInt32());
                y = Convert.ToInt32(((JsonElement)shapeProperties["EndPoint"]).GetProperty("Y").GetInt32());
                Point endPoint = new Point(x, y);

                int colorArgb = Convert.ToInt32(shapeProperties["Color"]);
                Color color = Color.FromArgb(colorArgb);

                int width = Convert.ToInt32(shapeProperties["Width"]);

                // Create a new CircleShape instance using the extracted values
                return new CircleShape(startPoint, endPoint, color, width);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during CircleShape deserialization: {ex.Message}");
                return null; // Handle the error accordingly in your application
            }
        }

    }
}
