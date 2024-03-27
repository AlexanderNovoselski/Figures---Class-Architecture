namespace Figures.Models.Models.HelperModels.Shapes
{
    public class TextStylesModel
    {
        private string _fontName;
        private int _fontSize;

        public TextStylesModel()
        {
            
        }
        public TextStylesModel(string fontName, int fontSize)
        {
            _fontName = fontName;
            _fontSize = fontSize;
        }

        public string FontName { get { return _fontName; } set { _fontName = value; } }
        public int FontSize { get { return _fontSize; } set { _fontSize = value; } }

   

    }
}
