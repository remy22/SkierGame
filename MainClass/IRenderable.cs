﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public interface IRenderable
    {
        FieldCoordinates GetTopLeft();

        char[,] GetImage();
    }
}
