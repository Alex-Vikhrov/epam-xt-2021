using System;
using System.Collections.Generic;
using System.Text;

namespace _3._3._3._PIZZA_TIME
{
    class PersonnelCollection
    {
        #region List

        public void UUsePersonnelCollection()
        {
            List<Personnel> personnels = new List<Personnel>
            {
                new Personnel("Olga", "Nesterova", 24),
                new Personnel("Maxim", "Smirnov", 20),
                new Personnel("Viktoria", "Filipova", 24),
                new Waiter ("Olga", "Ejak", 23)
            };

            foreach (Personnel p in personnels)
            {
                p.ShowMessage();
            }
        }
        #endregion
    }
}
