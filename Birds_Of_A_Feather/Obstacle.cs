using System;
using System.Collections.Generic;
using System.Drawing;

namespace Birds_Of_A_Feather
{
    class Obstacle : StationaryObject
    {
        public override Vector[] vertices { get; set; } = new Vector[] { new Vector(0f, 0f), new Vector(0.02f, 0f), new Vector(0.02f * (1f + Math.Cos(Math.PI / 3)), 0.02f * Math.Sin(Math.PI / 3)), new Vector(0.02f, 0.04f * Math.Sin(Math.PI / 3)), new Vector(0f, 0.04f * Math.Sin(Math.PI / 3)), new Vector(-0.02f * Math.Cos(Math.PI / 3), 0.02f * Math.Sin(Math.PI / 3)) };
        public static Color colour;


        public static new List<Obstacle> activeObjects = new List<Obstacle>();

        public Obstacle(Vector _position)
            : base(_position)
        {
            activeObjects.Add(this);
        }

        public override void RemoveObjectFromScene()
        {
            activeObjects.Remove(this);
            base.RemoveObjectFromScene();
        }
    }
}
