using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
    [Serializable]
    class Neuron
    {
        List<Weight> weight = new List<Weight>();    // Список всех связей нейрона с предыдущим слоем
        double outputValue;                          // Выходное значение нейрона

        /* создание нейрона первого слоя.
         * активационной функции нет, весов тоже
         */
        public Neuron()
        {

        }

        /* создание нейрона последующих слоев.
         * получает предыдущий слой,
         * отправляет его в Weight и заполняет ссылки на нейроны предыдущего слоя и рандомно веса,
         * активационной формулой устанавливается выходное значение нейрона.
         */
        public Neuron(Layer preLayer, Random rnd)
        {
            foreach (Neuron neuron in preLayer.getList())
            {
                weight.Add(new Weight(neuron, (rnd.NextDouble() * (1 +1) + -1)));
            }
        }

        public void learnUnchange(int i, double w)
        {
            this.weight[i].setWeight(w);
        }

        public int getIndexChangedWeight(Random rnd)
        {
            return rnd.Next(0, this.weight.Count);
        }

        // Активационная формула
        public double getValue()
        {
            if (this.weight.Count>0)
            {
                return getActiv();
            }
            else return this.getOutputValue();
        }

        private double getActiv()
        {
            double summ = 0.0;
            foreach (Weight asd in weight)
            {
                summ = summ + asd.getWeight() * asd.getOutput().getValue();
            }
            //Parallel.ForEach(weight, asd =>
            //{
            //    summ = summ + asd.getWeight() * asd.getOutput().getValue();
            //});
            //return summ;
            return 2.0 / (1.0 + Math.Exp(-summ)) - 0.5;
        }

        public double getOutputValue()
        {
            return this.outputValue;
        }

        public void setValue(double val)
        {
            this.outputValue = val;
        }

        public List<Weight> getListWeight()
        {
            return this.weight;
        }
    }
}