using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependencyServiceOrnek.Servisler
{
    public interface IMetniSeseCevirmeServisi
    {
        void SeseDonustur(string metin);
    }
}
