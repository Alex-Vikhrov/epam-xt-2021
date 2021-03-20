using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2._1._Game_v2
{
    class Player
    {
        private int _speed;
        private int _height;
        private int _force;
        protected int x;
        protected int y;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                _height = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            { 
                if (value >= 500)
                _speed = value;
            }
        }

        public int Force
        {
            get
            {
                return _force;
            }
            set
            {
                if (value >= 100)
                    _force = value;
            }
        }

        public void Run()
        {
            Console.WriteLine("Flach Побежал");
        }

        public void Shot()
        {

        }

        public void SetInitialPosition()

        {
            Console.WriteLine("Flach в начальной позиции");
            x = 0;
            y = 0;
        }
    }
}
