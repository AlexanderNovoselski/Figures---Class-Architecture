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
        public int X { get => _x; }
        public int Y { get => _y; }

        public void SetPoint(int x, int y)
        {
            // Validations
            _x = x;
            _y = y;
        }
    }

}
