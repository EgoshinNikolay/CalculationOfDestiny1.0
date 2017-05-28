using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfDesnsityBeta
{

    /// <summary>
    /// Плотномер (преобразователь плотности жидкости) с пределами допустимой погрешности измерения не более 0,5 кг/м3
    /// </summary>
    class Densitometer05:IUnifiedMeter
    {

        const int ACCURACY= 2;
        double _temp;   //Температура измерения
        double _pressure; // Избыточное давление измерения
        double _density;   //Плотность измерения
        string _typeLiquid;   //Предпологаемый измеряемый тип жидкости (Нефть, Нефтепродукт, Масла)

        public Densitometer05(double density, double pressure, double temp, string typeLiquid)   //Конструктор инициализирует измеренные параметры
        {
            _temp = temp;
            _pressure = pressure;
            _density = density;
            _typeLiquid = typeLiquid;
        }

        //Реализуем методы, описанные в интерфейсе IUnifiedMeter    
        public virtual double GetDensity() { return _density; }
        public double GetPressure() { return _pressure; }
        public double GetTemp() { return _temp; }
        public virtual int GetAccuracy() { return ACCURACY; }
        public string GetTypeLiquid() { return _typeLiquid; }

        ////Защищенные свойства для инициализации полей в классах потомках.
        //protected double Temp { set => _temp = value; }
        //protected double Pressure { set => _temp = value; }
        //protected double Destiny { set => _temp = value; }
        //protected double TypeLiquid { set => _temp = value; }
    }
}
