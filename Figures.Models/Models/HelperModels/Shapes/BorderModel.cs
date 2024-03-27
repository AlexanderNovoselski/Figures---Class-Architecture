using Figures.Models.Enums;

namespace Figures.Models.Models.HelperModels.Shapes
{
    public class BorderModel
    {
        private int _lineHeight;
        private LineType _lineType;

        public BorderModel()
        {

        }
        public BorderModel(int lineHeight, LineType lineType)
        {
            _lineHeight = lineHeight;
            _lineType = lineType;
        }



        public LineType LineType { get { return _lineType; } set { _lineType = value; } }
        public int LineHeight { get { return _lineHeight; } set { _lineHeight = value; } }


    }
}
