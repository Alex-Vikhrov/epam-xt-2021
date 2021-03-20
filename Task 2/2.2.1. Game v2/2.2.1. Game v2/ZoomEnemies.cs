using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2._1._Game_v2
{
    class ZoomEnemies:Enemies
    {
        public new void SetInitialPosition()

        {
            base.SetInitialPosition();
            Console.WriteLine("Zoom - враг в начальной позиции");
            this.x = 20;
            this.y = 20;
        }
    }
}
