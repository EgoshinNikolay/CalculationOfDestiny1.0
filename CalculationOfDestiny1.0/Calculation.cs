using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationOfDensityBeta
{


    /// <summary>
    /// Класс где происходит перерасчет плотности
    /// </summary>
    class Calculation
    {

        double _temp;     //Температура при которой требуется рассчитать плотность
        double _pressure; //Избыточное давление при котором требуется рассчитать плотность

        const int GAMA_ACCURACY = 6;
        const int VITA_ACCURACY = 6;


        const double TEMP_MAX = 150.0;
        const double TEMP_MIN = -50.0;

        const double PRESSURE_MAX = 10.34;
        const double PRESSURE_MIN = 0.0;


        private readonly IUnifiedMeter _meter;   //Счетчик плотности, на основании данных которого происходит перерасчет
        private readonly CoefficientTable _coeffTable;  //Таблица коэффицентов для определения коэффицента объемного расширения при температуре 15С.
        public Calculation(IUnifiedMeter meter, CoefficientTable coeffTable, double pressure, double temp)
        {
            //Проверяем входящие параметры подходят для использования данного метода расчета плотности
            if ((meter.GetTemp() <= TEMP_MAX) && (meter.GetTemp() >= TEMP_MIN)&&(meter.GetPressure() <= PRESSURE_MAX) && (meter.GetPressure() >= PRESSURE_MIN))
                _meter = meter;
            else
                throw new InputException();

            _coeffTable = coeffTable;
            Pressure = pressure;
            Temp = temp;
        }

        //Свойство устанавливает и получает температуру для расчетов, проверяя подят ли параметры для метода расчета плотности
        public double Temp
        {
            get
            {
                return _temp;
            }
            private set
            {
                if ((value <= TEMP_MAX) && (value >= TEMP_MIN))
                    _temp = value;
                else
                    throw new InputException();
            }

        }


        //Свойство устанавливает и получает избыточное давление для расчетов, проверяя подят ли параметры для метода расчета плотности
        public double Pressure
        {
            get
            {
                return _pressure;
            }
            private set
            {
                if ((value <= PRESSURE_MAX) && (value >= PRESSURE_MIN))
                    _pressure = value;
                else
                    throw new InputException();
            }

        }

        public double GetDensity()
        {
            double po15 = DirectInputs();
            double vita15 = GetVita15(po15, _meter.GetTypeLiquid());
            double gama = GetGama(po15, _temp);
            double P = _pressure;
            double t = _temp;
            double density;
            
            if ((P==0) && (t==20))  //Расчитываем плотность при 20 градусах и избыточном давлении равном 0.
            {
                density = po15 * Math.Exp(-5 * vita15 * (1 + 4 * vita15));
            }
            else //расчет плотности во всех остальных случаях
            {
                density = po15 * Math.Exp(-vita15 * (t - 15) * (1 + 0.8 * vita15 * (t - 15))) / (1 - gama * P);
            }
            return Math.Round(density, _meter.GetAccuracy());//, MidpointRounding.AwayFromZero);
        }

        //Метод прямых подстановок
        private double DirectInputs()
        {
            double vita15 = 0; 
            double ro15 = 0;
            double ro15prev = 0;
            double ro15prevprev = -1;

            double gama = 0;
            //  double test;
            ro15 = _meter.GetDensity(); //Подставляем измеренную прибором плотность
            while (Math.Abs(ro15 - ro15prev) > 0.01)  //Повторяем метод прямых подстоновок пока  рассчитанная плотность при 15С не будет менятся более чем на 0,01 кг/м3
            {
                if (ro15==ro15prevprev) //Дополнительная проверка, чтоб исключить зацикливание если изменение плотности не достигает значения ниже 0,01 кг/м3.
                {
                    return ro15prev;
                }
                else
                {
                    ro15prevprev = ro15prev;
                }
                ro15prev = ro15;  //Сохраняем предыдущее значение плотности
                if (_meter.GetPressure() == 0)  //Если избычтоное давление при измерении плотности прибором равно 0
                {
                    vita15 = GetVita15(ro15, _meter.GetTypeLiquid()); //находим коэффицент объемного расширения
                    ro15 = GetRo15(_meter.GetDensity(),_meter.GetTemp(),vita15); // находим плотности при 15С в приблежении


                }
                else  //Если избычтоное давление при измерении плотности прибором не равно 0
                {
                    vita15 = GetVita15(ro15, _meter.GetTypeLiquid());//находим коэффицент объемного расширения (плотность каждый раз подставляем новую, найденную в прошлой итерации)
                    gama = GetGama(ro15,_meter.GetTemp());//находим коэффицент сжимаемости (плотность каждый раз подставляем новую, найденную в прошлой итерации)
                    ro15 = GetRo15(_meter.GetDensity(),_meter.GetPressure(),_meter.GetTemp(), vita15, gama);


                    
                }

            }
            return ro15;  //Значение плотности при 15С, полученное в последенем приближении.

        }

        //Метод возвращает плотности при 15 градусах в приблежении ( случай, когда есть избыточное давление)
        private double GetRo15( double destiny, double pressure, double temp, double vita15, double gama)  
        {
            double rot = destiny; //Измеренная плотность
            double P = pressure;  //Избыточное давление, при котором измерялась плотность
            double t = temp;  //Температура, при которой измерялась плотность
            double ro15;  //Плотность при 15 градусах в приблежении 

            ro15 = rot / Math.Exp(-vita15 * (t - 15) * (1 + 0.8 * vita15 * (t - 15))) * (1 - gama * P);
            return Math.Round(ro15, _meter.GetAccuracy(), MidpointRounding.AwayFromZero);
        }

        //Метод возвращает плотности при 15 градусах в приблежении ( случай, когда избыточное давление равно 0)
        private double GetRo15(double destiny, double temp, double vita15)
        {
            double rot = destiny; //Измеренная плотность
            double t = temp;  //Температура, при которой измерялась плотность
            double ro15;  //Плотность при 15 градусах в приблежении 

            ro15 = rot / Math.Exp(-vita15 * (t - 15) * (1 + 0.8 * vita15 * (t - 15)));
            return Math.Round(ro15, _meter.GetAccuracy(), MidpointRounding.AwayFromZero);
        }

        //Метод возвращает коэффицент объемного расширения нефти, нефтепродуктов, масел при температуре 15С
        private double GetVita15(double destiny, string typeLiquid)
        {
            CoefficientTable.RowCoeff row = _coeffTable.GetCoeff(destiny, typeLiquid); // Возвращает строку с коэффицентами для расчета коэфф. объемного расширения
            double k0 = row.K0;
            double k1 = row.K1;
            double k2 = row.K2;
            double vita15;
            double ro15 = destiny;
            vita15 = (k0 + k1 * ro15) / Math.Pow(ro15, 2) + k2;
            return Math.Round(vita15, VITA_ACCURACY, MidpointRounding.AwayFromZero);
        }
        //Метод возвращает коэффицент объемного расширения нефти, нефтепродуктов, масел при температуре 15С (Частный случай, когда избыточное давление равно 0)
        private double GetGama( double destiny, double temp)
        {
            double ro15 = destiny;
            double t = temp;
            double gama;
            gama = Math.Pow(10, -3) * Math.Exp(-1.62080 + 0.00021592 * t + 0.87096 * Math.Pow(10, 6) / Math.Pow(ro15, 2) + 4.2092 * t * Math.Pow(10, 3) / Math.Pow(ro15, 2));
            return Math.Round(gama, GAMA_ACCURACY, MidpointRounding.AwayFromZero);
        }
    }
}
