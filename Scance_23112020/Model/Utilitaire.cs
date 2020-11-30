using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    class Utilitaire
    {
        public static int retourNouvelleId<T>(List<T> uneListe)
        {
            int x = 0;

            for (int i = 0; i < uneListe.Count; i++)
            {
                PropertyInfo property = uneListe.ElementAt(i).GetType().GetProperty("Id");
                if (Convert.ToInt32(property.GetValue(uneListe.ElementAt(i))) == x) x++;
            }
            if (x == uneListe.Count) x++;
            return x;
        }
    }
}
