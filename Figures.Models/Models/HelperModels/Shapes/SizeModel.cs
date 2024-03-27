using Figures.Models.Enums;

namespace Figures.Models.Models.HelperModels.Shapes
{
    public class SizeModel
    {
        private int _width;
        private int _height;

        public SizeModel()
        {

        }
        public SizeModel(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public int Width { get { return _width; } set { _width = value; } }
        public int Height { get { return _height; } set { _height = value; } }
     
    }
}
