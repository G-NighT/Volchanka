using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
    [Serializable]
    public class CNetwork
    {
        private Random rnd;
        private int NumInputParams = 7;     // Число входных параметров
        private int NumOutputParams = 1;    // Число выходных параметров

        private int NumLayerOld;            // Число старых слоёв
        private int NumNeuronOld;           // Число старых нейронов
        private int NumSinapsyOld;          // Число старых связей
        private double OutputValueOld;      // Старое выходное значение

        public List<CLayer> LayersMass      // Лист слоёв
        {
            get;
            set;
        }
        public List<double> ErrorLst        // Лист ошибок
        {
            get;
            set;
        }

        public CNetwork() { }               // Конструктор для сериализации

        // Создание сети
        public CNetwork(int NLayer, int NNeuron)
        {
            // Инициализация компонентов сети
            ErrorLst   = new List<double>();
            rnd        = new Random();
            LayersMass = new List<CLayer>();

            // Входной слой
            CLayer FirstLayer = new CLayer();
            for (int i = 0; i < NumInputParams; i++)
            {
                FirstLayer.NeuronsMass.Add(new CNeuron());
            }
            LayersMass.Add(FirstLayer);

            // Cкрытые слои
            for (int i = 0; i < NLayer; i++)
            {
                CLayer temp = new CLayer();
                for (int j = 0; j < NNeuron; j++)
                {
                    temp.NeuronsMass.Add(new CNeuron());
                }
                LayersMass.Add(temp);
            }

            // Выходной слой
            CLayer LastLayer = new CLayer();
            for (int i = 0; i < NumOutputParams; i++)
            {
                LastLayer.NeuronsMass.Add(new CNeuron());
            }
            LayersMass.Add(LastLayer);

            // Создание связей между слоями нейронов
            for (int i = 1; i < LayersMass.Count; i++)
            {
                foreach (var X1 in LayersMass[i].NeuronsMass)
                {
                    X1.SinapsysMass = new List<CSinapsy>();
                    foreach (var X2 in LayersMass[i - 1].NeuronsMass)
                    {
                        CSinapsy s = new CSinapsy();
                        s.Weight = rnd.NextDouble() * 0.1 - 0.05;
                        s.Connection = X2;
                        X1.SinapsysMass.Add(s);
                    }
                }
            }
        }

        // Вычисление выходного значения. Передаем сюда "строку" выходных параметров
        public List<double> GetCalculation(CParam lst)
        {
            // Присваиваем входные значения нейронов
            LayersMass[0].NeuronsMass[0].OutputValue = lst._a;
            LayersMass[0].NeuronsMass[1].OutputValue = lst._b;
            LayersMass[0].NeuronsMass[2].OutputValue = lst._c;
            LayersMass[0].NeuronsMass[3].OutputValue = lst._d;
            LayersMass[0].NeuronsMass[4].OutputValue = lst._e;
            LayersMass[0].NeuronsMass[5].OutputValue = lst._f;
            LayersMass[0].NeuronsMass[6].OutputValue = lst._g;

            // Пересчитываем выходные значения остальным нейронам
            for (int i = 1; i < LayersMass.Count; i++)
            {
                //Parallel.ForEach(LayersMass[i].NeuronsMass, el => el.Calculation());
                foreach (var temp in LayersMass[i].NeuronsMass)
                {
                    temp.Calculation();
                }
            }

            // Возвращаем значение выходного параметра
            var res_lst = LayersMass.LastOrDefault().NeuronsMass.Select(o => o.OutputValue).ToList();

            return res_lst;
        }

        // Обучение нейронной сети
        public void Education()
        {
            NumLayerOld = rnd.Next(1, LayersMass.Count);
            NumNeuronOld = rnd.Next(0, LayersMass[NumLayerOld].NeuronsMass.Count);
            NumSinapsyOld = rnd.Next(0, LayersMass[NumLayerOld].NeuronsMass[NumNeuronOld].SinapsysMass.Count);
            OutputValueOld = LayersMass[NumLayerOld].NeuronsMass[NumNeuronOld].SinapsysMass[NumSinapsyOld].Weight;

            LayersMass[NumLayerOld].NeuronsMass[NumNeuronOld].SinapsysMass[NumSinapsyOld].Weight += rnd.NextDouble() * 0.1 - 0.05;
        }

        // Откат
        public void Recoil()
        {
            LayersMass[NumLayerOld].NeuronsMass[NumNeuronOld].SinapsysMass[NumSinapsyOld].Weight = OutputValueOld;
        }
    }
}
