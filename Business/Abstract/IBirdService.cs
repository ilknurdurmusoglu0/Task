
using Entities;

namespace Business.Abstract
{
    public interface IBirdService
    {
        Bird Size();
        Bird Color();
        Bird Feature(string feature);
        Bird Leg(int leg);
    }
}
