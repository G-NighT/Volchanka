using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volchanka
{
    [Serializable]
    public class CParam
    {
        public double _a, _b, _c, _d, _e, _f, _g, _res;
        public CParam(double aa, double bb, double cc, double dd, double ee, double ff, double gg, double ress)
        {
            _a = aa;
            _b = bb;
            _c = cc;
            _d = dd;
            _e = ee;
            _f = ff;
            _g = gg;
            _res = ress;
        }
    }
}
