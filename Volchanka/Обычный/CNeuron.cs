using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
    [Serializable]
    public class CNeuron
    {
        public List<CSinapsy> SinapsysMass
        {
            get;
            set;
        }
        public double OutputValue
        {
            get;
            set;
        }
        public void Calculation()
        {
            double result = 0;
            foreach (var temp in SinapsysMass)
            {
                result += temp.Weight * temp.Connection.OutputValue;
            }
            double a = 0.5; // Наклон сигмоидальной функции активации
            OutputValue = Math.Tanh(result / a);
        }
    }
}
