using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
    [Serializable]
    class Layer
    {
        List<Neuron> layer = new List<Neuron>();  // Список нейронов в слое
        
        // Создание первого слоя
        public Layer(int cap)
        {
            for (int i = 0; i < cap; i++)
            {
                layer.Add(new Neuron());
            }
        }

        /* Создание скрытых слоев.
         * int capNeuron - количество нейронов на слое в конфигурируемой сети
         * Layer preLayer - предыдущий слой
         */
        public Layer(int capNeuron, Layer preLayer, Random rnd)
        {
            for (int i = 0; i < capNeuron; i++)
            {
                layer.Add(new Neuron(preLayer,rnd));
            }
        }

        // Создание последнего слоя
        public Layer(Layer preLayer, Random rnd)
        {
            layer.Add(new Neuron(preLayer, rnd));
        }

        public int getIndexChangedNeuron(Random rnd)
        {
            return rnd.Next(0, this.layer.Count);
        }

        public void changeFirstLayer(double[] param)
        {
            for (int i = 0; i < 7; i++)
            {
                this.layer[i].setValue(param[i]);
            }
            //return this;
        }

        public List<Neuron> getList()
        {
            return this.layer;
        }
    }
}
