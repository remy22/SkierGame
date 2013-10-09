using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class ConsoleRenderer : IRenderer
    {
        //TODO: The code that will render te game to the Console
        int renderMatrixRows;
        int renderMatrixCols;
        char[,] renderMatrix;

        public ConsoleRenderer(int fieldRows, int fieldCols)
        {
            renderMatrix = new char[fieldRows, fieldCols];

            this.renderMatrixRows = renderMatrix.GetLength(0);
            this.renderMatrixCols = renderMatrix.GetLength(1);

            this.ClearQueue();
        }


        // Image is combination of all object`s symbols
        public void EnqueueForRendering(IRenderable obj)
        {
            
            char[,] objImage = obj.GetImage();
            int imageRows = objImage.GetLength(0);
            int imageCols = objImage.GetLength(1);

            // Set the image in top-left corner
            FieldCoordinates objTopLeft = obj.GetTopLeft();
            
            // Move the image to his position 
            int lastRow = Math.Min(objTopLeft.Row + imageRows, this.renderMatrixRows);
            int lastCol = Math.Min(objTopLeft.Col + imageCols, this.renderMatrixCols);

            for (int row = obj.GetTopLeft().Row; row < lastRow; row++)
            {
                for (int col = obj.GetTopLeft().Col; col < lastCol; col++)
                {
                    // Check if the object coordinates are in the fields
                    if (row >= 0 && row < renderMatrixRows &&
                        col >= 0 && col < renderMatrixCols)
                    {
                        renderMatrix[row, col] = objImage[row - obj.GetTopLeft().Row, col - obj.GetTopLeft().Col];
                    }
                }
            }
        }

        // Printing whole track
        public void RenderAll()
        {
            Console.SetCursorPosition(0, 0);

            StringBuilder track = new StringBuilder();

            for (int row = 0; row < this.renderMatrixRows; row++)
            {
                for (int col = 0; col < this.renderMatrixCols; col++)
                {
                    track.Append(this.renderMatrix[row,col]);
                }
                track.Append(Environment.NewLine);
                
            }
            Console.WriteLine(track.ToString());


            Console.SetCursorPosition(MainClass.FieldCols, 1);
            Score.PrintBestScore();

            Console.SetCursorPosition(MainClass.FieldCols, 3);
            Score.PrintScore();
                
                
        }

        // Clean whole track
        public void ClearQueue()
        {
            for (int row = 0; row < this.renderMatrixRows; row++)
            {
                for (int col = 0; col < this.renderMatrixCols; col++)
                {
                    this.renderMatrix[row, col] = ' ';
                }
            }
        }

    }
}
