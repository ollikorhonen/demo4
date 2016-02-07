using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caraplication
{
    class car
    {
        // field variables
        private readonly int maxSpeed = 200;
        private readonly double maxHeight = 4.5;


        private int speed;
        private double height;

        // height property
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("too small height");
                    height = 1;
                }
                else if (value > maxHeight)
                {
                    Console.WriteLine("too hight");
                    height = maxHeight;
                }
                else
                {
                    height = value;
                }
            }
        }
        // property variable
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed - set to max");
                    speed = maxSpeed;
                }
            }
        }

    }
}
