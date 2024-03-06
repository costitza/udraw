using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udraw
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Shape> DrawingDataShapes { get; set; }
        public List<FreehandShape> DrawingFreehandShapes { get; set; }

        public Board(int id, string name, List<Shape> drawingDataShapes, List<FreehandShape> drawingFreehandShapes)
        {
            Id = id;
            Name = name;
            DrawingDataShapes = drawingDataShapes;
            DrawingFreehandShapes = drawingFreehandShapes;
        }

        public Board()
        {
            
        }
    }


}
