using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
    [Serializable]
    public class CSinapsy
    {
        public double Weight
        {
            get;
            set;
        }
        public CNeuron Connection
        {
            get;
            set;
        }
    }
}
