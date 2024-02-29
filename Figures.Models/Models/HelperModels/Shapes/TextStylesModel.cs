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

        public string FontName => _fontName;
        public int FontSize => _fontSize;

        public void SetFontName(string fontName)
        {
            _fontName = fontName;
        }

        public void SetFontSize(int fontSize)
        {
            _fontSize = fontSize;
        }

    }
}
