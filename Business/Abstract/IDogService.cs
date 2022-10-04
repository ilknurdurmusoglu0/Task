using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDogService
    {
        Dog Size();
        Dog Color();
        Dog Feature(string feature);
        Dog Leg(int leg);
    }
}
