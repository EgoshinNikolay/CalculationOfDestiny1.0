using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationOfDensityBeta
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            try //Для упращения, все исключения связанные с неверным вводом значений плотности, избыточного, температуры обрабатываются в одном.
            {
            CoefficientTable table = new CoefficientTable();

            }
            catch(InputException)
            {
                MessageBox.Show("Не верный диапазон плотности или давления или температуры");
            }

        }

      

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CoefficientTable table = new CoefficientTable();
            IUnifiedMeter meter = null;
            try
            {
                switch (cbMeter.Text)
                {
                    case "Плотномер <0,5":
                        meter = new Densitometer05(Convert.ToDouble(tbDensity.Text), Convert.ToDouble(tbPressure.Text), Convert.ToDouble(tbTemp.Text), cbTypeLiquid.Text);
                        break;
                    case "Плотномер 0,5-1":
                        meter = new Densitometer1(Convert.ToDouble(tbDensity.Text), Convert.ToDouble(tbPressure.Text), Convert.ToDouble(tbTemp.Text), cbTypeLiquid.Text);
                        break;
                    case "Ареометр 15С":
                        meter = new Hydrometer15(Convert.ToDouble(tbDensity.Text), Convert.ToDouble(tbPressure.Text), Convert.ToDouble(tbTemp.Text), cbTypeLiquid.Text);
                        break;
                    case "Ареометр 20С":
                        meter = new Hydrometer20(Convert.ToDouble(tbDensity.Text), Convert.ToDouble(tbPressure.Text), Convert.ToDouble(tbTemp.Text), cbTypeLiquid.Text);
                        break;
                    default:
                        MessageBox.Show("Не выбран прибор");
                        return;

                }
            }
            catch
            {
                MessageBox.Show("Вы ввели недопустимые исходные значения");
                return;
            }
            try
            {
                Calculation calc = new Calculation(meter, table, Convert.ToDouble(tbNewPressure.Text), Convert.ToDouble(tbNewTemp.Text));
                lbResult.Text = String.Format("Результат расчета плотности {0} при температуре  {1}°С и избыточном давлении {2} МПа \n с учетом округления до {3} знака после запятой равен {4} кг/м3.", meter.GetTypeLiquid(), calc.Temp, calc.Pressure, meter.GetAccuracy(), calc.GetDensity());

            }

            catch (InputException ex)
            {
                MessageBox.Show("Введенные значения плотности, избыточного давления или температуры не могут использоваться для вычисления плотности данным методом");
                return;
            }


              }

     
    }
}
