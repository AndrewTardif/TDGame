using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class Tower : Entity
    {
        private static Tower instance;
        public static Tower Instance
        {
            get
            {
                if (instance == null)
                    instance = new Tower();

                return instance;
            }
        }

        private Tower()
        {
            image = Art.Tower;
            Position = Game1.ScreenSize / 2; //temporary position
            Radius = 10;
        }

        public override void Update()
        {
            // tower logic goes here
        }
    }
}
