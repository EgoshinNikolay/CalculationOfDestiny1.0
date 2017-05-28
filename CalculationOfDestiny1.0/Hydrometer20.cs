using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfDesnsityBeta
{
    /// <summary>
    /// Ареометр, градуированный при температуре 20С.
    /// Является частным случаем плотномера с погрешностью не более 0,5 кг/м3 и поэтому наследуется от этого класса.
    /// </summary>
    class Hydrometer20 : Densitometer05
    {
        const int ACCURACY = 1; //Мнимая точность прибора, на самом деле определяет число знаков после запятой. (для упрощения)
        public Hydrometer20(double density, double pressure, double temp, string typeLiquid) : base(density, pressure, temp, typeLiquid)
        {

        }
        public override double GetDensity()
        {
            double pt; //Нормализованная плотность ( с учетом температурного расширения стекла)
            double K;  //Коэффицент расширения стекла
            double t = GetTemp();  //Температура при которой измерялась плотность
            double par = base.GetDensity();//Плотность, измеренная ареометром

            K = 1 - 0.000025 * (t - 20);
            pt = par * Math.Round(K,4);
            return Math.Round(pt, ACCURACY, MidpointRounding.AwayFromZero);
        }
        public override int GetAccuracy() { return ACCURACY; }
    }
}
