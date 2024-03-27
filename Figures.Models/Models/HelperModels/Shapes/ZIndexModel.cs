namespace Figures.Models.Models.HelperModels.Shapes
{
    public class ZIndexModel
    {
        private int _zIndex;

        public ZIndexModel()
        {

        }
        public ZIndexModel(int zIndex)
        {
            _zIndex = zIndex;
        }

        public int ZIndex { get { return _zIndex; } set { _zIndex = value; } }


    }
}
