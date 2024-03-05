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
        public List<Shape> DrawingData { get; set; }

        public Board(int id, string name, List<Shape> drawingData)
        {
            Id = id;
            Name = name;
            DrawingData = drawingData;
        }

        public Board()
        {
            
        }
    }


}
