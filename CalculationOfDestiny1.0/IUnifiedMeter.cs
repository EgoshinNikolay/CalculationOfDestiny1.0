using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfDensityBeta
{

    /// <summary>
    /// Интерфейс приборов, с показаниями которых можно проводить расчет плотности.
    /// </summary>
    interface IUnifiedMeter
    {
        double GetDensity(); //Метод возвращает плотность, измеренную прибором.
        double GetPressure(); //Метод возвращает избыточное давление, при котором измерялась плотность.
        double GetTemp(); //Метод возвращает температуру, при которой измерялась плотность.
        int GetAccuracy();  //Метод возвращает точность прибора
        string GetTypeLiquid(); //Метод возвращает предпологаемый тип жидкости, плотность которого измерялась. (Нефть, Нефтепродукт, Масла)
    }
}
