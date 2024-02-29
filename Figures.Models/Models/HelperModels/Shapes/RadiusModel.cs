using Figures.Models.Enums;

namespace Figures.Models.Models.HelperModels.Shapes
{
    public class RadiusModel
    {
        private RadiusType _radiusType;
        public RadiusModel(RadiusType radiusType)
        {

            _radiusType = radiusType;

        }
        public RadiusType RadiusType => _radiusType;

        public void SetRadiusType(RadiusType radiusType)
        {
            _radiusType = radiusType;
        }
    }
}
