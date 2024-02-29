namespace Figures.Models.Models.HelperModels.Shapes
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

        public string ColorName => _color;

        public void SetColor(string color)
        {
            // Validations
            _color = color;
        }


    }
}
