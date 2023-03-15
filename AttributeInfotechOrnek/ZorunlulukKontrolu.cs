using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeInfotechOrnek
{
    public static class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakOrnek)
        {
            Type dogrulamacakTur = dogrulanacakOrnek.GetType();
            FieldInfo[] dogrulanacakTurAlanlari = dogrulamacakTur.GetFields(
                                                  BindingFlags.Public |
                                                  BindingFlags.Instance);
            foreach (FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunAlanAttribute), true);

                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakOrnek) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
