﻿namespace Figures.Models.Models.HelperModels.Shapes
{
    public class ColorModel
    {

        private string _color;

        public ColorModel()
        {

        }

        public ColorModel(string color)
        {
            _color = color;
        }

        public string ColorName { get { return _color; } set { _color = value; } }


    }
}
