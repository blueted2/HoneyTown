﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.TextureAtlases;
using Microsoft.Xna.Framework.Content;

namespace HarvestMoon.Entities.General
{
    public class NPC : Interactable
    {

        public enum NPCMenu
        {
            YesNo,
            Livestock,
            FarmGoods
        }

        public int Affection { get; set; }
        public string Name { get; set; }

        public NPC(Vector2 initialPosition,
                    Size2 size)
        {
            BoundingRectangle = new RectangleF(new Vector2(initialPosition.X - 32,
                                                            initialPosition.Y - 32),
                                               new Size2(size.Width, size.Height));

            X = initialPosition.X;
            Y = initialPosition.Y;

            Planked = true;
            Carryable = false;
            Interacts = true;
            IsNPC = true;

        }

        public override void Update(GameTime gameTime)
        {

        }

        public virtual void Interact(Item item, Action onInteractionStart, Action onInteractionEnd)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}