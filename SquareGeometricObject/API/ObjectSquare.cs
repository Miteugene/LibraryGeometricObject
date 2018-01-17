using SquareGeometricObject;
using SquareGeometricObject.GeometricInterface;

namespace SquareGeometricObject.API
{
    public class ObjectSquare : InterfaceObjectSquare
    {
        public double GetSquare(SimpleObject obj)
        {
            return obj.GetSquare();
        }
    }
}
