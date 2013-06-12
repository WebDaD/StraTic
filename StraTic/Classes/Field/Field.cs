using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class Field
    {
        List<Cell> cells;

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Field()
        {
            cells = new List<Cell>();
            throw new System.NotImplementedException();
        }
    
        /// <summary>
        /// List of Cells
        /// </summary>
        public List<Cell> Cells
        {
            get
            {
                return cells;
            }
        }

        /// <summary>
        /// Height of Field
        /// </summary>
        public int Height
        {
            get
            {
                int h = 0;
                foreach (Cell c in cells)
                {
                    if (c.Y > h) h = c.Y;
                }
                return h;
            }
        }

        /// <summary>
        /// Width of Field
        /// </summary>
        public int Width
        {
            get
            {
                int w = 0;
                foreach (Cell c in cells)
                {
                    if (c.X > w) w = c.X;
                }
                return w;
            }
        }

        /// <summary>
        /// Depth of Field
        /// </summary>
        public int Depth
        {
            get
            {
                int d = 0;
                foreach (Cell c in cells)
                {
                    if (c.Z > d) d = c.Z;
                }
                return d;
            }
        }

        /// <summary>
        /// Creates a defined Field of Cell.
        /// </summary>
        /// <param name="seed">Used to create a Random Element</param>
        /// <param name="width">Maximum Width of message</param>
        /// <param name="height">Maximum Height of Field</param>
        /// <param name="depth">Maximum Depth of Field</param>
        /// <returns>Object of type Field or null</returns>
        public static Field createField(int seed, int width, int height, int depth)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Adds A Cell to the Field
        /// </summary>
        /// <param name="x">Position on X-Axis</param>
        /// <param name="y">Position on Y-Axis</param>
        /// <param name="z">Depth-Level</param>
        /// <param name="type">Type of Cell</param>
        /// <returns>true or false</returns>
        public Boolean AddCell(int x, int y, int z, CellType type)
        {
            try
            {
                cells.Add(new Cell(x, y, z, type));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets a Specific Cell from The Field
        /// </summary>
        /// <param name="x">Position on X-Axis</param>
        /// <param name="y">Position on Y-Axis</param>
        /// <param name="z">Depth-Level</param>
        /// <returns>Object Cell or null</returns>
        public Cell GetCell(int x, int y, int z)
        {
            foreach (Cell c in cells)
            {
                if (c.X == x && c.Y == y && c.Z == z) return c;
            }
            return null;
        }
    }
}
