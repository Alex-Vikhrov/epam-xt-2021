using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3._3._3._PIZZA_TIME
{
    class PersonnelCollection: IEnumerable 
    {
        private ArrayList arPersonnel = new ArrayList();

        //Приведение для вызывающего кода 
        public Personnel GetPersonnel(int pos) => (Personnel)arPersonnel[pos];

        // Вставка объектов Personnel
        public void AddPersonnel(Personnel p)
        {
            arPersonnel.Add(p);
        } 

        public void ClearPersonnel()
        {
            arPersonnel.Clear();
        }

        public int Count => arPersonnel.Count;

        // перечисление
        IEnumerator IEnumerable.GetEnumerator() => arPersonnel.GetEnumerator();
        
        public void UsePersonnelCollection()
        {
            PersonnelCollection personnel = new PersonnelCollection();
            personnel.AddPersonnel(new Personnel("Olga", "Nesterova", 24));
            personnel.AddPersonnel(new Personnel("Maxim", "Smirnov", 20));
            personnel.AddPersonnel(new Personnel("Viktoria", "Filipova", 24));

            foreach(Personnel p in personnel)
            {
                Console.WriteLine(p);
            }
        }

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
