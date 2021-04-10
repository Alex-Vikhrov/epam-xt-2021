using System;
using System.Collections.Generic;
using System.Text;

namespace _3._3._3._PIZZA_TIME
{
    class PersonnelCollection/*: IEnumerable */
    {
        #region List

        public void UUsePersonnelCollection()
        {
            List<Personnel> personnels = new List<Personnel>();
            personnels.Add(new Personnel("Olga", "Nesterova", 24));
            personnels.Add(new Personnel("Maxim", "Smirnov", 20));
            personnels.Add(new Personnel("Viktoria", "Filipova", 24));

            foreach(Personnel p in personnels)
            {
                Console.WriteLine(p);
            }
        }
        #endregion
    }
}
