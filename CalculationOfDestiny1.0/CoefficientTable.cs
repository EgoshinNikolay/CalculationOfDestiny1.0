using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfDensityBeta
{

    /// <summary>
    /// Искусственно созданный класс для упращения, в реальных программах лучше хранить значения таблицы либо в БД, либо в файлах.
    /// </summary>
    class CoefficientTable
    {

   
        //Структура строк таблицы
        public struct RowCoeff
        {
            public string Name;       //Предпологаемое название жидкости
            public double RangBegin;  //Начало диапазона плотности
            public double RangEnd;    //Конец диапазона плотности
            public double K0;         //Коэффицент К0
            public double K1;         //Коэффицент К1
            public double K2;         //Коэффицент К3
            public RowCoeff(string name, double rangBegin, double rangEnd, double k0, double k1, double k2)  //конструктор для создания  строки.
            {
                Name = name;
                RangBegin = rangBegin;
                RangEnd = rangEnd;
                K0 = k0;
                K1 = k1;
                K2 = k2;
            }
        }

        //Инициализация таблицы при создании.
        private RowCoeff[] CoeffTable = { new RowCoeff("Нефть", 611.2, 1163.8, 613.9723, 0, 0),
        new RowCoeff("Нефтепродукт", 611.2, 770.9, 346.4228, 0.43884, 0),
        new RowCoeff("Нефтепродукт", 770.9, 778, 2690.7440, 0, -0.0033762),
        new RowCoeff("Нефтепродукт", 788, 838.7, 594.5418, 0, 0),
        new RowCoeff("Нефтепродукт", 838.7, 1163.9, 186.9696, 0.4862, 0),
        new RowCoeff("Масло", 801.3, 1163.9, 0, 0.6278, 0)
        };

        // Метод возвращает строку с нужными коэффицентами в зависимости от типа жидкости и значения плотности
        public RowCoeff GetCoeff(double destiny, string typeLiquid)
        {
            foreach (RowCoeff row in CoeffTable)   //проходим по таблицу и ищем строку подходящую по типу жидкости и плотности
            {
                if ((row.Name == typeLiquid) && (row.RangBegin <= destiny) && (row.RangEnd > destiny))
                    return row;
            }

            foreach (RowCoeff row in CoeffTable)  //если не находим строку, просто ищем подходящую по плотности (в случае если плотность не соотвествует типу жидкости)
            {
                if ((row.RangBegin <= destiny) && (row.RangEnd > destiny))
                    return row;
            }
           throw new InputException();  //если измеренная плотность не входит не в один диапазон вызываем ошибку
      
        }


    }
}
