using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Obsolete("Esta clase esta obsoleta")]
    public class Marco : Ventana
    {
        string material;

        public Marco(int pAlto, int pAncho, string pMaterial) : base(pAlto, pAncho)
        {
           material = pMaterial;
        }

        public override int area(int pAlto, int pAncho)
        {
            return pAlto * pAncho;
        }
    }
}
    
