using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class MainTower : Entity
    {
        const float speed = 8;

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
            Velocity = speed * Input.GetMovementDirection();
            Position += Velocity;
            Position = Vector2.Clamp(Position, Size / 2, Game1.ScreenSize - Size / 2);

            if (Velocity.LengthSquared() > 0)
                Orientation = Velocity.ToAngle();
        }
    }
}
