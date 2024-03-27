using System.Drawing;

namespace Figures.Models.Models.HelperModels.Shapes
{
    public class PointModel
    {
        private int _x;
        private int _y;

        public PointModel()
        {

        }
        public PointModel(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }


    }

}
