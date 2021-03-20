using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2._1._Game_v2
{
    class GameFlash
    {
        private Map _currentMap;
        public GameFlash(Map map)
        {
            _currentMap = map;
        }

        public void Initialize()
        {
            _currentMap.Prepare();
        }
    }
}
