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
        public LineType LineType => _lineType;
        public int LineHeight => _lineHeight;

        public void SetLineHeight(int lineHeight)
        {
            // Validations
            _lineHeight = lineHeight;
        }

        public void SetLineType(LineType lineType)
        {
            // Validations
            _lineType = lineType;
        }
    }
}
