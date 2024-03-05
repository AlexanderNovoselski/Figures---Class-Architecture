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
        public int X => _x;
        public int Y => _y; 

        public void SetPoint(int x, int y)
        {
            // Validations
            if(x < 0)
            {
                _x = 0;
            }
            else
            {
                _x = x;
            }
            if(y < 0)
            {
                _y = 0;
            }
            else
            {
                _y = y;
            }
        }
    }

}
