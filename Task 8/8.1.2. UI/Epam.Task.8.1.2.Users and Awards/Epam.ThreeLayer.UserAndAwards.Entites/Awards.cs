using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserAndAwards.Entites
{
    public class Awards
    {
        public Awards(string name, Guid id)
        {
            Name = name;
            ID = id;
        }

        public string Name { get; private set; }

        public Guid ID { get; }

        public void EditName(string newName)
        {
            if (newName == null)
            {
                throw new ArgumentException("str", "Name string cannot be null!");
            }

            Name = newName;
        }
    }
}
