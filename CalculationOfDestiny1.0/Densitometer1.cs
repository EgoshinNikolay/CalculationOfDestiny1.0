using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfDensityBeta
{
    
    /// <summary>
    /// Плотномер (преобразователь плотности жидкости) с пределами допустимой погрешности измерения от 0,5 до 1,0 кг/м3
    /// Является частным случаем плотномера с погрешностью не более 0,5 кг/м3 и поэтому наследуется от этого класса.
    /// </summary>
    class Densitometer1:Densitometer05
    {
        const int ACCURACY = 1;
        public Densitometer1(double density, double pressure, double temp, string typeLiquid) :base(density, pressure, temp, typeLiquid)
        {

        }
        public override int GetAccuracy() { return ACCURACY; }
    }
}
 