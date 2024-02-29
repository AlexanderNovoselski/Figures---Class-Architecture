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
        public int Width => _width;
        public int Height => _height;
        public void SetSize(int width, int height)
        {
            // Validations
            _width = width;
            _height = height;
        }
    }
}
