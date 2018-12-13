using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
[Serializable]
    class Web
    {
        List<Layer> web = new List<Layer>();             // Список слоев в сети
        List<double> ageErrorList = new List<double>();  // Ошибки по эпохам
        List<double[]> values=new List<double[]>();      // Конечные результаты по эпохам
        
        int indexLayer;
        int indexNeuron;
        int indexWeight;
        double preWeight;

        /* создание сети с конфигурируемыми параметрами.
         * на вход получаем количетсво входных параметров,
         * количество нейронов в слое и количество слоев
         */
        public Web createWeb(int param, int capNeuron, int capLayers, Random rnd)
        {
            this.web.Add(new Layer(param));
            for (int i = 0; i < capLayers; i++)
            {
                this.web.Add(new Layer(capNeuron, web[i], rnd));
            }
            this.web.Add(new Layer(web[capLayers],rnd));
            return this;
        }

        /* обучение сети.
         * пока ошибка не станет очень маленькой:
             * рандомим слой, нейрон и изменяемый вес.
             * сохраняем вес.
             * меняем в выбранном нейроне вес на рандомный.
             * запускаем эпоху.
             * если не успешна, возвращаем вес назад.
         */
        public string learnWeb(List<double[]> l, Random rnd, double fageCount)
        {
            do
            {
                indexLayer = this.getIndexChangedLayer(rnd);
                indexNeuron = this.web[indexLayer].getIndexChangedNeuron(rnd);
                indexWeight = this.web[indexLayer].getList()[indexNeuron].getIndexChangedWeight(rnd);
                preWeight = this.web[indexLayer].getList()[indexNeuron].getListWeight()[indexWeight].getWeight();

                this.web[indexLayer].getList()[indexNeuron].getListWeight()[indexWeight].setWeight((rnd.NextDouble() * (1 + 1) + -1));
                if (!ageWeb(l)) this.web[indexLayer].getList()[indexNeuron].getListWeight()[indexWeight].setWeight(preWeight);
            } while (ageErrorList.Count() < fageCount);

            return "done";
        }

        public double testWeb(double[] param)
        {
            this.changeFirstLayer(param);
            return this.getResult();
        }

        /* эпоха обучения сети.
         * получаем лист начальных параметров для обучения.
         * изменяем входные параметры первого слоя.
         * считаем ошибку для каждой итерации.
         * заполняем массив ошибок по эпохам если ошибка меньше последней.
         */
        private bool ageWeb(List<double[]> l)
        {
            double[] mError = new double[l.Count];
            double[] v = new double[l.Count];
            for (int i = 0; i < l.Count; i++)
            {
                this.changeFirstLayer(l[i]);
                mError[i] = this.getIterError(l[i]);
                v[i] = this.web[web.Count - 1].getList()[0].getValue();
            }
            if (ageErrorList.Capacity == 0 || ageErrorList.Last() > mError.Average())
            {
                this.values.Add(v);
                this.ageErrorList.Add(mError.Average());
                return true;
            }
            return false;
        }

        private int getIndexChangedLayer(Random rnd)
        {
            return rnd.Next(1, this.web.Count);
        }

        private void changeFirstLayer(double[] l)
        {
            this.web[0].changeFirstLayer(l);
        }

        private double getIterError(double[] l)
        {
            double output;
            output = this.web[web.Count - 1].getList()[0].getValue();
            
            return Math.Pow((output - l[7]), 2)/2;
        }
        
        private double getResult()
        {
            double output;
            output = this.web[web.Count - 1].getList()[0].getValue();
            return output;
        }
        
        private List<Layer> getListLayers()
        {
            return this.web;
        }

        public List<double> getErrorList()
        {
            return this.ageErrorList;
        }

        public List<double[]> getFinalValues()
        {
            return this.values;
        }
    }
}
