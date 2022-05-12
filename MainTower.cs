using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class MainTower : Entity
    {
        const float speed = 8;
        const int cooldownFrames = 7;
        int cooldownRemaining = 0;
        static Random rand = new Random();

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

            var aim = Input.GetAimDirection();
            if (aim.LengthSquared() > 0 && cooldownRemaining <= 0)
            {
                cooldownRemaining = cooldownFrames;
                float aimAngle = aim.ToAngle();
                Quaternion aimQuat = Quaternion.CreateFromYawPitchRoll(0, 0, aimAngle);
                float nxtFloat = (float)rand.NextDouble() * (0.04f - -0.04f) + -0.04f;

                float randomSpread = nxtFloat + nxtFloat;
                float randAngle = aimAngle + randomSpread;

                Vector2 vel = (11f * new Vector2((float)Math.Cos(randAngle), (float)Math.Sin(randAngle)));
                if (Input.WasMouseClicked()) {
                    Vector2 offset = Vector2.Transform(new Vector2(25, -8), aimQuat);
                    EntityManager.Add(new Bullet(Position + offset, vel));

                    offset = Vector2.Transform(new Vector2(25, 8), aimQuat);
                    EntityManager.Add(new Bullet(Position + offset, vel));
                }
            }

            if (cooldownRemaining > 0)
                cooldownRemaining--;
        }
    }
}
