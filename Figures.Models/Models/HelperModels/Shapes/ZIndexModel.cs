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

        public int ZIndex => _zIndex;

        public void SetZIndex(int zIndex)
        {
            _zIndex = zIndex;
        }
    }
}
