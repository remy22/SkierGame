using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class FieldCoordinates
    {
        // Coordinates of all the elements
        public int Row { get; set; }
        public int Col { get; set; }

        //Constructor
        public FieldCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public static FieldCoordinates operator +(FieldCoordinates a, FieldCoordinates b)
        {
            return new FieldCoordinates(a.Row + b.Row, a.Col + b.Col);
        }

        public static FieldCoordinates operator -(FieldCoordinates a, FieldCoordinates b)
        {
            return new FieldCoordinates(a.Row - b.Row, a.Col - b.Col);
        }

        //Allows comparing of values instead of addresses only (same object vs. same value)
        public override bool Equals(object obj)
        {
            FieldCoordinates objAsMatrixCoords = obj as FieldCoordinates;

            return objAsMatrixCoords.Row == this.Row && objAsMatrixCoords.Col == this.Col;
        }

        public override int GetHashCode()
        {
            return this.Row.GetHashCode()*7 + this.Col;
        }
    }
}
