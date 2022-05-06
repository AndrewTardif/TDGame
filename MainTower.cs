using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class MainTower : Entity
    {
        private static MainTower instance;
        public static MainTower Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainTower();

                return instance;
            }
        }

        private MainTower()
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
