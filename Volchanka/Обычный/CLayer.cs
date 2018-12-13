using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
    [Serializable]
    public class CLayer
    {
        public CLayer()
        {
            NeuronsMass = new List<CNeuron>();
        }
        public List<CNeuron> NeuronsMass
        {
            get;
            set;
        }
    }
}
