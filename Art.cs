using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    static class Art
    {
        public static Texture2D Tower { get; private set; }
        public static Texture2D Seeker { get; private set; }
        public static Texture2D Wanderer { get; private set; }
        public static Texture2D Bullet { get; private set; }
        public static Texture2D Pointer { get; private set; }

        public static Texture2D wallSprite { get; private set; }
        public static Texture2D wallCornerLeftSprite { get; private set; }
        public static Texture2D wallCornerRightSprite { get; private set; }
        public static Texture2D chestSprite { get; private set; }


        public static void Load(ContentManager content)
        {
            Tower = content.Load<Texture2D>("wall_mid");
            Seeker = content.Load<Texture2D>("wall_mid");
            Wanderer = content.Load<Texture2D>("wall_mid");
            Bullet = content.Load<Texture2D>("wall_mid");
            Pointer = content.Load<Texture2D>("wall_mid");

            wallSprite = content.Load<Texture2D>("wall_mid");
            wallCornerLeftSprite = content.Load<Texture2D>("wall_corner_left");
            wallCornerRightSprite = content.Load<Texture2D>("wall_corner_right");
            chestSprite = content.Load<Texture2D>("chest_empty_open_anim_f0");
        }
    }
}
